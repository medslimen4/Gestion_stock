<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_noteuser = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Combo_typeuser = New System.Windows.Forms.ComboBox()
        Me.txt_iduser = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.txt_teleuser = New System.Windows.Forms.TextBox()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Enregistre = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(11, 377)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1126, 180)
        Me.ListView1.TabIndex = 43
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ref_User"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mot de passe"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nom"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prenom"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tele_user"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type_user"
        Me.ColumnHeader7.Width = 88
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Note_user"
        Me.ColumnHeader8.Width = 102
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_noteuser)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Combo_typeuser)
        Me.Panel1.Controls.Add(Me.txt_iduser)
        Me.Panel1.Controls.Add(Me.txt_username)
        Me.Panel1.Controls.Add(Me.txt_nom)
        Me.Panel1.Controls.Add(Me.Supprimer)
        Me.Panel1.Controls.Add(Me.Modifier)
        Me.Panel1.Controls.Add(Me.txt_teleuser)
        Me.Panel1.Controls.Add(Me.Nouveau)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Enregistre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_prenom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(251, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 363)
        Me.Panel1.TabIndex = 42
        '
        'txt_noteuser
        '
        Me.txt_noteuser.Location = New System.Drawing.Point(435, 131)
        Me.txt_noteuser.Name = "txt_noteuser"
        Me.txt_noteuser.Size = New System.Drawing.Size(203, 20)
        Me.txt_noteuser.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(344, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Note_user"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(343, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Type_user"
        '
        'Combo_typeuser
        '
        Me.Combo_typeuser.FormattingEnabled = True
        Me.Combo_typeuser.Items.AddRange(New Object() {"Directeur ", "Ouvrier", "Visiteur "})
        Me.Combo_typeuser.Location = New System.Drawing.Point(435, 80)
        Me.Combo_typeuser.Name = "Combo_typeuser"
        Me.Combo_typeuser.Size = New System.Drawing.Size(203, 21)
        Me.Combo_typeuser.TabIndex = 44
        '
        'txt_iduser
        '
        Me.txt_iduser.Location = New System.Drawing.Point(110, 15)
        Me.txt_iduser.Name = "txt_iduser"
        Me.txt_iduser.Size = New System.Drawing.Size(203, 20)
        Me.txt_iduser.TabIndex = 32
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(110, 64)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(203, 20)
        Me.txt_username.TabIndex = 31
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(110, 156)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(203, 20)
        Me.txt_nom.TabIndex = 30
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.Color.Red
        Me.Supprimer.Location = New System.Drawing.Point(462, 276)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(87, 38)
        Me.Supprimer.TabIndex = 21
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.Color.Yellow
        Me.Modifier.Location = New System.Drawing.Point(364, 276)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(87, 38)
        Me.Modifier.TabIndex = 20
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'txt_teleuser
        '
        Me.txt_teleuser.Location = New System.Drawing.Point(435, 21)
        Me.txt_teleuser.Name = "txt_teleuser"
        Me.txt_teleuser.Size = New System.Drawing.Size(203, 20)
        Me.txt_teleuser.TabIndex = 27
        '
        'Nouveau
        '
        Me.Nouveau.BackColor = System.Drawing.Color.Lime
        Me.Nouveau.Location = New System.Drawing.Point(174, 276)
        Me.Nouveau.Name = "Nouveau"
        Me.Nouveau.Size = New System.Drawing.Size(87, 38)
        Me.Nouveau.TabIndex = 18
        Me.Nouveau.Text = "Nouveau"
        Me.Nouveau.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(344, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tele_user"
        '
        'Enregistre
        '
        Me.Enregistre.BackColor = System.Drawing.Color.Blue
        Me.Enregistre.ForeColor = System.Drawing.Color.Black
        Me.Enregistre.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Enregistre.Location = New System.Drawing.Point(268, 276)
        Me.Enregistre.Name = "Enregistre"
        Me.Enregistre.Size = New System.Drawing.Size(87, 38)
        Me.Enregistre.TabIndex = 19
        Me.Enregistre.Text = "Enregistré"
        Me.Enregistre.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(27, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Nom"
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(110, 205)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(203, 20)
        Me.txt_prenom.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Prenom"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(110, 111)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(203, 20)
        Me.txt_password.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(21, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Mot de passe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ref_user"
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 565)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_iduser As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Supprimer As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents txt_teleuser As TextBox
    Friend WithEvents Nouveau As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Enregistre As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_noteuser As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Combo_typeuser As ComboBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
