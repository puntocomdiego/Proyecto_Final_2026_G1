<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultas
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
        BtnPDF = New Button()
        BtnExcel = New Button()
        BtnCorreo = New Button()
        DgvListadoVentas = New DataGridView()
        BtnEnviar = New Button()
        BtnCancelar = New Button()
        TxtCorreo = New TextBox()
        CmbVendedor = New ComboBox()
        DtpInicial = New DateTimePicker()
        DtpFinal = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtnCerrar = New Button()
        Label5 = New Label()
        BtnOk = New Button()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        CType(DgvListadoVentas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnPDF
        ' 
        BtnPDF.BackColor = SystemColors.GradientActiveCaption
        BtnPDF.FlatStyle = FlatStyle.Popup
        BtnPDF.Font = New Font("Segoe UI", 15.75F)
        BtnPDF.Location = New Point(392, 559)
        BtnPDF.Name = "BtnPDF"
        BtnPDF.Size = New Size(175, 50)
        BtnPDF.TabIndex = 0
        BtnPDF.Text = "PDF"
        BtnPDF.UseVisualStyleBackColor = False
        ' 
        ' BtnExcel
        ' 
        BtnExcel.BackColor = SystemColors.GradientActiveCaption
        BtnExcel.FlatStyle = FlatStyle.Popup
        BtnExcel.Font = New Font("Segoe UI", 15.75F)
        BtnExcel.Location = New Point(573, 560)
        BtnExcel.Name = "BtnExcel"
        BtnExcel.Size = New Size(175, 50)
        BtnExcel.TabIndex = 1
        BtnExcel.Text = "Excel"
        BtnExcel.UseVisualStyleBackColor = False
        ' 
        ' BtnCorreo
        ' 
        BtnCorreo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnCorreo.BackColor = SystemColors.GradientActiveCaption
        BtnCorreo.FlatStyle = FlatStyle.Popup
        BtnCorreo.Font = New Font("Segoe UI", 15.75F)
        BtnCorreo.Location = New Point(754, 560)
        BtnCorreo.Name = "BtnCorreo"
        BtnCorreo.Size = New Size(175, 50)
        BtnCorreo.TabIndex = 2
        BtnCorreo.Text = "Correo"
        BtnCorreo.UseVisualStyleBackColor = False
        ' 
        ' DgvListadoVentas
        ' 
        DgvListadoVentas.AllowUserToAddRows = False
        DgvListadoVentas.AllowUserToDeleteRows = False
        DgvListadoVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvListadoVentas.BackgroundColor = Color.White
        DgvListadoVentas.BorderStyle = BorderStyle.None
        DgvListadoVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgvListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvListadoVentas.EnableHeadersVisualStyles = False
        DgvListadoVentas.GridColor = Color.Gray
        DgvListadoVentas.Location = New Point(54, 112)
        DgvListadoVentas.MultiSelect = False
        DgvListadoVentas.Name = "DgvListadoVentas"
        DgvListadoVentas.ReadOnly = True
        DgvListadoVentas.RowHeadersVisible = False
        DgvListadoVentas.RowHeadersWidth = 51
        DgvListadoVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvListadoVentas.Size = New Size(1280, 401)
        DgvListadoVentas.TabIndex = 3
        ' 
        ' BtnEnviar
        ' 
        BtnEnviar.BackColor = SystemColors.GradientActiveCaption
        BtnEnviar.FlatStyle = FlatStyle.Popup
        BtnEnviar.Font = New Font("Segoe UI", 15.75F)
        BtnEnviar.Location = New Point(392, 358)
        BtnEnviar.Name = "BtnEnviar"
        BtnEnviar.Size = New Size(175, 50)
        BtnEnviar.TabIndex = 4
        BtnEnviar.Text = "Enviar"
        BtnEnviar.UseVisualStyleBackColor = False
        BtnEnviar.Visible = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = SystemColors.GradientActiveCaption
        BtnCancelar.FlatStyle = FlatStyle.Popup
        BtnCancelar.Font = New Font("Segoe UI", 15.75F)
        BtnCancelar.Location = New Point(749, 358)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(175, 50)
        BtnCancelar.TabIndex = 5
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = False
        BtnCancelar.Visible = False
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtCorreo.Location = New Point(185, 271)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(970, 43)
        TxtCorreo.TabIndex = 6
        TxtCorreo.Visible = False
        ' 
        ' CmbVendedor
        ' 
        CmbVendedor.FormattingEnabled = True
        CmbVendedor.Location = New Point(529, 45)
        CmbVendedor.Name = "CmbVendedor"
        CmbVendedor.Size = New Size(175, 28)
        CmbVendedor.TabIndex = 7
        ' 
        ' DtpInicial
        ' 
        DtpInicial.CalendarFont = New Font("Segoe UI", 12F)
        DtpInicial.Format = DateTimePickerFormat.Short
        DtpInicial.Location = New Point(117, 44)
        DtpInicial.Name = "DtpInicial"
        DtpInicial.Size = New Size(122, 27)
        DtpInicial.TabIndex = 8
        DtpInicial.Value = New Date(2026, 11, 19, 0, 0, 0, 0)
        ' 
        ' DtpFinal
        ' 
        DtpFinal.Format = DateTimePickerFormat.Short
        DtpFinal.Location = New Point(313, 44)
        DtpFinal.Name = "DtpFinal"
        DtpFinal.Size = New Size(122, 27)
        DtpFinal.TabIndex = 9
        DtpFinal.Value = New Date(2026, 11, 19, 0, 0, 0, 0)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(208, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 28)
        Label1.TabIndex = 10
        Label1.Text = "Fecha de venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 11
        Label2.Text = "Entre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(269, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 20)
        Label3.TabIndex = 12
        Label3.Text = "y"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(565, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 28)
        Label4.TabIndex = 13
        Label4.Text = "Vendedor:"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnCerrar.BackColor = SystemColors.GradientActiveCaption
        BtnCerrar.FlatStyle = FlatStyle.Popup
        BtnCerrar.ForeColor = SystemColors.ControlText
        BtnCerrar.Location = New Point(1324, 568)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(80, 35)
        BtnCerrar.TabIndex = 15
        BtnCerrar.Text = "X"
        BtnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(614, 526)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 28)
        Label5.TabIndex = 14
        Label5.Text = "Exportar a:"
        ' 
        ' BtnOk
        ' 
        BtnOk.BackColor = SystemColors.GradientActiveCaption
        BtnOk.FlatStyle = FlatStyle.Popup
        BtnOk.Font = New Font("Segoe UI", 15.75F)
        BtnOk.Location = New Point(1169, 44)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(175, 50)
        BtnOk.TabIndex = 16
        BtnOk.Text = "Ok"
        BtnOk.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(749, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(404, 83)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Filtrar por:"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(259, 39)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(76, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Ambas"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(128, 39)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(94, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Vendedor"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(19, 39)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(68, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Fecha"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' FrmConsultas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1438, 621)
        Controls.Add(GroupBox1)
        Controls.Add(BtnOk)
        Controls.Add(Label5)
        Controls.Add(BtnCorreo)
        Controls.Add(BtnCerrar)
        Controls.Add(BtnExcel)
        Controls.Add(Label4)
        Controls.Add(BtnPDF)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DtpFinal)
        Controls.Add(DtpInicial)
        Controls.Add(CmbVendedor)
        Controls.Add(TxtCorreo)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnEnviar)
        Controls.Add(DgvListadoVentas)
        MinimizeBox = False
        Name = "FrmConsultas"
        Text = "FrmConsultas"
        CType(DgvListadoVentas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnPDF As Button
    Friend WithEvents BtnExcel As Button
    Friend WithEvents BtnCorreo As Button
    Friend WithEvents DgvListadoVentas As DataGridView
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents CmbVendedor As ComboBox
    Friend WithEvents DtpInicial As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
