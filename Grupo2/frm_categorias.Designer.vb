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
        btnBuscar = New Button()
        lblcoincidencias = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        RichTextBox1 = New RichTextBox()
        RichTextBox2 = New RichTextBox()
        RichTextBox3 = New RichTextBox()
        RichTextBox4 = New RichTextBox()
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(417, 68)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcategorias.Size = New Size(669, 203)
        dgvcategorias.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.BackColor = SystemColors.ScrollBar
        txtnombre.Location = New Point(89, 51)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(208, 23)
        txtnombre.TabIndex = 2
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.BackColor = SystemColors.ScrollBar
        txtdescripcion.Location = New Point(89, 101)
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
        btnguardar.Location = New Point(437, 22)
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
        btneliminar.Location = New Point(225, 22)
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
        btnlimpiar.Location = New Point(25, 22)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(175, 50)
        btnlimpiar.TabIndex = 6
        btnlimpiar.Text = "Limpiar             "
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 7
        Label1.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(4, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 8
        Label2.Text = "DESCRIPCION:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 25F)
        Label4.Location = New Point(53, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(214, 46)
        Label4.TabIndex = 10
        Label4.Text = "CATEGORIAS"
        ' 
        ' TXTBUSCAR
        ' 
        TXTBUSCAR.BackColor = SystemColors.ScrollBar
        TXTBUSCAR.Location = New Point(89, 144)
        TXTBUSCAR.Name = "TXTBUSCAR"
        TXTBUSCAR.Size = New Size(208, 23)
        TXTBUSCAR.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 12
        Label3.Text = "BUSCAR:"
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Rockwell Condensed", 25F)
        lblHora.Location = New Point(291, 21)
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
        btntutorial.Location = New Point(837, 22)
        btntutorial.Name = "btntutorial"
        btntutorial.Size = New Size(175, 50)
        btntutorial.TabIndex = 15
        btntutorial.Text = " ?Como usar                  "
        btntutorial.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.AppWorkspace
        btnBuscar.Font = New Font("Segoe UI", 10F)
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(636, 22)
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
        GroupBox1.Location = New Point(24, 64)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(369, 207)
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
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(btntutorial)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(24, 381)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.RightToLeft = RightToLeft.Yes
        GroupBox2.Size = New Size(1230, 92)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1027, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 50)
        Button1.TabIndex = 23
        Button1.Text = "     Salir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.ForeColor = SystemColors.InactiveCaptionText
        RichTextBox1.Location = New Point(12, 274)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(723, 22)
        RichTextBox1.TabIndex = 24
        RichTextBox1.Text = "ELIMINAR: Toca la flecha al inicio de la línea que quieras borrar para seleccionarla y luego toca el botón «Eliminar» para borrarla."
        RichTextBox1.Visible = False
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Location = New Point(12, 300)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.Size = New Size(1028, 25)
        RichTextBox2.TabIndex = 25
        RichTextBox2.Text = "GUARDAR: Coloca el nombre y la descripción en las cajas de texto antes de tocar el botón. Luego de haber ingresado los parámetros, toca el botón «Guardar» y se guardará automáticamente."
        RichTextBox2.Visible = False
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(12, 362)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(784, 25)
        RichTextBox3.TabIndex = 26
        RichTextBox3.Text = "APLICAR PARÁMETROS: Coloca una letra o palabra en la caja de texto «Buscar» y, al tocar el botón, se remarcarán las letras que hayas ingresado."
        RichTextBox3.Visible = False
        ' 
        ' RichTextBox4
        ' 
        RichTextBox4.Location = New Point(12, 331)
        RichTextBox4.Name = "RichTextBox4"
        RichTextBox4.Size = New Size(881, 25)
        RichTextBox4.TabIndex = 27
        RichTextBox4.Text = "LIMPIAR: Si colocaste un texto del que te hayas arrepentido, oprime el botón «Limpiar» para eliminar lo que escribiste en las cajas de texto de nombre y descripción"
        RichTextBox4.Visible = False
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1284, 488)
        Controls.Add(RichTextBox4)
        Controls.Add(RichTextBox3)
        Controls.Add(RichTextBox2)
        Controls.Add(RichTextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(lblcoincidencias)
        Controls.Add(lblHora)
        Controls.Add(Label4)
        Controls.Add(dgvcategorias)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        Name = "frm_categorias"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administracion de categorias"
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
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblcoincidencias As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
End Class
