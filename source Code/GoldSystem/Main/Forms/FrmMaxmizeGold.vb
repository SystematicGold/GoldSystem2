Public Class FrmMaxmizeGold
  Private Sub Guna2GradientPanel1_Click(sender As Object, e As EventArgs) Handles Guna2GradientPanel1.Click
    Try
      Close()
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub
End Class
