Imports System.IO
Imports ClosedXML.Excel
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop
Imports Proyecto_Final_2026_G1.cls_Productos_Datos


Public Class frm_Juegos


    Private objJuego As New cls_Productos_Datos
    Private tablaActual As DataTable
    Private objCat As New cls_categorias_datos()
    Private idJuegoSeleccionado As Integer = 0
    Private rutaImagenOrigen As String = ""

    Private Sub frm_juegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objJuego.CargarCategoriasCombo()
        objJuego.CargarGridJuegos()
        AplicarEstiloGrilla(dgvJuegos)
        objJuego.LimpiarFormulario()
    End Sub


    ' --- VALIDACIONES EXIGIDAS ---
    Private Function ValidarCampos() As Boolean
        ' 1. Campo Nombre Obligatorio
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre del juego es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return False
        End If

        ' 2. Categoría Obligatoria
        If cmbCategoria.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategoria.Focus()
            Return False
        End If

        ' 3. Validación de Precio (Numérico y Mayor a 0)
        Dim precio As Double
        If Not Double.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio numérico válido mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrecio.Focus()
            Return False
        End If

        ' 4. Validación de Stock (Entero y Mayor o Igual a 0)
        Dim stock As Integer
        If Not Integer.TryParse(txtStock.Text, stock) OrElse stock < 0 Then
            MessageBox.Show("Ingrese un stock numérico entero mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Return False
        End If

        Return True
    End Function

    ' Seleccionar Imagen de Portada
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Seleccionar Portada"
            If ofd.ShowDialog = DialogResult.OK Then
                rutaImagenOrigen = ofd.FileName
                picPortada.ImageLocation = rutaImagenOrigen
            End If
        End Using
    End Sub

    ' Botón Guardar (Alta / Modificación)
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        If Not ValidarCampos() Then Exit Sub

        Dim objJuego1 As New CLS_PRODUCTOS(txtNombre.Text, Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), dtpFechaIngreso.Value, rutaImagenOrigen, idJuegoSeleccionado)
        ' objJuego1.Id = Integer.Parse(lblID.Text)


        Try
            Dim rutaGuardada = ""
            If Not String.IsNullOrEmpty(rutaImagenOrigen) Then
                Dim carpetaDestino = Path.Combine(Application.StartupPath, "Portadas")
                If Not Directory.Exists(carpetaDestino) Then Directory.CreateDirectory(carpetaDestino)

                rutaGuardada = Path.Combine("Portadas", Guid.NewGuid.ToString & Path.GetExtension(rutaImagenOrigen))
                File.Copy(rutaImagenOrigen, Path.Combine(Application.StartupPath, rutaGuardada), True)
            Else
                rutaGuardada = If(idJuegoSeleccionado > 0, objJuego1.Portada, "")
            End If

            ' objJuego1.Id = idJuegoSeleccionado
            objJuego1.Nombre = txtNombre.Text.Trim
            objJuego1.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
            objJuego1.Precio = Convert.ToDouble(txtPrecio.Text)
            objJuego1.Stock = Convert.ToInt32(txtStock.Text)
            objJuego1.FechaIngreso = dtpFechaIngreso.Value
            objJuego1.Portada = rutaGuardada

            Dim exito = False
            If idJuegoSeleccionado = 0 Then
                exito = objJuego.AgregarJuego(objJuego1)
                MessageBox.Show("Juego guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Else
                '    exito = objJuego.ActualizarJuego(objJuego1)
                '    MessageBox.Show("Juego modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If exito Then
                objJuego.CargarGridJuegos()
                objJuego.LimpiarFormulario()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Cargar datos al hacer clic en una fila del DataGridView
    Private Sub dgvJuegos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJuegos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvJuegos.Rows(e.RowIndex)
            idJuegoSeleccionado = Convert.ToInt32(row.Cells("id").Value)
            txtNombre.Text = row.Cells("nombre").Value.ToString()
            cmbCategoria.SelectedValue = Convert.ToInt32(row.Cells("id_categoria").Value)
            txtPrecio.Text = row.Cells("precio").Value.ToString()
            txtStock.Text = row.Cells("stock").Value.ToString()
            dtpFechaIngreso.Value = Convert.ToDateTime(row.Cells("fecha_ingreso").Value)
            picPortada.Image = Nothing

            Dim rutaFoto As String = row.Cells("portada").Value.ToString()
            If Not String.IsNullOrEmpty(rutaFoto) AndAlso File.Exists(Path.Combine(Application.StartupPath, rutaFoto)) Then
                picPortada.ImageLocation = Path.Combine(Application.StartupPath, rutaFoto)
                objJuego.Portada = rutaFoto
            Else
                picPortada.Image = Nothing
                objJuego.Portada = ""
            End If
            'Try
            '    If Not String.IsNullOrEmpty(rutaFoto) AndAlso IO.File.Exists(Ruta) Then
            '        Using fs As New IO.FileStream(Ruta, IO.FileMode.Open, IO.FileAccess.Read)
            '            picPortada.Image = Image.FromStream(fs)
            '        End Using
            '    Else
            '        picPortada.Image = Nothing
            '    End If
            'Catch
            '    picPortada.Image = Nothing
            'End Try
        End If
    End Sub

    ' Eliminar Registro
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idJuegoSeleccionado > 0 Then
            If MessageBox.Show("¿Desea eliminar el juego seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objJuego.EliminarJuego(idJuegoSeleccionado) Then
                    MessageBox.Show("Juego eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    objJuego.CargarGridJuegos()
                    objJuego.LimpiarFormulario()
                End If
            End If
        Else
            MessageBox.Show("Seleccione un juego del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        objJuego.LimpiarFormulario()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'preguntar si desea salir del formulario
        'If MessageBox.Show("¿Desea salir del formulario de juegos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    'si la respuesta es sí, preguntar de broma si desea salir de nuevo
        '    If MessageBox.Show("¿Está seguro de que desea salir del formulario de juegos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '        If MessageBox.Show("¿Está realmente seguro de que desea salir del formulario de juegos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '            If MessageBox.Show("¿Está absolutamente seguro de que desea salir de este hermoso formulario?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                If MessageBox.Show("Todavía te puedes arrepentir, ¿quieres salir del formulario de juegos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                    If MessageBox.Show("¿Estas 100% seguro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                        If MessageBox.Show("OK adios :(", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Me.Close()
        '                        End If
        '                    End If
        '                End If
        '            End If
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub picPortada_Click(sender As Object, e As EventArgs) Handles picPortada.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pdf As New cls_Productos_Datos_2()

        Try
            If dgvJuegos.Rows.Count = 0 Then
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using sfd As New SaveFileDialog()
                sfd.Filter = "Archivo PDF (*.pdf)|*.pdf"
                sfd.FileName = "Listado_Juegos.pdf"
                If sfd.ShowDialog() = DialogResult.OK Then
                    pdf.ExportarDatosPDF(dgvJuegos, sfd.FileName)
                    MessageBox.Show("Datos exportados a PDF correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al exportar a PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'envia a excel el listado de juego en el DataGridView, si no hay datos mostrar un mensaje de error

        Try
            Dim dt As DataTable = objJuego.ListarJuegos()
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Archivo de Excel (*.xlsx)|*.xlsx"
                sfd.FileName = "Listado_Juegos.xlsx"
                If sfd.ShowDialog() = DialogResult.OK Then
                    objJuego.ExportarAExcel(dt, sfd.FileName)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    'Private Sub ReleaseObject(obj As Object)
    '    Try
    '        Runtime.InteropServices.Marshal.ReleaseComObject(obj)
    '    Catch
    '    Finally
    '        obj = Nothing
    '    End Try
    'End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        objJuego.FiltrarJuegos(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'llamar al frmcorreo para enviar un correo al gmail colocado en el txtGmail
        Dim frmCorreo As New frmCorreo()
        frmCorreo.ShowDialog()


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'modificar el juego seleccionado en el DataGridView a través del formulario, si no hay juego seleccionado mostrar un mensaje de error

        If idJuegoSeleccionado < 1 Then
            MessageBox.Show("Seleccione un juego del listado para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
            Exit Sub

        End If


        Dim objJuego1 As New CLS_PRODUCTOS(txtNombre.Text, Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtStock.Text), dtpFechaIngreso.Value, rutaImagenOrigen, idJuegoSeleccionado)

        Dim exito = True
        'If idJuegoSeleccionado = 1 Then
        exito = objJuego.ActualizarJuego(objJuego1)
        MessageBox.Show("Juego modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        objJuego.CargarGridJuegos()

        'End If
    End Sub

End Class

