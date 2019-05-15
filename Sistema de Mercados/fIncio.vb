Public Class fIncio

    Dim clickMove As Boolean = False
    Private formRegion As Rectangle
    Private borderColor As Color = Color.Black
    Private borderWidth As Integer = 10
    Dim Graphics As Graphics

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        fAlmacenes.Visible = True
        Me.Enabled = False
    End Sub

    Private Sub btnMercados_Click(sender As Object, e As EventArgs) Handles btnMercados.Click
        fMercados.Visible = True
        Me.Enabled = False
    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        fPuestos.Visible = True
        Me.Enabled = False
    End Sub


    Private Sub fIncio_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor, ButtonBorderStyle.Solid)
    End Sub

    Private Sub fIncio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
    End Sub
End Class
