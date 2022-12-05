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
      WebBrowser1.Navigate("http://goldpricez.com/kw/18k/gram")
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
  Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    Try
      Dim T0 As String = "gold_price_table"
      Dim K18 As String
      Guna2TextBox1.Text = WebBrowser1.Document.GetElementById("gold_price_table").InnerText


    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
End Class
