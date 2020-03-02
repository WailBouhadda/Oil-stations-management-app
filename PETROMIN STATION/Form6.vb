Public Class Form6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form7.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class