Imports System.IO


Public Class frm_Juegos

    Private objJuego As New CLS_PRODUCTOS()
    Private objCat As New cls_categorias_datos()
    Private idJuegoSeleccionado As Integer = 0
    Private rutaImagenOrigen As String = ""

    Private Sub frm_juegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategoriasCombo()
        CargarGridJuegos()
        LimpiarFormulario()
    End Sub

    ' Llena el ComboBox llamando a la clase del formulario de mi amigo
    Private Sub CargarCategoriasCombo()
        Dim dt As DataTable = objCat.obtenercategorias()
        cmbCategoria.DataSource = dt
        cmbCategoria.DisplayMember = "nombre"
        cmbCategoria.ValueMember = "id"
        cmbCategoria.SelectedIndex = -1
    End Sub

    Private Sub CargarGridJuegos()
        dgvJuegos.DataSource = objJuego.ListarJuegos()
        If dgvJuegos.Columns.Contains("id_categoria") Then
            dgvJuegos.Columns("id_categoria").Visible = False
        End If
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
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Seleccionar Portada"
            If ofd.ShowDialog() = DialogResult.OK Then
                rutaImagenOrigen = ofd.FileName
                picPortada.ImageLocation = rutaImagenOrigen
            End If
        End Using
    End Sub

    ' Botón Guardar (Alta / Modificación)
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not ValidarCampos() Then Exit Sub

        Try
            Dim rutaGuardada As String = ""
            If Not String.IsNullOrEmpty(rutaImagenOrigen) Then
                Dim carpetaDestino As String = Path.Combine(Application.StartupPath, "Portadas")
                If Not Directory.Exists(carpetaDestino) Then Directory.CreateDirectory(carpetaDestino)

                rutaGuardada = Path.Combine("Portadas", Guid.NewGuid().ToString() & Path.GetExtension(rutaImagenOrigen))
                File.Copy(rutaImagenOrigen, Path.Combine(Application.StartupPath, rutaGuardada), True)
            Else
                rutaGuardada = If(idJuegoSeleccionado > 0, objJuego.Portada, "")
            End If

            objJuego.Id = idJuegoSeleccionado
            objJuego.Nombre = txtNombre.Text.Trim()
            objJuego.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue)
            objJuego.Precio = Convert.ToDouble(txtPrecio.Text)
            objJuego.Stock = Convert.ToInt32(txtStock.Text)
            objJuego.FechaIngreso = dtpFechaIngreso.Value
            objJuego.Portada = rutaGuardada

            Dim exito As Boolean = False
            If idJuegoSeleccionado = 0 Then
                exito = objJuego.Guardar()
                MessageBox.Show("Juego guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                exito = objJuego.Modificar()
                MessageBox.Show("Juego modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            If exito Then
                CargarGridJuegos()
                LimpiarFormulario()
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

            Dim rutaFoto As String = row.Cells("portada").Value.ToString()
            If Not String.IsNullOrEmpty(rutaFoto) AndAlso File.Exists(Path.Combine(Application.StartupPath, rutaFoto)) Then
                picPortada.ImageLocation = Path.Combine(Application.StartupPath, rutaFoto)
                objJuego.Portada = rutaFoto
            Else
                picPortada.Image = Nothing
                objJuego.Portada = ""
            End If
        End If
    End Sub

    ' Eliminar Registro
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idJuegoSeleccionado > 0 Then
            If MessageBox.Show("¿Desea eliminar el juego seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If objJuego.Eliminar(idJuegoSeleccionado) Then
                    MessageBox.Show("Juego eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGridJuegos()
                    LimpiarFormulario()
                End If
            End If
        Else
            MessageBox.Show("Seleccione un juego del listado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub LimpiarFormulario()
        idJuegoSeleccionado = 0
        txtNombre.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
        cmbCategoria.SelectedIndex = -1
        dtpFechaIngreso.Value = DateTime.Now
        picPortada.Image = Nothing
        rutaImagenOrigen = ""
    End Sub
End Class

