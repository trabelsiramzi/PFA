<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connexion))
        Me.retour = New System.Windows.Forms.Button()
        Me.btdeco_en = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passfr = New System.Windows.Forms.TextBox()
        Me.con = New System.Windows.Forms.Button()
        Me.lbhuitchif = New System.Windows.Forms.Label()
        Me.lbmdpinco = New System.Windows.Forms.Label()
        Me.lbveuillez = New System.Windows.Forms.Label()
        Me.Btok = New System.Windows.Forms.Button()
        Me.lbribinexi = New System.Windows.Forms.Label()
        Me.ribfr = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'retour
        '
        Me.retour.BackColor = System.Drawing.Color.Transparent
        Me.retour.FlatAppearance.BorderSize = 0
        Me.retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.retour.ForeColor = System.Drawing.Color.Transparent
        Me.retour.Image = CType(resources.GetObject("retour.Image"), System.Drawing.Image)
        Me.retour.Location = New System.Drawing.Point(3, 3)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(47, 42)
        Me.retour.TabIndex = 6
        Me.retour.UseVisualStyleBackColor = False
        '
        'btdeco_en
        '
        Me.btdeco_en.BackColor = System.Drawing.Color.Transparent
        Me.btdeco_en.BackgroundImage = CType(resources.GetObject("btdeco_en.BackgroundImage"), System.Drawing.Image)
        Me.btdeco_en.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btdeco_en.Location = New System.Drawing.Point(12, 556)
        Me.btdeco_en.Name = "btdeco_en"
        Me.btdeco_en.Size = New System.Drawing.Size(56, 50)
        Me.btdeco_en.TabIndex = 19
        Me.btdeco_en.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 253)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'passfr
        '
        Me.passfr.AccessibleDescription = ""
        Me.passfr.BackColor = System.Drawing.Color.Silver
        Me.passfr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passfr.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passfr.ForeColor = System.Drawing.Color.White
        Me.passfr.Location = New System.Drawing.Point(141, 450)
        Me.passfr.Name = "passfr"
        Me.passfr.Size = New System.Drawing.Size(291, 32)
        Me.passfr.TabIndex = 21
        Me.passfr.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'con
        '
        Me.con.BackColor = System.Drawing.SystemColors.Control
        Me.con.BackgroundImage = CType(resources.GetObject("con.BackgroundImage"), System.Drawing.Image)
        Me.con.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.con.ForeColor = System.Drawing.SystemColors.Control
        Me.con.Location = New System.Drawing.Point(397, 450)
        Me.con.Name = "con"
        Me.con.Size = New System.Drawing.Size(35, 32)
        Me.con.TabIndex = 22
        Me.con.UseVisualStyleBackColor = False
        '
        'lbhuitchif
        '
        Me.lbhuitchif.AutoSize = True
        Me.lbhuitchif.BackColor = System.Drawing.Color.Transparent
        Me.lbhuitchif.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhuitchif.ForeColor = System.Drawing.Color.Transparent
        Me.lbhuitchif.Location = New System.Drawing.Point(105, 418)
        Me.lbhuitchif.Name = "lbhuitchif"
        Me.lbhuitchif.Size = New System.Drawing.Size(376, 29)
        Me.lbhuitchif.TabIndex = 23
        Me.lbhuitchif.Text = "Le RIB doit comporter des chiffres"
        '
        'lbmdpinco
        '
        Me.lbmdpinco.AutoSize = True
        Me.lbmdpinco.BackColor = System.Drawing.Color.Transparent
        Me.lbmdpinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmdpinco.ForeColor = System.Drawing.Color.Transparent
        Me.lbmdpinco.Location = New System.Drawing.Point(152, 418)
        Me.lbmdpinco.Name = "lbmdpinco"
        Me.lbmdpinco.Size = New System.Drawing.Size(257, 29)
        Me.lbmdpinco.TabIndex = 24
        Me.lbmdpinco.Text = "Mot de passe incorrect"
        '
        'lbveuillez
        '
        Me.lbveuillez.AutoSize = True
        Me.lbveuillez.BackColor = System.Drawing.Color.Transparent
        Me.lbveuillez.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbveuillez.ForeColor = System.Drawing.Color.Transparent
        Me.lbveuillez.Location = New System.Drawing.Point(105, 418)
        Me.lbveuillez.Name = "lbveuillez"
        Me.lbveuillez.Size = New System.Drawing.Size(365, 29)
        Me.lbveuillez.TabIndex = 25
        Me.lbveuillez.Text = "Veuillez remplir tous les champs "
        '
        'Btok
        '
        Me.Btok.BackColor = System.Drawing.SystemColors.Control
        Me.Btok.BackgroundImage = CType(resources.GetObject("Btok.BackgroundImage"), System.Drawing.Image)
        Me.Btok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btok.Location = New System.Drawing.Point(246, 498)
        Me.Btok.Name = "Btok"
        Me.Btok.Size = New System.Drawing.Size(99, 40)
        Me.Btok.TabIndex = 26
        Me.Btok.UseVisualStyleBackColor = False
        '
        'lbribinexi
        '
        Me.lbribinexi.AutoSize = True
        Me.lbribinexi.BackColor = System.Drawing.Color.Transparent
        Me.lbribinexi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbribinexi.ForeColor = System.Drawing.Color.Transparent
        Me.lbribinexi.Location = New System.Drawing.Point(208, 418)
        Me.lbribinexi.Name = "lbribinexi"
        Me.lbribinexi.Size = New System.Drawing.Size(158, 29)
        Me.lbribinexi.TabIndex = 28
        Me.lbribinexi.Text = "RIB inexistant"
        '
        'ribfr
        '
        Me.ribfr.AccessibleDescription = ""
        Me.ribfr.BackColor = System.Drawing.Color.Silver
        Me.ribfr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ribfr.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ribfr.ForeColor = System.Drawing.Color.White
        Me.ribfr.Location = New System.Drawing.Point(141, 383)
        Me.ribfr.Name = "ribfr"
        Me.ribfr.Size = New System.Drawing.Size(291, 32)
        Me.ribfr.TabIndex = 29
        Me.ribfr.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(110, 125)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 618)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ribfr)
        Me.Controls.Add(Me.lbribinexi)
        Me.Controls.Add(Me.Btok)
        Me.Controls.Add(Me.con)
        Me.Controls.Add(Me.passfr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btdeco_en)
        Me.Controls.Add(Me.lbhuitchif)
        Me.Controls.Add(Me.lbveuillez)
        Me.Controls.Add(Me.lbmdpinco)
        Me.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "connexion"
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents retour As Button
    Friend WithEvents btdeco_en As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passfr As TextBox
    Friend WithEvents con As Button
    Friend WithEvents lbhuitchif As Label
    Friend WithEvents lbmdpinco As Label
    Friend WithEvents lbveuillez As Label
    Friend WithEvents Btok As Button
    Friend WithEvents lbribinexi As Label
    Friend WithEvents ribfr As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
