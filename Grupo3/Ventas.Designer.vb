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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        BtnFinaliza = New Button()
        lblHora = New Label()
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
        Cmb2.Items.AddRange(New Object() {"Mario Kart 8 Deluxe", "The Legend of Zelda: Tears of the Kingdom", "Super Smash Bros Ultimate", "Splatoon 3", "Minecraft", "Stardew Valley", "Hollow Knight", "Gran Turismo 7", "Marvel's Spider-Man 2", "Forza Horizon 5", "Rocket League", "Sonic the Hedgehog (clasico)"})
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(393, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 4
        Label3.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(130, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 5
        Label4.Text = "Cantidad💎"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(586, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 15)
        Label5.TabIndex = 6
        Label5.Text = "Juegos🕹"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 189)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(674, 102)
        DataGridView1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(56, 297)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 23)
        Button1.TabIndex = 8
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(326, 297)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 23)
        Button2.TabIndex = 9
        Button2.Text = "Editar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnFinaliza
        ' 
        BtnFinaliza.ForeColor = SystemColors.ActiveCaptionText
        BtnFinaliza.Location = New Point(608, 297)
        BtnFinaliza.Name = "BtnFinaliza"
        BtnFinaliza.Size = New Size(122, 23)
        BtnFinaliza.TabIndex = 12
        BtnFinaliza.Text = "Confirmar"
        BtnFinaliza.UseVisualStyleBackColor = True
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.ForeColor = SystemColors.ActiveCaptionText
        lblHora.Location = New Point(705, 27)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(47, 15)
        lblHora.TabIndex = 13
        lblHora.Text = "Fecha..."
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
        Controls.Add(lblHora)
        Controls.Add(BtnFinaliza)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnFinaliza As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents BtnSalir As Button
End Class
