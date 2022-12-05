Imports System.Net.NetworkInformation

Public Class FrmLogin
  Public ClsLogin_ As New ClsLogin
  Private Sub GunaLinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
    Try
      Dim f As New SettingFile
      f.ShowDialog()
    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub
  Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
    Try
      If TxtUser.Text = String.Empty Or TxtPass.Text = String.Empty Then
        MessageBox.Show("يجب ادخال اليوزر والباسورد" & Environment.NewLine & "Must enter the Username and Password")
        Return
      End If
      Dim DT As New DataTable
      DT.Clear()
      DT = ClsLogin_.Login(TxtUser.Text.ToLower(), TxtPass.Text)
      If DT.Rows.Count > 0 Then
        My.Settings.Usercode = DT.Rows(0)(1)
        My.Settings.Username = DT.Rows(0)(2)
      Else
        MessageBox.Show("خطأ فى اليوزر او الباسورد")
      End If
      If LoginCheck.Checked Then
        Dim MAC As String = String.Empty
        Dim NICS() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        For i As Integer = 0 To NICS.Length - 1
          If NICS(i).GetPhysicalAddress.ToString() <> String.Empty Then
            MAC += NICS(i).GetPhysicalAddress.ToString()
          End If
        Next
        ClsLogin_.LoginInformation(My.Settings.Usercode, MAC)
      End If
      Dim f As New FrmMain
      f.Show()
      Me.Hide()
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub
End Class
