Public Class PresentacionPrincipal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmsuperusuario As New frmsuperusuario
        frmsuperusuario.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As New frmusuario
        usuario.Show()
        Me.Hide()
    End Sub
End Class