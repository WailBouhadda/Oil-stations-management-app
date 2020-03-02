Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim res As MsgBoxResult
        res = MsgBox("Voulez vous vraiment quitter !!?", MsgBoxStyle.YesNo, "Attention !!!")

        If res = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            If res = MsgBoxResult.No Then
                Me.Show()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "user" And TextBox2.Text = "admin" Then
            Me.Hide()
            Form6.Show()
        Else
            MsgBox("Le mot de passe ou Nom est incorrecte !!!", MsgBoxStyle.OkOnly, "Attention !!!!")

            End If





    End Sub


End Class
