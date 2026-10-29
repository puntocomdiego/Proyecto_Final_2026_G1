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
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(303, 110)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcategorias.Size = New Size(420, 184)
        dgvcategorias.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.BackColor = SystemColors.ScrollBar
        txtnombre.Location = New Point(89, 120)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(208, 23)
        txtnombre.TabIndex = 2
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.BackColor = SystemColors.ScrollBar
        txtdescripcion.Location = New Point(89, 181)
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(208, 23)
        txtdescripcion.TabIndex = 3
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = SystemColors.AppWorkspace
        btnguardar.Location = New Point(-1, 233)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(169, 47)
        btnguardar.TabIndex = 4
        btnguardar.Text = "GUARDAR"
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = SystemColors.AppWorkspace
        btneliminar.Location = New Point(1, 286)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(169, 48)
        btneliminar.TabIndex = 5
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = SystemColors.AppWorkspace
        btnlimpiar.Location = New Point(1, 340)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(169, 47)
        btnlimpiar.TabIndex = 6
        btnlimpiar.Text = "LIMPIAR"
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 7
        Label1.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-1, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 8
        Label2.Text = "DESCRIPCION:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 54F)
        Label4.Location = New Point(1, -1)
        Label4.Name = "Label4"
        Label4.Size = New Size(449, 96)
        Label4.TabIndex = 10
        Label4.Text = "CATEGORIAS"
        ' 
        ' TXTBUSCAR
        ' 
        TXTBUSCAR.BackColor = SystemColors.ScrollBar
        TXTBUSCAR.Location = New Point(775, 181)
        TXTBUSCAR.Name = "TXTBUSCAR"
        TXTBUSCAR.Size = New Size(246, 23)
        TXTBUSCAR.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(867, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 12
        Label3.Text = "BUSCAR:"
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Rockwell Condensed", 40F)
        lblHora.Location = New Point(526, 26)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(54, 64)
        lblHora.TabIndex = 14
        lblHora.Text = "..."
        ' 
        ' Timer1
        ' 
        ' 
        ' btntutorial
        ' 
        btntutorial.BackColor = SystemColors.AppWorkspace
        btntutorial.Location = New Point(-1, 407)
        btntutorial.Name = "btntutorial"
        btntutorial.Size = New Size(148, 41)
        btntutorial.TabIndex = 15
        btntutorial.Text = "Como usar?"
        btntutorial.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(167, 314)
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
        Label6.Location = New Point(176, 337)
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
        Label7.Location = New Point(176, 354)
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
        Label8.Location = New Point(176, 375)
        Label8.Name = "Label8"
        Label8.Size = New Size(868, 19)
        Label8.TabIndex = 19
        Label8.Text = "APLICAR PARAMETROS: Coloca una letra o palabra en la caja de texto buscar y al tocar el boton se remarcaran las letras que hayas colocado "
        Label8.Visible = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.AppWorkspace
        btnBuscar.Location = New Point(798, 210)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(206, 70)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "APLICAR PARAMETROS"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' lblcoincidencias
        ' 
        lblcoincidencias.AutoSize = True
        lblcoincidencias.Font = New Font("Segoe UI", 45F)
        lblcoincidencias.Location = New Point(303, 313)
        lblcoincidencias.Name = "lblcoincidencias"
        lblcoincidencias.Size = New Size(74, 81)
        lblcoincidencias.TabIndex = 20
        lblcoincidencias.Text = "..."
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1110, 453)
        Controls.Add(lblcoincidencias)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(btntutorial)
        Controls.Add(lblHora)
        Controls.Add(btnBuscar)
        Controls.Add(Label3)
        Controls.Add(TXTBUSCAR)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnlimpiar)
        Controls.Add(btneliminar)
        Controls.Add(btnguardar)
        Controls.Add(txtdescripcion)
        Controls.Add(txtnombre)
        Controls.Add(dgvcategorias)
        KeyPreview = True
        Name = "frm_categorias"
        Text = "CATEGORIAS"
        CType(dgvcategorias, ComponentModel.ISupportInitialize).EndInit()
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
End Class
