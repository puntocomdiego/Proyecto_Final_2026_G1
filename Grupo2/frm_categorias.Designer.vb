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
        dgvcategorias = New DataGridView()
        txtnombre = New TextBox()
        txtdescripcion = New TextBox()
        btnguardar = New Button()
        btneliminar = New Button()
        btnlimpiar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(115, 108)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvcategorias.Size = New Size(572, 184)
        dgvcategorias.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.BackColor = SystemColors.ScrollBar
        txtnombre.Location = New Point(277, 307)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(282, 23)
        txtnombre.TabIndex = 2
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.BackColor = SystemColors.ScrollBar
        txtdescripcion.Location = New Point(274, 356)
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(285, 23)
        txtdescripcion.TabIndex = 3
        ' 
        ' btnguardar
        ' 
        btnguardar.BackColor = SystemColors.AppWorkspace
        btnguardar.Location = New Point(102, 398)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(169, 47)
        btnguardar.TabIndex = 4
        btnguardar.Text = "GUARDAR"
        btnguardar.UseVisualStyleBackColor = False
        ' 
        ' btneliminar
        ' 
        btneliminar.BackColor = SystemColors.AppWorkspace
        btneliminar.Location = New Point(314, 397)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(165, 48)
        btneliminar.TabIndex = 5
        btneliminar.Text = "ELIMINAR"
        btneliminar.UseVisualStyleBackColor = False
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.BackColor = SystemColors.AppWorkspace
        btnlimpiar.Location = New Point(519, 398)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(154, 47)
        btnlimpiar.TabIndex = 6
        btnlimpiar.Text = "LIMPIAR"
        btnlimpiar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(212, 307)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 7
        Label1.Text = "NOMBRE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(187, 359)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 8
        Label2.Text = "DESCRIPCION:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 54F)
        Label4.Location = New Point(175, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(449, 96)
        Label4.TabIndex = 10
        Label4.Text = "CATEGORIAS"
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(821, 450)
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
End Class
