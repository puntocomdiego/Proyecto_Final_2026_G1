Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmConsultas
    Dim correo As MailMessage
    Dim WithEvents clienteSmtp As New SmtpClient("smtp.gmail.com")

    Public Sub ExportarPDF(ByVal dgv As DataGridView, ByVal filename As String)
        Dim pdfTable As New PdfPTable(dgv.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        ' Agregar encabezados de columna
        For Each column As DataGridViewColumn In dgv.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240) ' Color de fondo gris claro
            pdfTable.AddCell(cell)
        Next
        ' Agregar filas de datos
        For Each row As DataGridViewRow In dgv.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(cell.Value.ToString())
            Next
        Next

    End Sub

    Private Sub ExportarAExcel(dt As DataTable, rutaDestino As String)
        Dim excelApp As Excel.Application = Nothing
        Dim libro As Excel.Workbook = Nothing
        Dim hoja As Excel.Worksheet = Nothing

        Try
            excelApp = New Excel.Application
            libro = excelApp.Workbooks.Add()
            hoja = CType(libro.Worksheets(1), Excel.Worksheet)

            For col As Integer = 0 To dt.Columns.Count - 1
                hoja.Cells(1, col + 1) = dt.Columns(col).ColumnName
            Next

            For fila As Integer = 0 To dt.Rows.Count - 1
                For col As Integer = 0 To dt.Columns.Count - 1
                    hoja.Cells(fila + 2, col + 1) = dt.Rows(fila)(col).ToString()
                Next
            Next

            hoja.Columns.AutoFit()
            libro.SaveAs(rutaDestino)
            MessageBox.Show("Datos exportados correctamente a: " & rutaDestino,
                         "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            libro?.Close()
            excelApp?.Quit()

            If hoja IsNot Nothing Then ReleaseObject(hoja)
            If libro IsNot Nothing Then ReleaseObject(libro)
            If excelApp IsNot Nothing Then ReleaseObject(excelApp)

        End Try

    End Sub
    Private Sub ReleaseObject(obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        Catch
        Finally
            obj = Nothing
        End Try
    End Sub
    Private Function ValidarMail(ByVal direccion As String) As Boolean
        Try
            ' se intenta crear una dirección de correo válida
            Dim Prueba As New System.Net.Mail.MailAddress(direccion)
            Return True ' si llega hasta aquí, la dirección es válida
        Catch ex As FormatException
            Return False ' si salta al error, la dirección no es válida
        End Try
    End Function

    Private Sub BtnCorreo_Click(sender As Object, e As EventArgs) Handles BtnCorreo.Click

        TxtCorreo.Enabled = True
        TxtCorreo.Visible = True
        TxtCorreo.Focus()
        BtnOk.Enabled = True
        BtnOk.Visible = True
        BtnCancelar.Enabled = True
        BtnCancelar.Visible = True
        BtnPDF.Enabled = False
        BtnPDF.Visible = False
        BtnExcel.Enabled = False
        BtnExcel.Visible = False
        BtnCorreo.Enabled = False
        BtnCorreo.Visible = False
        DgvListadoVentas.Enabled = False
        DgvListadoVentas.Visible = False

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            If ValidarMail(TxtCorreo.Text) = False Then
                Throw New Exception("La dirección del receptor no tiene un formato válido (ejemplo @gmail.com).")
            End If

            correo = New MailMessage()
            correo.From = New MailAddress("nietonazareno9@gmail.com")
            correo.To.Add(TxtCorreo.Text)

            clienteSmtp.Credentials = New System.Net.NetworkCredential("nietonazareno9@gmail.com", "tu_contraseña")
            clienteSmtp.EnableSsl = True
            clienteSmtp.Send(correo)

            clienteSmtp.Port = 587
            clienteSmtp.Send(correo)
            clienteSmtp.EnableSsl = True

            MessageBox.Show("Correo enviado correctamente.", "Envío de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        MessageBox.Show("Se canceló el envío del correo.", "Envío de correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnOk.Enabled = False
        BtnOk.Visible = False
        BtnCancelar.Enabled = False
        BtnCancelar.Visible = False
        TxtCorreo.Enabled = False
        TxtCorreo.Visible = False
        DgvListadoVentas.Enabled = True
        DgvListadoVentas.Visible = True
        BtnCorreo.Enabled = True
        BtnCorreo.Visible = True
        BtnExcel.Enabled = True
        BtnExcel.Visible = True
        BtnPDF.Enabled = True
        BtnPDF.Visible = True

    End Sub
End Class