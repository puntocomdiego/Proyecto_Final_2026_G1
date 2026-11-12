<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Juegos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Juegos))
        txtNombre = New TextBox()
        txtStock = New TextBox()
        txtPrecio = New TextBox()
        cmbCategoria = New ComboBox()
        dtpFechaIngreso = New DateTimePicker()
        picPortada = New PictureBox()
        btnExaminar = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        dgvJuegos = New DataGridView()
        ofd = New OpenFileDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        lblID = New Label()
        Label6 = New Label()
        CType(picPortada, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJuegos, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(68, 64)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(68, 164)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(68, 114)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(68, 216)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(121, 23)
        cmbCategoria.TabIndex = 4
        ' 
        ' dtpFechaIngreso
        ' 
        dtpFechaIngreso.Location = New Point(68, 266)
        dtpFechaIngreso.Name = "dtpFechaIngreso"
        dtpFechaIngreso.Size = New Size(200, 23)
        dtpFechaIngreso.TabIndex = 5
        ' 
        ' picPortada
        ' 
        picPortada.BackColor = SystemColors.ControlLight
        picPortada.Location = New Point(327, 40)
        picPortada.Name = "picPortada"
        picPortada.Size = New Size(293, 259)
        picPortada.SizeMode = PictureBoxSizeMode.Zoom
        picPortada.TabIndex = 6
        picPortada.TabStop = False
        ' 
        ' btnExaminar
        ' 
        btnExaminar.BackColor = SystemColors.GradientActiveCaption
        btnExaminar.FlatStyle = FlatStyle.Popup
        btnExaminar.Font = New Font("Segoe UI", 15.75F)
        btnExaminar.ForeColor = SystemColors.Desktop
        btnExaminar.Image = CType(resources.GetObject("btnExaminar.Image"), Image)
        btnExaminar.ImageAlign = ContentAlignment.MiddleRight
        btnExaminar.Location = New Point(649, 249)
        btnExaminar.Name = "btnExaminar"
        btnExaminar.Size = New Size(175, 50)
        btnExaminar.TabIndex = 7
        btnExaminar.Text = "Examinar"
        btnExaminar.TextAlign = ContentAlignment.MiddleLeft
        btnExaminar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.GradientActiveCaption
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Segoe UI", 15.75F)
        btnGuardar.ForeColor = SystemColors.Desktop
        btnGuardar.Image = My.Resources.Resources.guardar_save_icon_1320191245245380651_48px
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(272, 8)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(175, 50)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleLeft
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = SystemColors.GradientActiveCaption
        btnEliminar.FlatStyle = FlatStyle.Popup
        btnEliminar.Font = New Font("Segoe UI", 15.75F)
        btnEliminar.ForeColor = SystemColors.Desktop
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(477, 8)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(175, 50)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.MiddleLeft
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.GradientActiveCaption
        btnLimpiar.FlatStyle = FlatStyle.Popup
        btnLimpiar.Font = New Font("Segoe UI", 15.75F)
        btnLimpiar.ForeColor = SystemColors.Desktop
        btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), Image)
        btnLimpiar.ImageAlign = ContentAlignment.MiddleRight
        btnLimpiar.Location = New Point(68, 8)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(175, 50)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.TextAlign = ContentAlignment.MiddleLeft
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' dgvJuegos
        ' 
        dgvJuegos.AllowUserToAddRows = False
        dgvJuegos.AllowUserToDeleteRows = False
        dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJuegos.Location = New Point(68, 305)
        dgvJuegos.Name = "dgvJuegos"
        dgvJuegos.RowHeadersWidth = 51
        dgvJuegos.Size = New Size(756, 200)
        dgvJuegos.TabIndex = 11
        ' 
        ' ofd
        ' 
        ofd.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(68, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 12
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(68, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 13
        Label2.Text = "Precio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(68, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 14
        Label3.Text = "Stock:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(68, 190)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 15
        Label4.Text = "Categoria:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(68, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 21)
        Label5.TabIndex = 16
        Label5.Text = "Fecha Ingreso:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnLimpiar)
        Panel1.Controls.Add(btnEliminar)
        Panel1.Controls.Add(btnGuardar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 518)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(857, 67)
        Panel1.TabIndex = 19
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = SystemColors.Desktop
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(765, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 35)
        Button1.TabIndex = 11
        Button1.Text = "salir"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(183, 9)
        lblID.Name = "lblID"
        lblID.Size = New Size(54, 15)
        lblID.TabIndex = 21
        lblID.Text = "Nombre:"
        lblID.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(85, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 20
        Label6.Text = "Nombre:"
        Label6.Visible = False
        ' 
        ' frm_Juegos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(857, 585)
        Controls.Add(lblID)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvJuegos)
        Controls.Add(btnExaminar)
        Controls.Add(picPortada)
        Controls.Add(dtpFechaIngreso)
        Controls.Add(cmbCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtStock)
        Controls.Add(txtNombre)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frm_Juegos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administración de Juegos"
        CType(picPortada, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvJuegos, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents picPortada As PictureBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents dgvJuegos As DataGridView
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblID As Label
    Friend WithEvents Label6 As Label
End Class
