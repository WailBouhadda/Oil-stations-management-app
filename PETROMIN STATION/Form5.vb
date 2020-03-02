Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PETROMINDataSet2.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter1.Fill(Me.PETROMINDataSet2.PETROMIN)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PETROMINBindingSource1.EndEdit()
        MsgBox("Les modifications à été enregistrer avec succès !!!", MsgBoxStyle.OkOnly, " Félicitation !!!")
        PETROMINTableAdapter1.Update(PETROMINDataSet2.PETROMIN)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class