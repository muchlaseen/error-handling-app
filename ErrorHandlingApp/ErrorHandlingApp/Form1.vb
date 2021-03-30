Public Class Form1

    Dim ListKaryawan As New List(Of String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListKaryawan.Add("Achmad Muchlasin")
        ListKaryawan.Add("Reza Kurniawan")
        ListKaryawan.Add("Agus Susanto")
        ListKaryawan.Add("Andri Setiawan")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            txtList.Text = ListKaryawan(CInt(txtIndex.Text))
        Catch ex As Exception
            txtError.Text = ex.Message
        Finally
            MessageBox.Show("Nilai index dicari: " + txtIndex.Text)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtIndex.Text = ""
        txtList.Text = ""
        txtError.Text = ""
    End Sub
End Class
