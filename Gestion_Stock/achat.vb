Imports System.Data.SqlClient
Public Class achat
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand
    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from achat"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("id_user"))
            listems.SubItems.Add(dr("note_achat"))
        End While
        dr.Close()
        Dim str2 As String = "select count(*),sum(qte_achat),count(distinct id_prod)from achat"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre des achats : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "total Quantité : " & dr2.Item(1).ToString
        Me.lbl_prod.Text = "Total produit : " & dr2.Item(2).ToString

        dr2.Close()
        cn.Close()
    End Sub

    Private Sub achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
        txt_iduser.Text = connection.id_user
    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_idachat.Text = Nothing Or date_ach.Text = Nothing Or txt_qteach.Text = Nothing Or txt_idprod.Text = Nothing Or txt_idfourn.Text = Nothing Or txt_iduser.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into achat values('" & txt_idachat.Text & "','" & date_ach.Text & "','" & txt_qteach.Text & "','" & txt_idprod.Text & "','" & txt_idfourn.Text & "','" & txt_iduser.Text & "','" & txt_noteach.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_idachat.Text = Nothing
        date_ach.Text = Date.Now
        txt_qteach.Text = Nothing
        txt_idprod.Text = Nothing
        txt_idfourn.Text = Nothing
        txt_noteach.Text = Nothing
        txt_idachat.Focus()

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit!")
        Else
            cn.Open()
            cmd.CommandText = " select * from achat where id_achat='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idachat.Text = dr.Item(0).ToString
                Me.date_ach.Text = dr.Item(1).ToString
                Me.txt_qteach.Text = dr.Item(2).ToString
                Me.txt_idprod.Text = dr.Item(3).ToString
                Me.txt_idfourn.Text = dr.Item(4).ToString
                Me.txt_iduser.Text = dr.Item(5).ToString
                Me.txt_noteach.Text = dr.Item(6).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        If txt_idachat.Text = Nothing Or date_ach.Text = Nothing Or txt_qteach.Text = Nothing Or txt_idprod.Text = Nothing Or txt_idfourn.Text = Nothing Or txt_iduser.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " update achat set date_achat = '" & date_ach.Text & "', qte_achat = '" & txt_qteach.Text & "', id_prod = '" & txt_idprod.Text & "', id_fourn = '" & txt_idfourn.Text & "', id_user = '" & txt_iduser.Text & "', note_achat = '" & txt_noteach.Text & "' where id_achat = '" & txt_idprod.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Modifier Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If

    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_idachat.Text = Nothing Then
            MsgBox("veuillez remplir id_achat pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from achat where id_achat='" & txt_idachat.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("supprision Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub txt_rech_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_rech.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from achat where " & combo_rech.Text & " like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rech.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("id_user"))
            listems.SubItems.Add(dr("note_achat"))
        End While
        dr.Close()
        Dim str2 As String = "select count(*),sum(qte_achat),count(distinct id_prod)from achat where " & combo_rech.Text & " like '%' + @1 + '%'"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre des achats : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "total Quantité : " & dr2.Item(1).ToString
        Me.lbl_prod.Text = "Total produit : " & dr2.Item(2).ToString

        dr2.Close()
        cn.Close()
    End Sub

    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rech.TextChanged
        txt_rech.Text = Nothing
        txt_rech.Focus()
    End Sub
End Class