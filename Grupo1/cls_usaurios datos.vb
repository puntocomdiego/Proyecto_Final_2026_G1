
Imports System.Data.OleDb
Public Class cls_usaurios_datos


    Private Shared ReadOnly ruta As String =
    IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\LEVEL_UP.accdb")
    Private Shared ReadOnly cadenaConexion As String =
        $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"


    Public Function Agregar(p As usuarios) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "INSERT INTO usuarios (usuario, contrasena, nombre, apellido, tipo, fecha_creacion) VALUES (?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", p.usuario)
                cmd.Parameters.AddWithValue("?", p.contrasena)
                cmd.Parameters.AddWithValue("?", p.nombre)
                cmd.Parameters.AddWithValue("?", p.apellido)
                cmd.Parameters.AddWithValue("?", p.tipo)
                cmd.Parameters.AddWithValue("?", p.fecha_creacion)
                cmd.Parameters.AddWithValue("?", p.Foto)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Modificar(p As usuarios) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "UPDATE usuarios SET usuario = ?, contrasena = ?, nombre = ?, apellido = ?, tipo = ?, fecha_creacion = ? WHERE id = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", p.usuario)
                cmd.Parameters.AddWithValue("?", p.contrasena)
                cmd.Parameters.AddWithValue("?", p.nombre)
                cmd.Parameters.AddWithValue("?", p.apellido)
                cmd.Parameters.AddWithValue("?", p.tipo)
                cmd.Parameters.AddWithValue("?", p.fecha_creacion)
                cmd.Parameters.AddWithValue("?", p.Foto)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Eliminar(id As Integer) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "DELETE FROM usuarios WHERE id = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", id)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function Listar() As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "SELECT id, usuario, contrasena, nombre, apellido, tipo, fecha_creacion FROM usuarios ORDER BY usuario"
            Using da As New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function Buscar(texto As String) As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "SELECT id, usuario, contrasena, nombre, apellido, tipo, fecha_creacion FROM usuarios " &
                    "WHERE usuario LIKE ? ORDER BY usuario"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", "%" & texto & "%")
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

























End Class
