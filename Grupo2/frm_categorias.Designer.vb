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
        btnBuscar = New Button()
        lblHora = New Label()
        Timer1 = New Timer(components)
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(303, 108)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcategorias.Size = New Size(561, 184)
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
        btnguardar.Location = New Point(43, 231)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(169, 47)
        btnguardar.TabIndex = 4
        btnguardar.Text = "GUARDAR"
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = SystemColors.AppWorkspace
        btneliminar.Location = New Point(43, 284)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(169, 48)
        btneliminar.TabIndex = 5
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = SystemColors.AppWorkspace
        btnlimpiar.Location = New Point(43, 338)
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
        Label4.Location = New Point(89, -4)
        Label4.Name = "Label4"
        Label4.Size = New Size(449, 96)
        Label4.TabIndex = 10
        Label4.Text = "CATEGORIAS"
        ' 
        ' TXTBUSCAR
        ' 
        TXTBUSCAR.BackColor = SystemColors.ScrollBar
        TXTBUSCAR.Location = New Point(303, 338)
        TXTBUSCAR.Name = "TXTBUSCAR"
        TXTBUSCAR.Size = New Size(561, 23)
        TXTBUSCAR.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(549, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 12
        Label3.Text = "BUSCAR:"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = SystemColors.AppWorkspace
        btnBuscar.Location = New Point(372, 406)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(425, 70)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "APLICAR PARAMETROS"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Font = New Font("Rockwell Condensed", 25F)
        lblHora.Location = New Point(616, 31)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(87, 40)
        lblHora.TabIndex = 14
        lblHora.Text = "Label5"
        ' 
        ' Timer1
        ' 
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(876, 500)
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
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents Timer1 As Timer
End Class
