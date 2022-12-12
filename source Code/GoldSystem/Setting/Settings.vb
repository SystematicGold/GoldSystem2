Module Settings
    Public Sub NumberOnly(sender As Object, e As KeyPressEventArgs)
        Try
            If Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub TextBoxEnter(txt As TextBox)
        If txt.Text = 0 Then
            txt.Text = String.Empty
        Else
        End If
    End Sub
    Public Sub TextBoxLeave(txt As TextBox)
        If txt.Text = String.Empty Then
            txt.Text = 0
        Else
        End If
    End Sub
End Module
