Imports System.Data.OleDb

Public Class cls_Productos_Datos
    Private Shared ReadOnly ruta As String =
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
    Public Function ListarJuegos() As DataTable

    End Function

    Public Function AgregarJuego(p As CLS_PRODUCTOS) As Boolean
        'Using cn As New OleDbConnection(cadenaConexion)
        '    Dim sql As String =
        '    "INSERT INTO Productos (descripcion, precio, foto) VALUES (?, ?, ?)"
        '    Using cmd As New OleDbCommand(sql, cn)
        '        cmd.Parameters.AddWithValue("?", p.Descripcion)
        '        cmd.Parameters.AddWithValue("?", p.Precio)
        '        cmd.Parameters.AddWithValue("?", p.Foto)
        '        cn.Open()
        '        Return cmd.ExecuteNonQuery() > 0
        '    End Using
        'End Using
    End Function

    Public Function ActualizarJuego(juego As CLS_PRODUCTOS) As Boolean

    End Function

    Public Function EliminarJuego(id As Integer) As Boolean

    End Function

    Public Function ObtenerJuegoPorId(id As Integer) As CLS_PRODUCTOS

    End Function

    ' ---------- CATEGORÍAS ----------

    Public Function ListarCategorias() As DataTable

    End Function

    ' Una sola función (antes estaba duplicada)
    Public Function ObtenerNombreCategoriaPorId(id As Integer) As String

    End Function

    Public Function ObtenerIdCategoriaPorNombre(nombre As String) As Integer

    End Function



End Class
