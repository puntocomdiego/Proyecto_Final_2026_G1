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
        DataGridView1 = New DataGridView()
        ofd = New OpenFileDialog()
        CType(picPortada, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(67, 34)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(67, 132)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(67, 80)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(67, 174)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(121, 23)
        cmbCategoria.TabIndex = 4
        ' 
        ' dtpFechaIngreso
        ' 
        dtpFechaIngreso.Location = New Point(67, 208)
        dtpFechaIngreso.Name = "dtpFechaIngreso"
        dtpFechaIngreso.Size = New Size(200, 23)
        dtpFechaIngreso.TabIndex = 5
        ' 
        ' picPortada
        ' 
        picPortada.Location = New Point(281, 34)
        picPortada.Name = "picPortada"
        picPortada.Size = New Size(216, 176)
        picPortada.TabIndex = 6
        picPortada.TabStop = False
        ' 
        ' btnExaminar
        ' 
        btnExaminar.Location = New Point(544, 32)
        btnExaminar.Name = "btnExaminar"
        btnExaminar.Size = New Size(121, 40)
        btnExaminar.TabIndex = 7
        btnExaminar.Text = "Examinar"
        btnExaminar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(544, 78)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(121, 40)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(544, 124)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(121, 40)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(544, 170)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(121, 40)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(67, 250)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(598, 188)
        DataGridView1.TabIndex = 11
        ' 
        ' ofd
        ' 
        ofd.FileName = "OpenFileDialog1"
        ' 
        ' frm_Juegos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnLimpiar)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(btnExaminar)
        Controls.Add(picPortada)
        Controls.Add(dtpFechaIngreso)
        Controls.Add(cmbCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtStock)
        Controls.Add(txtNombre)
        Name = "frm_Juegos"
        Text = "frm_Juegos"
        CType(picPortada, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ofd As OpenFileDialog
End Class
