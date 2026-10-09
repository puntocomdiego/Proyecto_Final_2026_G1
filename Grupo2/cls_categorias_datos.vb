Imports System.Data.OleDb


Public Class cls_categorias_datos
    Private Shared ReadOnly ruta As String =
       IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String =
        $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
    Private dgvcategorias As Object

    Friend Function obtenercategorias() As DataTable
        Dim dt As New DataTable
        Dim con As OleDbConnection = ObtenerConexion()
        Dim cmd As New OleDbCommand("SELECT * FROM CATEGORIAS", con)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function guardar(p As CLS_CATEGORIAS) As Boolean

        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "INSERT INTO categorias  (nombre, descripcion) VALUES (?, ?)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", p.Nombre)
                cmd.Parameters.AddWithValue("?", p.Descripcion)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using


    End Function

    Public Function Eliminar(codigo As Integer) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "DELETE FROM categorias WHERE codigo = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", codigo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Function Listar() As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "SELECT codigo, nombre, descripcion FROM categorias ORDER BY nombre"
            Using da As New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Class
