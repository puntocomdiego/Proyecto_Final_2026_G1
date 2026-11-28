'Imports System.IO
'Imports com
'Imports DocumentFormat.OpenXml.Wordprocessing
'Imports iTextSharp.text
'Imports iTextSharp.text.pdf

Imports System.IO
Imports iText = iTextSharp.text
Imports iTextPdf = iTextSharp.text.pdf

Public Class cls_Productos_Datos_2
    Public Sub ExportarDatosPDF(dgvJuegos As DataGridView, ruta As String)

        ' Hoja A4 horizontal para que entren más columnas
        Dim doc As New iText.Document(iText.PageSize.A4.Rotate(), 20, 20, 30, 30)

        Using fs As New FileStream(ruta, FileMode.Create)
            iTextPdf.PdfWriter.GetInstance(doc, fs)
            doc.Open()

            Dim fuenteTitulo = iText.FontFactory.GetFont("Arial", 16, iText.Font.BOLD)
            Dim fuenteHeader = iText.FontFactory.GetFont("Arial", 10, iText.Font.BOLD)
            Dim fuenteCelda = iText.FontFactory.GetFont("Arial", 9, iText.Font.NORMAL)

            ' Título
            Dim titulo As New iText.Paragraph("Listado de Juegos", fuenteTitulo)
            titulo.Alignment = iText.Element.ALIGN_CENTER
            titulo.SpacingAfter = 15
            doc.Add(titulo)

            ' Columnas visibles
            Dim columnas = dgvJuegos.Columns.Cast(Of DataGridViewColumn)().Where(Function(c) c.Visible).ToList()

            Dim tabla As New iTextPdf.PdfPTable(columnas.Count)
            tabla.WidthPercentage = 100

            ' Encabezados
            For Each col In columnas
                Dim celda As New iTextPdf.PdfPCell(New iText.Phrase(col.HeaderText, fuenteHeader))
                celda.BackgroundColor = iText.BaseColor.LIGHT_GRAY
                celda.HorizontalAlignment = iText.Element.ALIGN_CENTER
                celda.Padding = 5
                tabla.AddCell(celda)
            Next

            ' Datos
            For Each fila As DataGridViewRow In dgvJuegos.Rows
                If fila.IsNewRow Then Continue For
                For Each col In columnas
                    Dim valor As String = If(fila.Cells(col.Index).Value, "").ToString()
                    Dim celda As New iTextPdf.PdfPCell(New iText.Phrase(valor, fuenteCelda))
                    celda.Padding = 4
                    tabla.AddCell(celda)
                Next
            Next

            doc.Add(tabla)
            doc.Close()
        End Using

    End Sub

End Class
