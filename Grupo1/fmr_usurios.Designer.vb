<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmr_usurios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmr_usurios))
        Label1 = New Label()
        txtnombre = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtcontra = New TextBox()
        txtnomusuario = New TextBox()
        txtapellido = New TextBox()
        gbx_usuarioinfo = New GroupBox()
        btnnuevo = New Button()
        btnmodificar = New Button()
        btneliminar = New Button()
        btnlimpiar = New Button()
        GroupBox1 = New GroupBox()
        btnfoto = New Button()
        Label6 = New Label()
        dgvusuarios = New DataGridView()
        picfoto = New PictureBox()
        ofdfoto = New OpenFileDialog()
        txtbuscar = New TextBox()
        btnsalir = New Button()
        gbx_usuarioinfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).BeginInit()
        CType(picfoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(6, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre :"
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(218, 35)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(255, 20)
        txtnombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(6, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 2
        Label2.Text = "Apellido :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(6, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 21)
        Label3.TabIndex = 3
        Label3.Text = "Nombre de usuario :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(6, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 4
        Label4.Text = "Contraseña :"
        ' 
        ' txtcontra
        ' 
        txtcontra.Location = New Point(218, 206)
        txtcontra.Name = "txtcontra"
        txtcontra.Size = New Size(255, 20)
        txtcontra.TabIndex = 6
        ' 
        ' txtnomusuario
        ' 
        txtnomusuario.Location = New Point(218, 146)
        txtnomusuario.Name = "txtnomusuario"
        txtnomusuario.Size = New Size(255, 20)
        txtnomusuario.TabIndex = 7
        ' 
        ' txtapellido
        ' 
        txtapellido.Location = New Point(218, 86)
        txtapellido.Name = "txtapellido"
        txtapellido.Size = New Size(255, 20)
        txtapellido.TabIndex = 8
        ' 
        ' gbx_usuarioinfo
        ' 
        gbx_usuarioinfo.Controls.Add(Label3)
        gbx_usuarioinfo.Controls.Add(Label1)
        gbx_usuarioinfo.Controls.Add(txtapellido)
        gbx_usuarioinfo.Controls.Add(txtnombre)
        gbx_usuarioinfo.Controls.Add(txtnomusuario)
        gbx_usuarioinfo.Controls.Add(Label2)
        gbx_usuarioinfo.Controls.Add(txtcontra)
        gbx_usuarioinfo.Controls.Add(Label4)
        gbx_usuarioinfo.Font = New Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbx_usuarioinfo.Location = New Point(36, 33)
        gbx_usuarioinfo.Name = "gbx_usuarioinfo"
        gbx_usuarioinfo.Size = New Size(485, 289)
        gbx_usuarioinfo.TabIndex = 10
        gbx_usuarioinfo.TabStop = False
        gbx_usuarioinfo.Text = "Usuario info"
        ' 
        ' btnnuevo
        ' 
        btnnuevo.BackColor = SystemColors.GradientActiveCaption
        btnnuevo.BackgroundImageLayout = ImageLayout.Zoom
        btnnuevo.FlatStyle = FlatStyle.Popup
        btnnuevo.Font = New Font("Segoe UI", 15.75F)
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.MiddleLeft
        btnnuevo.Location = New Point(48, 38)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(175, 50)
        btnnuevo.TabIndex = 11
        btnnuevo.Text = "nuevo"
        btnnuevo.TextAlign = ContentAlignment.MiddleRight
        btnnuevo.UseVisualStyleBackColor = False
        ' 
        ' btnmodificar
        ' 
        btnmodificar.BackColor = SystemColors.GradientActiveCaption
        btnmodificar.FlatStyle = FlatStyle.Popup
        btnmodificar.Font = New Font("Segoe UI", 15.75F)
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.MiddleLeft
        btnmodificar.Location = New Point(48, 100)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(175, 50)
        btnmodificar.TabIndex = 12
        btnmodificar.Text = "modificar"
        btnmodificar.TextAlign = ContentAlignment.MiddleRight
        btnmodificar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = SystemColors.GradientActiveCaption
        btneliminar.FlatStyle = FlatStyle.Popup
        btneliminar.Font = New Font("Segoe UI", 15.75F)
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.MiddleLeft
        btneliminar.Location = New Point(48, 160)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(175, 50)
        btneliminar.TabIndex = 13
        btneliminar.Text = "eliminar"
        btneliminar.TextAlign = ContentAlignment.MiddleRight
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), Image)
        btnlimpiar.Location = New Point(510, 12)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(44, 33)
        btnlimpiar.TabIndex = 15
        btnlimpiar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnfoto)
        GroupBox1.Controls.Add(btneliminar)
        GroupBox1.Controls.Add(btnnuevo)
        GroupBox1.Controls.Add(btnmodificar)
        GroupBox1.Location = New Point(573, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(278, 294)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' btnfoto
        ' 
        btnfoto.BackColor = SystemColors.GradientActiveCaption
        btnfoto.FlatStyle = FlatStyle.Popup
        btnfoto.Font = New Font("Segoe UI", 15.75F)
        btnfoto.Image = CType(resources.GetObject("btnfoto.Image"), Image)
        btnfoto.ImageAlign = ContentAlignment.MiddleLeft
        btnfoto.Location = New Point(48, 216)
        btnfoto.Name = "btnfoto"
        btnfoto.Size = New Size(175, 50)
        btnfoto.TabIndex = 14
        btnfoto.Text = "cargar foto"
        btnfoto.TextAlign = ContentAlignment.MiddleRight
        btnfoto.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(49, 395)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 21)
        Label6.TabIndex = 10
        Label6.Text = "Usuario a busacr:"
        ' 
        ' dgvusuarios
        ' 
        dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvusuarios.Location = New Point(36, 480)
        dgvusuarios.Name = "dgvusuarios"
        dgvusuarios.Size = New Size(580, 209)
        dgvusuarios.TabIndex = 18
        ' 
        ' picfoto
        ' 
        picfoto.Location = New Point(655, 420)
        picfoto.Name = "picfoto"
        picfoto.Size = New Size(218, 269)
        picfoto.TabIndex = 19
        picfoto.TabStop = False
        ' 
        ' ofdfoto
        ' 
        ofdfoto.FileName = "ingrese una imaguen"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(233, 394)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(215, 23)
        txtbuscar.TabIndex = 9
        ' 
        ' btnsalir
        ' 
        btnsalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnsalir.BackColor = SystemColors.GradientActiveCaption
        btnsalir.FlatStyle = FlatStyle.Popup
        btnsalir.Font = New Font("Segoe UI", 10F)
        btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), Image)
        btnsalir.ImageAlign = ContentAlignment.MiddleRight
        btnsalir.Location = New Point(937, 633)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(80, 35)
        btnsalir.TabIndex = 20
        btnsalir.Text = "salir"
        btnsalir.TextAlign = ContentAlignment.MiddleLeft
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' fmr_usurios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1042, 693)
        Controls.Add(btnsalir)
        Controls.Add(txtbuscar)
        Controls.Add(picfoto)
        Controls.Add(dgvusuarios)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Controls.Add(btnlimpiar)
        Controls.Add(gbx_usuarioinfo)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "fmr_usurios"
        Text = "Ingrese nombre de usuario y contraseña"
        gbx_usuarioinfo.ResumeLayout(False)
        gbx_usuarioinfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(dgvusuarios, ComponentModel.ISupportInitialize).EndInit()
        CType(picfoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents txtnomusuario As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents gbx_usuarioinfo As GroupBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents btnfoto As Button
    Friend WithEvents picfoto As PictureBox
    Friend WithEvents ofdfoto As OpenFileDialog
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnsalir As Button

End Class
