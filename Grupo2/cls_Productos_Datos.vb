Imports System.Data.OleDb

Public Class cls_Productos_Datos
    Private Shared ReadOnly ruta As String =
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
    Public Function ListarJuegos() As DataTable

    End Function

    Public Function AgregarJuego(p As CLS_PRODUCTOS) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
            "INSERT INTO Productos (descripcion, precio, foto) VALUES (?, ?, ?)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", p.Nombre)
                cmd.Parameters.AddWithValue("?", p.Precio)
                cmd.Parameters.AddWithValue("?", p.Stock)
                cmd.Parameters.AddWithValue("?", p.IdCategoria)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ActualizarJuego(p As CLS_PRODUCTOS) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
            "UPDATE Productos SET descripcion = ?, precio = ?, foto = ? WHERE codigo = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", p.Nombre)
                cmd.Parameters.AddWithValue("?", p.Precio)
                cmd.Parameters.AddWithValue("?", p.Stock)
                cmd.Parameters.AddWithValue("?", p.Id)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function EliminarJuego(codigo As Integer) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "DELETE FROM Productos WHERE codigo = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", codigo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    'Public Function ObtenerJuegoPorId(id As Integer) As CLS_PRODUCTOS

    'End Function

    '' ---------- CATEGORÍAS ----------

    'Public Function ListarCategorias() As DataTable

    'End Function

    '' Una sola función (antes estaba duplicada)
    'Public Function ObtenerNombreCategoriaPorId(id As Integer) As String

    'End Function

    'Public Function ObtenerIdCategoriaPorNombre(nombre As String) As Integer

    'End Function



End Class
