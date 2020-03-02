Imports System.IO
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form6.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PETROMINDataSet3.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter1.Fill(Me.PETROMINDataSet3.PETROMIN)
        'TODO: This line of code loads data into the 'PETROMINDataSet2.PETROMIN' table. You can move, or remove it, as needed.
        Me.PETROMINTableAdapter.Fill(Me.PETROMINDataSet2.PETROMIN)

        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("PrixPublicSuperspDataGridViewTextBoxColumn").Value = Math.Round(row.Cells("DTDataGridViewTextBoxColumn").Value + row.Cells("PrixStructSuperspDataGridViewTextBoxColumn").Value, 2)
            Next
        Catch ex As Exception
            MessageBox.Show(" veuiller entrer le PrixStruct Supersp")
        End Try
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("PrixPublicGasoil10PPMDataGridViewTextBoxColumn").Value = Math.Round(row.Cells("DTDataGridViewTextBoxColumn").Value + row.Cells("PrixStructGasoil10PPMDataGridViewTextBoxColumn").Value, 2)

            Next
        Catch ex As Exception
            MessageBox.Show("veuiller entrer le PrixStruct Gasoil10PPM")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form5.Show()

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Dim savefile As New SaveFileDialog


        savefile.FileName = "STATION"
        savefile.Filter = "Fichier Text (*.xml)|*.xml"
        savefile.ShowDialog()


        Dim sw As New IO.StreamWriter(savefile.FileName)






        sw.WriteLine("<?xml version=""1.0"" encoding=""UTF-8""?>")
        sw.WriteLine("<Stations xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">")
        For Each row As DataGridViewRow In DataGridView1.Rows
            sw.WriteLine("    <Station>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")

            sw.WriteLine("<Longitude>" & row.Cells("LongitudeDataGridViewTextBoxColumn").Value & "</Longitude>")
            sw.WriteLine("  <Latitude>" & row.Cells("LatitudeDataGridViewTextBoxColumn").Value & "</Latitude>")

            sw.WriteLine("  <ProductLines>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("    <!--Essence-->" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<ProductLine>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<FromDate>" & row.Cells("DateDeDebutDataGridViewTextBoxColumn").Value & "</FromDate>")
            sw.WriteLine("<ToDate>" & row.Cells("DateDeFinDataGridViewTextBoxColumn").Value & "</ToDate>")
            sw.WriteLine("<Price>" & row.Cells("PrixPublicSuperspDataGridViewTextBoxColumn").Value & "</Price>")
            sw.WriteLine("<Product>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<Id>" & row.Cells("IDSuperDataGridViewTextBoxColumn").Value & "</Id>")
            sw.WriteLine("</Product>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("</ProductLine>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("    <!--Diesel-->" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<ProductLine>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<FromDate>" & row.Cells("DateDeDebutDataGridViewTextBoxColumn").Value & "</FromDate>")
            sw.WriteLine("<ToDate>" & row.Cells("DateDeFinDataGridViewTextBoxColumn").Value & "</ToDate>")
            sw.WriteLine("<Price>" & row.Cells("PrixPublicGasoil10PPMDataGridViewTextBoxColumn").Value & "</Price>")
            sw.WriteLine("<Product>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("<Id>" & row.Cells("IDGasoilDataGridViewTextBoxColumn").Value & "</Id>")
            sw.WriteLine("</Product>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("</ProductLine>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("</ProductLines>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")
            sw.WriteLine("</Station>" & row.Cells("VIDEDataGridViewTextBoxColumn").Value & "")



        Next


        sw.WriteLine("</Stations>")
        sw.Close()

        MsgBox("Le fichier à été enregistrer avec succés", MsgBoxStyle.OkOnly, "Félicitation !!")





    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        WindowState = FormWindowState.Minimized
    End Sub
End Class