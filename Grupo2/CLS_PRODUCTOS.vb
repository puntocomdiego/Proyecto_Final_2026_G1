
Imports System.Data

Imports System.Data.OleDb

    Public Class CLS_PRODUCTOS
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property IdCategoria As Integer
        Public Property Precio As Double
        Public Property Stock As Integer
        Public Property FechaIngreso As Date
        Public Property Portada As String


    ' Obtenemos la conexión desde el módulo común del proyecto
    Private Function ObtenerConexion() As OleDbConnection

        Return Conexion.ObtenerConexion()
    End Function

    Public Function ListarJuegosPorCategoria(idCategoria As Integer) As DataTable
        Dim dt As New DataTable()
        Using conn As OleDbConnection = ObtenerConexion()
            Dim query As String = "SELECT j.id, j.nombre, c.nombre AS Categoria, j.precio, j.stock, j.fecha_ingreso, j.portada, j.id_categoria " &
                                     "FROM juegos j INNER JOIN categorias c ON j.id_categoria = c.id " &
                                     "WHERE j.id_categoria = ? " &
                                     "ORDER BY j.id DESC"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_categoria", idCategoria)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    ' Carga todos los juegos relacionándolos con el nombre de su categoría
    Public Function ListarJuegos() As DataTable
            Dim dt As New DataTable()
            Using conn As OleDbConnection = ObtenerConexion()
                Dim query As String = "SELECT j.id, j.nombre, c.nombre AS Categoria, j.precio, j.stock, j.fecha_ingreso, j.portada, j.id_categoria " &
                                     "FROM juegos j INNER JOIN categorias c ON j.id_categoria = c.id " &
                                     "ORDER BY j.id DESC"
                Dim cmd As New OleDbCommand(query, conn)
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End Using
            Return dt
        End Function

        ' Guarda un nuevo juego en la base de datos
        Public Function Guardar() As Boolean
            Using conn As OleDbConnection = ObtenerConexion()
                Dim query As String = "INSERT INTO juegos (nombre, id_categoria, precio, stock, fecha_ingreso, portada) " &
                                     "VALUES (?, ?, ?, ?, ?, ?)"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", Nombre)
                cmd.Parameters.AddWithValue("@id_categoria", IdCategoria)
                cmd.Parameters.AddWithValue("@precio", Precio)
                cmd.Parameters.AddWithValue("@stock", Stock)
                cmd.Parameters.AddWithValue("@fecha_ingreso", FechaIngreso.ToShortDateString())
                cmd.Parameters.AddWithValue("@portada", If(String.IsNullOrEmpty(Portada), DBNull.Value, Portada))
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Function

        ' Modifica los datos de un juego existente
        Public Function Modificar() As Boolean
            Using conn As OleDbConnection = ObtenerConexion()
                Dim query As String = "UPDATE juegos SET nombre = ?, id_categoria = ?, precio = ?, stock = ?, " &
                                     "fecha_ingreso = ?, portada = ? WHERE id = ?"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", Nombre)
                cmd.Parameters.AddWithValue("@id_categoria", IdCategoria)
                cmd.Parameters.AddWithValue("@precio", Precio)
                cmd.Parameters.AddWithValue("@stock", Stock)
                cmd.Parameters.AddWithValue("@fecha_ingreso", FechaIngreso.ToShortDateString())
                cmd.Parameters.AddWithValue("@portada", If(String.IsNullOrEmpty(Portada), DBNull.Value, Portada))
                cmd.Parameters.AddWithValue("@id", Id)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Function

        ' Elimina un juego por su ID
        Public Function Eliminar(idJuego As Integer) As Boolean
            Using conn As OleDbConnection = ObtenerConexion()
                Dim query As String = "DELETE FROM juegos WHERE id = ?"
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idJuego)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Function
    End Class

