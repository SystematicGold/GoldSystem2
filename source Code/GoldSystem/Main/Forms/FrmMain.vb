Imports RestSharp

Public Class FrmMain
  Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      End
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
  Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
            'WebBrowser1.Navigate("http://goldpricez.com/kw/18k/gram")
        Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
<<<<<<< HEAD
  Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    Try
      Dim T0 As String = "gold_price_table"
      Dim K18 As String
      Guna2TextBox1.Text = WebBrowser1.Document.GetElementById("gold_price_table").InnerText
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
=======
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
        Try
            'Dim T0 As String = "gold_price_table"
            'Dim K18 As String
            'Guna2TextBox1.Text = WebBrowser1.Document.GetElementById("gold_price_table").InnerText


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            Dim F As New FrmGold
            F.show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim f As New XtraReport1

    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs)
        Try
            Guna2Panel7.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureEdit2_Click(sender As Object, e As EventArgs)
        Try
            'Guna2Panel6.Size.Width = 10.0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click

    End Sub
>>>>>>> 168439aafcdb12f7110aed5dd5cccf285cd81a2a
End Class
