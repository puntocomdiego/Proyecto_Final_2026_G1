Imports System.Data.OleDb
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports iTextSharp.text
Imports iTextSharp.text.Actions
Imports iTextSharp.text.pdf
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FrmConsultas
    Dim correo As MailMessage
    Dim WithEvents clienteSmtp As New SmtpClient("smtp.gmail.com")
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
    Dim dtventas As New DataTable
    Dim opcion As Byte = 0


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
        Dim excelApp As Excel.Application = Nothing ' Variable para la aplicación de Excel
        Dim libro As Excel.Workbook = Nothing ' Variable para el libro de Excel
        Dim hoja As Excel.Worksheet = Nothing  ' Variable para la hoja de Excel

        Try
            excelApp = New Excel.Application ' Se crea una nueva instancia de la aplicación de Excel
            libro = excelApp.Workbooks.Add()  ' Se agrega un nuevo libro de Excel
            hoja = CType(libro.Worksheets(1), Excel.Worksheet) ' Se obtiene la primera hoja del libro

            For col As Integer = 0 To dt.Columns.Count - 1  ' Se recorre cada columna del DataTable
                hoja.Cells(1, col + 1) = dt.Columns(col).ColumnName ' Se asigna el nombre de la columna a la primera fila de la hoja de Excel
            Next

            For fila As Integer = 0 To dt.Rows.Count - 1 ' Se recorre cada fila del DataTable
                For col As Integer = 0 To dt.Columns.Count - 1 ' Se recorre cada columna del DataTable
                    hoja.Cells(fila + 2, col + 1) = dt.Rows(fila)(col).ToString() ' Se asigna el valor de la celda correspondiente en la hoja de Excel
                Next
            Next

            hoja.Columns.AutoFit() ' Se ajusta automáticamente el ancho de las columnas para que se adapten al contenido
            libro.SaveAs(rutaDestino) ' Se guarda el libro de Excel en la ruta especificada
            MessageBox.Show("Datos exportados correctamente a: " & rutaDestino,
                         "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Se muestra un mensaje indicando que la exportación fue exitosa






        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            libro?.Close() ' Se cierra el libro de Excel si no es Nothing
            excelApp?.Quit() ' Se cierra la aplicación de Excel si no es Nothing

            If hoja IsNot Nothing Then ReleaseObject(hoja) ' Se libera la hoja de Excel si no es Nothing
            If libro IsNot Nothing Then ReleaseObject(libro) ' Se libera el libro de Excel si no es Nothing
            If excelApp IsNot Nothing Then ReleaseObject(excelApp) ' Se libera la aplicación de Excel si no es Nothing

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
        ' SQL = "SELECT ventas.id, ventas.fecha, ventas.id_usuario, ventas.total From ventas;"
        SQL = "Select  ventas.id, ventas.fecha, ventas.total, usuarios.usuario From usuarios INNER Join ventas On usuarios.id = ventas.id_usuario;"


        Dim da As New OleDbDataAdapter(SQL, cn)
        da.Fill(dtventas)

        DgvListadoVentas.DataSource = dtventas
        DgvListadoVentas.Columns(0).HeaderText = "ID"
        DgvListadoVentas.Columns(1).HeaderText = "Fecha"
        DgvListadoVentas.Columns(3).HeaderText = "ID Usuario"
        DgvListadoVentas.Columns(2).HeaderText = "Total"

        ' agrega al combo box los vendedores únicos de la tabla usuarios que tengan ventas
        Dim SQLVendedores As String = "SELECT DISTINCT usuarios.usuario FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario;" ' se crea la consulta SQL para obtener los vendedores únicos

        Dim cmdVendedores As New OleDbCommand(SQLVendedores, cn) ' se crea el comando con la consulta y la conexión

        Dim daVendedores As New OleDbDataAdapter(cmdVendedores) ' se crea el adaptador de datos con el comando

        Dim dtVendedores As New DataTable() ' se crea un DataTable para almacenar los vendedores únicos

        daVendedores.Fill(dtVendedores) ' se llena el DataTable con los datos obtenidos de la consulta

        CmbVendedor.DataSource = dtVendedores ' se asigna el DataTable como fuente de datos del ComboBox

        ' se asigna el nombre de la columna que se mostrará en el ComboBox
        CmbVendedor.DisplayMember = "usuario"


    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        MsgBox("¿Desea cerrar la ventana consultas?", MessageBoxButtons.YesNo)
        Me.Close()
    End Sub

    Private Sub BtnOk_Click_1(sender As Object, e As EventArgs) Handles BtnOk.Click

        Dim SQL As String


        Try
            ' se busca entre la fecha inicial y la fecha final
            Dim fechainicial As Date = DtpInicial.Value.Date
            Dim fechafinal As Date = DtpFinal.Value.Date
            Dim vendedor As String = CmbVendedor.SelectedItem.ToString() ' obtiene el vendedor seleccionado del ComboBox
            Dim usuario As String = DgvListadoVentas.Columns(3).HeaderText = "ID Usuario"
            vendedor = usuario




            Select Case opcion

                Case 1
                    ' se crea la consulta SQL con parámetros para evitar inyecciones SQL
                    SQL = "SELECT ventas.id, ventas.fecha, ventas.total, ventas.id_usuario " &
                    "FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario " &
                    "WHERE ventas.fecha >= #" & fechainicial.ToString("MM/dd/yyyy") & "# " &
                    "AND ventas.fecha <= #" & fechafinal.ToString("MM/dd/yyyy") & "#;"


                Case 2
                    ' se crea la consulta SQL con parámetros para evitar inyecciones SQL
                    SQL = "SELECT ventas.id, ventas.fecha, ventas.total, ventas.id_usuario " &
                    "FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario " &
                    "WHERE  #" & vendedor & "#;"

                Case 3
                    ' se crea la consulta SQL con parámetros para evitar inyecciones SQL
                    SQL = "SELECT ventas.id, ventas.fecha, ventas.total, ventas.id_usuario " &
                    "FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario " &
                    "WHERE ventas.fecha >= #" & fechainicial.ToString("MM/dd/yyyy") & "# " &
                    "AND ventas.fecha <= #" & fechafinal.ToString("MM/dd/yyyy") & "#;"




            End Select



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

            ''agrega al combo box los vendedores únicos de la tabla usuarios que tengan ventas en el rango de fechas seleccionado
            'Dim SQLVendedores As String = "SELECT DISTINCT usuarios.usuario FROM usuarios INNER JOIN ventas ON usuarios.id = ventas.id_usuario WHERE ventas.fecha BETWEEN ? AND ?;" ' se crea la consulta SQL para obtener los vendedores únicos

            'Dim cmdVendedores As New OleDbCommand(SQLVendedores, cn) ' se crea el comando con la consulta y la conexión

            'cmdVendedores.Parameters.AddWithValue("?", OleDbType.Date).Value = fechainicial.Date ' se agregan los parámetros a la consulta

            'cmdVendedores.Parameters.AddWithValue("?", OleDbType.Date).Value = fechafinal.Date.AddDays(1) ' se agregan los parámetros a la consulta

            'Dim daVendedores As New OleDbDataAdapter(cmdVendedores) ' se crea el adaptador de datos con el comando

            'Dim dtVendedores As New DataTable() ' se crea un DataTable para almacenar los vendedores únicos

            'daVendedores.Fill(dtVendedores) ' se llena el DataTable con los datos obtenidos de la consulta

            'CmbVendedor.DataSource = dtVendedores ' se asigna el DataTable como fuente de datos del ComboBox

            'CmbVendedor.DisplayMember = "nombre" ' se asigna el nombre de la columna que se mostrará en el ComboBox

            '' se relaciona el ComboBox con el DataTable para que muestre los vendedores únicos en el rango de fechas seleccionado



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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        opcion = 3
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        opcion = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        opcion = 2
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        ' Exporta los datos del DataGridView a un archivo Excel 
        Dim rutaDestino As String = "S:\pf\bin\Debug\net8.0-windows" ' Ruta de destino del archivo Excel




    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles BtnPDF.Click

    End Sub

    Private Sub CmbVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbVendedor.SelectedIndexChanged

    End Sub
End Class