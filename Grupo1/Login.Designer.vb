<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblUsuario = New Label()
        lblContrasena = New Label()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnIniciarSesion = New Button()
        btnMostrar = New Button()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsuario.Location = New Point(39, 31)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(73, 21)
        lblUsuario.TabIndex = 4
        lblUsuario.Text = "Usuario:"
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContrasena.Location = New Point(12, 77)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(100, 21)
        lblContrasena.TabIndex = 5
        lblContrasena.Text = "Contraseña:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(118, 29)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(224, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(118, 77)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(224, 23)
        txtContraseña.TabIndex = 2
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIniciarSesion.Location = New Point(12, 128)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(168, 43)
        btnIniciarSesion.TabIndex = 4
        btnIniciarSesion.Text = "Iniciar Sesion"
        btnIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMostrar.Location = New Point(348, 71)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(46, 40)
        btnMostrar.TabIndex = 3
        btnMostrar.Text = "👁"
        btnMostrar.TextAlign = ContentAlignment.TopLeft
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 183)
        Controls.Add(btnMostrar)
        Controls.Add(btnIniciarSesion)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(lblContrasena)
        Controls.Add(lblUsuario)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents btnMostrar As Button
End Class
