Public Class test
    Public Function verification(ch As String) As Boolean
        Dim ok As Boolean = False
        If (ch = "") Then
            MsgBox("Veuillez remplir les champs")

        Else
            ok = True
        End If
        Return ok
    End Function
End Class
