Imports System.Data.SqlClient
Public Class Form1
    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand
    Public dr3 As SqlDataReader
    Public cmd3 As New SqlCommand
    Public id As ArrayList

    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle_prod"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("type_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_barre"))
        End While
        dr.Close()

        Dim str2 As String = "select count(*) as total , max(pu_prod) as maxpu , min(pu_prod) as minpu from produits"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre de produits : " & dr2.Item(0).ToString
        Me.max.Text = "max prix_u : " & dr2.Item(1).ToString
        Me.min.Text = "min prix_u : " & dr2.Item(2).ToString

        dr2.Close()

        cn.Close()
    End Sub
    Private Sub type()
        cn.Open()
        Dim Str As String = "select distinct type_prod from produits"
        cmd = New SqlCommand(Str, cn)
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.combo_type.Items.Add(dr("type_prod")).ToString()
        End While

        dr.Close()
        cn.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
        type()


    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_idprod.Text = Nothing Or txt_libelle.Text = Nothing Or txt_pu.Text = Nothing Or combo_type.Text = Nothing Or txt_pv.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into produits values('" & txt_idprod.Text & "','" & txt_libelle.Text & "','" & txt_pu.Text & "','" & combo_type.Text & "','" & txt_pv.Text & "','" & txt_noteprod.Text & "','" & txt_codebarre.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
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
            cmd.CommandText = " select * from produits where id_prod='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idprod.Text = dr.Item(0).ToString
                Me.txt_libelle.Text = dr.Item(1).ToString
                Me.txt_pu.Text = dr.Item(2).ToString
                Me.txt_pu.Text = Replace(txt_pu.Text, ",", ".")
                Me.combo_type.Text = dr.Item(3).ToString
                Me.txt_pv.Text = dr.Item(4).ToString
                Me.txt_pv.Text = Replace(txt_pv.Text, ",", ".")
                Me.txt_noteprod.Text = dr.Item(5).ToString
                Me.txt_codebarre.Text = dr.Item(6).ToString
                dr.Close()
            End If
            Dim Str2 As String = " select COALESCE(sum(COALESCE(qte_achat,0)),0) from achat where id_prod='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd2 = New SqlCommand(Str2, cn)
            dr2 = cmd2.ExecuteReader
            If dr2.Read Then
                lbl_qteachat.Text = dr2.Item(0).ToString
                dr2.Close()
            End If
            Dim Str3 As String = " select COALESCE(sum(COALESCE(qte_vente,0)),0) from vente where id_prod='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd3 = New SqlCommand(Str3, cn)
            dr3 = cmd3.ExecuteReader
            If dr3.Read Then
                lbl_qtevente.Text = dr3.Item(0).ToString
                dr3.Close()
            End If

            lbl_enstock.Text = lbl_qteachat.Text - lbl_qtevente.Text

            cn.Close()
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        If txt_idprod.Text = Nothing Or txt_libelle.Text = Nothing Or txt_pu.Text = Nothing Or combo_type.Text = Nothing Or txt_pv.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour modifier")
        Else
            If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " update produits set libelle_prod = '" & txt_libelle.Text & "', pu_prod = '" & txt_pu.Text & "', type_prod = '" & combo_type.Text & "', prix_vente = '" & txt_pv.Text & "', note_prod = '" & txt_noteprod.Text & "', code_barre = '" & txt_codebarre.Text & "' where id_prod = '" & txt_idprod.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Modifier Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If

    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_idprod.Text = Nothing Then
            MsgBox("veuillez remplir id_prod pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from produits where id_prod='" & txt_idprod.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("supprision Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If

    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_idprod.Text = Nothing
        txt_libelle.Text = Nothing
        txt_pu.Text = Nothing
        combo_type.Text = Nothing
        txt_pv.Text = Nothing
        txt_noteprod.Text = Nothing
        txt_codebarre.Text = Nothing


        txt_idprod.Focus()

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_rech.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from produits where " & combo_rech.Text & " like '%' + @1 + '%' "
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rech.Text)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle_prod"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("type_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_barre"))
        End While
        dr.Close()
        Dim str2 As String = "select count(*) as total , max(pu_prod) as maxpu , min(pu_prod) as minpu from produits where " & combo_rech.Text & " like '%' + @1 + '%'"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.total.Text = "Nombre de produits : " & dr2.Item(0).ToString
        Me.max.Text = "max prix_u : " & dr2.Item(1).ToString
        Me.min.Text = "min prix_u : " & dr2.Item(2).ToString

        dr2.Close()
        cn.Close()
    End Sub

    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rech.TextChanged
        txt_rech.Text = Nothing
        txt_rech.Focus()
    End Sub


End Class

