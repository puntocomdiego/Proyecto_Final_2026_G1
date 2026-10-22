Public Class frm_categorias
    Private objCategoria As New CLS_CATEGORIAS()
    Private idcategoriaSeleccionada As Integer = 0

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorias.CellContentClick

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

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
    End Sub

    Private Sub frm_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000      ' 1 segundo
        Timer1.Enabled = True
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

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
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    ' Variable a nivel de formulario (fuera de cualquier Sub)
    Private textoBusqueda As String = ""

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        textoBusqueda = TXTBUSCAR.Text.Trim()
        dgvcategorias.Invalidate()   ' redibuja el grid para marcar las letras

        If textoBusqueda = "" Then
            lblcoincidencias.Text = ""
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

        lblcoincidencias.Text = $"Coincidencias: {coincidencias}"
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
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        lblcoincidencias.Visible = False

    End Sub

    Private Sub btntutorial_MouseLeave(sender As Object, e As EventArgs) Handles btntutorial.MouseLeave
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        lblcoincidencias.Visible = True
    End Sub

    Private Sub lblcoincidencias_Click(sender As Object, e As EventArgs) Handles lblcoincidencias.Click

    End Sub
End Class