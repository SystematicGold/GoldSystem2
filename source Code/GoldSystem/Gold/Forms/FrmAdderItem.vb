Public Class FrmAdderItem
    Dim ClsItem As New ClsGoldItem
    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComKart.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsItem.Kart()
            If DT.Rows.Count > 0 Then
                ComKart.DataSource = DT
                ComKart.DisplayMember = "Name"
                ComKart.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class