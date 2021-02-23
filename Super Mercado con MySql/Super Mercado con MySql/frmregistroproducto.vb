Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmregistroproducto
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow
    Private Sub btnregistrarP_Click(sender As Object, e As EventArgs) Handles btnregistrarP.Click
        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
        conexion.Open()
        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = "insert into producto values(null, '" & txtnombreprod.Text & "', " & txtprecioprod.Text & "," & txtcategoriaprod.Text & ");"
        micomando.ExecuteNonQuery()
        MessageBox.Show("datos ingresados correctamente")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim constr As String
        constr = "data source=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("select * from categoria", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvregistrarproducto.DataSource = tabla

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