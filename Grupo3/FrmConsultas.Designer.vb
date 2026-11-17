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
        Cmb = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BtnCerrar = New Button()
        Label5 = New Label()
        BtnOk = New Button()
        CType(DgvListadoVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnPDF
        ' 
        BtnPDF.Font = New Font("Segoe UI", 15.75F)
        BtnPDF.Location = New Point(392, 559)
        BtnPDF.Name = "BtnPDF"
        BtnPDF.Size = New Size(175, 50)
        BtnPDF.TabIndex = 0
        BtnPDF.Text = "PDF"
        BtnPDF.UseVisualStyleBackColor = True
        ' 
        ' BtnExcel
        ' 
        BtnExcel.Font = New Font("Segoe UI", 15.75F)
        BtnExcel.Location = New Point(573, 560)
        BtnExcel.Name = "BtnExcel"
        BtnExcel.Size = New Size(175, 50)
        BtnExcel.TabIndex = 1
        BtnExcel.Text = "Excel"
        BtnExcel.UseVisualStyleBackColor = True
        ' 
        ' BtnCorreo
        ' 
        BtnCorreo.Font = New Font("Segoe UI", 15.75F)
        BtnCorreo.Location = New Point(754, 560)
        BtnCorreo.Name = "BtnCorreo"
        BtnCorreo.Size = New Size(175, 50)
        BtnCorreo.TabIndex = 2
        BtnCorreo.Text = "Correo"
        BtnCorreo.UseVisualStyleBackColor = True
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
        BtnEnviar.Font = New Font("Segoe UI", 15.75F)
        BtnEnviar.Location = New Point(392, 358)
        BtnEnviar.Name = "BtnEnviar"
        BtnEnviar.Size = New Size(175, 50)
        BtnEnviar.TabIndex = 4
        BtnEnviar.Text = "Enviar"
        BtnEnviar.UseVisualStyleBackColor = True
        BtnEnviar.Visible = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Font = New Font("Segoe UI", 15.75F)
        BtnCancelar.Location = New Point(749, 358)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(175, 50)
        BtnCancelar.TabIndex = 5
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
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
        ' Cmb
        ' 
        Cmb.FormattingEnabled = True
        Cmb.Location = New Point(901, 47)
        Cmb.Name = "Cmb"
        Cmb.Size = New Size(175, 28)
        Cmb.TabIndex = 7
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(160, 45)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(515, 45)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(410, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 10
        Label1.Text = "Fecha de venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(86, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 11
        Label2.Text = "Entre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(447, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 20)
        Label3.TabIndex = 12
        Label3.Text = "y"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(954, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 13
        Label4.Text = "Vendedor:"
        ' 
        ' BtnCerrar
        ' 
        BtnCerrar.Location = New Point(1324, 568)
        BtnCerrar.Name = "BtnCerrar"
        BtnCerrar.Size = New Size(80, 35)
        BtnCerrar.TabIndex = 15
        BtnCerrar.Text = "X"
        BtnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(596, 526)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 14
        Label5.Text = "Exportar a:"
        ' 
        ' BtnOk
        ' 
        BtnOk.Font = New Font("Segoe UI", 9F)
        BtnOk.Location = New Point(1126, 47)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(80, 28)
        BtnOk.TabIndex = 16
        BtnOk.Text = "Ok"
        BtnOk.UseVisualStyleBackColor = True
        ' 
        ' FrmConsultas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(248))
        ClientSize = New Size(1438, 621)
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
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Cmb)
        Controls.Add(TxtCorreo)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnEnviar)
        Controls.Add(DgvListadoVentas)
        Name = "FrmConsultas"
        Text = "FrmConsultas"
        CType(DgvListadoVentas, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Cmb As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnOk As Button
End Class
