Public Class fMercados
    Dim Provincias As New UcProvincias
    Private Sub fMercados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fMercados_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fIncio.Enabled = True
    End Sub
End Class