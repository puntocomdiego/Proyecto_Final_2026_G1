<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPLASH
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
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tw Cen MT Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(82, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 74)
        Label1.TabIndex = 0
        Label1.Text = "Level Up"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(118, 196)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(151, 23)
        ProgressBar1.TabIndex = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' SPLASH
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 280)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SPLASH"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SPLASH"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
