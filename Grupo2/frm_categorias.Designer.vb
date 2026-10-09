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
        CType(dgvcategorias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvcategorias
        ' 
        dgvcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvcategorias.Location = New Point(161, 24)
        dgvcategorias.Name = "dgvcategorias"
        dgvcategorias.Size = New Size(532, 184)
        dgvcategorias.TabIndex = 0
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(322, 214)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(282, 23)
        txtnombre.TabIndex = 2
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.Location = New Point(322, 266)
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(285, 23)
        txtdescripcion.TabIndex = 3
        ' 
        ' btnguardar
        ' 
        btnguardar.Location = New Point(161, 307)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(169, 47)
        btnguardar.TabIndex = 4
        btnguardar.Text = "guardar :)"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btneliminar
        ' 
        btneliminar.Location = New Point(374, 306)
        btneliminar.Name = "btneliminar"
        btneliminar.Size = New Size(165, 48)
        btneliminar.TabIndex = 5
        btneliminar.Text = "eliminar"
        btneliminar.UseVisualStyleBackColor = True
        ' 
        ' btnlimpiar
        ' 
        btnlimpiar.Location = New Point(579, 307)
        btnlimpiar.Name = "btnlimpiar"
        btnlimpiar.Size = New Size(154, 47)
        btnlimpiar.TabIndex = 6
        btnlimpiar.Text = "limpiar"
        btnlimpiar.UseVisualStyleBackColor = True
        ' 
        ' frm_categorias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnlimpiar)
        Controls.Add(btneliminar)
        Controls.Add(btnguardar)
        Controls.Add(txtdescripcion)
        Controls.Add(txtnombre)
        Controls.Add(dgvcategorias)
        Name = "frm_categorias"
        Text = "e"
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
End Class
