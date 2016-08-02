<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tunisia_Bank_
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tunisia_Bank_))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.en = New System.Windows.Forms.RadioButton()
        Me.fr = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please choose your language "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(322, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Merci de choisir votre langue"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(248, 233)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "ok"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'en
        '
        Me.en.AutoSize = True
        Me.en.BackColor = System.Drawing.Color.Transparent
        Me.en.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.en.ForeColor = System.Drawing.Color.White
        Me.en.Location = New System.Drawing.Point(125, 129)
        Me.en.Name = "en"
        Me.en.Size = New System.Drawing.Size(117, 33)
        Me.en.TabIndex = 8
        Me.en.TabStop = True
        Me.en.Text = "English "
        Me.en.UseVisualStyleBackColor = False
        '
        'fr
        '
        Me.fr.AutoSize = True
        Me.fr.BackColor = System.Drawing.Color.Transparent
        Me.fr.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fr.ForeColor = System.Drawing.Color.White
        Me.fr.Location = New System.Drawing.Point(125, 168)
        Me.fr.Name = "fr"
        Me.fr.Size = New System.Drawing.Size(123, 33)
        Me.fr.TabIndex = 9
        Me.fr.TabStop = True
        Me.fr.Text = "Français"
        Me.fr.UseVisualStyleBackColor = False
        '
        'Tunisia_Bank_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(366, 291)
        Me.Controls.Add(Me.fr)
        Me.Controls.Add(Me.en)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tunisia_Bank_"
        Me.Text = "Tunisia_Bank_"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents en As RadioButton
    Friend WithEvents fr As RadioButton
End Class
