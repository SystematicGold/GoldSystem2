Public Class FrmMain
  Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Try
      End
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub

  Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click, Guna2Button5.Click

  End Sub

  Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

  End Sub
End Class
