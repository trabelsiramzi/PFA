Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Oracle.ManagedDataAccess.Types
'Géré les operation sur la base de donnée
Public Class operation
    Public ribnumber As String = connexion.ribfr.Text
    Public Function nombanque(rib As String)
        Dim con As New connecte
        Dim vrib As Integer = CInt(rib)
        con.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = con.conn
        con.return_parm(cmd, "vnomb")

        con.input(cmd, "RIBB", vrib)
        cmd.CommandText = "nombanque"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Return cmd.Parameters("vnomb").Value.ToString

    End Function
    Public Function retourcodevirement(rib As String) As String
        Dim cdvirement As String
        Dim con As New connecte()
        con.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = con.conn
        con.return_parm(cmd, "codev")
        con.inputn(cmd, "ribb", rib)

        cmd.CommandText = "retourcodevirement"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cdvirement = cmd.Parameters("codev").Value.ToString
        con.diconnect()
        Return cdvirement
    End Function

    Public Function verificationsolde(montant As String) As Boolean
        Dim validesolde As Boolean

        Dim ribb As Integer = CInt(ribnumber)
        Dim vmontant As Integer = CInt(montant)
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.return_parm(cmd, "valide")
        conn.inputn(cmd, "ribb", ribb)
        conn.inputn(cmd, "montant", vmontant)
        cmd.CommandText = "clientp.verificationsolde"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim ch As String = cmd.Parameters("valide").Value.ToString
        validesolde = CBool(ch)
        conn.diconnect()
        Return validesolde
    End Function

    Public Function verif_connection(RIB As String, pass As String) As Char
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.return_parm(cmd, "ok")
        conn.input(cmd, "ribb", RIB)
        conn.input(cmd, "pass", pass)
        cmd.CommandText = "clientp.verife_cl_log"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim resultat As Char = cmd.Parameters("ok").Value.ToString
        conn.diconnect()
        Return resultat
    End Function


    ' fonction qui retour le solde 
    Public Function verif_solde(RIB As String) As Double
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd2 As New OracleCommand
        cmd2.Connection = conn.conn

        conn.output(cmd2, "vsolde")
        conn.input(cmd2, "ribb", RIB)
        cmd2.CommandText = "affiche_solde"
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.ExecuteNonQuery()
        Dim solde_ As Double
        solde_ = cmd2.Parameters("vsolde").Value.ToString
        conn.diconnect()
        Return Convert.ToDouble(solde_)
    End Function

    Public Sub premier_carac(RIB As String)
        Dim con As New connecte
        Try
            con.connecter()
            Dim cmd As New OracleCommand
            cmd.Connection = con.conn
            con.output(cmd, "carc")
            con.input(cmd, "ribb", RIB)
            cmd.CommandText = "clientp.premiercarac"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Acceuil.Labpremcarac.Text = cmd.Parameters("carc").Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.diconnect()
        End Try
    End Sub

    Public Sub cord(RIB As String)
        Dim con As New connecte
        Try
            con.connecter()


            Dim cmd As New OracleCommand
            cmd.Connection = con.conn

            con.output(cmd, "vsolde")
            con.output(cmd, "vnom")
            con.output(cmd, "vprenom")
            con.output(cmd, "vnomb")
            con.input(cmd, "RIBB", RIB)


            cmd.CommandText = "clientp.affiche_cord"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Acceuil.lastname.Text = cmd.Parameters("vnom").Value.ToString
            Acceuil.name1.Text = cmd.Parameters("vprenom").Value.ToString
            Acceuil.balance.Text = cmd.Parameters("vsolde").Value.ToString


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.diconnect()
        End Try
    End Sub
    'virement 
    Public Sub virements(ribd As String, montant As String, ribe As String)
        Dim conn As New connecte()
        conn.connecter()
        Dim rd As Integer = CInt(ribd)
        Dim re As Integer = CInt(ribe)
        Dim mn As Integer = CInt(montant)


        Dim cmd As New OracleCommand()
        cmd.Connection = conn.conn
        conn.inputn(cmd, "vribd", rd)
        conn.inputn(cmd, "vribs", re)
        conn.inputn(cmd, "vmontant", mn)

        cmd.CommandText = "clientp.virement"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        conn.diconnect()

    End Sub
    'function permette d'afficher les operation entre deux date donnée 
    Public Sub extrait(datd As String, datfin As String)

        Acceuil.lbextrait.Items.Clear()
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.input(cmd, "RIBB", connexion.ribfr.Text)
        conn.input(cmd, "date1", datd)
        conn.input(cmd, "date2", datfin)
        conn.output_cursor(cmd, "io_cursor")
        Dim ch1 As String = "retire vers"
        If Tunisia_Bank_.en.Checked Then
            ch1 = "Sent to"
        End If
        cmd.CommandText = "p1.extrait"
        cmd.CommandType = CommandType.StoredProcedure
        Try
            Dim myReader As OracleDataReader

            cmd.ExecuteNonQuery()


            myReader = (cmd.Parameters("io_cursor").Value).GetDataReader()

            If myReader.HasRows Then
                Do While myReader.Read()
                    Dim ch As String = myReader(2) & "|" & ch1 & "|" & myReader(5) & "|" & myReader(6)
                    Acceuil.lbextrait.Items.Add(ch)
                Loop
            Else
                If Tunisia_Bank_.en.Checked = True Then
                    Acceuil.lbextrait.Items.Add("No transaction Founded ")
                    Acceuil.tbdatedeb.Text = "First Date dd/mm/yy"
                    Acceuil.tbdatefin.Text = "First Date dd/mm/yy"
                Else
                    Acceuil.lbextrait.Items.Add("Il n'ya aucune opération à afficher  ")
                    Acceuil.tbdatedeb.Text = "Date Début jj/mm/aa"
                    Acceuil.tbdatefin.Text = "Date fin jj/mm/aa"
                End If
            End If





                myReader.Close()
        Catch myex As Exception
            MsgBox(myex.Message)
        End Try
        conn.diconnect()

    End Sub
    'affiche devis 
    Public Sub affiche_devis(rib As String)
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.input(cmd, "vrib", rib)

        conn.output_cursor(cmd, "io_cursor")
        cmd.CommandText = "devise_ech.affiche_devis"
        cmd.CommandType = CommandType.StoredProcedure
        Try
            Dim myReader As OracleDataReader

            cmd.ExecuteNonQuery()


            myReader = (cmd.Parameters("io_cursor").Value).GetDataReader()

            If myReader.HasRows Then
                myReader.Read()
                Acceuil.usdta.Text = myReader(2)
                Acceuil.usdtv.Text = myReader(3)
                myReader.Read()
                Acceuil.eurta.Text = myReader(2)
                Acceuil.eurtv.Text = myReader(3)
                myReader.Read()
                Acceuil.jpyta.Text = myReader(2)
                Acceuil.jpytv.Text = myReader(3)
                myReader.Read()
                Acceuil.gbpta.Text = myReader(2)
                Acceuil.gbptv.Text = myReader(3)
            End If





            myReader.Close()
        Catch myex As Exception
            MsgBox(myex.Message)
        End Try
    End Sub
    Public Sub ajoutavis(BIC As String, tdesc As String)
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.input(cmd, "VBIC", BIC)
        conn.input(cmd, "vdesc", tdesc)

        cmd.CommandText = "ajouteravis"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        conn.diconnect()
    End Sub
    Public Function retbic(RIB As String) As String
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.input(cmd, "vrib", RIB)
        conn.output(cmd, "tbic")

        cmd.CommandText = "retbic"
        cmd.CommandType = CommandType.StoredProcedure

        cmd.ExecuteNonQuery()
        Dim resultat As String = cmd.Parameters("tbic").Value.ToString
        conn.diconnect()
        Return resultat
    End Function
    Public Sub calcule_devis(RIB As String)
        Dim montant As Integer = CInt(Acceuil.tbtnd.Text)
        Dim conn As New connecte()
        conn.connecter()
        Dim cmd As New OracleCommand
        cmd.Connection = conn.conn
        conn.input(cmd, "vrib", RIB)
        conn.output_cursor(cmd, "io_cursor")
        cmd.CommandText = "devise_ech.affiche_devis"
        cmd.CommandType = CommandType.StoredProcedure
        Try
            Dim myReader As OracleDataReader

            cmd.ExecuteNonQuery()


            myReader = (cmd.Parameters("io_cursor").Value).GetDataReader()

            If myReader.HasRows Then
                myReader.Read()
                Acceuil.tbusd.Text = montant * myReader(2)
                myReader.Read()
                Acceuil.tbeuro.Text = montant * myReader(2)
                myReader.Read()
                Acceuil.tbjpy.Text = montant * myReader(2)
                myReader.Read()
                Acceuil.tbgbp.Text = montant * myReader(2)


            End If





            myReader.Close()
        Catch myex As Exception
            MsgBox(myex.Message)
        End Try
    End Sub
End Class

