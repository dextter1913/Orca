Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmsuperusuario
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow

    Private Sub btniniciarsesion_Click(sender As Object, e As EventArgs) Handles btniniciarsesionsupersu.Click
        'buscar el usuario y la contraseña
        Dim buscar As String
        Dim busca As String

        conexion = New MySqlConnection
        conexion.ConnectionString = ("server=localhost;database=supermercado;userID=root;password=;")
        conexion.Open()
        micomando = New MySqlCommand
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text
        micomando.CommandText = " select superusuario from superusuario where superusuario='" & txtsuperusuario.Text & "';"
        buscar = micomando.ExecuteScalar
        Me.txtsuperusuario.Text = buscar

        micomando.CommandText = " select superpassword from superusuario where superpassword='" & txtsupercontraseña.Text & "';"
        busca = micomando.ExecuteScalar
        Me.txtsupercontraseña.Text = busca

        If (txtsupercontraseña.Text = "") Or (txtsupercontraseña.Text = "") Then
            MsgBox("verificar el nombre o la contraseña", vbInformation, "aviso")
        Else
            If (txtsuperusuario.Text = buscar) And (txtsupercontraseña.Text = busca) Then
                With prginiciodesesionsuper()

                    prginiciodesesionsuper.Maximum = 500000
                    prginiciodesesionsuper.Minimum = 0
                    prginiciodesesionsuper.Value = 0

                    For x = prginiciodesesionsuper.Minimum To prginiciodesesionsuper.Maximum
                        prginiciodesesionsuper.Value = x

                    Next x

                End With
                ' MsgBox("su clave es correcta", vbInformation, "informacion")
                Dim yo As New frmagregarusuario
                yo.Show()
                Me.Hide()
            Else
                MsgBox("su clave es incorrecta", vbInformation, "aviso")
                txtsupercontraseña.Text = ""
                txtsuperusuario.Text = ""
            End If

        End If
    End Sub

    Private Sub btnvolversuper_Click(sender As Object, e As EventArgs) Handles btnvolversuper.Click
        Dim volver As New PresentacionPrincipal
        volver.Show()
        Me.Hide()
    End Sub
End Class