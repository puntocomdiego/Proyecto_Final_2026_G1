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
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.Location = New Point(68, 47)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(56, 17)
        lblUsuario.TabIndex = 4
        lblUsuario.Text = "Usuario:"
        ' 
        ' lblContrasena
        ' 
        lblContrasena.AutoSize = True
        lblContrasena.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContrasena.Location = New Point(47, 106)
        lblContrasena.Name = "lblContrasena"
        lblContrasena.Size = New Size(77, 17)
        lblContrasena.TabIndex = 5
        lblContrasena.Text = "Contraseña:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(130, 46)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(245, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(130, 105)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(245, 23)
        txtContraseña.TabIndex = 2
        ' 
        ' btnIniciarSesion
        ' 
        btnIniciarSesion.BackColor = SystemColors.GradientActiveCaption
        btnIniciarSesion.FlatStyle = FlatStyle.Popup
        btnIniciarSesion.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIniciarSesion.ImageAlign = ContentAlignment.MiddleRight
        btnIniciarSesion.Location = New Point(12, 180)
        btnIniciarSesion.Name = "btnIniciarSesion"
        btnIniciarSesion.Size = New Size(160, 44)
        btnIniciarSesion.TabIndex = 4
        btnIniciarSesion.Text = "&Iniciar Sesion"
        btnIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnMostrar
        ' 
        btnMostrar.BackColor = Color.White
        btnMostrar.FlatStyle = FlatStyle.Flat
        btnMostrar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMostrar.Location = New Point(377, 99)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(30, 30)
        btnMostrar.TabIndex = 3
        btnMostrar.Text = "👁"
        btnMostrar.TextAlign = ContentAlignment.TopCenter
        btnMostrar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.GradientActiveCaption
        btnSalir.FlatStyle = FlatStyle.Popup
        btnSalir.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ImageAlign = ContentAlignment.MiddleRight
        btnSalir.Location = New Point(315, 180)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(120, 36)
        btnSalir.TabIndex = 5
        btnSalir.Text = "&Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AcceptButton = btnIniciarSesion
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        CancelButton = btnSalir
        ClientSize = New Size(467, 239)
        Controls.Add(btnSalir)
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
    Friend WithEvents btnSalir As Button
End Class
