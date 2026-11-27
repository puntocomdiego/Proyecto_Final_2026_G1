<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        lblTitulo = New Label()
        pgr = New ProgressBar()
        Timer1 = New Timer(components)
        lblPorcentaje = New Label()
        lblEstado = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.Black
        lblTitulo.Font = New Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.White
        lblTitulo.Location = New Point(30, 60)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(308, 86)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Level Up"
        lblTitulo.Visible = False
        ' 
        ' pgr
        ' 
        pgr.ForeColor = SystemColors.GradientActiveCaption
        pgr.Location = New Point(123, 227)
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
        lblPorcentaje.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblPorcentaje.Location = New Point(190, 209)
        lblPorcentaje.Name = "lblPorcentaje"
        lblPorcentaje.Size = New Size(24, 15)
        lblPorcentaje.TabIndex = 3
        lblPorcentaje.Text = "0%"
        lblPorcentaje.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(1, 261)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(16, 15)
        lblEstado.TabIndex = 4
        lblEstado.Text = "..."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(397, 207)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' frmSplash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(398, 280)
        Controls.Add(PictureBox1)
        Controls.Add(lblEstado)
        Controls.Add(lblPorcentaje)
        Controls.Add(pgr)
        Controls.Add(lblTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SPLASH"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pgr As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
