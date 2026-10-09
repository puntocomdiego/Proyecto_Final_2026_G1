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

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        ' Verificar que haya una fila seleccionada
        If dgvcategorias.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccioná una categoría para eliminar.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmación
        Dim nombre As String = dgvcategorias.CurrentRow.Cells("nombre").Value.ToString()
        Dim respuesta As DialogResult = MessageBox.Show(
        $"¿Seguro que querés eliminar la categoría '{nombre}'?",
        "Confirmar eliminación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If respuesta <> DialogResult.Yes Then Return

        Try
            Dim codigo As Integer = Convert.ToInt32(dgvcategorias.CurrentRow.Cells("codigo").Value)
            Dim datos As New cls_categorias_datos()

            If datos.Eliminar(codigo) Then
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
End Class