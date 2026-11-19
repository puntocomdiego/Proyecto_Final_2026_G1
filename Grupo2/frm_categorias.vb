Public Class frm_categorias
    Private objCategoria As New CLS_CATEGORIAS()
    Private idcategoriaSeleccionada As Integer = 0

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorias.CellContentClick
        dgvcategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        ' Validaciones
        If String.IsNullOrWhiteSpace(txtnombre.Text) Then
            MessageBox.Show("Ingresá el nombre de la categoría.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnombre.Focus()
            Return
        End If

        Try
            ' Crear el objeto con los datos del formulario
            Dim categoria As New CLS_CATEGORIAS()
            categoria.Nombre = txtnombre.Text.Trim()
            categoria.Descripcion = txtdescripcion.Text.Trim()

            ' Llamar a la capa de datos
            Dim datos As New cls_categorias_datos()

            If datos.guardar(categoria) Then
                MessageBox.Show("Categoría guardada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
                CargarCategorias()
            Else
                MessageBox.Show("No se pudo guardar la categoría.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtnombre.Clear()
        txtdescripcion.Clear()
        txtnombre.Focus()
    End Sub

    Private Sub CargarCategorias()
        Dim datos As New cls_categorias_datos()
        dgvcategorias.DataSource = datos.Listar()
    End Sub

    Private Sub dgvcategorias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorias.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvcategorias.Rows(e.RowIndex)
            txtnombre.Text = Convert.ToString(fila.Cells("nombre").Value)
            txtdescripcion.Text = Convert.ToString(fila.Cells("descripcion").Value)
        End If
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
    End Sub

    Private Sub frm_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000      ' 1 segundo
        Timer1.Enabled = True
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        ' Cada RichTextBox se formatea de forma individual
        NegritaPrimeraPalabra(RichTextBox1) ' Ejemplo: ELIMINAR: ...
        NegritaPrimeraPalabra(RichTextBox2) ' Ejemplo: GUARDAR: ...
        NegritaPrimeraPalabra(RichTextBox4) ' Ejemplo: LIMPIAR: ...
        NegritaPalabras(RichTextBox3, 2) ' Ejemplo: APLICAR PARÁMETROS: ...
    End Sub
    'quiero que en un formulario de categorias, cuando haga click en un dato del data grid view aparezcan el nombre y consola del jue
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If dgvcategorias.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccioná una categoría para eliminar.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim nombre As String = Convert.ToString(dgvcategorias.CurrentRow.Cells("nombre").Value)

            Dim respuesta As DialogResult = MessageBox.Show(
            $"¿Seguro que querés eliminar la categoría '{nombre}'?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If respuesta <> DialogResult.Yes Then Return

            Dim id As Integer = Convert.ToInt32(dgvcategorias.CurrentRow.Cells("id").Value)
            Dim datos As New cls_categorias_datos()

            If datos.Eliminar(id) Then
                MessageBox.Show("Categoría eliminada correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCategorias()
            Else
                MessageBox.Show("No se pudo eliminar la categoría.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        LimpiarCampos()
        If txtnombre.Text = "" Then
            MessageBox.Show("Los campos se han limpiado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    ' Variable a nivel de formulario (fuera de cualquier Sub)
    Private textoBusqueda As String = ""

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'al presionar el boton buscar se debe buscar en el datagridview las letras que coincidan con lo que se escribio en el textbox y marcarlo de amarillo



        textoBusqueda = TXTBUSCAR.Text.Trim()
        dgvcategorias.Invalidate()   ' redibuja el grid para marcar las letras

        If textoBusqueda = "" Then
            MessageBox.Show("No hay caracteres para buscar.", "Atención",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim coincidencias As Integer = 0

        For Each fila As DataGridViewRow In dgvcategorias.Rows
            If fila.IsNewRow Then Continue For

            For Each celda As DataGridViewCell In fila.Cells
                Dim valor As String = Convert.ToString(celda.Value)
                Dim pos As Integer = valor.IndexOf(textoBusqueda, StringComparison.CurrentCultureIgnoreCase)

                While pos >= 0
                    coincidencias += 1
                    pos = valor.IndexOf(textoBusqueda, pos + textoBusqueda.Length,
                                    StringComparison.CurrentCultureIgnoreCase)
                End While
            Next
        Next



    End Sub

    Private Sub dgvcategorias_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) _
    Handles dgvcategorias.CellPainting

        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 OrElse textoBusqueda = "" Then Return

        Dim valor As String = Convert.ToString(e.Value)
        If valor = "" OrElse valor.IndexOf(textoBusqueda, StringComparison.CurrentCultureIgnoreCase) < 0 Then Return

        ' Dibujamos nosotros la celda
        e.Handled = True
        Dim seleccionada As Boolean = (e.State And DataGridViewElementStates.Selected) <> 0
        e.PaintBackground(e.ClipBounds, seleccionada)

        Dim fuente As Font = e.CellStyle.Font
        Dim flags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or
                                   TextFormatFlags.NoPadding Or TextFormatFlags.NoPrefix
        Dim tam As New Size(Integer.MaxValue, e.CellBounds.Height)
        Dim xInicio As Integer = e.CellBounds.X + 3

        ' Pintar de amarillo SOLO las letras que coinciden
        Dim pos As Integer = valor.IndexOf(textoBusqueda, StringComparison.CurrentCultureIgnoreCase)
        While pos >= 0
            Dim anchoAntes As Integer = If(pos = 0, 0,
            TextRenderer.MeasureText(e.Graphics, valor.Substring(0, pos), fuente, tam, flags).Width)
            Dim anchoHasta As Integer =
            TextRenderer.MeasureText(e.Graphics, valor.Substring(0, pos + textoBusqueda.Length), fuente, tam, flags).Width

            Dim rectAmarillo As New Rectangle(xInicio + anchoAntes, e.CellBounds.Y + 2,
                                          anchoHasta - anchoAntes, e.CellBounds.Height - 4)
            e.Graphics.FillRectangle(Brushes.Yellow, rectAmarillo)

            pos = valor.IndexOf(textoBusqueda, pos + textoBusqueda.Length, StringComparison.CurrentCultureIgnoreCase)
        End While

        ' Dibujar el texto encima
        Dim colorTexto As Color = If(seleccionada, e.CellStyle.SelectionForeColor, e.CellStyle.ForeColor)
        Dim rectTexto As New Rectangle(xInicio, e.CellBounds.Y, e.CellBounds.Width - 3, e.CellBounds.Height)
        TextRenderer.DrawText(e.Graphics, valor, fuente, rectTexto, colorTexto, flags)

        ' Dibujar los bordes de la celda
        e.Paint(e.ClipBounds, DataGridViewPaintParts.Border)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click

    End Sub

    Private Sub btntutorial_MouseEnter(sender As Object, e As EventArgs) Handles btntutorial.MouseEnter
        RichTextBox1.Visible = True
        RichTextBox2.Visible = True
        RichTextBox3.Visible = True
        RichTextBox4.Visible = True

    End Sub

    Private Sub btntutorial_MouseLeave(sender As Object, e As EventArgs) Handles btntutorial.MouseLeave
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        RichTextBox3.Visible = False
        RichTextBox4.Visible = False
    End Sub

    Private Sub lblcoincidencias_Click(sender As Object, e As EventArgs) Handles lblcoincidencias.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'que pregunte si deseas salir del formulario de categorias y si le das a aceptar se cierra el formulario
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas salir del formulario de categorías?", "Confirmación",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)






        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btntutorial_Click(sender As Object, e As EventArgs) Handles btntutorial.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
    Private Sub NegritaPrimeraPalabra(ByVal rtb As RichTextBox)
        If rtb Is Nothing OrElse rtb.Lines.Length = 0 Then Return

        Dim inicioOriginal As Integer = rtb.SelectionStart
        Dim longitudOriginal As Integer = rtb.SelectionLength

        For i As Integer = 0 To rtb.Lines.Length - 1
            Dim linea As String = rtb.Lines(i)
            If String.IsNullOrWhiteSpace(linea) Then Continue For

            Dim inicioLinea As Integer = rtb.GetFirstCharIndexFromLine(i)
            If inicioLinea < 0 Then Continue For

            ' Toma hasta el primer espacio (por ejemplo, "ELIMINAR:" o la primera palabra)
            Dim indiceEspacio As Integer = linea.IndexOf(" "c)
            Dim largoPrimeraPalabra As Integer = If(indiceEspacio >= 0, indiceEspacio, linea.Length)

            If largoPrimeraPalabra > 0 Then
                rtb.Select(inicioLinea, largoPrimeraPalabra)
                Dim fuenteActual As Font = If(rtb.SelectionFont, rtb.Font)
                rtb.SelectionFont = New Font(fuenteActual, fuenteActual.Style Or FontStyle.Bold)
            End If
        Next

        ' Restaurar cursor o selección original
        rtb.Select(inicioOriginal, longitudOriginal)
        Dim fuenteCursor As Font = If(rtb.SelectionFont, rtb.Font)
        If fuenteCursor.Bold Then
            rtb.SelectionFont = New Font(fuenteCursor, fuenteCursor.Style And Not FontStyle.Bold)
        End If
    End Sub
    Private Sub FormatearBloque(ByVal rtb As RichTextBox, ByVal palabraNegrita As String, ByVal restoTexto As String)
        rtb.Clear()

        ' Primera palabra o título en negrita
        rtb.SelectionFont = New Font(rtb.Font, FontStyle.Bold)
        rtb.AppendText(palabraNegrita & " ")

        ' Resto del texto en fuente regular
        rtb.SelectionFont = New Font(rtb.Font, FontStyle.Regular)
        rtb.AppendText(restoTexto)
    End Sub
    Private Sub NegritaPalabras(ByVal rtb As RichTextBox, Optional ByVal cantidadPalabras As Integer = 1)
        If rtb Is Nothing OrElse rtb.Lines.Length = 0 OrElse cantidadPalabras < 1 Then Return

        Dim inicioOriginal As Integer = rtb.SelectionStart
        Dim longitudOriginal As Integer = rtb.SelectionLength

        For i As Integer = 0 To rtb.Lines.Length - 1
            Dim linea As String = rtb.Lines(i)
            If String.IsNullOrWhiteSpace(linea) Then Continue For

            Dim inicioLinea As Integer = rtb.GetFirstCharIndexFromLine(i)
            If inicioLinea < 0 Then Continue For

            ' Buscar hasta dónde llegan las N palabras indicadas
            Dim largoTotal As Integer = 0
            Dim palabrasContadas As Integer = 0
            Dim enPalabra As Boolean = False

            For j As Integer = 0 To linea.Length - 1
                If Not Char.IsWhiteSpace(linea(j)) Then
                    If Not enPalabra Then
                        enPalabra = True
                        palabrasContadas += 1
                        If palabrasContadas > cantidadPalabras Then Exit For
                    End If
                    largoTotal = j + 1
                Else
                    enPalabra = False
                End If
            Next

            If largoTotal > 0 Then
                rtb.Select(inicioLinea, largoTotal)
                Dim fuenteActual As Font = If(rtb.SelectionFont, rtb.Font)
                rtb.SelectionFont = New Font(fuenteActual, fuenteActual.Style Or FontStyle.Bold)
            End If
        Next

        ' Restaurar cursor o selección original
        rtb.Select(inicioOriginal, longitudOriginal)
        Dim fuenteCursor As Font = If(rtb.SelectionFont, rtb.Font)
        If fuenteCursor.Bold Then
            rtb.SelectionFont = New Font(fuenteCursor, fuenteCursor.Style And Not FontStyle.Bold)
        End If
    End Sub
    Private Sub BloquearEscritura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress, RichTextBox2.KeyPress, RichTextBox3.KeyPress, RichTextBox4.KeyPress
        ' Cancela cualquier carácter que intente insertarse
        e.Handled = True
    End Sub
    'el pepe es un 
End Class