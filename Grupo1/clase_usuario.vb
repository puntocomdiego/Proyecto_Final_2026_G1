Imports System.Data.OleDb

Public Class clase_usuario

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Usuario As String
    Public Property Contrasena As String
    Public Property FechaCreacion As Date = Date.Now


    Public Sub New(nombre As String, apellido As String, usuario As String, contrasena As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Usuario = usuario
        Me.Contrasena = contrasena
    End Sub


End Class
