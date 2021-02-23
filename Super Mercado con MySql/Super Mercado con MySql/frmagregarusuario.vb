Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmagregarusuario
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If txtingresaruser.Text = " " Or txtingresaruser.Text = "" Then
            MsgBox("Ingrese un usuario valido valido")
        ElseIf txtingresarcontra.Text = txtconfirmarcontra.Text Then
            conexion = New MySqlConnection
            conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
            conexion.Open()
            micomando = New MySqlCommand()
            micomando.Connection = conexion
            micomando.CommandType = CommandType.Text
            micomando.CommandText = "insert into usuarios values( null,'" & txtingresaruser.Text & "','" & txtingresarcontra.Text & "');"
            micomando.ExecuteNonQuery()
            MessageBox.Show("datos ingresados correctamente")
            Dim constr As String
            constr = "data source=localhost;database=supermercado;userid=root;password=;"
            Dim con As New MySqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable
            Dim da As New MySqlDataAdapter("select * from usuarios", con)
            Try
                Dim cmd As New MySqlCommandBuilder(da)
                da.Fill(tabla)
                DataGridView1.DataSource = tabla

            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                con = Nothing
                ds = Nothing
                tabla = Nothing
                da = Nothing
            End Try
            txtingresaruser.Clear()
            txtingresarcontra.Clear()
            txtconfirmarcontra.Clear()
        ElseIf txtingresarcontra.Text <> txtconfirmarcontra.Text Then
            MsgBox("contraseñas no coinciden")
        End If
    End Sub

    Private Sub frmagregarusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constr As String
        constr = "data source=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("select * from usuarios", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtingresarcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtconfirmarcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;user=root;password=;database=supermercado"
        conexion.Open()

        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = " delete from usuarios where idusuario =' " & txteliminarid.Text & " '; "
        micomando.ExecuteNonQuery()
        Dim constr As String
        constr = "data source=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("select * from usuarios", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub chkmostrarcontraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkmostrarcontraseña.CheckedChanged
        If chkmostrarcontraseña.Checked = True Then
            txtingresarcontra.UseSystemPasswordChar = False
        Else
            txtingresarcontra.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkmostrarconfirmarcontraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkmostrarconfirmarcontraseña.CheckedChanged
        If chkmostrarconfirmarcontraseña.Checked = True Then
            txtconfirmarcontra.UseSystemPasswordChar = False
        Else
            txtconfirmarcontra.UseSystemPasswordChar = True
        End If
    End Sub
End Class