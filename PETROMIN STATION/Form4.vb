Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PETROMINDataSet2.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter2.Fill(Me.PETROMINDataSet2.PETROMIN)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        PETROMINBindingSource2.RemoveCurrent()
        PETROMINTableAdapter2.Update(PETROMINDataSet2.PETROMIN)

        MsgBox("Une station à été Supprimer avec succès !!!", MsgBoxStyle.OkOnly, "Félicitation !!!")


    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class