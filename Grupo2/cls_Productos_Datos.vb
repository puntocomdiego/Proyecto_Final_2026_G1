Imports System.Data.OleDb

Public Class cls_Productos_Datos
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
            Dim sql As String =
            "UPDATE Juegos SET nombre = ?, id_Categoria = ?, precio = ?, fecha_Ingreso = ? WHERE portada = ?"
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

    '' ---------- CATEGORÍAS ----------

    'Public Function ListarCategorias() As DataTable

    'End Function

    '' Una sola función (antes estaba duplicada)
    'Public Function ObtenerNombreCategoriaPorId(id As Integer) As String

    'End Function

    'Public Function ObtenerIdCategoriaPorNombre(nombre As String) As Integer

    'End Function



End Class
