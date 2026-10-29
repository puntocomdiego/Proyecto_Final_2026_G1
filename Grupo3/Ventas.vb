Imports System.Xml

Public Class Ventas
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb1.SelectedIndexChanged


    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        'While True
        '    lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        '    ' Application.DoEvents()
        'End While


        For I = 1 To 10
            Cmb1.Items.Add(I)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With DataGridView1
            .Columns.Clear()
            .Columns.Add("Id", "id_venta")
            .Columns.Add("Id Juego", "Cantidad")
            .Columns.Add("precio", "Subtotal")
            .RowCount = DataGridView1.RowCount + 1
        End With

    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs) Handles lblHora.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("¿Desea salir del sistema?", MsgBoxStyle.YesNo, "Salir")
    End Sub
End Class