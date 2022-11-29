<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_idclient = New System.Windows.Forms.TextBox()
        Me.txt_nomclient = New System.Windows.Forms.TextBox()
        Me.txt_teleclient = New System.Windows.Forms.TextBox()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.txt_noteclient = New System.Windows.Forms.TextBox()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Enregistre = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_emailclient = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_adressclient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(11, 377)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1126, 180)
        Me.ListView1.TabIndex = 41
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ref_Client"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom_Client"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Adresse_Client"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tele_client"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Note_client"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email_client"
        Me.ColumnHeader6.Width = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.txt_idclient)
        Me.Panel1.Controls.Add(Me.txt_nomclient)
        Me.Panel1.Controls.Add(Me.txt_teleclient)
        Me.Panel1.Controls.Add(Me.Supprimer)
        Me.Panel1.Controls.Add(Me.Modifier)
        Me.Panel1.Controls.Add(Me.txt_noteclient)
        Me.Panel1.Controls.Add(Me.Nouveau)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Enregistre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_emailclient)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_adressclient)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(345, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 363)
        Me.Panel1.TabIndex = 40
        '
        'txt_idclient
        '
        Me.txt_idclient.Location = New System.Drawing.Point(154, 15)
        Me.txt_idclient.Name = "txt_idclient"
        Me.txt_idclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_idclient.TabIndex = 32
        '
        'txt_nomclient
        '
        Me.txt_nomclient.Location = New System.Drawing.Point(154, 64)
        Me.txt_nomclient.Name = "txt_nomclient"
        Me.txt_nomclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_nomclient.TabIndex = 31
        '
        'txt_teleclient
        '
        Me.txt_teleclient.Location = New System.Drawing.Point(154, 160)
        Me.txt_teleclient.Name = "txt_teleclient"
        Me.txt_teleclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_teleclient.TabIndex = 30
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
        'txt_noteclient
        '
        Me.txt_noteclient.Location = New System.Drawing.Point(154, 250)
        Me.txt_noteclient.Name = "txt_noteclient"
        Me.txt_noteclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_noteclient.TabIndex = 27
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
        Me.Label6.Location = New System.Drawing.Point(25, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Note_client"
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
        Me.Label5.Location = New System.Drawing.Point(27, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tele_client"
        '
        'txt_emailclient
        '
        Me.txt_emailclient.Location = New System.Drawing.Point(154, 205)
        Me.txt_emailclient.Name = "txt_emailclient"
        Me.txt_emailclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_emailclient.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email_client"
        '
        'txt_adressclient
        '
        Me.txt_adressclient.Location = New System.Drawing.Point(154, 111)
        Me.txt_adressclient.Name = "txt_adressclient"
        Me.txt_adressclient.Size = New System.Drawing.Size(203, 20)
        Me.txt_adressclient.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(27, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Adresse_client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(27, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nom_client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(27, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ref_client"
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1148, 565)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "client"
        Me.Text = "client"
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
    Friend WithEvents txt_idclient As TextBox
    Friend WithEvents txt_nomclient As TextBox
    Friend WithEvents txt_teleclient As TextBox
    Friend WithEvents Supprimer As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents txt_noteclient As TextBox
    Friend WithEvents Nouveau As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Enregistre As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_emailclient As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_adressclient As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
