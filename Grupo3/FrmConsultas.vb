Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmConsultas
    Dim correo As MailMessage
    Dim WithEvents clienteSmtp As New SmtpClient("smtp.gmail.com")
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
    Dim dtventas As New DataTable


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
        Try

            TxtCorreo.Visible = True
            TxtCorreo.Focus()
            BtnEnviar.Visible = True
            BtnCancelar.Visible = True
            BtnPDF.Visible = False
            BtnExcel.Visible = False
            BtnCorreo.Visible = False
            DgvListadoVentas.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error al enviar el correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
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
        Try

            BtnEnviar.Visible = False
            BtnCancelar.Visible = False
            TxtCorreo.Visible = False
            DgvListadoVentas.Visible = True
            BtnCorreo.Visible = True
            BtnExcel.Visible = True
            BtnPDF.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error al cancelar el envío del correo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQL As String = ""
        SQL = "SELECT ventas.id, ventas.fecha, ventas.id_usuario, ventas.total From ventas;"


        Dim da As New OleDbDataAdapter(SQL, cn)
        da.Fill(dtventas)

        DgvListadoVentas.DataSource = dtventas
        DgvListadoVentas.Columns(0).HeaderText = "ID"
        DgvListadoVentas.Columns(1).HeaderText = "Fecha"
        DgvListadoVentas.Columns(2).HeaderText = "ID Usuario"
        DgvListadoVentas.Columns(3).HeaderText = "Total"

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        MsgBox("¿Desea cerrar la ventana consultas?", MessageBoxButtons.YesNo)
        Me.Close()
    End Sub

    Private Sub BtnOk_Click_1(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            ' se busca entre la fecha inicial y la fecha final
            Dim fechainicial As Date = DtpInicial.Value.Date
            Dim fechafinal As Date = DtpFinal.Value.Date

            ' se crea la consulta SQL con parámetros para evitar inyecciones SQL
            Dim SQL As String = "SELECT ventas.id, ventas.fecha, ventas.id_usuario, ventas.total From ventas WHERE fecha BETWEEN ? AND ?;"

            Dim cmd As New OleDbCommand(SQL, cn) ' se crea el comando con la consulta y la conexión

            cmd.Parameters.AddWithValue("?", OleDbType.Date).Value = fechainicial.Date ' se agregan los parámetros a la consulta

            cmd.Parameters.AddWithValue("?", OleDbType.Date).Value = fechafinal.Date.AddDays(1) ' se agregan los parámetros a la consulta

            cmd.Connection.Open() ' se abre la conexión

            Dim da As New OleDbDataAdapter(cmd) ' se crea el adaptador de datos con el comando

            ' se llena el DataTable con los datos obtenidos de la consulta
            dtventas.Clear() ' se limpia el DataTable antes de llenarlo

            da.Fill(dtventas) ' se llena el DataTable con los datos obtenidos de la consulta


            DgvListadoVentas.DataSource = dtventas
            DgvListadoVentas.Columns(0).HeaderText = "ID"
            DgvListadoVentas.Columns(1).HeaderText = "Fecha"
            DgvListadoVentas.Columns(2).HeaderText = "ID Usuario"
            DgvListadoVentas.Columns(3).HeaderText = "Total"

            cmd.Connection.Close() ' se cierra la conexión 

            ' agrega al combo box los vendedores únicos de la tabla usuarios que tengan ventas en el rango de fechas seleccionado
            Dim SQLVendedores As String = "SELECT DISTINCT usuarios.nombre FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario WHERE ventas.fecha BETWEEN ? AND ?;" ' se crea la consulta SQL para obtener los vendedores únicos

            Dim cmdVendedores As New OleDbCommand(SQLVendedores, cn) ' se crea el comando con la consulta y la conexión

            cmdVendedores.Parameters.AddWithValue("?", OleDbType.Date).Value = fechainicial.Date ' se agregan los parámetros a la consulta

            cmdVendedores.Parameters.AddWithValue("?", OleDbType.Date).Value = fechafinal.Date.AddDays(1) ' se agregan los parámetros a la consulta

            Dim daVendedores As New OleDbDataAdapter(cmdVendedores) ' se crea el adaptador de datos con el comando

            Dim dtVendedores As New DataTable() ' se crea un DataTable para almacenar los vendedores únicos

            daVendedores.Fill(dtVendedores) ' se llena el DataTable con los datos obtenidos de la consulta

            CmbVendedor.DataSource = dtVendedores ' se asigna el DataTable como fuente de datos del ComboBox

            CmbVendedor.DisplayMember = "nombre" ' se asigna el nombre de la columna que se mostrará en el ComboBox



            If CmbVendedor.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un vendedor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If fechainicial < "03/05/2026" Then
                MessageBox.Show("No hay ventas registradas antes del 03/05/2026.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al filtrar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class