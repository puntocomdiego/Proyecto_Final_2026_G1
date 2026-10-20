
Imports System.Data.OleDb
Imports Proyecto_Final_2026_G1.clase_usuario
Public Class cls_usuarios_datos



    Private Shared ReadOnly ruta As String =
        IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"

    'funcion agregar
    Public Function Agregar(u As clase_usuario) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "INSERT INTO usuarios (nombre, apellido, usuario, contrasena, fecha_creacion, foto) VALUES (?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", u.Nombre)
                cmd.Parameters.AddWithValue("?", u.Apellido)
                cmd.Parameters.AddWithValue("?", u.NombreUsuario)
                cmd.Parameters.AddWithValue("?", u.Contrasena)
                cmd.Parameters.AddWithValue("?", u.FechaCreacion)
                cmd.Parameters.AddWithValue("?", u.Foto)

                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    'funcion modificar
    Public Function Modificar(u As clase_usuario) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "UPDATE usuarios SET nombre = ?, apellido = ?, usuario = ?, contrasena = ?, foto = ? WHERE id = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", u.Nombre)
                cmd.Parameters.AddWithValue("?", u.Apellido)
                cmd.Parameters.AddWithValue("?", u.NombreUsuario)
                cmd.Parameters.AddWithValue("?", u.Contrasena)
                cmd.Parameters.AddWithValue("?", u.Foto)
                cmd.Parameters.AddWithValue("?", u.Id)
                cmd.Parameters.AddWithValue("?", u.Foto)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    'funcion eliminar
    Public Function Eliminar(codigo As Integer) As Boolean
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String = "DELETE FROM usuarios WHERE id = ?"
            Using cmd As New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("?", codigo)
                cn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    'funcion listar
    Public Function Listar() As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "SELECT id, nombre, apellido, usuario, contrasena, fecha_creacion, foto FROM usuarios ORDER BY nombre"
            Using da As New OleDbDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    'funcion buscar
    Public Function Buscar(texto As String) As DataTable
        Dim dt As New DataTable()
        Using cn As New OleDbConnection(cadenaConexion)
            Dim sql As String =
                "SELECT id, nombre, apellido, usuario, contrasena, fecha_creacion, foto FROM usuarios " &
                "WHERE nombre LIKE ? ORDER BY nombre"
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
