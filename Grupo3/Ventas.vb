Imports System.Xml
Imports System.Data.OleDb

Public Class Ventas

    ' Conexión a la base de datos Access
    ' IMPORTANTE: cambiar la ruta por la de tu computadora (o usar el módulo de conexión del grupo)
    ' ------------------------------------------------------------
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\60653756\Documents\1\bin\Debug\net8.0-windows\LEVEL_UP.accdb")

    ' Aquí se guardan los juegos que traemos de la base
    Dim dtJuegos As New DataTable

    ' Usuario que hace la venta (después se cambia por el que hizo login)
    Dim idUsuario As Integer = 1

    ' ------------------------------------------------------------
    ' Al abrir el formulario
    ' ------------------------------------------------------------
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Estilo de la grilla (módulo Estilos.vb)
        AplicarEstiloGrilla(DataGridView1)

        ' Columnas de la grilla (el carrito)
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("id", "id")
        DataGridView1.Columns.Add("Juego", "Juego")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        DataGridView1.Columns.Add("Precio", "Precio")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("Precio").DefaultCellStyle.Format = "C2"
        DataGridView1.Columns("Subtotal").DefaultCellStyle.Format = "C2"

        ' Cantidades para elegir en Cmb2 (si no tenías cargadas)
        If Cmb2.Items.Count = 0 Then
            For i As Integer = 1 To 20
                Cmb2.Items.Add(i)
            Next
        End If
        Cmb2.Text = "1"

        CargarJuegos()
        btnConfirmar.Enabled = False
    End Sub

    ' ------------------------------------------------------------
    ' Trae los juegos con stock y los pone en el ComboBox Cmb1
    ' ------------------------------------------------------------
    Private Sub CargarJuegos()
        Try
            dtJuegos.Clear()
            Dim da As New OleDbDataAdapter("SELECT id, nombre, precio, stock FROM juegos WHERE stock > 0 ORDER BY nombre", cn)
            da.Fill(dtJuegos)

            Cmb1.DataSource = dtJuegos
            Cmb1.DisplayMember = "nombre"
            Cmb1.ValueMember = "id"
            Cmb1.SelectedIndex = -1
            lblStock.Text = "-"
        Catch ex As Exception
            MessageBox.Show("No se pudieron cargar los juegos: " & ex.Message)
        End Try
    End Sub

    ' ------------------------------------------------------------
    ' Cuando elegimos un juego, mostramos su stock
    ' ------------------------------------------------------------
    Private Sub Cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb1.SelectedIndexChanged
        If Cmb1.SelectedIndex >= 0 Then
            Dim fila As DataRow = dtJuegos.Rows(Cmb1.SelectedIndex)
            lblStock.Text = fila("stock").ToString()
        Else
            lblStock.Text = "-"
        End If
    End Sub

    ' ------------------------------------------------------------
    ' Lee la cantidad de Cmb2 (devuelve 0 si no es un número válido)
    ' ------------------------------------------------------------
    Private Function LeerCantidad() As Integer
        Dim cantidad As Integer
        If Integer.TryParse(Cmb2.Text, cantidad) AndAlso cantidad > 0 Then
            Return cantidad
        End If
        Return 0
    End Function

    ' ------------------------------------------------------------
    ' Botón AGREGAR: pasa el juego al carrito (la grilla)
    ' ------------------------------------------------------------
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Validación: tiene que haber un juego elegido
        If Cmb1.SelectedIndex < 0 Then
            MessageBox.Show("Primero elegí un juego")
            Return
        End If

        ' Validación: la cantidad tiene que ser un número mayor a 0
        Dim cantidad As Integer = LeerCantidad()
        If cantidad = 0 Then
            MessageBox.Show("Ingresá una cantidad válida (un número mayor a 0)")
            Return
        End If

        QuitarTotal()

        Dim fila As DataRow = dtJuegos.Rows(Cmb1.SelectedIndex)
        Dim idJuego As Integer = CInt(fila("id"))
        Dim nombre As String = fila("nombre").ToString()
        Dim precio As Decimal = CDec(fila("precio"))
        Dim stock As Integer = CInt(fila("stock"))

        ' Buscamos si el juego ya está en el carrito
        Dim filaCarrito As DataGridViewRow = Nothing
        For Each f As DataGridViewRow In DataGridView1.Rows
            If CInt(f.Cells("id").Value) = idJuego Then
                filaCarrito = f
            End If
        Next

        Dim yaEnCarrito As Integer = 0
        If filaCarrito IsNot Nothing Then
            yaEnCarrito = CInt(filaCarrito.Cells("Cantidad").Value)
        End If

        ' Validación: no vender más de lo que hay en stock
        If yaEnCarrito + cantidad > stock Then
            MessageBox.Show("No hay stock suficiente. Stock disponible: " & stock)
            CalcularTotal()
            Return
        End If

        If filaCarrito Is Nothing Then
            ' Juego nuevo: agregamos un renglón al coso
            DataGridView1.Rows.Add(idJuego, nombre, cantidad, precio, cantidad * precio)
        Else
            ' Juego repetido: sumamos la cantidad y recalculamos el subtotal
            filaCarrito.Cells("Cantidad").Value = yaEnCarrito + cantidad
            filaCarrito.Cells("Subtotal").Value = (yaEnCarrito + cantidad) * precio
        End If

        CalcularTotal()
        Cmb2.Text = "1"
    End Sub

    ' ------------------------------------------------------------
    ' Botón EDITAR: cambia la cantidad del renglón seleccionado
    ' (se elige el renglón en la grilla, se pone la nueva cantidad en Cmb2)
    ' ------------------------------------------------------------

    ' ------------------------------------------------------------
    ' Saca la fila del total (si está) para poder trabajar con los juegos
    ' ------------------------------------------------------------
    Private Sub QuitarTotal()
        If DataGridView1.Rows.Count > 0 Then
            Dim ultima As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
            If ultima.Cells("Juego").Value.ToString() = "TOTAL A PAGAR" Then
                DataGridView1.Rows.Remove(ultima)
            End If
        End If
    End Sub

    ' ------------------------------------------------------------
    ' Suma los subtotales y agrega la fila "TOTAL A PAGAR" al final
    ' ------------------------------------------------------------
    Private Sub CalcularTotal()
        QuitarTotal()

        Dim total As Decimal = 0
        Dim cantidadTotal As Integer = 0

        For Each f As DataGridViewRow In DataGridView1.Rows
            total = total + CDec(f.Cells("Subtotal").Value)
            cantidadTotal = cantidadTotal + CInt(f.Cells("Cantidad").Value)
        Next

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows.Add(0, "TOTAL A PAGAR", cantidadTotal, "", total)
            Dim ultima As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
            ultima.DefaultCellStyle.BackColor = ColorAmarillo
            ultima.DefaultCellStyle.SelectionBackColor = ColorAmarillo
            ultima.DefaultCellStyle.Font = FuenteBoton
            btnConfirmar.Enabled = True
        Else
            btnConfirmar.Enabled = False
        End If
    End Sub

    ' ------------------------------------------------------------
    ' Botón CONFIRMAR: guarda en ventas, detalle_ventas y baja el stock
    ' ------------------------------------------------------------
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        QuitarTotal()

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("El carrito está vacío")
            Return
        End If

        ' Calculamos el total de la venta
        Dim total As Decimal = 0
        For Each f As DataGridViewRow In DataGridView1.Rows
            total = total + CDec(f.Cells("Subtotal").Value)
        Next

        Dim cmd As OleDbCommand
        Dim idVenta As Integer

        cn.Open()

        Dim tran As OleDbTransaction = cn.BeginTransaction()

        Try
            ' 1) Guardamos la cabecera en la tabla ventas
            cmd = New OleDbCommand("INSERT INTO ventas (fecha, id_usuario, total) VALUES (?, ?, ?)", cn, tran)
            cmd.Parameters.AddWithValue("@fecha", Now)
            cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.ExecuteNonQuery()

            ' 2) Averiguamos el id de la venta que se acaba de crear
            cmd = New OleDbCommand("SELECT @@IDENTITY", cn, tran)
            idVenta = CInt(cmd.ExecuteScalar())


            For Each f As DataGridViewRow In DataGridView1.Rows
                cmd = New OleDbCommand("INSERT INTO detalle_ventas (id_venta, id_juego, cantidad, precio_unitario, subtotal) VALUES (?, ?, ?, ?, ?)", cn, tran)
                cmd.Parameters.AddWithValue("@id_venta", idVenta)
                cmd.Parameters.AddWithValue("@id_juego", CInt(f.Cells("id").Value))
                cmd.Parameters.AddWithValue("@cantidad", CInt(f.Cells("Cantidad").Value))
                cmd.Parameters.AddWithValue("@precio_unitario", CDec(f.Cells("Precio").Value))
                cmd.Parameters.AddWithValue("@subtotal", CDec(f.Cells("Subtotal").Value))
                cmd.ExecuteNonQuery()

                cmd = New OleDbCommand("UPDATE juegos SET stock = stock - ? WHERE id = ?", cn, tran)
                cmd.Parameters.AddWithValue("@cantidad", CInt(f.Cells("Cantidad").Value))
                cmd.Parameters.AddWithValue("@id", CInt(f.Cells("id").Value))
                cmd.ExecuteNonQuery()
            Next

            tran.Commit()
            MessageBox.Show("Venta guardada. Total: " & total.ToString("C2"))

            ' Dejamos todo listo para una nueva venta
            DataGridView1.Rows.Clear()
            btnConfirmar.Enabled = False
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show("No se pudo guardar la venta: " & ex.Message)
            CalcularTotal()
        Finally
            cn.Close()
        End Try

        CargarJuegos()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        MsgBox("¿Seguro de que quiere salir de ventas?", MsgBoxStyle.YesNo, "Salir")

        If MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class