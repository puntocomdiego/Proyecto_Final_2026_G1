
Imports System.Data.OleDb
Imports System.Windows.Forms



Public Class clsVentas

    ' --- PROCEDIMIENTO AGREGAR ---
    Public Sub AgregarAlCarrito(dtJuegos As DataTable, dgvCarrito As DataGridView, indexJuego As Integer, cantidad As Integer)
        If indexJuego < 0 Then
            MessageBox.Show("Primero elegí un juego")
            Return
        End If

        If cantidad <= 0 Then
            MessageBox.Show("Ingresá una cantidad válida (un número mayor a 0)")
            Return
        End If

        QuitarTotal(dgvCarrito)

        Dim fila = dtJuegos.Rows(indexJuego)
        Dim idJuego As Integer = fila("id")
        Dim nombre = fila("nombre").ToString
        Dim precio As Decimal = fila("precio")
        Dim stock As Integer = fila("stock")

        Dim filaCarrito As DataGridViewRow = Nothing
        For Each f As DataGridViewRow In dgvCarrito.Rows
            If f.Cells("id").Value IsNot Nothing AndAlso CInt(f.Cells("id").Value) = idJuego Then
                filaCarrito = f
            End If
        Next

        Dim yaEnCarrito As Integer = 0
        If filaCarrito IsNot Nothing Then
            yaEnCarrito = CInt(filaCarrito.Cells("Cantidad").Value)
        End If

        If yaEnCarrito + cantidad > stock Then
            MessageBox.Show("No hay stock suficiente. Stock disponible: " & stock)
            Return
        End If

        If filaCarrito Is Nothing Then
            dgvCarrito.Rows.Add(idJuego, nombre, cantidad, precio, cantidad * precio)
        Else
            filaCarrito.Cells("Cantidad").Value = yaEnCarrito + cantidad
            filaCarrito.Cells("Subtotal").Value = (yaEnCarrito + cantidad) * precio
        End If
    End Sub

    ' --- PROCEDIMIENTO MODIFICAR ---
    Public Function ModificarCantidad(dgvCarrito As DataGridView, nuevaCantidad As Integer) As Boolean
        If dgvCarrito.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccioná un juego del carrito para modificar.")
            Return False
        End If

        Dim fila As DataGridViewRow = dgvCarrito.SelectedRows(0)

        ' No permitir modificar la fila del Total
        If fila.Cells("Juego").Value.ToString() = "TOTAL A PAGAR" Then
            MessageBox.Show("No podés modificar la fila del Total.")
            Return False
        End If

        ' Buscar el stock real del juego en la base de datos
        Dim idJuego As Integer = CInt(fila.Cells("id").Value)
        Dim stockDisponible As Integer = 0

        Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
            Using cmd As New OleDbCommand("SELECT stock FROM juegos WHERE id = ?", cn)
                cmd.Parameters.AddWithValue("@id", idJuego)
                cn.Open()
                stockDisponible = CInt(cmd.ExecuteScalar())
            End Using
        End Using

        If nuevaCantidad > stockDisponible Then
            MessageBox.Show("No podés poner esa cantidad. Stock máximo: " & stockDisponible)
            Return False
        End If

        If nuevaCantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a 0. Si querés quitarlo, usá el botón Eliminar.")
            Return False
        End If

        ' Actualizar la grilla
        Dim precio As Decimal = CDec(fila.Cells("Precio").Value)
        fila.Cells("Cantidad").Value = nuevaCantidad
        fila.Cells("Subtotal").Value = nuevaCantidad * precio
        Return True
    End Function

    ' --- PROCEDIMIENTO ELIMINAR ---
    Public Function EliminarDelCarrito(dgvCarrito As DataGridView) As Boolean
        If dgvCarrito.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccioná un juego del carrito para eliminar.")
            Return False
        End If

        Dim fila As DataGridViewRow = dgvCarrito.SelectedRows(0)

        If fila.Cells("Juego").Value.ToString() = "TOTAL A PAGAR" Then
            MessageBox.Show("No podés eliminar la fila del Total.")
            Return False
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este juego del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            dgvCarrito.Rows.Remove(fila)
            Return True
        End If

        Return False
    End Function

    ' --- FUNCIÓN AUXILIAR PARA QUITAR EL TOTAL ---
    Public Sub QuitarTotal(dgvCarrito As DataGridView)
        If dgvCarrito.Rows.Count > 0 Then
            Dim ultima As DataGridViewRow = dgvCarrito.Rows(dgvCarrito.Rows.Count - 1)
            If ultima.Cells("Juego").Value IsNot Nothing AndAlso ultima.Cells("Juego").Value.ToString() = "TOTAL A PAGAR" Then
                dgvCarrito.Rows.Remove(ultima)
            End If
        End If
    End Sub

End Class
