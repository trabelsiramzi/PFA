Public Class Tunisia_Banks_
    Public ch1 As String = "Excellente Application"
    Public ch2 As String = "Moyenne Application"


    Private Sub Tunisia_Banks__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbthankvisit.Visible = False
        lbmercivisit.Visible = False
        btokmauvais.Visible = False
        tbavismauvais.Visible = False
        lbdemavisen.Visible = True
        lbdemavisf.Visible = True
        tbavismauvais.Text = " Please write what you didn't appreciate in Tunisia Bank$
Veuillez saisir qu'est ce qui nous n'avez pas plu dans cette application   "
        tbavismauvais.ForeColor = Color.Gray

    End Sub

    Private Sub btbad_Click(sender As Object, e As EventArgs) Handles btbad.Click
        btokmauvais.Visible = True
        tbavismauvais.Visible = True
        btbad.Visible = True
        btmoy.Visible = False
        btgood.Visible = False


    End Sub

    Private Sub tbavismauvais_TextChanged(sender As Object, e As EventArgs) Handles tbavismauvais.Click
        tbavismauvais.Text = ""
        tbavismauvais.ForeColor = Color.Black
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub



    Private Sub btgood_Click(sender As Object, e As EventArgs) Handles btgood.Click
        btbad.Visible = False
        btmoy.Visible = False
        btgood.Visible = False
        lbthankvisit.Visible = True
        lbmercivisit.Visible = True
        lbdemavisen.Visible = False
        lbdemavisf.Visible = False
        Dim x As New operation
        Dim x1 As New operation
        Dim h As String
        h = x1.retbic(connexion.ribfr.Text)
        x.ajoutavis(h, ch1)


    End Sub

    Private Sub btmoy_Click(sender As Object, e As EventArgs) Handles btmoy.Click
        btbad.Visible = False
        btmoy.Visible = False
        btgood.Visible = False
        lbthankvisit.Visible = True
        lbmercivisit.Visible = True
        lbdemavisen.Visible = False
        lbdemavisf.Visible = False
        Dim x As New operation
        Dim x1 As New operation
        Dim h As String
        h = x1.retbic(connexion.ribfr.Text)
        x.ajoutavis(h, ch2)
    End Sub

    Private Sub btokmauvais_Click(sender As Object, e As EventArgs) Handles btokmauvais.Click
        Dim ch3 As String = "Mauvaise Application"
        Dim x As New operation

        If tbavismauvais.Text = " Please write what you didn't appreciate in Tunisia Bank$
Veuillez saisir qu'est ce qui nous n'avez pas plu dans cette application   " Then
            tbavismauvais.Text = ""
            Dim l As String
            ch3 = ch3 + tbavismauvais.Text
            l = x.retbic(connexion.ribfr.Text)
            x.ajoutavis(l, ch3)
        Else
            Dim h As String
            ch3 = ch3 & " : " & tbavismauvais.Text
            h = x.retbic(connexion.ribfr.Text)
            x.ajoutavis(h, ch3)
        End If
        btokmauvais.Visible = False
        tbavismauvais.Visible = False
        btbad.Visible = False
        lbthankvisit.Visible = True
        lbmercivisit.Visible = True
        lbdemavisen.Visible = False
        lbdemavisf.Visible = False
    End Sub
End Class