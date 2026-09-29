Public Class SPLASH
    Private Sub SPLASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Randomize()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 90 Then
            ProgressBar1.Value += Int((3 - 0 + 1) * Rnd() + 1)
        Else
            ProgressBar1.Value += 1
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            'Me.Hide()
            'Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        Timer1.Enabled = True
    End Sub
End Class