<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Label1 = New Label()
        Cmb1 = New ComboBox()
        Cmb2 = New ComboBox()
        Label2 = New Label()
        lblStock = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        btnAgregar = New Button()
        btnConfirmar = New Button()
        BtnSalir = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(243, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 37)
        Label1.TabIndex = 0
        Label1.Text = ChrW(55357) & ChrW(57042) & "Añadir al carrito" & ChrW(55357) & ChrW(57042)
        ' 
        ' Cmb1
        ' 
        Cmb1.FormattingEnabled = True
        Cmb1.Location = New Point(56, 153)
        Cmb1.Name = "Cmb1"
        Cmb1.Size = New Size(224, 23)
        Cmb1.TabIndex = 1
        ' 
        ' Cmb2
        ' 
        Cmb2.FormattingEnabled = True
        Cmb2.Location = New Point(498, 153)
        Cmb2.Name = "Cmb2"
        Cmb2.Size = New Size(224, 23)
        Cmb2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(369, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 3
        Label2.Text = "🕶Stock👓"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.ForeColor = SystemColors.ActiveCaptionText
        lblStock.Location = New Point(393, 130)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(13, 15)
        lblStock.TabIndex = 4
        lblStock.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(130, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 5
        Label4.Text = "Juegos💎"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(586, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 6
        Label5.Text = "Cantidad🕹"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 189)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(674, 102)
        DataGridView1.TabIndex = 7
        ' 
        ' btnAgregar
        ' 
        btnAgregar.ForeColor = SystemColors.ActiveCaptionText
        btnAgregar.Location = New Point(382, 409)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(141, 23)
        btnAgregar.TabIndex = 8
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.ForeColor = SystemColors.ActiveCaptionText
        btnConfirmar.Location = New Point(552, 409)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(122, 23)
        btnConfirmar.TabIndex = 12
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.Red
        BtnSalir.ForeColor = SystemColors.ActiveCaptionText
        BtnSalir.Location = New Point(708, 403)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(80, 35)
        BtnSalir.TabIndex = 14
        BtnSalir.Text = "X"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSalir)
        Controls.Add(btnConfirmar)
        Controls.Add(btnAgregar)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lblStock)
        Controls.Add(Label2)
        Controls.Add(Cmb2)
        Controls.Add(Cmb1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaption
        Name = "Ventas"
        Text = "Ventas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb1 As ComboBox
    Friend WithEvents Cmb2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents BtnSalir As Button
End Class
