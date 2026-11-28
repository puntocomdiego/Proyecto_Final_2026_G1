Imports System.Data.OleDb
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ClosedXML.Excel

'Imports iTextSharp.text
'Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop

Public Class cls_Productos_Datos
    Private idJuegoSeleccionado As Integer = 0
    Private rutaImagenOrigen As String = ""
    Private frm_Juegos As frm_Juegos
    Private objCat As New cls_categorias_datos()


    Private Shared ReadOnly ruta As String =
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
    Public Property Portada As String

    Public Function ListarJuegos() As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
            "SELECT id, nombre, id_Categoria, precio, stock, fecha_ingreso, portada FROM juegos ORDER BY nombre"
            Using da As New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function AgregarJuego(p As CLS_PRODUCTOS) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
            "INSERT INTO juegos (nombre, id_Categoria, precio, stock, fecha_Ingreso, portada) VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(sql, cn)

                'cmd.Parameters.AddWithValue("?", p.Id)
                cmd.Parameters.AddWithValue("?", p.Nombre)
                cmd.Parameters.AddWithValue("?", p.IdCategoria)
                cmd.Parameters.AddWithValue("?", p.Precio)
                cmd.Parameters.AddWithValue("?", p.Stock)
                cmd.Parameters.AddWithValue("?", p.FechaIngreso)
                cmd.Parameters.AddWithValue("?", p.Portada)

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarJuego(p As CLS_PRODUCTOS) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "UPDATE Juegos SET nombre = ?, id_categoria = ?, precio = ?, stock = ?, fecha_Ingreso = ?, portada = ? WHERE id = ?"
            Try




                Using cmd As New OleDbCommand(sql, cn)

                    cmd.Parameters.AddWithValue("?", p.Nombre)
                    cmd.Parameters.AddWithValue("?", p.IdCategoria)
                    cmd.Parameters.AddWithValue("?", p.Precio)
                    cmd.Parameters.AddWithValue("?", p.Stock)
                    cmd.Parameters.AddWithValue("?", p.FechaIngreso)
                    cmd.Parameters.AddWithValue("?", p.Portada)
                    cmd.Parameters.AddWithValue("?", p.Id)
                    cn.Open()
                    Return cmd.ExecuteNonQuery() > 0
                End Using

            Catch ex As Exception
                MsgBox("Error al actualizar el juego: " & ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try


        End Using
    End Function

    Public Function EliminarJuego(codigo As Integer) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "DELETE * FROM juegos WHERE id = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", codigo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ObtenerJuegoPorId(id As Integer) As CLS_PRODUCTOS
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "SELECT * FROM Productos WHERE codigo = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", id)
                cn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return New CLS_PRODUCTOS With {
                            .Id = Convert.ToInt32(reader("codigo")),
                            .Nombre = reader("descripcion").ToString(),
                            .Precio = Convert.ToDouble(reader("precio")),
                            .Stock = Convert.ToInt32(reader("stock"))}
                        '.IdCategoria = Convert.ToInt32(reader("id_categoria"))

                    Else
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

    End Function

    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub LimpiarFormulario()

        idJuegoSeleccionado = 0
        frm_Juegos.txtNombre.Clear()
        frm_Juegos.txtPrecio.Clear()
        frm_Juegos.txtStock.Clear()
        frm_Juegos.cmbCategoria.SelectedIndex = -1
        frm_Juegos.dtpFechaIngreso.Value = DateTime.Now
        frm_Juegos.picPortada.Image = Nothing
        rutaImagenOrigen = ""
        frm_Juegos.lblID.Text = "0"
    End Sub

    Public Sub ExportarAExcel(dt As DataTable, rutaDestino As String)

        Try
            Using wb As New XLWorkbook()
                wb.Worksheets.Add(dt, "Juegos")
                wb.SaveAs(rutaDestino)
            End Using
            MessageBox.Show("Datos exportados a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Public Sub FiltrarJuegos(criterio As String)
        Dim dt As DataTable = ListarJuegos()
        If Not String.IsNullOrWhiteSpace(criterio) Then
            Dim filtro As String = $"nombre LIKE '%{criterio}%'"
            Dim dv As New DataView(dt)
            dv.RowFilter = filtro
            frm_Juegos.dgvJuegos.DataSource = dv.ToTable()
        Else
            frm_Juegos.dgvJuegos.DataSource = dt
        End If
    End Sub

    ' Llena el ComboBox llamando a la clase del formulario de mi amigo
    Public Sub CargarCategoriasCombo()
        Dim dt As DataTable = objCat.obtenercategorias()
        frm_Juegos.cmbCategoria.DataSource = dt
        frm_Juegos.cmbCategoria.DisplayMember = "nombre"
        frm_Juegos.cmbCategoria.ValueMember = "id"
        frm_Juegos.cmbCategoria.SelectedIndex = -1
    End Sub

    Public Sub CargarGridJuegos()
        frm_Juegos.dgvJuegos.DataSource = ListarJuegos()

        If frm_Juegos.dgvJuegos.Columns.Contains("id_categoria") Then
            frm_Juegos.dgvJuegos.Columns("id_categoria").Visible = False
        End If
    End Sub

    '' ---------- CATEGORÍAS ----------

    'Public Function ListarCategorias() As DataTable

    'End Function

    '' Una sola función (antes estaba duplicada)
    'Public Function ObtenerNombreCategoriaPorId(id As Integer) As String

    'End Function

    'Public Function ObtenerIdCategoriaPorNombre(nombre As String) As Integer

    'End Function



End Class
