Imports System.Data.OleDb

Public Class clase_usuario

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property NombreUsuario As String
    Public Property Contrasena As String
    Public Property FechaCreacion As Date
    Public Property Foto As String


    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellido As String, nombreUsuario As String,
                   contrasena As String, fechaCreacion As Date)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.NombreUsuario = nombreUsuario
        Me.Contrasena = contrasena
        Me.FechaCreacion = fechaCreacion
        Me.Foto = Foto
    End Sub

End Class
