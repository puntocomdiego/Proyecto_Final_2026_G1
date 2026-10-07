Public Class SPLASH
    Private Sub SPLASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Randomize()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPorcentaje.Text = pgr.Value.ToString() & "%"

        If pgr.Value < 90 Then
            pgr.Value += Int((10 - 3 + 1) * Rnd() + 1)
            If pgr.Value < 10 Then
                lblEstado.Text = "Cargando recursos."
            ElseIf pgr.Value < 20 Then
                lblEstado.Text = "Configurando interfaz."
            ElseIf pgr.Value < 50 Then
                lblEstado.Text = "Haciendo un simulacro."
            ElseIf pgr.Value < 70 Then
                lblEstado.Text = "Conectando a la base de datos."
            ElseIf pgr.Value < 90 Then
                lblEstado.Text = "Buscando por archivos corruptos."
            End If
        Else
            pgr.Value += 1
            lblEstado.Text = "Inicializando."
        End If

        If pgr.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        pgr.Value = 0
        Timer1.Enabled = True
    End Sub
End Class