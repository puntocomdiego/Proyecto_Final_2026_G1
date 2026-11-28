<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorreo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorreo))
        Label2 = New Label()
        btnEnviar = New Button()
        Label1 = New Label()
        txtGmail = New TextBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 2
        ' 
        ' btnEnviar
        ' 
        btnEnviar.BackColor = SystemColors.GradientActiveCaption
        btnEnviar.FlatStyle = FlatStyle.Popup
        btnEnviar.Font = New Font("Segoe UI", 15.75F)
        btnEnviar.ForeColor = SystemColors.Desktop
        btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), Image)
        btnEnviar.ImageAlign = ContentAlignment.MiddleRight
        btnEnviar.Location = New Point(85, 118)
        btnEnviar.Name = "btnEnviar"
        btnEnviar.Size = New Size(175, 50)
        btnEnviar.TabIndex = 26
        btnEnviar.Text = "Env. Gmail"
        btnEnviar.TextAlign = ContentAlignment.MiddleLeft
        btnEnviar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(54, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 21)
        Label1.TabIndex = 28
        Label1.Text = "Inserte su Gmail:"
        ' 
        ' txtGmail
        ' 
        txtGmail.Location = New Point(54, 67)
        txtGmail.Name = "txtGmail"
        txtGmail.Size = New Size(239, 23)
        txtGmail.TabIndex = 27
        ' 
        ' frmCorreo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(347, 203)
        Controls.Add(Label1)
        Controls.Add(txtGmail)
        Controls.Add(btnEnviar)
        Controls.Add(Label2)
        Name = "frmCorreo"
        Text = "frmCorreo"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGmail As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
