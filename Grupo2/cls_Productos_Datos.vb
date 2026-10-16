Public Class cls_Productos_Datos
    Public Function ListarJuegos() As DataTable

    End Function

    'Public Function AgregarJuego(p As Producto) As Boolean
    '    Using cn As New OleDbConnection(cadenaConexion)
    '        Dim sql As String =
    '        "INSERT INTO Productos (descripcion, precio, foto) VALUES (?, ?, ?)"
    '        Using cmd As New OleDbCommand(sql, cn)
    '            cmd.Parameters.AddWithValue("?", p.Descripcion)
    '            cmd.Parameters.AddWithValue("?", p.Precio)
    '            cmd.Parameters.AddWithValue("?", p.Foto)
    '            cn.Open()
    '            Return cmd.ExecuteNonQuery() > 0
    '        End Using
    '    End Using
    'End Function

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

    Public Class Producto

        ' ===== Propiedades =====
        Public Property Codigo As Integer
        Public Property Descripcion As String
        Public Property Precio As Decimal
        Public Property Foto As String
        ' Cadena de conexión, compartida por toda la clase.
        ' Uso AppDomain para que la clase NO dependa del formulario.
        Private Shared ReadOnly ruta As String =
            IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Productos.accdb")
        Private Shared ReadOnly cadenaConexion As String =
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
        ' ===== Constructores =====
        Public Sub New()
            ' Constructor vacío: crear el objeto y cargar sus datos después.
        End Sub
        Public Sub New(descripcion As String, precio As Decimal, foto As String)
            Me.Descripcion = descripcion
            Me.Precio = precio
            Me.Foto = foto
        End Sub




    End Class


End Class
