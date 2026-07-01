Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)

        If Label1.Text = "7" _
   Or Label2.Text = "7" _
   Or Label3.Text = "7" Then
            MsgBox("Hai vinto! 🏆")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
