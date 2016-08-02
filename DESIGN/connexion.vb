Public Class connexion

    Private Sub connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ribfr.ForeColor = Color.Gray
        ribfr.Text = "Relevé d'identité bancaire"
        passfr.ForeColor = Color.Gray
        passfr.Text = " Mot de Passe"
        lbhuitchif.Visible = False
        lbmdpinco.Visible = False
        lbveuillez.Visible = False
        Btok.Visible = False
        lbribinexi.Visible = False


    End Sub

    Private Sub connexion_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        If Tunisia_Bank_.fr.Checked = True Then


            ribfr.ForeColor = Color.Gray
            ribfr.Text = "Relevé d'identité bancaire"
            passfr.ForeColor = Color.Gray
            passfr.Text = " Mot de Passe"
        Else
            ribfr.ForeColor = Color.Gray

            passfr.ForeColor = Color.Gray
            ribfr.Text = "Bank Identifier Number "

            passfr.Text = " Password"
        End If
        passfr.PasswordChar = ""

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles con.Click

        If (passfr.Text = "") Or (ribfr.Text = "") Or (passfr.Text = " Mot de passe") Or (ribfr.Text = "Relevé d'identité bancaire") Then
            lbhuitchif.Visible = False
            lbmdpinco.Visible = False
            lbveuillez.Visible = True
            Btok.Visible = True
            passfr.Visible = False
            ribfr.Visible = False
            con.Visible = False
            lbribinexi.Visible = False
        ElseIf (IsNumeric(ribfr.Text) = False) Then
            lbhuitchif.Visible = True
            lbmdpinco.Visible = False
            lbveuillez.Visible = False
            Btok.Visible = True
            passfr.Visible = False
            ribfr.Visible = False
            con.Visible = False
            lbribinexi.Visible = False

        Else

            Try
                Dim test As New operation()
                If test.verif_connection(ribfr.Text, passfr.Text) = "o" Then

                    Me.Hide()
                    If Tunisia_Bank_.en.Checked = True Then
                        Acceuil.Show()
                        Acceuil.Text = "Home"
                        Acceuil.lbtranen.Visible = True
                        Acceuil.lbcurconv.Visible = True
                        Acceuil.lbproen.Visible = True
                        Acceuil.lbbankstat.Visible = True
                        Acceuil.profil.Text = "Profile"
                        Acceuil.lbNoun.Text = "First name :"
                        Acceuil.lbnomen.Text = "Last name :"
                        Acceuil.lbsoldeen.Text = "Balance :"
                        Acceuil.gbextraitbancaire.Text = "Bank Statement"


                        Acceuil.virement.Text = "Transfer"
                        Acceuil.C_Virement.Text = "Transfer Code"
                        Acceuil.gbconv.Text = "Currency Converter"



                    Else
                        Acceuil.Show()
                        Acceuil.lbtranen.Visible = False
                        Acceuil.lbcurconv.Visible = False
                        Acceuil.lbproen.Visible = False
                        Acceuil.lbbankstat.Visible = False
                    End If

                ElseIf test.verif_connection(ribfr.Text, passfr.Text) = "n" Then

                    lbhuitchif.Visible = False
                    lbmdpinco.Visible = True
                    lbveuillez.Visible = False
                    Btok.Visible = True
                    passfr.Visible = False
                    ribfr.Visible = False
                    con.Visible = False
                    lbribinexi.Visible = False
                ElseIf test.verif_connection(ribfr.Text, passfr.Text) = "x" Then
                    lbhuitchif.Visible = False 
                    lbmdpinco.Visible = False
                    lbveuillez.Visible = False
                    Btok.Visible = True
                    passfr.Visible = False
                    ribfr.Visible = False
                    con.Visible = False
                    lbribinexi.Visible = True


                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)

            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        Me.Hide()
        Tunisia_Bank_.Show()
    End Sub

    

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub passfr_TextChanged_1(sender As Object, e As EventArgs) Handles passfr.Click
        passfr.ForeColor = Color.White
        passfr.Text = ""
        passfr.PasswordChar = "*"
    End Sub

    Private Sub btdeco_en_Click(sender As Object, e As EventArgs) Handles btdeco_en.Click
        Me.Close()
    End Sub

    Private Sub Btok_Click(sender As Object, e As EventArgs) Handles Btok.Click
        ribfr.ForeColor = Color.Gray

        passfr.ForeColor = Color.Gray
        If Tunisia_Bank_.fr.Checked = True Then


            ribfr.Text = "Relevé d'identité bancaire"

            passfr.Text = " Mot de Passe"
        ElseIf Tunisia_Bank_.en.Checked = True Then

            ribfr.Text = "Bank Identifier Number "

            passfr.Text = " Password"
        End If

        con.Visible = True
        ribfr.Visible = True
        passfr.Visible = True
        lbmdpinco.Visible = False
        lbhuitchif.Visible = False
        lbveuillez.Visible = False
        lbribinexi.Visible = False

        passfr.PasswordChar = ""
        Btok.Visible = False
    End Sub



    Private Sub ribfr_Click(sender As Object, e As EventArgs) Handles ribfr.Click
        ribfr.ForeColor = Color.White
        ribfr.Text = ""
    End Sub


End Class