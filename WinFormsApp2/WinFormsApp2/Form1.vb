Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Int(Rnd() * 7 + 1)
        Label2.Text = Int(Rnd() * 7 + 1)
        Label3.Text = Int(Rnd() * 7 + 1)

        If Label1.Text = "6" Or Label2.Text = "6" Or Label3.Text = "6" Then
            MsgBox("Hai vinto! 🏆")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
