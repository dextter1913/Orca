Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmregistarcliente
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow
    Private Sub btningresarcliente_Click(sender As Object, e As EventArgs) Handles btningresarcliente.Click
        If txtnombreingresarcliente.Text = "" Or txtapellidoingresarcliente.Text = "" Or txtingresecedulacliente.Text = "" Or txtingreseteefonocliete.Text = "" Or txtingresedireccioncliente.Text = "" Or txtingresarcorreocliente.Text = "" Or txtingreseidempleado.Text = "" Or txtingresesexocliente.Text = "" Or txtingreseciudadcliente.Text = "" Then
            MsgBox("ingrese los campos correctamente")
        Else
            conexion = New MySqlConnection
            conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
            conexion.Open()
            micomando = New MySqlCommand()
            micomando.Connection = conexion
            micomando.CommandType = CommandType.Text
            micomando.CommandText = "insert into cliente values( null,'" & txtnombreingresarcliente.Text & "', '" & txtapellidoingresarcliente.Text & "'," & txtingresecedulacliente.Text & ",'" & txtingreseteefonocliete.Text & "','" & txtingreseciudadcliente.Text & "','" & txtingresesexocliente.Text & "','" & txtingresedireccioncliente.Text & "','" & txtingresarcorreocliente.Text & "'," & txtingreseidempleado.Text & ");"
            micomando.ExecuteNonQuery()
            MessageBox.Show("datos ingresados correctamente")

            Dim constr As String
            constr = "data source=localhost;database=supermercado;userid=root;password=;"
            Dim con As New MySqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable
            Dim da As New MySqlDataAdapter("select * from cliente", con)
            Try
                Dim cmd As New MySqlCommandBuilder(da)
                da.Fill(tabla)
                dgvingresarclientes.DataSource = tabla

            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                con = Nothing
                ds = Nothing
                tabla = Nothing
                da = Nothing
            End Try
        End If
    End Sub

    Private Sub frmregistarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constr As String
        constr = "data source=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("select * from cliente", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvingresarclientes.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing
        End Try
    End Sub
End Class