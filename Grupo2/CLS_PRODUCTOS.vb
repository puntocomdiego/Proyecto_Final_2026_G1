
Imports System.Data

Imports System.Data.OleDb

Public Class CLS_PRODUCTOS
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property IdCategoria As Integer
    Public Property Precio As Double
    Public Property Stock As Integer
    Public Property FechaIngreso As Date
    Public Property Portada As String

    Private Shared ReadOnly ruta As String =
   IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "level_up.accdb")
    Private Shared ReadOnly cadenaConexion As String =
    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};"
    ' Obtenemos la conexión desde el módulo común del proyecto
    Public Sub New()
        ' Constructor vacío: crear el objeto y cargar sus datos después.
    End Sub
    Public Sub New(nombre As String, idCategoria As Integer, precio As Double, stock As Integer, fechaIngreso As Date, portada As String)
        Me.Nombre = nombre
        Me.IdCategoria = idCategoria
        Me.Precio = precio
        Me.Stock = stock
        Me.FechaIngreso = fechaIngreso
        Me.Portada = portada

    End Sub

End Class

