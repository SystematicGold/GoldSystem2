Public Class ClsGoldItem
    Public Function Stone()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM StoneCategory order by Code")
        Return DT
    End Function
    Public Function Kart()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM KartItems order by Code")
        Return DT
    End Function
End Class
