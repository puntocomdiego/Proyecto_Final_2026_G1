
Imports System.Data.OleDb
Public Class CLS_CATEGORIAS
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Id As string
    Private Function obtenerconexion() As OleDbConnection
        Return Conexion.ObtenerConexion()
    End Function
    Friend Function obtenercategorias() As DataTable
        Dim dt As New DataTable
        Dim con As OleDbConnection = obtenerconexion()
        Dim cmd As New OleDbCommand("SELECT * FROM CATEGORIAS", con)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
    Public Function guardar() As Boolean
        Dim con As OleDbConnection = obtenerconexion()
        Dim cmd As New OleDbCommand("INSERT INTO CATEGORIAS (nombre, descripcion) VALUES (@nombre, @descripcion)", con)
        cmd.Parameters.AddWithValue("@nombre", Nombre)
        cmd.Parameters.AddWithValue("@descripcion", Descripcion)
        con.Open()
        Dim result As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return result > 0
    End Function
    Public Function eliminar() As Boolean
        Dim con As OleDbConnection = obtenerconexion()
        Dim cmd As New OleDbCommand("DELETE FROM CATEGORIAS WHERE id = @id", con)
        cmd.Parameters.AddWithValue("@id", Id)
        con.Open()
        Dim result As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return result > 0
    End Function
    Public Function limpiar() As Boolean
        Nombre = String.Empty
        Descripcion = String.Empty
        Id = 0
        Return True
    End Function




End Class

