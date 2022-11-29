<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_codebarre = New System.Windows.Forms.TextBox()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_noteprod = New System.Windows.Forms.TextBox()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Enregistre = New System.Windows.Forms.Button()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_libelle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idprod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_rech = New System.Windows.Forms.TextBox()
        Me.combo_rech = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.max = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_qteachat = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_qtevente = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_enstock = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Supprimer)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_codebarre)
        Me.Panel1.Controls.Add(Me.Modifier)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_noteprod)
        Me.Panel1.Controls.Add(Me.Nouveau)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Enregistre)
        Me.Panel1.Controls.Add(Me.combo_type)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_pv)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_pu)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_libelle)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_idprod)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(27, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 363)
        Me.Panel1.TabIndex = 16
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(296, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "DT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(296, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "DT"
        '
        'txt_codebarre
        '
        Me.txt_codebarre.Location = New System.Drawing.Point(129, 278)
        Me.txt_codebarre.Name = "txt_codebarre"
        Me.txt_codebarre.Size = New System.Drawing.Size(203, 20)
        Me.txt_codebarre.TabIndex = 29
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
        Me.Label7.Text = "Code_Barre"
        '
        'txt_noteprod
        '
        Me.txt_noteprod.Location = New System.Drawing.Point(129, 231)
        Me.txt_noteprod.Name = "txt_noteprod"
        Me.txt_noteprod.Size = New System.Drawing.Size(203, 20)
        Me.txt_noteprod.TabIndex = 27
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
        Me.Label6.Location = New System.Drawing.Point(27, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Note_produit"
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
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Location = New System.Drawing.Point(129, 148)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(203, 21)
        Me.combo_type.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(27, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Type_produit"
        '
        'txt_pv
        '
        Me.txt_pv.Location = New System.Drawing.Point(129, 191)
        Me.txt_pv.Name = "txt_pv"
        Me.txt_pv.Size = New System.Drawing.Size(159, 20)
        Me.txt_pv.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Prix_vente"
        '
        'txt_pu
        '
        Me.txt_pu.Location = New System.Drawing.Point(129, 106)
        Me.txt_pu.Name = "txt_pu"
        Me.txt_pu.Size = New System.Drawing.Size(159, 20)
        Me.txt_pu.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Prix_produit"
        '
        'txt_libelle
        '
        Me.txt_libelle.Location = New System.Drawing.Point(129, 60)
        Me.txt_libelle.Name = "txt_libelle"
        Me.txt_libelle.Size = New System.Drawing.Size(203, 20)
        Me.txt_libelle.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Libelle_produit"
        '
        'txt_idprod
        '
        Me.txt_idprod.Location = New System.Drawing.Point(129, 15)
        Me.txt_idprod.Name = "txt_idprod"
        Me.txt_idprod.Size = New System.Drawing.Size(203, 20)
        Me.txt_idprod.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ref_produit"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(27, 373)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1126, 180)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ref_produit"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Libelle_produit"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prix_produit"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "type_produit"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prix_vente"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Note_produit"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Code_Barre"
        Me.ColumnHeader7.Width = 100
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txt_rech)
        Me.Panel2.Controls.Add(Me.combo_rech)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(481, 321)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 46)
        Me.Panel2.TabIndex = 32
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
        Me.combo_rech.Items.AddRange(New Object() {"id_prod", "libelle_prod", "pu_prod", "type_prod", "prix_vente", "note_prod", "code_barre"})
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
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Rechercher par :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.max)
        Me.Panel3.Controls.Add(Me.min)
        Me.Panel3.Controls.Add(Me.total)
        Me.Panel3.Location = New System.Drawing.Point(481, 266)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(672, 49)
        Me.Panel3.TabIndex = 33
        '
        'max
        '
        Me.max.Location = New System.Drawing.Point(187, 15)
        Me.max.Name = "max"
        Me.max.Size = New System.Drawing.Size(143, 23)
        Me.max.TabIndex = 35
        Me.max.Text = "Label12"
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(336, 15)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(136, 14)
        Me.min.TabIndex = 36
        Me.min.Text = "Label13"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(27, 15)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(153, 23)
        Me.total.TabIndex = 34
        Me.total.Text = "Label11"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_qteachat)
        Me.GroupBox1.Location = New System.Drawing.Point(511, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 66)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qte_Achat"
        '
        'lbl_qteachat
        '
        Me.lbl_qteachat.AutoSize = True
        Me.lbl_qteachat.Location = New System.Drawing.Point(34, 27)
        Me.lbl_qteachat.Name = "lbl_qteachat"
        Me.lbl_qteachat.Size = New System.Drawing.Size(35, 13)
        Me.lbl_qteachat.TabIndex = 0
        Me.lbl_qteachat.Text = "0000"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lbl_qtevente)
        Me.GroupBox2.Location = New System.Drawing.Point(708, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(132, 66)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Qte_Vente"
        '
        'lbl_qtevente
        '
        Me.lbl_qtevente.AutoSize = True
        Me.lbl_qtevente.Location = New System.Drawing.Point(39, 27)
        Me.lbl_qtevente.Name = "lbl_qtevente"
        Me.lbl_qtevente.Size = New System.Drawing.Size(35, 13)
        Me.lbl_qtevente.TabIndex = 1
        Me.lbl_qtevente.Text = "0000"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lbl_enstock)
        Me.GroupBox3.Location = New System.Drawing.Point(898, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 66)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "En Stock"
        '
        'lbl_enstock
        '
        Me.lbl_enstock.AutoSize = True
        Me.lbl_enstock.Location = New System.Drawing.Point(38, 27)
        Me.lbl_enstock.Name = "lbl_enstock"
        Me.lbl_enstock.Size = New System.Drawing.Size(35, 13)
        Me.lbl_enstock.TabIndex = 2
        Me.lbl_enstock.Text = "0000"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 565)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_codebarre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_noteprod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_libelle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idprod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Supprimer As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents Nouveau As Button
    Friend WithEvents Enregistre As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents combo_rech As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_rech As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents max As Label
    Friend WithEvents min As Label
    Friend WithEvents total As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_qteachat As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_qtevente As Label
    Friend WithEvents lbl_enstock As Label
End Class
