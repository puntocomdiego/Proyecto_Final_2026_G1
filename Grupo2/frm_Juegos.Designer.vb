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
        dgvJuegos = New DataGridView()
        ofd = New OpenFileDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(picPortada, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvJuegos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(67, 38)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(67, 128)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 2
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(67, 84)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 3
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(67, 170)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(121, 23)
        cmbCategoria.TabIndex = 4
        ' 
        ' dtpFechaIngreso
        ' 
        dtpFechaIngreso.Location = New Point(67, 214)
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
        ' dgvJuegos
        ' 
        dgvJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJuegos.Location = New Point(67, 250)
        dgvJuegos.Name = "dgvJuegos"
        dgvJuegos.Size = New Size(598, 188)
        dgvJuegos.TabIndex = 11
        ' 
        ' ofd
        ' 
        ofd.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 12
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 13
        Label2.Text = "Precio:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 14
        Label3.Text = "Stock:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 15
        Label4.Text = "Categoria:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(72, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 16
        Label5.Text = "Fecha Ingreso:"
        ' 
        ' frm_Juegos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvJuegos)
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
        CType(dgvJuegos, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvJuegos As DataGridView
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
