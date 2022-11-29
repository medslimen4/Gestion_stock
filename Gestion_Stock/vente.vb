Imports System.Data.SqlClient
Public Class vente
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand
    Public dr3 As SqlDataReader
    Public cmd3 As New SqlCommand
    Public dr4 As SqlDataReader
    Public cmd4 As New SqlCommand

    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from vente"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_vente"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("payer_nonpayer"))
            listems.SubItems.Add(dr("methode_paiement"))
            listems.SubItems.Add(dr("profit"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_user"))
            listems.SubItems.Add(dr("note_vente"))
        End While
        dr.Close()
        Dim str2 As String = "select count(*),sum(qte_vente),sum(profit) from vente "
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre des ventes : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "Total Quantité : " & dr2.Item(1).ToString
        Me.lbl_profit.Text = "Profit : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()

    End Sub
    Private Sub vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
        txt_iduser.Text = connection.id_user

    End Sub

    Private Sub txt_idprod_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_idprod.KeyUp

        Dim achatx As Integer = 0
        Dim ventex As Integer = 0
        Dim x As Integer = 0

        cn.Open()
        Dim str2 As String = "select pu_prod,prix_vente from produits where id_prod='" & txt_idprod.Text & "'"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            txt_prixprod.Text = dr2.Item(0)
            txt_prixvente.Text = dr2.Item(1)
        Else
            txt_prixprod.Text = 0
            txt_prixvente.Text = 0
        End If
        dr2.Close()
        Dim Str3 As String = " select COALESCE(sum(COALESCE(qte_achat,0)),0) from achat where id_prod='" & txt_idprod.Text & "'"
        cmd2 = New SqlCommand(Str3, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            achatx = Val(dr2.Item(0).ToString)
            dr2.Close()
        End If
        Dim Str4 As String = " select COALESCE(sum(COALESCE(qte_vente,0)),0) from vente where id_prod='" & txt_idprod.Text & "'"
        cmd2 = New SqlCommand(Str4, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            ventex = Val(dr2.Item(0).ToString)
            dr2.Close()
        End If
        stock.Text = Nothing
        stock.Text = achatx - ventex

        cn.Close()
    End Sub

    Private Sub txt_qtevente_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_qtevente.KeyUp
        If (txt_prixprod.Text = Nothing Or txt_prixvente.Text = Nothing Or txt_qtevente.Text = Nothing) Then
            txt_profit.Text = ""
        Else
            txt_profit.Text = (txt_prixvente.Text - txt_prixprod.Text) * txt_qtevente.Text
        End If
        If (Val(stock.Text) < Val(txt_qtevente.Text)) Then
            txt_s.Text = "Hors Stock !"
        Else
            txt_s.Text = ""

        End If

    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_idvente.Text = Nothing
        txt_idprod.Text = Nothing
        txt_prixprod.Text = Nothing
        txt_prixvente.Text = Nothing
        txt_profit.Text = Nothing
        txt_qtevente.Text = Nothing
        txt_idclient.Text = Nothing
        Combo_pnp.Text = Nothing
        Combo_paim.Text = Nothing
        date_vente.Text = Date.Now
        txt_notevent.Text = Nothing
        stock.Text = Nothing

    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_idvente.Text = Nothing Or txt_idprod.Text = Nothing Or txt_prixprod.Text = Nothing Or txt_prixvente.Text = Nothing Or txt_profit.Text = Nothing Or txt_qtevente.Text = Nothing Or txt_idclient.Text = Nothing Or txt_iduser.Text = Nothing Or Combo_pnp.Text = Nothing Or Combo_paim.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into vente values('" & txt_idvente.Text & "','" & date_vente.Text & "','" & txt_qtevente.Text & "','" & txt_prixprod.Text & "','" & txt_prixvente.Text & "','" & Combo_pnp.Text & "','" & txt_profit.Text & "','" & txt_idprod.Text & "','" & txt_idclient.Text & "','" & txt_iduser.Text & "','" & txt_notevent.Text & "','" & Combo_paim.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click

        If txt_idvente.Text = Nothing Or txt_idprod.Text = Nothing Or txt_prixprod.Text = Nothing Or txt_prixvente.Text = Nothing Or txt_profit.Text = Nothing Or txt_qtevente.Text = Nothing Or txt_idclient.Text = Nothing Or txt_iduser.Text = Nothing Or Combo_pnp.Text = Nothing Or Combo_paim.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " update vente set date_vente = '" & date_vente.Text & "', qte_vente = '" & txt_qtevente.Text & "', pu_achat = '" & txt_prixprod.Text & "', pu_vente = '" & txt_prixvente.Text & "', payer_nonpayer = '" & Combo_pnp.Text & "', profit = '" & txt_profit.Text & "', id_prod = '" & txt_idprod.Text & "', id_client = '" & txt_idclient.Text & "', id_user = '" & txt_iduser.Text & "', note_vente = '" & txt_notevent.Text & "', methode_paiement = '" & Combo_paim.Text & "' where id_vente = '" & txt_idvente.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Modifier Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit!")
        Else
            cn.Open()
            cmd.CommandText = " select * from vente where id_vente='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idvente.Text = dr.Item(0).ToString
                Me.date_vente.Text = dr.Item(1).ToString
                Me.txt_qtevente.Text = dr.Item(2).ToString
                Me.txt_prixprod.Text = dr.Item(3).ToString
                Me.txt_prixvente.Text = dr.Item(4).ToString
                Me.Combo_pnp.Text = dr.Item(5).ToString
                Me.txt_profit.Text = dr.Item(6).ToString
                Me.txt_idprod.Text = dr.Item(7).ToString
                Me.txt_idclient.Text = dr.Item(8).ToString
                Me.txt_iduser.Text = dr.Item(9).ToString
                Me.txt_notevent.Text = dr.Item(10).ToString
                Me.Combo_paim.Text = dr.Item(11).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_idvente.Text = Nothing Then
            MsgBox("veuillez remplir id_vente pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from vente where id_vente='" & txt_idvente.Text & "'"
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
        Dim str As String = "select * from vente where " & combo_rech.Text & " like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rech.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_vente"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("payer_nonpayer"))
            listems.SubItems.Add(dr("methode_paiement"))
            listems.SubItems.Add(dr("profit"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_user"))
            listems.SubItems.Add(dr("note_vente"))
        End While
        dr.Close()
        Dim str2 As String = "select count(*),sum(qte_vente),sum(profit)from vente where " & combo_rech.Text & " like '%' + @1 + '%'"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre des ventes : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "Total Quantité : " & dr2.Item(1).ToString
        Me.lbl_profit.Text = "Profit : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()
    End Sub

    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rech.TextChanged
        txt_rech.Text = Nothing
        txt_rech.Focus()
    End Sub


End Class