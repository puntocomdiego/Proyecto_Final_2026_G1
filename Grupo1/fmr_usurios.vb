

Public Class fmr_usurios

    Private Sub MostrarFoto(ruta As String)
        Try
            If Not String.IsNullOrEmpty(ruta) AndAlso IO.File.Exists(ruta) Then
                Using fs As New IO.FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read)
                    picfoto.Image = Image.FromStream(fs)
                End Using
            Else
                picfoto.Image = Nothing
            End If
        Catch
            picfoto.Image = Nothing
        End Try
    End Sub




    Private datos As New cls_usuarios_datos()
    Private rutaFoto As String = String.Empty

    Private Sub ConfigurarGrilla()
        dgvusuarios.ReadOnly = True
        dgvusuarios.AllowUserToAddRows = False
        dgvusuarios.MultiSelect = False
        dgvusuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvusuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub MostrarUsuarios(dt As DataTable)
        dgvusuarios.DataSource = dt
        dgvusuarios.Columns("id").Visible = False
        dgvusuarios.Columns("nombre").HeaderText = "Nombre"
        dgvusuarios.Columns("apellido").HeaderText = "Apellido"
        dgvusuarios.Columns("usuario").HeaderText = "Usuario"
        dgvusuarios.Columns("contrasena").HeaderText = "Contraseña"
        dgvusuarios.Columns("fecha_creacion").HeaderText = "Fecha de creación"
        dgvusuarios.Columns("fecha_creacion").DefaultCellStyle.Format = "d"
        dgvusuarios.Columns("foto").HeaderText = "Ruta de la foto"


    End Sub

    Private Sub dgvusuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvusuarios.SelectionChanged
        If dgvusuarios.CurrentRow Is Nothing Then Exit Sub

        txtnombre.Text = dgvusuarios.CurrentRow.Cells("nombre").Value.ToString()
        txtapellido.Text = dgvusuarios.CurrentRow.Cells("apellido").Value.ToString()
        txtnomusuario.Text = dgvusuarios.CurrentRow.Cells("usuario").Value.ToString()
        txtcontra.Text = dgvusuarios.CurrentRow.Cells("contrasena").Value.ToString()
        rutaFoto = dgvusuarios.CurrentRow.Cells("foto").Value.ToString()
        MostrarFoto(rutaFoto)

    End Sub

    Private Sub fmr_usurios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrilla()
        MostrarUsuarios(datos.Listar())
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        MostrarUsuarios(datos.Buscar(txtbuscar.Text.Trim()))
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        If Not DatosValidos() Then Exit Sub
        Try
            Dim u As New clase_usuario(txtnombre.Text.Trim(), txtapellido.Text.Trim(), txtnomusuario.Text.Trim(), txtcontra.Text, Date.Now)
            If datos.Agregar(u) Then          ' el objeto datos hace el trabajo
                MostrarUsuarios(datos.Listar())
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo agregar el usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click ''''''''''''''''
        If dgvusuarios.CurrentRow Is Nothing Then Exit Sub
        If Not DatosValidos() Then Exit Sub
        Try
            Dim u As New clase_usuario(txtnombre.Text.Trim(), txtapellido.Text.Trim(), txtnomusuario.Text.Trim(), txtcontra.Text, Date.Now)

            u.Id = Integer.Parse(dgvusuarios.CurrentRow.Cells("id").Value.ToString())
            If datos.Modificar(u) Then MostrarUsuarios(datos.Listar())
        Catch ex As Exception
            MessageBox.Show("No se pudo modificar el usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If dgvusuarios.CurrentRow Is Nothing Then Exit Sub
        If MessageBox.Show("¿Eliminar el usuario seleccionado?", "Confirmar",
                           MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        Try
            If datos.Eliminar(Integer.Parse(dgvusuarios.CurrentRow.Cells("id").Value.ToString())) Then
                MostrarUsuarios(datos.Listar())
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub Limpiar()
        txtnombre.Clear()
        txtapellido.Clear()
        txtnomusuario.Clear()
        txtcontra.Clear()
    End Sub

    Private Function DatosValidos() As Boolean
        If txtnombre.Text.Trim() = "" Then
            MessageBox.Show("Ingresá el nombre.")
            Return False
        End If
        If txtapellido.Text.Trim() = "" Then
            MessageBox.Show("Ingresá el apellido.")
            Return False
        End If
        If txtnomusuario.Text.Trim() = "" Then
            MessageBox.Show("Ingresá el usuario.")
            Return False
        End If
        If txtcontra.Text = "" Then
            MessageBox.Show("Ingresá la contraseña.")
            Return False
        End If
        Return True
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Limpiar()
    End Sub

    Private Sub btnfoto_Click(sender As Object, e As EventArgs) Handles btnfoto.Click
        ofdfoto.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If ofdfoto.ShowDialog() = DialogResult.OK Then
            rutaFoto = ofdfoto.FileName
            MostrarFoto(rutaFoto)
        End If

    End Sub
End Class
