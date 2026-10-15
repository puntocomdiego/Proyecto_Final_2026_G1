Public Class fmr_usurios

    Private usuarios As New cls_usaurios_datos()
    Private rutaFoto As String = String.Empty

    Private Sub fmr_usurios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ConfigurarGrilla()
        'MostrarProductos(datos.Listar())        ' antes: Producto.Listar() 
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        'MostrarProductos(datos.Buscar(txtbuscar.Text.Trim()))
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        btnnuevo.Text = "agregar"

        'If Not DatosValidos() Then Exit Sub

        'Try
        '    Dim u As New Usuario(txtnomusuario.Text.Trim(), txtcontra.Text, txtnombre.Text.Trim(), txtapellido.Text.Trim()

        '    If datos.Agregar(u) Then

        '    End If

        '    MostrarUsuarios(datos.Listar())
        '    Limpiar()

        'Catch ex As Exception
        '    MessageBox.Show("No se pudo agregar el usuario: " & ex.Message)
        'End Try

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        'If txtusario.Text = "" Then Exit Sub

        'If MessageBox.Show("¿Eliminar el usuario seleccionado?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.No Then
        '    Exit Sub
        'End If


        'Try
        '    If datos.Eliminar(Integer.Parse(txtCodigo.Text)) Then
        '        MostrarUsuarios(datos.Listar())
        '        Limpiar()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("No se pudo eliminar el usuario: " & ex.Message)
        'End Try



    End Sub












End Class
