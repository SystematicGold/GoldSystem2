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
      PanelAll.Visible = True
      PanalGold.Visible = False
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
  Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
    Try
      PanalGold.Visible = True
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim f As New XtraReport1

    End Sub
  Private Sub PictureEdit1_Click_1(sender As Object, e As EventArgs) Handles PictureEdit1.Click
    Try
      PanalGold.Visible = False
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub
End Class
