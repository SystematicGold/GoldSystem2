Public Class FrmAdderItem
    Dim ClsItem As New ClsGoldItem
    Public IsYes = False
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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            IsYes = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCostGram.KeyPress, TxtCost.KeyPress, TxtMade.KeyPress, TxtWeight.KeyPress, TxtPeace.KeyPress
        Try
            NumberOnly(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TextBox5_Enter(sender As Object, e As EventArgs) Handles TxtWeight.Enter
        Try
            TextBoxEnter(TxtWeight)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TxtWeight.Leave
        Try
            TextBoxLeave(TxtWeight)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtMade_Enter(sender As Object, e As EventArgs) Handles TxtMade.Enter
        Try
            TextBoxEnter(TxtMade)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtMade_Leave(sender As Object, e As EventArgs) Handles TxtMade.Leave
        Try
            TextBoxLeave(TxtMade)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtCost_Enter(sender As Object, e As EventArgs) Handles TxtCost.Enter
        Try
            TextBoxEnter(TxtCost)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtCost_Leave(sender As Object, e As EventArgs) Handles TxtCost.Leave
        Try
            TextBoxLeave(TxtCost)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtCostGram_Enter(sender As Object, e As EventArgs) Handles TxtCostGram.Enter
        Try
            TextBoxEnter(TxtCostGram)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtCostGram_Leave(sender As Object, e As EventArgs) Handles TxtCostGram.Leave
        Try
            TextBoxLeave(TxtCostGram)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtPeace_Enter(sender As Object, e As EventArgs) Handles TxtPeace.Enter
        Try
            TextBoxEnter(TxtPeace)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtPeace_Leave(sender As Object, e As EventArgs) Handles TxtPeace.Leave
        Try
            TextBoxLeave(TxtPeace)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class