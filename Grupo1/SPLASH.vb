Public Class SPLASH
    Private Sub SPLASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Do While ProgressBar1.Value < 100
            Application.DoEvents()
        Loop
        Timer1.Enabled = False
        ProgressBar1.Value = 100

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = +1
    End Sub
End Class