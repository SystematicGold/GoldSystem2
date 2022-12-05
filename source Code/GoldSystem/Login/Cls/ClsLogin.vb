Public Class ClsLogin
  Public Function Login(UserCode As String, Password As String)
    Dim Con As New ClsConnectionString
    Dim DT As New DataTable
    DT.Clear()
    DT = Con.SELECT_TXT("SELECT * FROM Users where Username = '" & UserCode & "' and Password = '" & Password & "'")
    Return DT
  End Function
  Public Sub LoginInformation(user As Integer, mac As String)
    Dim Con As New ClsConnectionString
    Con.EXECUTE_TXT("UPDATE Users SET MacNumber = '" & mac & "', SavedLogin = 1 where UserCode = " & user & "")
  End Sub
  Public Function CheckInformation(mac As String)
    Dim Con As New ClsConnectionString
    Dim DT As New DataTable
    DT.Clear()
    DT = Con.SELECT_TXT("SELECT UserCode, Username, SavedLogin FROM Users where MacNumber = '" & mac & "'")
    Return DT
  End Function
End Class
