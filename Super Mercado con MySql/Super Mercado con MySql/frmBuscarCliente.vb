Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmBuscarCliente
    Dim conexion As MySqlConnection
    Dim micomando As MySqlCommand
    Dim miadapter As MySqlDataReader
    Dim mi As New DataTable
    Dim midataset As DataSet
    Dim fila As DataRow
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnbuscarC_Click(sender As Object, e As EventArgs) Handles btnbuscarC.Click
        Dim buscaidcliente As String
        Dim buscacedula As String
        Dim buscanombre As String
        Dim buscaapellido As String
        Dim buscatelefono As String
        Dim buscadireccion As String
        Dim buscaemail As String
        Dim buscsexo As String
        Dim buscciudad As String


        conexion = New MySqlConnection
        conexion.ConnectionString = "server=localhost;database=supermercado;userID=root;password=;"
        conexion.Open()
        micomando = New MySqlCommand()
        micomando.Connection = conexion
        micomando.CommandType = CommandType.Text

        If rdocedula.Checked = True Then
            buscacedula = txtbuscarC.Text

            If buscacedula = " " Or Not IsNumeric(buscacedula) Then
                MsgBox("Dato incorrecto")
            Else

            End If

            micomando.CommandText = "select id_cliente from cliente where CedulaCli = '" & buscacedula & "';"
            buscaidcliente = micomando.ExecuteScalar
            Me.lblIDcl.Text = buscaidcliente

            micomando.CommandText = "select CedulaCli from cliente where CedulaCli = '" & buscacedula & "';"
            buscacedula = micomando.ExecuteScalar
            Me.lblcedulacliente.Text = buscacedula

            micomando.CommandText = "select NombreCli from cliente where CedulaCli = '" & buscacedula & "';"
            buscanombre = micomando.ExecuteScalar
            Me.lblnombrecliente.Text = buscanombre

            micomando.CommandText = "select ApellCli from cliente where CedulaCli = '" & buscacedula & "';"
            buscaapellido = micomando.ExecuteScalar
            Me.lblapellidocliente.Text = buscaapellido


            micomando.CommandText = "select TelCli from cliente where CedulaCli = '" & buscacedula & "';"
            buscatelefono = micomando.ExecuteScalar
            Me.lbltelefonocl.Text = buscatelefono

            micomando.CommandText = "select DireccionCl from cliente where CedulaCli = '" & buscacedula & "';"
            buscadireccion = micomando.ExecuteScalar
            Me.lbldireccioncl.Text = buscadireccion

            micomando.CommandText = "select CorreoCli from cliente where CedulaCli = '" & buscacedula & "';"
            buscaemail = micomando.ExecuteScalar
            Me.lblcorreocl.Text = buscaemail

            micomando.CommandText = "select sexo from cliente where CedulaCli = '" & buscacedula & "';"
            buscsexo = micomando.ExecuteScalar
            Me.lblsexo.Text = buscsexo

            micomando.CommandText = "select ciudad from cliente where CedulaCli = '" & buscacedula & "';"
            buscciudad = micomando.ExecuteScalar
            Me.lblciudadcl.Text = buscciudad

            conexion.Close()
        End If

        btningresarpedido.Enabled = True
        btnexportarpedido.Enabled = True
    End Sub

    Private Sub btnexportarpedido_Click(sender As Object, e As EventArgs) Handles btnexportarpedido.Click
        Dim constr As String
        constr = "datasource=localhost;database=supermercado;userid=root;password=;"
        Dim con As New MySqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim da As New MySqlDataAdapter("select * from cliente", con)
        Try
            Dim cmd As New MySqlCommandBuilder(da)
            da.Fill(tabla)
            dgvexportar.DataSource = tabla

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con = Nothing
            ds = Nothing
            tabla = Nothing
            da = Nothing

        End Try
        exportare()
    End Sub
    Private Sub exportare()
        Try
            Dim Archivo As String = Application.StartupPath & "\pagos.xls"  'con esto le desimos el tipo de archivo que va a tomar  txt =bloc de notas; doc de word
            File.Delete(Archivo)
            Using strStreamW As Stream = File.OpenWrite(Archivo)
                Using strStreamWriter As New StreamWriter(strStreamW, System.Text.Encoding.UTF8)
                    Dim filas As Integer
                    If (dgvexportar.AllowUserToAddRows) Then
                        filas = Me.dgvexportar.Rows.Count - 2
                    Else
                        filas = Me.dgvexportar.Rows.Count - 1
                    End If

                    Dim columnas As Integer = Me.dgvexportar.Columns.Count - 1
                    Dim linea As String = String.Empty
                    Dim f, c As Integer

                    'CABECERA
                    For c = 0 To columnas
                        linea = linea & Me.dgvexportar.Columns(c).Name & ";"
                    Next
                    strStreamWriter.WriteLine(linea.Substring(0, linea.Length - 1))
                    linea = String.Empty

                    'FILAS
                    For f = 0 To filas
                        For c = 0 To columnas
                            Dim value As Object = Me.dgvexportar.Item(c, f).Value

                            If (value Is DBNull.Value) Then value = String.Empty
                            linea = linea & CStr(value) & ";"
                        Next
                        strStreamWriter.WriteLine(linea.Substring(0, linea.Length - 1))
                        linea = String.Empty
                    Next
                    strStreamWriter.Close()
                End Using
                strStreamW.Close()
            End Using
            Process.Start(Archivo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btningresarpedido_Click(sender As Object, e As EventArgs) Handles btningresarpedido.Click
        Dim pedido As New frmpedido
        pedido.Show()
    End Sub
    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class