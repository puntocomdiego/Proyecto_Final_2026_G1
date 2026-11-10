<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        ABREMEÇToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        JuegosToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        ConsultasToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {ABREMEÇToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(737, 29)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' ABREMEÇToolStripMenuItem
        ' 
        ABREMEÇToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UsuariosToolStripMenuItem, CategoriasToolStripMenuItem, JuegosToolStripMenuItem, VentasToolStripMenuItem, ConsultasToolStripMenuItem})
        ABREMEÇToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ABREMEÇToolStripMenuItem.Name = "ABREMEÇToolStripMenuItem"
        ABREMEÇToolStripMenuItem.Size = New Size(62, 25)
        ABREMEÇToolStripMenuItem.Text = "Menu"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(154, 26)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.Size = New Size(154, 26)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' JuegosToolStripMenuItem
        ' 
        JuegosToolStripMenuItem.Name = "JuegosToolStripMenuItem"
        JuegosToolStripMenuItem.Size = New Size(154, 26)
        JuegosToolStripMenuItem.Text = "Juegos"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(154, 26)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' ConsultasToolStripMenuItem
        ' 
        ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        ConsultasToolStripMenuItem.Size = New Size(154, 26)
        ConsultasToolStripMenuItem.Text = "Consultas"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(20, 20)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 501)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(737, 22)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(42, 17)
        ToolStripStatusLabel.Text = "Estado"
        ' 
        ' MDIParent1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(737, 523)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "MDIParent1"
        Text = "MDIParent1"
        WindowState = FormWindowState.Maximized
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ABREMEÇToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINISTRADORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JuegosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem

End Class
