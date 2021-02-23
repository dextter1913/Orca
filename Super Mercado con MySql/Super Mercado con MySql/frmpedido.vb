Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Public Class frmpedido
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow
    Dim buscarcod As String
    Dim buscanombreProducto As String
    Dim buscaprecio As String
    Dim buscaidcategoria As String
    Dim cantidad, precio, total, acumuladortotal, contador, acumuladoriva, iva, totalconiva, acumtotalconiva As Integer

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
        conexion.Open()
        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = " delete from pedido where cod_compra=" & txteliminar.Text & "; "
        micomando.ExecuteNonQuery()
        MessageBox.Show("Se elimino su pedido")
        Dim constr As String
        constr = "datasource=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("Select * from pedido INNER JOIN producto ON pedido.cod_compra = producto.id_producto;", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvpedido.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing

        End Try
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) 
        Dim constr As String
        constr = "datasource=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("Select * from pedido INNER JOIN producto ON pedido.cod_compra = producto.id_producto;", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvpedido.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing

        End Try
    End Sub

    Private Sub btningresarcompra_Click(sender As Object, e As EventArgs) Handles btningresarcompra.Click
        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
        conexion.Open()
        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = "insert into pedido values(null," & lbltotalconiva.Text & ",CURRENT_TIMESTAMP()," & txtnumcaja.Text & "," & txtcodigoproducto.Text & ");"
        micomando.ExecuteNonQuery()
        MessageBox.Show("Pedido ingresado correctamente")
        Dim constr As String
        constr = "datasource=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("Select * from pedido INNER JOIN producto ON pedido.cod_compra = producto.id_producto;", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvpedido.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing

        End Try
    End Sub

    Private Sub frmpedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbuscarprod_Click(sender As Object, e As EventArgs) Handles btnbuscarprod.Click

        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;database=supermercado;user ID=root;password=;"
        conexion.Open()
        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text

        buscarcod = txtcodigoproducto.Text

        If buscarcod = " " Or Not IsNumeric(buscarcod) Then
            MsgBox("Dato incorrecto")
        Else

        End If
        micomando.CommandText = "select id_producto from producto where id_producto = '" & buscarcod & "';"
        buscarcod = micomando.ExecuteScalar
        Me.txtcodigoproducto.Text = buscarcod

        micomando.CommandText = "select nom_prod from producto where id_producto = '" & buscarcod & "';"
        buscanombreProducto = micomando.ExecuteScalar
        Me.lblproducto.Text = buscanombreProducto

        micomando.CommandText = "select precio_prod from producto where id_producto = '" & buscarcod & "';"
        buscaprecio = micomando.ExecuteScalar
        Me.lblprecio.Text = buscaprecio



        micomando.CommandText = "select id_categoria from producto where id_producto = '" & buscarcod & "';"
        buscaidcategoria = micomando.ExecuteScalar
        Me.lblcategoria.Text = buscaidcategoria


        conexion.Close()
        txtcantidad.Text = ""
    End Sub

    Private Sub btnfacturar_Click(sender As Object, e As EventArgs) Handles btnfacturar.Click
        txtnumcaja.Enabled = True
        contador = 1
        cantidad = CInt(txtcantidad.Text)

        precio = buscaprecio
        total = precio * cantidad
        iva = total * 0.19
        totalconiva = total + iva
        While contador = 1
            acumuladortotal = acumuladortotal + total
            acumuladoriva = acumuladoriva + iva
            acumtotalconiva = acumtotalconiva + totalconiva
            contador = contador + 1
        End While
        lbltotal.Text = CStr(acumuladortotal)
        lbliva.Text = CStr(acumuladoriva)
        lbltotalconiva.Text = CStr(acumtotalconiva)
        contador = 1
    End Sub
End Class