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
        lblTitulo = New Label()
        pgr = New ProgressBar()
        Timer1 = New Timer(components)
        lblPorcentaje = New Label()
        lblEstado = New Label()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("News701 BT", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.Location = New Point(27, 76)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(327, 78)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Level Up"
        ' 
        ' pgr
        ' 
        pgr.Location = New Point(118, 196)
        pgr.Name = "pgr"
        pgr.Size = New Size(151, 23)
        pgr.TabIndex = 1
        ' 
        ' Timer1
        ' 
        ' 
        ' lblPorcentaje
        ' 
        lblPorcentaje.AutoSize = True
        lblPorcentaje.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPorcentaje.Location = New Point(178, 172)
        lblPorcentaje.Name = "lblPorcentaje"
        lblPorcentaje.Size = New Size(33, 21)
        lblPorcentaje.TabIndex = 3
        lblPorcentaje.Text = "0%"
        lblPorcentaje.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(1, 261)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(21, 20)
        lblEstado.TabIndex = 4
        lblEstado.Text = "..."
        ' 
        ' SPLASH
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(398, 280)
        Controls.Add(lblEstado)
        Controls.Add(lblPorcentaje)
        Controls.Add(pgr)
        Controls.Add(lblTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "SPLASH"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SPLASH"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pgr As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents lblEstado As Label
End Class
