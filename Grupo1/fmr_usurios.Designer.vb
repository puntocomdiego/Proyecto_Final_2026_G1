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
        btnfoto = New Button()
        Button5 = New Button()
        GroupBox1 = New GroupBox()
        txt = New TextBox()
        Label6 = New Label()
        dgvusuarios = New DataGridView()
        picfoto = New PictureBox()
        gbx_usuarioinfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvusuarios, ComponentModel.ISupportInitialize).BeginInit()
        CType(picfoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Modern No. 20", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 22)
        Label1.TabIndex = 0
        Label1.Text = "Nombre :"
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(218, 32)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(137, 20)
        txtnombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Modern No. 20", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(6, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 22)
        Label2.TabIndex = 2
        Label2.Text = "Apellido :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 22)
        Label3.TabIndex = 3
        Label3.Text = "Nombre de usuario :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Modern No. 20", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 22)
        Label4.TabIndex = 4
        Label4.Text = "Contraseña :"
        ' 
        ' txtcontra
        ' 
        txtcontra.Location = New Point(218, 206)
        txtcontra.Name = "txtcontra"
        txtcontra.Size = New Size(215, 20)
        txtcontra.TabIndex = 6
        ' 
        ' txtnomusuario
        ' 
        txtnomusuario.Location = New Point(218, 144)
        txtnomusuario.Name = "txtnomusuario"
        txtnomusuario.Size = New Size(215, 20)
        txtnomusuario.TabIndex = 7
        ' 
        ' txtapellido
        ' 
        txtapellido.Location = New Point(218, 87)
        txtapellido.Name = "txtapellido"
        txtapellido.Size = New Size(137, 20)
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
        gbx_usuarioinfo.Size = New Size(459, 264)
        gbx_usuarioinfo.TabIndex = 10
        gbx_usuarioinfo.TabStop = False
        gbx_usuarioinfo.Text = "Usuario info"
        ' 
        ' btnnuevo
        ' 
        btnnuevo.BackgroundImageLayout = ImageLayout.Zoom
        btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), Image)
        btnnuevo.ImageAlign = ContentAlignment.MiddleLeft
        btnnuevo.Location = New Point(35, 38)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(122, 41)
        btnnuevo.TabIndex = 11
        btnnuevo.Text = "nuevo"
        btnnuevo.TextAlign = ContentAlignment.MiddleRight
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnmodificar
        ' 
        btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), Image)
        btnmodificar.ImageAlign = ContentAlignment.MiddleLeft
        btnmodificar.Location = New Point(35, 94)
        btnmodificar.Name = "btnmodificar"
        btnmodificar.Size = New Size(122, 33)
        btnmodificar.TabIndex = 12
        btnmodificar.Text = "modificar"
        btnmodificar.TextAlign = ContentAlignment.MiddleRight
        btnmodificar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.MiddleLeft
        btneliminar.Location = New Point(35, 144)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(122, 33)
        btneliminar.TabIndex = 13
        btneliminar.Text = "eliminar"
        btneliminar.TextAlign = ContentAlignment.MiddleRight
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnfoto
        ' 
        btnfoto.Image = CType(resources.GetObject("btnfoto.Image"), Image)
        btnfoto.ImageAlign = ContentAlignment.MiddleLeft
        btnfoto.Location = New Point(35, 192)
        btnfoto.Name = "btnfoto"
        btnfoto.Size = New Size(122, 33)
        btnfoto.TabIndex = 14
        btnfoto.Text = "foto"
        btnfoto.TextAlign = ContentAlignment.MiddleRight
        btnfoto.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(477, 21)
        Button5.Name = "Button5"
        Button5.Size = New Size(44, 33)
        Button5.TabIndex = 15
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btneliminar)
        GroupBox1.Controls.Add(btnnuevo)
        GroupBox1.Controls.Add(btnfoto)
        GroupBox1.Controls.Add(btnmodificar)
        GroupBox1.Location = New Point(541, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 240)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' txt
        ' 
        txt.Location = New Point(254, 324)
        txt.Name = "txt"
        txt.Size = New Size(196, 23)
        txt.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Modern No. 20", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(55, 321)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 22)
        Label6.TabIndex = 10
        Label6.Text = "usuario a buscar :"
        ' 
        ' dgvusuarios
        ' 
        dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvusuarios.Location = New Point(22, 401)
        dgvusuarios.Name = "dgvusuarios"
        dgvusuarios.Size = New Size(580, 209)
        dgvusuarios.TabIndex = 18
        ' 
        ' picfoto
        ' 
        picfoto.Location = New Point(667, 345)
        picfoto.Name = "picfoto"
        picfoto.Size = New Size(203, 277)
        picfoto.TabIndex = 19
        picfoto.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(962, 692)
        Controls.Add(picfoto)
        Controls.Add(dgvusuarios)
        Controls.Add(Label6)
        Controls.Add(txt)
        Controls.Add(GroupBox1)
        Controls.Add(Button5)
        Controls.Add(gbx_usuarioinfo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
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
    Friend WithEvents btnfoto As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvusuarios As DataGridView
    Friend WithEvents picfoto As PictureBox

End Class
