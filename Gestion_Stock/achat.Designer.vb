<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class achat
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_qte = New System.Windows.Forms.Label()
        Me.lbl_prod = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_rech = New System.Windows.Forms.TextBox()
        Me.combo_rech = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.date_ach = New System.Windows.Forms.DateTimePicker()
        Me.txt_idprod = New System.Windows.Forms.TextBox()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.txt_noteach = New System.Windows.Forms.TextBox()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_iduser = New System.Windows.Forms.TextBox()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Enregistre = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_idfourn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qteach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idachat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_qte)
        Me.Panel3.Controls.Add(Me.lbl_prod)
        Me.Panel3.Controls.Add(Me.total)
        Me.Panel3.Location = New System.Drawing.Point(465, 270)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 49)
        Me.Panel3.TabIndex = 37
        '
        'lbl_qte
        '
        Me.lbl_qte.Location = New System.Drawing.Point(187, 15)
        Me.lbl_qte.Name = "lbl_qte"
        Me.lbl_qte.Size = New System.Drawing.Size(143, 23)
        Me.lbl_qte.TabIndex = 35
        Me.lbl_qte.Text = "Label12"
        '
        'lbl_prod
        '
        Me.lbl_prod.Location = New System.Drawing.Point(336, 15)
        Me.lbl_prod.Name = "lbl_prod"
        Me.lbl_prod.Size = New System.Drawing.Size(136, 14)
        Me.lbl_prod.TabIndex = 36
        Me.lbl_prod.Text = "Label13"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(27, 15)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(153, 23)
        Me.total.TabIndex = 34
        Me.total.Text = "Label11"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_rech)
        Me.Panel2.Controls.Add(Me.combo_rech)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(465, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 46)
        Me.Panel2.TabIndex = 36
        '
        'txt_rech
        '
        Me.txt_rech.Location = New System.Drawing.Point(292, 18)
        Me.txt_rech.Name = "txt_rech"
        Me.txt_rech.Size = New System.Drawing.Size(145, 20)
        Me.txt_rech.TabIndex = 33
        '
        'combo_rech
        '
        Me.combo_rech.FormattingEnabled = True
        Me.combo_rech.Items.AddRange(New Object() {"id_achat", "date_achat", "qte_achat", "id_prod" & Global.Microsoft.VisualBasic.ChrW(9), "id_fourn", "id_user", "note_achat"})
        Me.combo_rech.Location = New System.Drawing.Point(128, 17)
        Me.combo_rech.Name = "combo_rech"
        Me.combo_rech.Size = New System.Drawing.Size(140, 21)
        Me.combo_rech.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Rechercher par :"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(11, 377)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1126, 180)
        Me.ListView1.TabIndex = 35
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ref_achat"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "date_achat"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantité_achat"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ref_produit"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ref_fournisseur"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ref_user"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "note_achat"
        Me.ColumnHeader7.Width = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.date_ach)
        Me.Panel1.Controls.Add(Me.txt_idprod)
        Me.Panel1.Controls.Add(Me.Supprimer)
        Me.Panel1.Controls.Add(Me.txt_noteach)
        Me.Panel1.Controls.Add(Me.Modifier)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_iduser)
        Me.Panel1.Controls.Add(Me.Nouveau)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Enregistre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_idfourn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_qteach)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_idachat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(11, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 363)
        Me.Panel1.TabIndex = 34
        '
        'date_ach
        '
        Me.date_ach.CustomFormat = "yyyy/MM/dd"
        Me.date_ach.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_ach.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_ach.Location = New System.Drawing.Point(129, 56)
        Me.date_ach.Name = "date_ach"
        Me.date_ach.Size = New System.Drawing.Size(203, 24)
        Me.date_ach.TabIndex = 31
        '
        'txt_idprod
        '
        Me.txt_idprod.Location = New System.Drawing.Point(129, 148)
        Me.txt_idprod.Name = "txt_idprod"
        Me.txt_idprod.Size = New System.Drawing.Size(203, 20)
        Me.txt_idprod.TabIndex = 30
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.Color.Red
        Me.Supprimer.Location = New System.Drawing.Point(307, 321)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(87, 38)
        Me.Supprimer.TabIndex = 21
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'txt_noteach
        '
        Me.txt_noteach.Location = New System.Drawing.Point(129, 278)
        Me.txt_noteach.Name = "txt_noteach"
        Me.txt_noteach.Size = New System.Drawing.Size(203, 20)
        Me.txt_noteach.TabIndex = 29
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.Color.Yellow
        Me.Modifier.Location = New System.Drawing.Point(209, 321)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(87, 38)
        Me.Modifier.TabIndex = 20
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(29, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Note_achat"
        '
        'txt_iduser
        '
        Me.txt_iduser.Enabled = False
        Me.txt_iduser.Location = New System.Drawing.Point(129, 231)
        Me.txt_iduser.Name = "txt_iduser"
        Me.txt_iduser.Size = New System.Drawing.Size(203, 20)
        Me.txt_iduser.TabIndex = 27
        '
        'Nouveau
        '
        Me.Nouveau.BackColor = System.Drawing.Color.Lime
        Me.Nouveau.Location = New System.Drawing.Point(19, 321)
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
        Me.Label6.Location = New System.Drawing.Point(29, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Ref_user"
        '
        'Enregistre
        '
        Me.Enregistre.BackColor = System.Drawing.Color.Blue
        Me.Enregistre.ForeColor = System.Drawing.Color.Black
        Me.Enregistre.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Enregistre.Location = New System.Drawing.Point(113, 321)
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
        Me.Label5.Location = New System.Drawing.Point(27, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Ref_produit"
        '
        'txt_idfourn
        '
        Me.txt_idfourn.Location = New System.Drawing.Point(129, 191)
        Me.txt_idfourn.Name = "txt_idfourn"
        Me.txt_idfourn.Size = New System.Drawing.Size(203, 20)
        Me.txt_idfourn.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Ref_fournisseur"
        '
        'txt_qteach
        '
        Me.txt_qteach.Location = New System.Drawing.Point(129, 106)
        Me.txt_qteach.Name = "txt_qteach"
        Me.txt_qteach.Size = New System.Drawing.Size(203, 20)
        Me.txt_qteach.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Quantité_achat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Date_achat"
        '
        'txt_idachat
        '
        Me.txt_idachat.Location = New System.Drawing.Point(129, 15)
        Me.txt_idachat.Name = "txt_idachat"
        Me.txt_idachat.Size = New System.Drawing.Size(203, 20)
        Me.txt_idachat.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ref_achat"
        '
        'achat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 565)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "achat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "achat"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_qte As Label
    Friend WithEvents lbl_prod As Label
    Friend WithEvents total As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_rech As TextBox
    Friend WithEvents combo_rech As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Supprimer As Button
    Friend WithEvents txt_noteach As TextBox
    Friend WithEvents Modifier As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_iduser As TextBox
    Friend WithEvents Nouveau As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Enregistre As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_idfourn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qteach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idachat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_ach As DateTimePicker
    Friend WithEvents txt_idprod As TextBox
End Class
