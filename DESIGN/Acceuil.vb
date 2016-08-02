Imports System
Imports System.IO
Imports System.Text

Public Class Acceuil
    Shared i As Integer = 1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles B_extrait.Click
        lbveu.Visible = False
        lbveuen.Visible = False
        lbdf.Visible = False
        lbfd.Visible = False
        lbld.Visible = False
        lbfd.Visible = False
        lbdatv.Visible = False
        Btokext.Visible = False
        gbextraitbancaire.Visible = True
        profil.Visible = False
        C_Virement.Visible = False
        virement.Visible = False
        gbconv.Visible = False
        If Tunisia_Bank_.fr.Checked Then


            tbdatedeb.ForeColor = Color.Gray
            tbdatefin.ForeColor = Color.Gray
            tbdatedeb.Text = " Date début jj/mm/aa"
            tbdatefin.Text = " Date fin jj/mm/aa"
        Else tbdatedeb.ForeColor = Color.Gray
            tbdatedeb.Text = " First Date dd/mm/yy"
            tbdatefin.ForeColor = Color.Gray
            tbdatefin.Text = " Last Date dd/mm/yy"

        End If
        lbextrait.Visible = False
        btimprim.Visible = False
        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        gbconv.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_profil.Click
        profil.Visible = True
        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        gbconv.Visible = False
        C_Virement.Visible = False
        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = False
        Dim xs As New operation
        xs.cord(connexion.ribfr.Text)
    End Sub

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim x As New operation
        x.premier_carac(connexion.ribfr.Text)
        '' If x.retbic(connexion.ribfr.Text) = "987654321" Then
        ''logo.BackgroundImage = Image.FromFile("C:\Users\linda\Desktop\lekribyoufa\clientapp\clientapp\biat1.png")

        ''Else
        ''If x.retbic(connexion.ribfr.Text) = "987654322" Then
        ''logo.BackgroundImage = Image.FromFile("C:\Users\linda\Desktop\lekribyoufa\clientapp\clientapp\atb1.png")
        ''If x.retbic(connexion.ribfr.Text) = "987654323" Then
        '' logo.BackgroundImage = Image.FromFile("C:\Users\linda\Desktop\lekribyoufa\clientapp\clientapp\stb1.png")
        '' Else
        ''If x.retbic(connexion.ribfr.Text) = "987654324" Then
        ''logo.BackgroundImage = Image.FromFile("C:\Users\firas\Desktop\7abyoufajedbouhhowa\lekribyoufa\clientapp\clientapp")

        ''Else
        ''If x.retbic(connexion.ribfr.Text) = "987654325" Then
        ''logo.BackgroundImage = Image.FromFile("C:\Users\linda\Desktop\lekribyoufa\clientapp\clientapp\bh1.png")
        ''End If
        ''End If
        ''End If
        ''End If
        ''End If
        profil.Visible = False
        C_Virement.Visible = False
        gbinfos.Visible = False

        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = False
        labdate.Text = Date.Now
        gbConvertisseur.Visible = False
        gbconv.Visible = False

    End Sub

    Private Sub C_Virement_Enter(sender As Object, e As EventArgs) Handles C_Virement.Enter
        virement.Visible = False
        tb_codevirement.Visible = True
    End Sub
    Private Sub C_Virement_Click(sender As Object, e As EventArgs) Handles C_Virement.Click
        If Tunisia_Bank_.fr.Checked = True Then
            tb_codevirement.ForeColor = Color.Gray
            tb_codevirement.Text = " Code de virement"
        Else
            tb_codevirement.ForeColor = Color.Gray
            tb_codevirement.Text = " Transfer Code"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles B_virement.Click
        mtefr.Visible = False
        mteen.Visible = False
        mmribfr.Visible = False
        mmriben.Visible = False
        rien.Visible = False
        rifr.Visible = False
        mvfr.Visible = False
        mven.Visible = False
        sifr.Visible = False
        sien.Visible = False
        btokv.Visible = False




        profil.Visible = False
        C_Virement.Visible = False
        virement.Visible = True
        gbextraitbancaire.Visible = False
        gbconv.Visible = False
        C_Virement.Visible = False

        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        gbconv.Visible = False
        If Tunisia_Bank_.en.Checked = True Then

            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Recipient BAN"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Amount to be sent"
        Else

            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Rib du destinataire"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Montant à envoyer"
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb_codevirement.Click
        tb_codevirement.ForeColor = Color.White
        tb_codevirement.Text = ""
        tb_codevirement.PasswordChar = "*"
    End Sub

    Private Sub ok_c_v_Click(sender As Object, e As EventArgs) Handles ok_c_v.Click


        Dim v As New connecte()
        If (i = 3) Then
            If Tunisia_Bank_.en.Checked = True Then
                troitvfalse.Visible = True
                btokretcon.Visible = True
                tb_codevirement.Visible = False
                ok_c_v.Visible = False
            Else
                troistvfaaux.Visible = True
                btokretcon.Visible = True
                tb_codevirement.Visible = False
                ok_c_v.Visible = False
            End If
            i = 1
        End If

        Dim rc As New operation()

            If v.validation(tb_codevirement.Text, rc.retourcodevirement(connexion.ribfr.Text)) = False Then
                ok_c_v.Visible = False
                If Tunisia_Bank_.en.Checked = True Then
                    ict.Visible = True
                    btokcv.Visible = True
                    tb_codevirement.Visible = False
                Else
                    icfr.Visible = True
                    btokcv.Visible = True
                    tb_codevirement.Visible = False


                End If
                labcv.Text = i.ToString()
                labcv.Visible = True
                tb_codevirement.Text = ""

                i = i + 1

            Else
                ok_c_v.Visible = False

                Dim vc As New operation()
            vc.virements(tbribd.Text, tbmtenv.Text, connexion.ribfr.Text)
            If Tunisia_Bank_.en.Checked = True Then
                    mtsuccen.Visible = True
                    btokcv.Visible = True
                    tb_codevirement.Visible = False
                Else
                    mtsucfr.Visible = True
                    btokcv.Visible = True
                    tb_codevirement.Visible = False


                End If
                i = 1

            End If






    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btextr.Click

        Dim ext As New operation()

        If IsDate(tbdatefin.Text) And IsDate(tbdatefin.Text) Then
            ext.extrait(tbdatedeb.Text, tbdatefin.Text)
            lbextrait.Visible = True
            btimprim.Visible = True
            Btokext.Visible = False
            lbveu.Visible = False
            lbveuen.Visible = False
            lbdf.Visible = False
            lbfd.Visible = False
            lbld.Visible = False
            lbfd.Visible = False
            lbdatv.Visible = False
        ElseIf IsDate(tbdatedeb.Text) = False Then
            If tbdatedeb.Text = "" Then
                If Tunisia_Bank_.fr.Checked = True Then
                    btimprim.Visible = False
                    lbextrait.Visible = False
                    lbdatv.Visible = True
                    Btokext.Visible = True

                Else
                    btimprim.Visible = False
                    lbextrait.Visible = False
                    lbfd.Visible = True
                    Btokext.Visible = True
                End If

            Else
                If Tunisia_Bank_.fr.Checked = True Then
                    btimprim.Visible = False
                    lbextrait.Visible = False
                    lbveu.Visible = True
                    Btokext.Visible = True
                Else
                    btimprim.Visible = False
                    lbextrait.Visible = False
                    lbveuen.Visible = True
                    Btokext.Visible = True
                End If
            End If

            If IsDate(tbdatefin.Text) = False Then
                If tbdatefin.Text = "" Then
                    If Tunisia_Bank_.fr.Checked = True Then
                        btimprim.Visible = False
                        lbextrait.Visible = False
                        lbdf.Visible = True
                        Btokext.Visible = True
                    Else btimprim.Visible = False
                        lbextrait.Visible = False
                        lbld.Visible = True
                        Btokext.Visible = True
                    End If
                Else
                    If Tunisia_Bank_.fr.Checked = True Then
                        btimprim.Visible = False
                        lbextrait.Visible = False
                        lbveu.Visible = True
                        Btokext.Visible = True
                    Else
                        btimprim.Visible = False
                        lbextrait.Visible = False
                        lbveuen.Visible = True
                        Btokext.Visible = True
                    End If
                End If
            End If

        End If



    End Sub



    Private Sub B_conv_Click(sender As Object, e As EventArgs) Handles B_conv.Click
        gbconv.Visible = True
        profil.Visible = False
        C_Virement.Visible = False
        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        If Tunisia_Bank_.en.Checked = True Then
            labconven.Visible = True
        Else
            labconven.Visible = False
        End If

    End Sub



    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tbdatedeb.Click

        tbdatedeb.ForeColor = Color.Black
        tbdatedeb.Text = ""
    End Sub

    Private Sub tbdatefin_TextChanged(sender As Object, e As EventArgs) Handles tbdatefin.Click
        tbdatefin.ForeColor = Color.Black
        tbdatefin.Text = ""
    End Sub

    Private Sub tbribd_TextChanged(sender As Object, e As EventArgs) Handles tbribd.Click
        tbribd.ForeColor = Color.White
        tbribd.Text = ""
    End Sub

    Private Sub tbmtenv_TextChanged(sender As Object, e As EventArgs) Handles tbmtenv.Click
        tbmtenv.ForeColor = Color.White
        tbmtenv.Text = ""
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btdeco.Click
        Me.Close()
        Tunisia_Banks_.Show()
    End Sub

    Private Sub profil_Enter(sender As Object, e As EventArgs) Handles profil.Enter


    End Sub

    Private Sub btenvmt_Click(sender As Object, e As EventArgs) Handles btenvmt.Click
        tb_codevirement.Visible = True
        ok_c_v.Visible = True
        Dim versolde As New operation()
        Dim v As New connecte()
        If (IsNumeric(tbribd.Text) = False) Then
            tbribd.Visible = False
            tbmtenv.Visible = False
            btenvmt.Visible = False
            If Tunisia_Bank_.en.Checked = True Then
                rien.Visible = True
                btokv.Visible = True
            Else
                rifr.Visible = True
                btokv.Visible = True
            End If

        ElseIf v.validation(connexion.ribfr.Text, tbribd.Text) = True Then
            tbribd.Visible = False
            tbmtenv.Visible = False
            btenvmt.Visible = False
            If Tunisia_Bank_.en.Checked = True Then
                mmriben.Visible = True
                btokv.Visible = True

            Else
                mmribfr.Visible = True
                btokv.Visible = True

            End If



        ElseIf (tbmtenv.Text = "") Or (tbmtenv.Text = "Montant à envoyer") Or (tbmtenv.Text = " Recipient BAN") Or (tbmtenv.Text = "0") Then

            If Tunisia_Bank_.en.Checked = True Then
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                mteen.Visible = True
                btokv.Visible = True

            Else
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                mtefr.Visible = True
                btokv.Visible = True
            End If
        ElseIf IsNumeric(tbmtenv.Text) = False Then
            If Tunisia_Bank_.en.Checked = True Then
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                mven.Visible = True
                btokv.Visible = True
            Else
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                mvfr.Visible = True
                btokv.Visible = True
            End If
        ElseIf (versolde.verificationsolde(tbmtenv.Text) = True) Then
            troitvfalse.Visible = False
            troistvfaaux.Visible = False
            btokretcon.Visible = False
            mtsuccen.Visible = False
            btokcv.Visible = False
            mtsucfr.Visible = False
            ict.Visible = False
            icfr.Visible = False
            labcv.Visible = False

            C_Virement.Visible = True
            virement.Visible = False
            If Tunisia_Bank_.fr.Checked = True Then
                tb_codevirement.ForeColor = Color.Gray
                tb_codevirement.Text = " Code de virement"
            Else
                tb_codevirement.ForeColor = Color.Gray
                tb_codevirement.Text = " Transfer Code"
            End If

        Else
            If Tunisia_Bank_.en.Checked = True Then
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                sien.Visible = True
                btokv.Visible = True
            Else
                tbribd.Visible = False
                tbmtenv.Visible = False
                btenvmt.Visible = False
                sifr.Visible = True
                btokv.Visible = True
            End If
        End If




    End Sub

    Private Sub btinf_Click(sender As Object, e As EventArgs) Handles btinf.Click
        gbinfos.Visible = True
        gbConvertisseur.Visible = False
        profil.Visible = False
        C_Virement.Visible = False
        If Tunisia_Bank_.en.Checked = True Then
            lbta.Text = "Buying Rate"
            lbtv.Text = "Selling Rate "
        End If
        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = False
        Dim x As New operation
        x.affiche_devis(connexion.ribfr.Text)

    End Sub

    Private Sub btconv_Click(sender As Object, e As EventArgs) Handles btconv.Click
        gbinfos.Visible = False
        gbConvertisseur.Visible = True
        profil.Visible = False
        C_Virement.Visible = False
        If Tunisia_Bank_.en.Checked = True Then
            gbConvertisseur.Text = "Converter"
        End If


        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = False
    End Sub

    Private Sub btretgbconv_Click(sender As Object, e As EventArgs) Handles btretgbconv.Click
        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        profil.Visible = False
        C_Virement.Visible = False
        gbinfos.Visible = False

        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = True
    End Sub

    Private Sub btretconv_Click(sender As Object, e As EventArgs) Handles btretconv.Click
        gbinfos.Visible = False
        gbConvertisseur.Visible = False
        profil.Visible = False
        C_Virement.Visible = False
        gbinfos.Visible = False

        virement.Visible = False
        gbextraitbancaire.Visible = False
        gbconv.Visible = True
    End Sub

    Private Sub gbConvertisseur_Enter(sender As Object, e As EventArgs) Handles gbConvertisseur.Enter
        tbeuro.Enabled = False
        tbgbp.Enabled = False
        tbjpy.Enabled = False
        tbusd.Enabled = False
    End Sub

    Private Sub btconvert_Click(sender As Object, e As EventArgs) Handles btconvert.Click
        If IsNumeric(tbtnd.Text) Then
            Dim x As New operation
            x.calcule_devis(connexion.ribfr.Text)
        Else
            MsgBox("Il faut saisire une numero")
        End If

    End Sub

    Private Sub gbextraitbancaire_click(sender As Object, e As EventArgs) Handles gbextraitbancaire.Click
        If Tunisia_Bank_.en.Checked = True Then
            tbdatedeb.ForeColor = Color.Gray
            tbdatedeb.Text = " First Date dd/mm/yy"
            tbdatefin.ForeColor = Color.Gray
            tbdatefin.Text = " Last Date dd/mm/yy"

        Else
            tbdatedeb.ForeColor = Color.Gray
            tbdatefin.ForeColor = Color.Gray
            tbdatedeb.Text = " Date début jj/mm/aa"
            tbdatefin.Text = " Date fin jj/mm/aa"
        End If
    End Sub

    Private Sub Btokext_Click(sender As Object, e As EventArgs) Handles Btokext.Click
        lbveu.Visible = False
        lbveuen.Visible = False
        lbdf.Visible = False
        lbfd.Visible = False
        lbld.Visible = False
        lbfd.Visible = False
        Btokext.Visible = False
        lbdatv.Visible = False
        btimprim.Visible = False
        lbextrait.Visible = False
        If Tunisia_Bank_.en.Checked = True Then
            tbdatedeb.ForeColor = Color.Gray
            tbdatedeb.Text = " First Date dd/mm/yy"
            tbdatefin.ForeColor = Color.Gray
            tbdatefin.Text = " Last Date dd/mm/yy"
        Else
            tbdatedeb.ForeColor = Color.Gray
            tbdatefin.ForeColor = Color.Gray
            tbdatedeb.Text = " Date début jj/mm/aa"
            tbdatefin.Text = " Date fin jj/mm/aa"
        End If

    End Sub

    Private Sub virement_Click(sender As Object, e As EventArgs) Handles virement.Click
        If Tunisia_Bank_.en.Checked = True Then
            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Recipient BAN"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Amount to be sent"

        Else
            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Rib du destinataire"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Montant à envoyer"
        End If
    End Sub

    Private Sub btokv_Click(sender As Object, e As EventArgs) Handles btokv.Click

        mtefr.Visible = False
        mteen.Visible = False
        mmribfr.Visible = False
        mmriben.Visible = False
        rien.Visible = False
        rifr.Visible = False
        mvfr.Visible = False
        mven.Visible = False
        sifr.Visible = False
        sien.Visible = False
        btokv.Visible = False
        tbmtenv.Visible = True
        tbribd.Visible = True
        btenvmt.Visible = True
        If Tunisia_Bank_.en.Checked = True Then
            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Recipient BAN"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Amount to be sent"

        Else
            tbribd.ForeColor = Color.Gray
            tbribd.Text = " Rib du destinataire"
            tbmtenv.ForeColor = Color.Gray
            tbmtenv.Text = " Montant à envoyer"
        End If
    End Sub

    Private Sub btokcv_Click(sender As Object, e As EventArgs) Handles btokcv.Click
        If mtsuccen.Visible = True Or mtsucfr.Visible = True Then
            virement.Visible = True
            C_Virement.Visible = False
            If Tunisia_Bank_.fr.Checked = True Then
                tb_codevirement.ForeColor = Color.Gray
                tb_codevirement.Text = " Code de virement"
            Else
                tb_codevirement.ForeColor = Color.Gray
                tb_codevirement.Text = " Transfer Code"
            End If

        End If
        troitvfalse.Visible = False
        troistvfaaux.Visible = False
        mtsuccen.Visible = False
        btokcv.Visible = False
        mtsucfr.Visible = False
        ict.Visible = False
        icfr.Visible = False
        btokretcon.Visible = False
        labcv.Visible = False
        tb_codevirement.Visible = True

        ok_c_v.Visible = True




    End Sub

    Private Sub btokretcon_Click(sender As Object, e As EventArgs) Handles btokretcon.Click


        btokretcon.Visible = False
        Me.Close()
        connexion.Show()
        connexion.ribfr.ForeColor = Color.Gray

        connexion.passfr.ForeColor = Color.Gray
        If Tunisia_Bank_.fr.Checked = True Then


            connexion.ribfr.ForeColor = Color.Gray
            connexion.ribfr.Text = "Relevé d'identité bancaire"
            connexion.passfr.ForeColor = Color.Gray
            connexion.passfr.Text = " Mot de Passe"
        Else
            connexion.Text = "Connection "
            connexion.ribfr.ForeColor = Color.Gray

            connexion.passfr.ForeColor = Color.Gray
            connexion.ribfr.Text = "Bank Identifier Number "

            connexion.passfr.Text = " Password"

        End If
        connexion.lbhuitchif.Visible = False
        connexion.lbmdpinco.Visible = False
        connexion.lbveuillez.Visible = False
        connexion.Btok.Visible = False
        connexion.passfr.PasswordChar = ""
    End Sub

    Private Sub lbcurconv_Click(sender As Object, e As EventArgs) Handles lbcurconv.Click

    End Sub

    Private Sub btimprim_Click(sender As Object, e As EventArgs) Handles btimprim.Click

        Dim ch As String = Date.Now.ToString
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\firas\Desktop\test.text", True)
        file.WriteLine(ch)
        file.WriteLine("                                           ******************************     Extrait Bncaire     ******************************")
        Dim ext As New operation
        ch = "" + ext.nombanque(connexion.ribfr.Text) + "   "
        file.WriteLine(ch)
        Dim i As Integer = 0
        While i < lbextrait.Items.Count
            ch = lbextrait.Items(i)
            file.WriteLine(ch)
            i = i + 1
            ch = ""
        End While

        file.Close()
        Shell("cmd.exe c/ print /d:LPT2: C:\Users\firas\Desktop\test.text ")
        My.Computer.FileSystem.DeleteFile("C:\Users\firas\Desktop\test.text")
        If Tunisia_Bank_.en.Checked = True Then
            MsgBox("Sucess of printing process")
        Else
            MsgBox("Impression effectiuée avec succés ")
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labdate.Text = DateTime.Now.ToString()


    End Sub

    Private Sub tb_codevirement_TextChanged(sender As Object, e As EventArgs) Handles tb_codevirement.TextChanged

    End Sub
End Class