Imports System.Data.OleDb

Public Class Login
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        If txtContraseña.PasswordChar = "*" Then
            txtContraseña.PasswordChar = ""
            btnMostrar.Text = "🕶"
        Else
            txtContraseña.PasswordChar = "*"
            btnMostrar.Text = "👁"
        End If

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
                MsgBox("Ingrese nombre de usuario y contraseña")
                txtUsuario.Focus()
                Exit Sub
            End If

            Dim SQL1 As String
            Dim SQL2 As String

            'SQL1 se utiliza para verificar si el usuario existe y si la contraseña es correcta."
            SQL1 = "SELECT usuarios.usuario, usuarios.contrasena " _
         + "FROM usuarios " _
         + "WHERE usuarios.usuario='" & txtUsuario.Text & "' AND usuarios.contrasena='" & txtContraseña.Text & "';"

            'SQL2 se utiliza para verificar si el usuario es administrador, NO ES INUTIL, NO LO BORRES O ACABARE CONTIGO.
            SQL2 = "Select usuarios.usuario, usuarios.contrasena, usuarios.tipo " _
         + "FROM usuarios " _
         + "WHERE usuarios.usuario='" & txtUsuario.Text & "' AND usuarios.contrasena='" & txtContraseña.Text & "' AND usuarios.tipo='admin';"

            Dim da As New OleDbDataAdapter(SQL1, CadenaDeConexion)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Usuario inexistente o contraseña incorrecta...")
                txtUsuario.Focus()
                Exit Sub
            Else
                Dim dr As DataRow
                dr = dt.Rows(0)

                da = New OleDbDataAdapter(SQL2, CadenaDeConexion)
                dt = New DataTable
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    rol = "admin"
                    MsgBox("Usuario autentificado correctamente como 'Admin'.", MsgBoxStyle.OkOnly, "Login")
                    'MDIParent1.Show()
                Else
                    rol = "vendedor"
                    MsgBox("Usuario autentificado correctamente como 'Vendedor'.", MsgBoxStyle.OkOnly, "Login")
                End If

                Me.Hide()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtContraseña_LostFocus(sender As Object, e As EventArgs) Handles txtContraseña.LostFocus
        If txtContraseña.Text = "" Then
            txtContraseña.ForeColor = Color.Gray
            txtContraseña.Text = "Escriba la contraseña"
            txtContraseña.PasswordChar = ""
        End If
    End Sub

    Private Sub txtContraseña_GotFocus(sender As Object, e As EventArgs) Handles txtContraseña.GotFocus
        If txtContraseña.Text = "Escriba la contraseña" Then
            txtContraseña.ForeColor = Color.Black
            txtContraseña.Text = ""
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña_LostFocus(Nothing, Nothing)
    End Sub
End Class