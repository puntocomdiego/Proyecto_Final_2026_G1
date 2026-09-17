Public Class Frm_Consultas_De_ventas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim respuesta As DialogResult
        respuesta = MsgBox("¿Desea salir de la consulta de ventas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If respuesta = DialogResult.Yes Then
            Me.Close()
        Else

        End If

    End Sub

End Class