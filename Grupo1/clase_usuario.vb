Imports System.Data.OleDb

Public Class clase_usuario

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property usuario As String
    Public Property Contrasena As String
    Public Property FechaCreacion As Date
    Public Property Foto As String
    Public Property tipo As String



    Public Sub New(nombre As String, apellido As String, usuario As String, contrasena As String, fechaCreacion As Date, foto As String, tipo As String)

        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.usuario = usuario
        Me.Contrasena = contrasena
        Me.FechaCreacion = fechaCreacion
        Me.Foto = foto
        Me.tipo = tipo
    End Sub


End Class
