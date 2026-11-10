<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_categorias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_categorias))
        dgvcategorias = New DataGridView()
        txtnombre = New TextBox()
        txtdescripcion = New TextBox()
        btnguardar = New Button()
        btneliminar = New Button()
        btnlimpiar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TXTBUSCAR = New TextBox()
        Label3 = New Label()
        lblHora = New Label()
        Timer1 = New Timer(components)
        btntutorial = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnBuscar = New Button()
        lblcoincidencias = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(427, 48)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcategorias.Size = New Size(743, 223)
        dgvcategorias.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.BackColor = SystemColors.ScrollBar
        txtnombre.Location = New Point(94, 36)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(208, 23)
        txtnombre.TabIndex = 2
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.BackColor = SystemColors.ScrollBar
        txtdescripcion.Location = New Point(94, 83)
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(208, 23)
        txtdescripcion.TabIndex = 3
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = SystemColors.AppWorkspace
        btnguardar.Font = New Font("Segoe UI", 10F)
        btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), Image)
        btnguardar.ImageAlign = ContentAlignment.MiddleRight
        btnguardar.Location = New Point(459, 22)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(175, 50)
        btnguardar.TabIndex = 4
        btnguardar.Text = "Guardar                "
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = SystemColors.AppWorkspace
        btneliminar.Font = New Font("Segoe UI", 10F)
        btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), Image)
        btneliminar.ImageAlign = ContentAlignment.MiddleRight
        btneliminar.Location = New Point(258, 22)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(175, 50)
        btneliminar.TabIndex = 5
        btneliminar.Text = "Eliminar         "
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = SystemColors.AppWorkspace
        btnlimpiar.Font = New Font("Segoe UI", 10F)
        btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), Image)
        btnlimpiar.ImageAlign = ContentAlignment.MiddleRight
        btnlimpiar.Location = New Point(62, 22)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(175, 50)
        btnlimpiar.TabIndex = 6
        btnlimpiar.Text = "Limpiar             "
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 7
        Label1.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 8
        Label2.Text = "DESCRIPCION:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 25F)
        Label4.Location = New Point(112, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(214, 46)
        Label4.TabIndex = 10
        Label4.Text = "CATEGORIAS"
        ' 
        ' TXTBUSCAR
        ' 
        TXTBUSCAR.BackColor = SystemColors.ScrollBar
        TXTBUSCAR.Location = New Point(94, 126)
        TXTBUSCAR.Name = "TXTBUSCAR"
        TXTBUSCAR.Size = New Size(208, 23)
        TXTBUSCAR.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 12
        Label3.Text = "BUSCAR:"
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Rockwell Condensed", 25F)
        lblHora.Location = New Point(373, 15)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(35, 40)
        lblHora.TabIndex = 14
        lblHora.Text = "..."
        ' 
        ' Timer1
        ' 
        ' 
        ' btntutorial
        ' 
        btntutorial.BackColor = SystemColors.AppWorkspace
        btntutorial.Font = New Font("Segoe UI", 10F)
        btntutorial.Image = CType(resources.GetObject("btntutorial.Image"), Image)
        btntutorial.ImageAlign = ContentAlignment.MiddleRight
        btntutorial.Location = New Point(831, 22)
        btntutorial.Name = "btntutorial"
        btntutorial.Size = New Size(175, 50)
        btntutorial.TabIndex = 15
        btntutorial.Text = " ?Como usar                  "
        btntutorial.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(77, 321)
        Label5.Name = "Label5"
        Label5.Size = New Size(1057, 23)
        Label5.TabIndex = 16
        Label5.Text = "GUARDAR: Coloca el nombre en la caja de texto y descripcion antes de tocar el boton. Luego de haber colocado los parametros toca el boton y se guardara automaticamente"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        Label5.UseCompatibleTextRendering = True
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(77, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(805, 19)
        Label6.TabIndex = 17
        Label6.Text = "ELIMINAR: Toca la flecha al inicio de la linea que quieras borrar para seleccionarla y luego toca el boton eliminar para borrar la linea"
        Label6.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(77, 341)
        Label7.Name = "Label7"
        Label7.Size = New Size(884, 19)
        Label7.TabIndex = 18
        Label7.Text = "LIMPIAR:Al colocar un texto que te hayas arrepentido oprime el boton para eliminar lo que colocaste en las cajas de texto nombre y descripcion"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(77, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(868, 19)
        Label8.TabIndex = 19
        Label8.Text = "APLICAR PARAMETROS: Coloca una letra o palabra en la caja de texto buscar y al tocar el boton se remarcaran las letras que hayas colocado "
        Label8.Visible = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.AppWorkspace
        btnBuscar.Font = New Font("Segoe UI", 10F)
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(650, 22)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(175, 50)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "Aplicar parametros           "
        btnBuscar.TextAlign = ContentAlignment.MiddleRight
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' lblcoincidencias
        ' 
        lblcoincidencias.AutoSize = True
        lblcoincidencias.Font = New Font("Segoe UI", 15F)
        lblcoincidencias.Location = New Point(635, 274)
        lblcoincidencias.Name = "lblcoincidencias"
        lblcoincidencias.Size = New Size(24, 28)
        lblcoincidencias.TabIndex = 20
        lblcoincidencias.Text = "..."
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TXTBUSCAR)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtdescripcion)
        GroupBox1.Controls.Add(txtnombre)
        GroupBox1.Location = New Point(24, 87)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(326, 184)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(btnlimpiar)
        GroupBox2.Controls.Add(btneliminar)
        GroupBox2.Controls.Add(btnguardar)
        GroupBox2.Controls.Add(btnBuscar)
        GroupBox2.Controls.Add(btntutorial)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(56, 384)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1030, 78)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1092, 425)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 37)
        Button1.TabIndex = 23
        Button1.Text = "     Salir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1182, 474)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(lblcoincidencias)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblHora)
        Controls.Add(Label4)
        Controls.Add(dgvcategorias)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        Name = "frm_categorias"
        Text = "CATEGORIAS"
        CType(dgvcategorias, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvcategorias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btntutorial As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblcoincidencias As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
End Class
