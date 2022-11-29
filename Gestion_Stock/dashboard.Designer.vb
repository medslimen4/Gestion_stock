<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_nomadmin = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.img_admin = New System.Windows.Forms.PictureBox()
        Me.img_client = New System.Windows.Forms.PictureBox()
        Me.img_fourn = New System.Windows.Forms.PictureBox()
        Me.img_produit = New System.Windows.Forms.PictureBox()
        Me.img_vente = New System.Windows.Forms.PictureBox()
        Me.img_achat = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.img_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_client, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_fourn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_produit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_vente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_achat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_nomadmin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(1246, 103)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Stock.My.Resources.Resources.seDéconnecter
        Me.PictureBox1.Location = New System.Drawing.Point(1082, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(505, 39)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(58, 16)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "Label1"
        '
        'lbl_nomadmin
        '
        Me.lbl_nomadmin.AutoSize = True
        Me.lbl_nomadmin.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nomadmin.ForeColor = System.Drawing.Color.White
        Me.lbl_nomadmin.Location = New System.Drawing.Point(845, 33)
        Me.lbl_nomadmin.Name = "lbl_nomadmin"
        Me.lbl_nomadmin.Size = New System.Drawing.Size(63, 22)
        Me.lbl_nomadmin.TabIndex = 9
        Me.lbl_nomadmin.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1246, 447)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.img_admin)
        Me.Panel3.Controls.Add(Me.img_client)
        Me.Panel3.Controls.Add(Me.img_fourn)
        Me.Panel3.Controls.Add(Me.img_produit)
        Me.Panel3.Controls.Add(Me.img_vente)
        Me.Panel3.Controls.Add(Me.img_achat)
        Me.Panel3.Location = New System.Drawing.Point(110, 24)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(996, 410)
        Me.Panel3.TabIndex = 0
        '
        'img_admin
        '
        Me.img_admin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_admin.Image = Global.Gestion_Stock.My.Resources.Resources.admin
        Me.img_admin.Location = New System.Drawing.Point(651, 228)
        Me.img_admin.Name = "img_admin"
        Me.img_admin.Size = New System.Drawing.Size(170, 150)
        Me.img_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_admin.TabIndex = 7
        Me.img_admin.TabStop = False
        '
        'img_client
        '
        Me.img_client.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_client.Image = Global.Gestion_Stock.My.Resources.Resources.client
        Me.img_client.Location = New System.Drawing.Point(418, 228)
        Me.img_client.Name = "img_client"
        Me.img_client.Size = New System.Drawing.Size(170, 150)
        Me.img_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_client.TabIndex = 6
        Me.img_client.TabStop = False
        '
        'img_fourn
        '
        Me.img_fourn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_fourn.Image = Global.Gestion_Stock.My.Resources.Resources.Fournisseur
        Me.img_fourn.Location = New System.Drawing.Point(185, 228)
        Me.img_fourn.Name = "img_fourn"
        Me.img_fourn.Size = New System.Drawing.Size(170, 150)
        Me.img_fourn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fourn.TabIndex = 5
        Me.img_fourn.TabStop = False
        '
        'img_produit
        '
        Me.img_produit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_produit.Image = Global.Gestion_Stock.My.Resources.Resources.prod
        Me.img_produit.Location = New System.Drawing.Point(651, 36)
        Me.img_produit.Name = "img_produit"
        Me.img_produit.Size = New System.Drawing.Size(170, 150)
        Me.img_produit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produit.TabIndex = 4
        Me.img_produit.TabStop = False
        '
        'img_vente
        '
        Me.img_vente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_vente.Image = Global.Gestion_Stock.My.Resources.Resources.vente__1_
        Me.img_vente.Location = New System.Drawing.Point(418, 36)
        Me.img_vente.Name = "img_vente"
        Me.img_vente.Size = New System.Drawing.Size(170, 150)
        Me.img_vente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_vente.TabIndex = 3
        Me.img_vente.TabStop = False
        '
        'img_achat
        '
        Me.img_achat.BackColor = System.Drawing.Color.White
        Me.img_achat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_achat.Cursor = System.Windows.Forms.Cursors.Default
        Me.img_achat.Image = Global.Gestion_Stock.My.Resources.Resources.achat
        Me.img_achat.Location = New System.Drawing.Point(185, 36)
        Me.img_achat.Name = "img_achat"
        Me.img_achat.Size = New System.Drawing.Size(170, 150)
        Me.img_achat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_achat.TabIndex = 2
        Me.img_achat.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Gestion_Stock.My.Resources.Resources.logoen
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 550)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.img_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_client, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_fourn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_produit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_vente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_achat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents img_achat As PictureBox
    Friend WithEvents img_admin As PictureBox
    Friend WithEvents img_client As PictureBox
    Friend WithEvents img_fourn As PictureBox
    Friend WithEvents img_produit As PictureBox
    Friend WithEvents img_vente As PictureBox
    Friend WithEvents lbl_nomadmin As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
