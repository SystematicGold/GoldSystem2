﻿Public Class FrmAddCat
    Dim ClsItem As New ClsGoldItem
    Dim counter As Integer = 0
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If ComStone.Text = String.Empty Then
                MessageBox.Show("يجب اختيار الفصوص")
                Return
            End If
            If TxtStoneWeight.Text = String.Empty Or TxtStoneWeight.Text = 0 Then
                MessageBox.Show("يجب ادخال الوزن")
                Return
            End If
            If TxtStonePrice.Text = String.Empty Or TxtStonePrice.Text = 0 Then
                MessageBox.Show("يجب ادخال السعر")
                Return
            End If
            counter += 1
            Dim row As String() = New String() {ComStone.SelectedValue, counter,
                                                  ComStone.Text,
                                                  TxtStoneWeight.Text,
                                                  TxtStoneColor.Text, TxtStonePrice.Text}
            DgvStone.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtStoneWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStoneWeight.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtStonePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStonePrice.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComStone_DropDown(sender As Object, e As EventArgs) Handles ComStone.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsItem.Stone()
            If DT.Rows.Count > 0 Then
                ComStone.DataSource = DT
                ComStone.DisplayMember = "Name"
                ComStone.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim f As New FrmAdderItem
            f.TxtCode.Text = TxtCode.Text
            f.TxtBarCode.Text = TxtBarCode.Text
            f.ShowDialog()
            If f.IsYes = True Then
                Dim row As String() = New String() {f.TxtBarCode.Text,
                                                 f.TxtName.Text,
                                                 f.ComKart.SelectedValue,
                                                 f.TxtWeight.Text,
                                                 f.TxtMade.Text,
                                                 f.TxtCost.Text,
                                                 f.TxtCostGram.Text,
                                                 f.TxtPeace.Text}
                DgvAdderItem.Rows.Add(row)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
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
    Private Sub DgvStone_AllowUserToAddRowsChanged(sender As Object, e As EventArgs) Handles DgvStone.AllowUserToAddRowsChanged
        Try
            'For i As Integer = 0 To 
        Catch ex As Exception

        End Try
    End Sub
End Class