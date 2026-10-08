
Imports System.Data.OleDb
Public Class CLS_CATEGORIAS
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Id As Integer
    Private Function obtenerconexion() As OleDbConnection
        Return Conexion.ObtenerConexion()
    End Function


    Public Sub New()
        ' Constructor vacío: crear el objeto y cargar sus datos después. 
    End Sub

    Public Sub New(descripcion As String, nombre As String)
        Me.Descripcion = descripcion
        Me.Nombre = nombre

    End Sub


End Class

