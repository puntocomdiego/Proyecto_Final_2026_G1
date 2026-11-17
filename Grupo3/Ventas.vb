Imports System.Xml
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class Ventas

    ' Conexión a la base de datos Access
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Ruta)
    Dim dtJuegos As New DataTable
    Dim idUsuario As Integer = 1

    ' Instanciamos la clase que creamos arriba
    Dim gestor As New clsVentas()

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Button1.Enabled = False


        ' Estilo de la grilla
        AplicarEstiloGrilla(DataGridView1)

        ' Configuración de la grilla del Carrito (Izquierda)
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("id", "id")
        DataGridView1.Columns.Add("Juego", "Juego")
        DataGridView1.Columns.Add("Cantidad", "Cantidad")
        DataGridView1.Columns.Add("Precio", "Precio")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("Precio").DefaultCellStyle.Format = "C2"
        DataGridView1.Columns("Subtotal").DefaultCellStyle.Format = "C2"

        ' Para que se seleccione toda la fila al hacer clic
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        If Cmb2.Items.Count = 0 Then
            For i As Integer = 1 To 20
                Cmb2.Items.Add(i)
            Next
        End If
        Cmb2.Text = ""

        CargarJuegos()
        CargarHistorialVentas() ' <--- Carga el historial en el DataGridView de la derecha
        btnConfirmar.Enabled = False
    End Sub

    ' ------------------------------------------------------------
    ' Trae los juegos con stock
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
    ' CARGAR HISTORIAL DE VENTAS (El DataGridView de la derecha)
    ' ------------------------------------------------------------
    Private Sub CargarHistorialVentas()
        Try
            ' Asumo que el DataGridView de la derecha se llama DataGridView2
            ' Si se llama diferente, cambialo acá
            Dim dtVentas As New DataTable

            ' Consulta para unir las tablas ventas, detalle_ventas y juegos
            Dim query As String = "SELECT v.fecha AS Fecha_Hora, j.nombre AS Juego, dv.cantidad AS Cantidad, v.total AS Total " &
                                  "FROM (ventas v INNER JOIN detalle_ventas dv ON v.id = dv.id_venta) " &
                                  "INNER JOIN juegos j ON dv.id_juego = j.id " &
                                  "ORDER BY v.fecha DESC"

            Dim da As New OleDbDataAdapter(query, cn)
            da.Fill(dtVentas)

            DatagridVentas.DataSource = dtVentas

            ' Damos formato a la columna de la fecha y el total
            If DatagridVentas.Columns.Contains("Fecha_Hora") Then
                DatagridVentas.Columns("Fecha_Hora").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            End If
            If DatagridVentas.Columns.Contains("Total") Then
                DatagridVentas.Columns("Total").DefaultCellStyle.Format = "C2"
            End If

        Catch ex As Exception
            ' Si el DatagridVentas no existe o hay error, no rompemos la app
            MessageBox.Show("Error al cargar el historial: " & ex.Message)
        End Try
    End Sub

    Private Sub Cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb1.SelectedIndexChanged
        If Cmb1.SelectedIndex >= 0 Then
            Dim fila As DataRow = dtJuegos.Rows(Cmb1.SelectedIndex)
            lblStock.Text = fila("stock").ToString()
        Else
            lblStock.Text = "-"
        End If
    End Sub

    Private Function LeerCantidad() As Integer
        Dim cantidad As Integer
        If Integer.TryParse(Cmb2.Text, cantidad) AndAlso cantidad > 0 Then
            Return cantidad
        End If
        Return 0
    End Function

    ' ------------------------------------------------------------
    ' BOTÓN AGREGAR
    ' ------------------------------------------------------------
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click



        Dim cantidad As Integer = LeerCantidad()

        ' Usamos el procedimiento de la clase
        gestor.AgregarAlCarrito(dtJuegos, DataGridView1, Cmb1.SelectedIndex, cantidad)

        CalcularTotal()
        Cmb2.Text = "1"
    End Sub

    ' ------------------------------------------------------------
    ' BOTÓN MODIFICAR (Ventanita para cambiar la cantidad)
    ' ------------------------------------------------------------
    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccioná una fila del carrito para modificar.")
            Return
        End If

        ' Pedimos la cantidad con un InputBox simple
        Dim input As String = InputBox("Ingrese la nueva cantidad (solo números):", "Modificar Cantidad")

        ' Validamos que no esté vacío y que sean solo números
        If String.IsNullOrWhiteSpace(input) Then Return

        Dim nuevaCantidad As Integer
        If Not Integer.TryParse(input, nuevaCantidad) Then
            MessageBox.Show("Error: Solo se permiten números enteros.")
            Return
        End If

        ' Llamamos al procedimiento de la clase
        If gestor.ModificarCantidad(DataGridView1, nuevaCantidad) Then
            CalcularTotal() ' Si se modificó bien, recalculamos el total
        End If
    End Sub

    ' ------------------------------------------------------------
    ' BOTÓN ELIMINAR
    ' ------------------------------------------------------------
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ' Llamamos al procedimiento de la clase
        If gestor.EliminarDelCarrito(DataGridView1) Then
            CalcularTotal() ' Si se eliminó bien, recalculamos el total
        End If
    End Sub

    ' ------------------------------------------------------------
    ' CÁLCULO DEL TOTAL
    ' ------------------------------------------------------------
    Private Sub CalcularTotal()
        gestor.QuitarTotal(DataGridView1)

        Dim total As Decimal = 0
        Dim cantidadTotal As Integer = 0

        For Each f As DataGridViewRow In DataGridView1.Rows
            total = total + CDec(f.Cells("Subtotal").Value)
            cantidadTotal = cantidadTotal + CInt(f.Cells("Cantidad").Value)
        Next

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows.Add(0, "TOTAL A PAGAR", cantidadTotal, "", total)
            Dim ultima As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
            ultima.DefaultCellStyle.BackColor = Color.Yellow ' Usa el color que tenías
            ultima.DefaultCellStyle.SelectionBackColor = Color.Yellow
            btnConfirmar.Enabled = True
        Else
            btnConfirmar.Enabled = False
        End If
    End Sub

    ' ------------------------------------------------------------
    ' BOTÓN CONFIRMAR (MANTENIDO IGUAL PERO ACTUALIZA HISTORIAL)
    ' ------------------------------------------------------------
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        gestor.QuitarTotal(DataGridView1)

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("El carrito está vacío")
            Return
        End If

        Dim total As Decimal = 0
        For Each f As DataGridViewRow In DataGridView1.Rows
            total = total + CDec(f.Cells("Subtotal").Value)
        Next

        Dim cmd As OleDbCommand
        Dim idVenta As Integer

        cn.Open()
        Dim tran As OleDbTransaction = cn.BeginTransaction()

        Try
            cmd = New OleDbCommand("INSERT INTO ventas (fecha, id_usuario, total) VALUES (?, ?, ?)", cn, tran)
            cmd.Parameters.AddWithValue("@fecha", Now)
            cmd.Parameters.AddWithValue("@id_usuario", idUsuario)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.ExecuteNonQuery()

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

            DataGridView1.Rows.Clear()
            btnConfirmar.Enabled = False
            Button1.Enabled = True

        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show("No se pudo guardar la venta: " & ex.Message)
            CalcularTotal()
        Finally
            cn.Close()
        End Try

        CargarJuegos()
        CargarHistorialVentas() ' <--- IMPORTANTE: Actualizamos la grilla de la derecha
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim resp As MsgBoxResult = MsgBox("¿Seguro de que quiere salir de ventas?", MsgBoxStyle.YesNo, "Salir")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Cmb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmConsultas.Show()
        Me.Close()
    End Sub
End Class