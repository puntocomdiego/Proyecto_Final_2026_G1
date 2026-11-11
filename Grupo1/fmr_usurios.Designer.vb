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
        picfoto = New PictureBox()
        btnnuevo = New Button()
        btnmodificar = New Button()
        btneliminar = New Button()
        GroupBox1 = New GroupBox()
        btnguardar = New Button()
        btnfoto = New Button()
        Label6 = New Label()
        dgvusuarios = New DataGridView()
        ofdfoto = New OpenFileDialog()
        txtbuscar = New TextBox()
        btnsalir = New Button()
        Label5 = New Label()
        cmbtipo = New ComboBox()
        gbx_usuarioinfo.SuspendLayout()
        CType(picfoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(137, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 21)
        Label1.TabIndex = 0
        Label1.Text = "Nombre :"
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(218, 35)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(255, 23)
        txtnombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(138, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 2
        Label2.Text = "Apellido :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(60, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 21)
        Label3.TabIndex = 3
        Label3.Text = "Nombre de usuario :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(116, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 21)
        Label4.TabIndex = 4
        Label4.Text = "Contraseña :"
        ' 
        ' txtcontra
        ' 
        txtcontra.Location = New Point(218, 220)
        txtcontra.Name = "txtcontra"
        txtcontra.Size = New Size(255, 23)
        txtcontra.TabIndex = 6
        ' 
        ' txtnomusuario
        ' 
        txtnomusuario.Location = New Point(218, 158)
        txtnomusuario.Name = "txtnomusuario"
        txtnomusuario.Size = New Size(255, 23)
        txtnomusuario.TabIndex = 7
        ' 
        ' txtapellido
        ' 
        txtapellido.Location = New Point(218, 97)
        txtapellido.Name = "txtapellido"
        txtapellido.Size = New Size(255, 23)
        txtapellido.TabIndex = 8
        ' 
        ' gbx_usuarioinfo
        ' 
        gbx_usuarioinfo.Controls.Add(cmbtipo)
        gbx_usuarioinfo.Controls.Add(Label5)
        gbx_usuarioinfo.Controls.Add(Label3)
        gbx_usuarioinfo.Controls.Add(Label1)
        gbx_usuarioinfo.Controls.Add(txtapellido)
        gbx_usuarioinfo.Controls.Add(txtnombre)
        gbx_usuarioinfo.Controls.Add(txtnomusuario)
        gbx_usuarioinfo.Controls.Add(Label2)
        gbx_usuarioinfo.Controls.Add(txtcontra)
        gbx_usuarioinfo.Controls.Add(Label4)
        gbx_usuarioinfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbx_usuarioinfo.Location = New Point(30, 79)
        gbx_usuarioinfo.Name = "gbx_usuarioinfo"
        gbx_usuarioinfo.Size = New Size(484, 308)
        gbx_usuarioinfo.TabIndex = 10
        gbx_usuarioinfo.TabStop = False
        gbx_usuarioinfo.Text = "Información del usuario"
        ' 
        ' picfoto
        ' 
        picfoto.Location = New Point(1135, 94)
        picfoto.Name = "picfoto"
        picfoto.Size = New Size(273, 254)
        picfoto.SizeMode = PictureBoxSizeMode.StretchImage
        picfoto.TabIndex = 19
        picfoto.TabStop = False
        ' 
        ' btnnuevo
        ' 
        btnnuevo.BackColor = SystemColors.GradientActiveCaption
        btnnuevo.BackgroundImageLayout = ImageLayout.Zoom
        btnnuevo.FlatStyle = FlatStyle.Popup
        btnnuevo.Font = New Font("Segoe UI", 15.75F)
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.MiddleLeft
        btnnuevo.Location = New Point(28, 36)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(175, 50)
        btnnuevo.TabIndex = 11
        btnnuevo.Text = "Nuevo"
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
        btnmodificar.Location = New Point(432, 33)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(175, 50)
        btnmodificar.TabIndex = 12
        btnmodificar.Text = "Modificar"
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
        btneliminar.Location = New Point(838, 36)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(175, 50)
        btneliminar.TabIndex = 13
        btneliminar.Text = "Eliminar"
        btneliminar.TextAlign = ContentAlignment.MiddleRight
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnguardar)
        GroupBox1.Controls.Add(btnfoto)
        GroupBox1.Controls.Add(btneliminar)
        GroupBox1.Controls.Add(btnnuevo)
        GroupBox1.Controls.Add(btnmodificar)
        GroupBox1.Location = New Point(189, 415)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1027, 107)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Opciones"
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = SystemColors.GradientActiveCaption
        btnguardar.BackgroundImageLayout = ImageLayout.Zoom
        btnguardar.FlatStyle = FlatStyle.Popup
        btnguardar.Font = New Font("Segoe UI", 15.75F)
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.MiddleLeft
        btnguardar.Location = New Point(231, 35)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(175, 50)
        btnguardar.TabIndex = 15
        btnguardar.Text = "Guardar"
        btnguardar.TextAlign = ContentAlignment.MiddleRight
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btnfoto
        ' 
        btnfoto.BackColor = SystemColors.GradientActiveCaption
        btnfoto.FlatStyle = FlatStyle.Popup
        btnfoto.Font = New Font("Segoe UI", 15.75F)
        btnfoto.Image = CType(resources.GetObject("btnfoto.Image"), Image)
        btnfoto.ImageAlign = ContentAlignment.MiddleLeft
        btnfoto.Location = New Point(641, 35)
        btnfoto.Name = "btnfoto"
        btnfoto.Size = New Size(175, 50)
        btnfoto.TabIndex = 14
        btnfoto.Text = "Cargar Foto"
        btnfoto.TextAlign = ContentAlignment.MiddleRight
        btnfoto.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(565, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 21)
        Label6.TabIndex = 10
        Label6.Text = "Usuario a buscar:"
        ' 
        ' dgvusuarios
        ' 
        dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvusuarios.Location = New Point(548, 79)
        dgvusuarios.Name = "dgvusuarios"
        dgvusuarios.Size = New Size(581, 284)
        dgvusuarios.TabIndex = 18
        ' 
        ' ofdfoto
        ' 
        ofdfoto.FileName = "ingrese una imaguen"
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(699, 37)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(344, 23)
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
        btnsalir.Location = New Point(1260, 550)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(80, 35)
        btnsalir.TabIndex = 20
        btnsalir.Text = "salir"
        btnsalir.TextAlign = ContentAlignment.MiddleLeft
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(169, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 21)
        Label5.TabIndex = 9
        Label5.Text = "Tipo:"
        ' 
        ' cmbtipo
        ' 
        cmbtipo.FormattingEnabled = True
        cmbtipo.Items.AddRange(New Object() {"Admin", "Vendedor"})
        cmbtipo.Location = New Point(218, 273)
        cmbtipo.Name = "cmbtipo"
        cmbtipo.Size = New Size(255, 23)
        cmbtipo.TabIndex = 11
        ' 
        ' fmr_usurios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1413, 597)
        Controls.Add(btnsalir)
        Controls.Add(txtbuscar)
        Controls.Add(picfoto)
        Controls.Add(dgvusuarios)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Controls.Add(gbx_usuarioinfo)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "fmr_usurios"
        Text = "Ingrese nombre de usuario y contraseña"
        gbx_usuarioinfo.ResumeLayout(False)
        gbx_usuarioinfo.PerformLayout()
        CType(picfoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(dgvusuarios, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents btnfoto As Button
    Friend WithEvents picfoto As PictureBox
    Friend WithEvents ofdfoto As OpenFileDialog
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbtipo As ComboBox

End Class
