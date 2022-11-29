Public Class dashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now
    End Sub

    Private Sub img_achat_Click(sender As Object, e As EventArgs) Handles img_achat.Click
        achat.Show()
    End Sub

    Private Sub img_vente_Click(sender As Object, e As EventArgs) Handles img_vente.Click
        vente.Show()
    End Sub

    Private Sub img_produit_Click(sender As Object, e As EventArgs) Handles img_produit.Click
        Form1.Show()
    End Sub

    Private Sub img_fourn_Click(sender As Object, e As EventArgs) Handles img_fourn.Click
        fournisseurs.Show()
    End Sub

    Private Sub img_client_Click(sender As Object, e As EventArgs) Handles img_client.Click
        client.Show()
    End Sub

    Private Sub img_admin_Click(sender As Object, e As EventArgs) Handles img_admin.Click
        admin.Show()
    End Sub

    Private Sub img_achat_MouseHover(sender As Object, e As EventArgs) Handles img_achat.MouseHover
        img_achat.Image = My.Resources.achatb
    End Sub

    Private Sub img_achat_MouseLeave(sender As Object, e As EventArgs) Handles img_achat.MouseLeave
        img_achat.Image = My.Resources.achat

    End Sub

    Private Sub img_vente_MouseHover(sender As Object, e As EventArgs) Handles img_vente.MouseHover
        img_vente.Image = My.Resources.venteb

    End Sub

    Private Sub img_vente_MouseLeave(sender As Object, e As EventArgs) Handles img_vente.MouseLeave
        img_vente.Image = My.Resources.vente__1_

    End Sub

    Private Sub img_produit_MouseHover(sender As Object, e As EventArgs) Handles img_produit.MouseHover
        img_produit.Image = My.Resources.prodb

    End Sub

    Private Sub img_produit_MouseLeave(sender As Object, e As EventArgs) Handles img_produit.MouseLeave
        img_produit.Image = My.Resources.prod

    End Sub

    Private Sub img_fourn_MouseHover(sender As Object, e As EventArgs) Handles img_fourn.MouseHover
        img_fourn.Image = My.Resources.Fournisseurb

    End Sub

    Private Sub img_fourn_MouseLeave(sender As Object, e As EventArgs) Handles img_fourn.MouseLeave
        img_fourn.Image = My.Resources.Fournisseur

    End Sub

    Private Sub img_client_MouseHover(sender As Object, e As EventArgs) Handles img_client.MouseHover
        img_client.Image = My.Resources.clientb

    End Sub

    Private Sub img_client_MouseLeave(sender As Object, e As EventArgs) Handles img_client.MouseLeave
        img_client.Image = My.Resources.client

    End Sub

    Private Sub img_admin_MouseHover(sender As Object, e As EventArgs) Handles img_admin.MouseHover
        img_admin.Image = My.Resources.adminb

    End Sub

    Private Sub img_admin_MouseLeave(sender As Object, e As EventArgs) Handles img_admin.MouseLeave
        img_admin.Image = My.Resources.admin

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.seDéconnecterb

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.seDéconnecter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If MsgBox("voulez vous vraiment vous déconnecter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            login.Show()
        End If

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_nomadmin.Text = connection.prenom_user & "" & connection.nom_user
    End Sub

End Class