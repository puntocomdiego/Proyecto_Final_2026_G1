Imports System.IO
Imports System.Net.Mail
Imports iTextSharp.text
Imports iTextSharp.text.pdf



Public Class frmCorreo
    Private dgvJuegos As DataGridView

    'Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
    '    'crear pdf del datagridview y mandar por correo utilizando el correo que colocaremos en el textbox
    '    Try
    '        'crear pdf del datagridview
    '        Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
    '        Dim filename As String = Path.Combine(Path.GetTempPath(), "datos.pdf")
    '        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)

    '        Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))

    '        Dim pdf As New cls_Productos_Datos_2()
    '        doc.Open()
    '        pdf.ExportarDatosPDF(dgvJuegos, filename)
    '        doc.Close()

    '        'enviar correo con el pdf adjunto
    '        Dim correo As New MailMessage()
    '        correo.From = New MailAddress("kevinperochena4@gmail.com") 'correo del remitente
    '        correo.To.Add(txtGmail.Text) 'correo del destinatario
    '        correo.Subject = "Listado de Juegos"
    '        correo.Body = "Adjunto encontrará el listado de juegos en formato PDF."

    '        correo.Attachments.Add(New Attachment(filename))

    '        Dim smtp As New SmtpClient("smtp.gmail.com") 'servidor smtp de gmail
    '        smtp.Port = 587
    '        smtp.Credentials = New System.Net.NetworkCredential("kevinperochena4@gmail.com", "58640836") 'correo y contraseña del remitente
    '        smtp.EnableSsl = True

    '        smtp.Send(correo)


    '        MsgBox("Correo enviado correctamente.", MsgBoxStyle.Information, "Éxito")


    '    Catch ex As Exception
    '        MsgBox("Error al enviar el correo: " & ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try




    '    'Try
    '    '    'Intentar generar el documento.
    '    '    Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
    '    '    Dim filename As String ' = My.Application.Info.DirectoryPath + "\datos.pdf"
    '    '    Dim ruta As String

    '    '    FolderBrowserDialog1.ShowDialog()
    '    '    ruta = FolderBrowserDialog1.SelectedPath()
    '    '    filename = ruta + "\datos.pdf"
    '    '    Dim f As String = Format(Now.Date, "dd-MM-yy")
    '    '    'filename = ruta + "\" + ComboBox1.Text + "-" + f + ".pdf"

    '    '    Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
    '    '    Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))

    '    '    'PdfWriter.GetInstance(doc, file)
    '    '    Dim pdf As New cls_Productos_Datos_2()
    '    '    doc.Open()
    '    '    pdf.ExportarDatosPDF(dgvJuegos, "Listado de Juegos")
    '    '    doc.Close()

    '    '    MsgBox("Terminó todo bien...!!")

    '    '    Shell("rundll32.exe url.dll,FileProtocolHandler " & (filename))


    '    'Catch ex As Exception
    '    '    'Si el intento es fallido, mostrar MsgBox.
    '    '    MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    'End Try

    'End Sub
End Class