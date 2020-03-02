Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PETROMINDataSet2.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter.Fill(Me.PETROMINDataSet2.PETROMIN)


        PETROMINBindingSource.AddNew()



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        PETROMINBindingSource.EndEdit()
        PETROMINTableAdapter.Update(PETROMINDataSet2.PETROMIN)

        MsgBox("Nouveau station à été ajouter avec succès !!!", MsgBoxStyle.OkOnly, "Félicitation !!!")




    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class