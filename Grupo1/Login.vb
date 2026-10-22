Imports System.Data.OleDb
Imports System.Reflection.Metadata.Ecma335

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
                MessageBox.Show("Ingrese un nombre de usuario y una contraseña valida, no deje campos vacíos.", "Campos vacíos detectados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Focus()
                Exit Sub
            End If

            btnIniciarSesion.Enabled = False
            txtContraseña.Enabled = False
            txtUsuario.Enabled = False

            MessageBox.Show("Verificando Información, esto puede tomar unos segundos, cierre esta ventana para proseguir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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
                btnIniciarSesion.Enabled = True
                txtContraseña.Enabled = True
                txtUsuario.Enabled = True
                Exit Sub
            Else
                Dim dr As DataRow
                dr = dt.Rows(0)

                da = New OleDbDataAdapter(SQL2, CadenaDeConexion)
                dt = New DataTable
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    rol = "admin"
                    MessageBox.Show("Usuario autentificado correctamente como 'Administrador'.", "Inicio de sesion concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MDIParent1.Show()
                    Me.Close()

                Else
                    rol = "vendedor"
                    MessageBox.Show("Usuario autentificado correctamente como 'Vendedor'.", "Inicio de sesion concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MDIParent1.Show()
                    MDIParent1.UsuariosToolStripMenuItem.Visible = False
                    Me.Close()
                End If

                Hide()

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

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtContraseña.Focus()
        End If
    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIniciarSesion.Focus()
            btnIniciarSesion.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As DialogResult = MessageBox.Show("Esta seguro de que desea salir del programa?", "Salir del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class