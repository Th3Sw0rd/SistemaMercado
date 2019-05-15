Public Class fPuestos

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub fPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fPuestos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        fIncio.Enabled = True
    End Sub
End Class