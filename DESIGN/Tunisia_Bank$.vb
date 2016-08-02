Public Class Tunisia_Bank_
    Private Sub Tunisia_Bank__Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If fr.Checked = True Then
            connexion.Show()
            Me.Hide()
        End If
        If en.Checked = True Then

            connexion.Text = "Connection"
            connexion.Show()
            connexion.ribfr.ForeColor = Color.Gray
            connexion.ribfr.Text = "Bank Identifier Number "
            connexion.passfr.ForeColor = Color.Gray
            connexion.passfr.Text = " Password"
            connexion.lbhuitchif.Text = "You have to write 8 digits "
            connexion.lbveuillez.Text = "You should fill all the fields "
            connexion.lbmdpinco.Text = " Wrong Password "
            connexion.lbribinexi.Text = "BAN does not exist"
            Me.Hide()
        End If
    End Sub
End Class