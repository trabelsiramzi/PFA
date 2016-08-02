Imports System.Data
Imports Oracle.ManagedDataAccess.Types
Imports Oracle.ManagedDataAccess.Client
Public Class connecte
    Dim XE As String = "Data Source=XE;User Id=system;Password=system;"
    Public conn As New OracleConnection(XE)
    Public Sub connecter()
        conn.Open()
    End Sub
    Public Sub diconnect()
        conn.Dispose()

    End Sub
    Public Sub input(cmd1 As OracleCommand, variable As String, valeur As String)
        cmd1.Parameters.Add(variable, OracleDbType.NVarchar2, 90).Direction = ParameterDirection.Input
        cmd1.Parameters(variable).Value = valeur
    End Sub
    Public Sub return_parm(cmd1 As OracleCommand, variable As String)
        cmd1.Parameters.Add(variable, OracleDbType.NVarchar2, 10).Direction = ParameterDirection.ReturnValue
    End Sub
    Public Sub inputd(cmd1 As OracleCommand, variable As String, valeur As String)
        cmd1.Parameters.Add(variable, OracleDbType.Date).Direction = ParameterDirection.Input
        cmd1.Parameters(variable).Value = valeur
    End Sub
    Public Sub inputn(cmd1 As OracleCommand, variable As String, valeur As Integer)
        cmd1.Parameters.Add(variable, OracleDbType.Decimal, 10).Direction = ParameterDirection.Input
        cmd1.Parameters(variable).Value = valeur
    End Sub

    Public Sub output(cmd As OracleCommand, variable As String)
        cmd.Parameters.Add(variable, OracleDbType.NVarchar2, 10).Direction = ParameterDirection.Output
    End Sub
    Public Sub output_cursor(myCMD As OracleCommand, variable As String)
        myCMD.Parameters.Add(New OracleParameter(variable, OracleDbType.RefCursor)).Direction = ParameterDirection.Output
    End Sub
    Public Function validation(ch As String, ch1 As String) As Boolean

        Dim v As Boolean = False
        If (String.Compare(ch, ch1) = 0) Then
            v = True

        End If
        Return v
    End Function
End Class
