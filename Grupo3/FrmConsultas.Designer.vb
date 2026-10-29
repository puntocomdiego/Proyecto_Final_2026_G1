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
        BtnOk = New Button()
        BtnCancelar = New Button()
        TxtCorreo = New TextBox()
        CType(DgvListadoVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnPDF
        ' 
        BtnPDF.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPDF.Location = New Point(54, 436)
        BtnPDF.Name = "BtnPDF"
        BtnPDF.Size = New Size(286, 49)
        BtnPDF.TabIndex = 0
        BtnPDF.Text = "Exportar a PDF"
        BtnPDF.UseVisualStyleBackColor = True
        ' 
        ' BtnExcel
        ' 
        BtnExcel.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnExcel.Location = New Point(562, 436)
        BtnExcel.Name = "BtnExcel"
        BtnExcel.Size = New Size(294, 49)
        BtnExcel.TabIndex = 1
        BtnExcel.Text = "Exportar a Excel"
        BtnExcel.UseVisualStyleBackColor = True
        ' 
        ' BtnCorreo
        ' 
        BtnCorreo.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCorreo.Location = New Point(1066, 436)
        BtnCorreo.Name = "BtnCorreo"
        BtnCorreo.Size = New Size(268, 49)
        BtnCorreo.TabIndex = 2
        BtnCorreo.Text = "Enviar por Correo"
        BtnCorreo.UseVisualStyleBackColor = True
        ' 
        ' DgvListadoVentas
        ' 
        DgvListadoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvListadoVentas.Location = New Point(54, 29)
        DgvListadoVentas.Name = "DgvListadoVentas"
        DgvListadoVentas.RowHeadersWidth = 51
        DgvListadoVentas.Size = New Size(1280, 401)
        DgvListadoVentas.TabIndex = 3
        ' 
        ' BtnOk
        ' 
        BtnOk.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnOk.Location = New Point(395, 284)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(192, 51)
        BtnOk.TabIndex = 4
        BtnOk.Text = "Ok"
        BtnOk.UseVisualStyleBackColor = True
        BtnOk.Visible = False
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCancelar.Location = New Point(757, 284)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(192, 51)
        BtnCancelar.TabIndex = 5
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        BtnCancelar.Visible = False
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtCorreo.Location = New Point(191, 216)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(970, 43)
        TxtCorreo.TabIndex = 6
        TxtCorreo.Visible = False
        ' 
        ' FrmConsultas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1372, 497)
        Controls.Add(TxtCorreo)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnOk)
        Controls.Add(DgvListadoVentas)
        Controls.Add(BtnCorreo)
        Controls.Add(BtnExcel)
        Controls.Add(BtnPDF)
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
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtCorreo As TextBox
End Class
