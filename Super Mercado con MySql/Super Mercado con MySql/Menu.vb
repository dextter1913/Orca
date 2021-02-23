Public Class frmmenu

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim registrarproducto As New frmregistroproducto
        registrarproducto.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim registrarcliente As New frmregistarcliente
        registrarcliente.ShowDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim acerca As New frmacerca
        acerca.ShowDialog()
    End Sub

    Private Sub tmrmenu_Tick(sender As Object, e As EventArgs) Handles tmrmenu.Tick

        txthora.Text = Hour(Now)
        txtminuto.Text = Minute(Now)
        txtsegundo.Text = Second(Now)

    End Sub

    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        Dim buscar As New frmBuscarCliente
        buscar.ShowDialog()
    End Sub
End Class