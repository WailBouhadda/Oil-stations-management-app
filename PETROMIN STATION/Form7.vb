Public Class Form7


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form6.Show()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PETROMINDataSet2.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter.Fill(Me.PETROMINDataSet2.PETROMIN)


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("PrixStructSuperspDataGridViewTextBoxColumn").Value = TextBox1.Text
            Next
        Catch ex As Exception
            MessageBox.Show(" veuiller entrer le PrixStruct Essence")
        End Try
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("PrixStructGasoil10PPMDataGridViewTextBoxColumn").Value = TextBox2.Text

            Next
        Catch ex As Exception
            MessageBox.Show("veuiller entrer le PrixStruct Diesel")
        End Try
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("DateDeDebutDataGridViewTextBoxColumn").Value = DateTimePicker1.Value
            Next
        Catch ex As Exception
            MessageBox.Show(" veuiller entrer la date")
        End Try
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("DateDeFinDataGridViewTextBoxColumn").Value = DateTimePicker2.Value
            Next
        Catch ex As Exception
            MessageBox.Show("veuiller entrer la date")
        End Try

        PETROMINBindingSource.EndEdit()
        MsgBox("Les modifications à été enregistrer avec succès !!!", MsgBoxStyle.OkOnly, " Félicitation !!!")






        PETROMINTableAdapter.Update(PETROMINDataSet2.PETROMIN)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class

