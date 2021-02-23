Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmusuario
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow

    Private Sub btniniciarsesion_Click(sender As Object, e As EventArgs) Handles btniniciarsesion.Click
        'buscar el usuario y la contraseña
        Dim buscar As String
        Dim busca As String

        conexion = New MySqlConnection
        conexion.ConnectionString = ("server=localhost;database=supermercado;userID=root;password=;")
        conexion.Open()
        micomando = New MySqlCommand
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = " select usuario from usuarios where usuario='" & txtusuarioV.Text & "';"
        buscar = micomando.ExecuteScalar
        Me.txtusuarioV.Text = buscar

        micomando.CommandText = " select password from usuarios where password='" & txtcontraseñaV.Text & "';"
        busca = micomando.ExecuteScalar
        Me.txtcontraseñaV.Text = busca

        If (txtusuarioV.Text = "") Or (txtcontraseñaV.Text = "") Then
            MsgBox("verificar el nombre o la contraseña", vbInformation, "aviso")
        Else
            If (txtusuarioV.Text = buscar) And (txtcontraseñaV.Text = busca) Then
                With prginiciodesesion()

                    prginiciodesesion.Maximum = 500000
                    prginiciodesesion.Minimum = 0
                    prginiciodesesion.Value = 0

                    For x = prginiciodesesion.Minimum To prginiciodesesion.Maximum
                        prginiciodesesion.Value = x

                    Next x

                End With
                ' MsgBox("su clave es correcta", vbInformation, "informacion")
                Dim yo As New frmmenu
                yo.Show()
                Me.Hide()
            Else
                MsgBox("su clave es incorrecta", vbInformation, "aviso")
                txtcontraseñaV.Text = ""
                txtusuarioV.Text = ""
            End If

        End If


    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnvolver_Click(sender As Object, e As EventArgs) Handles btnvolver.Click
        Dim volver As New PresentacionPrincipal
        volver.Show()
        Me.Hide()
    End Sub
End Class
