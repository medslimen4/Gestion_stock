Imports System.Data.SqlClient
Public Class fournisseurs
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from fournisseurs"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("nom_fourn"))
            listems.SubItems.Add(dr("adresse_fourn"))
            listems.SubItems.Add(dr("tele_fourn"))
            listems.SubItems.Add(dr("note_fourn"))
            listems.SubItems.Add(dr("email_fourn"))
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub fournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_idfourn.Text = Nothing Or txt_nomfourn.Text = Nothing Or txt_adressfourn.Text = Nothing Or txt_telefourn.Text = Nothing Or txt_emailfourn.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into fournisseurs values('" & txt_idfourn.Text & "','" & txt_nomfourn.Text & "','" & txt_adressfourn.Text & "','" & txt_telefourn.Text & "','" & txt_notefourn.Text & "','" & txt_emailfourn.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_idfourn.Text = Nothing
        txt_nomfourn.Text = Nothing
        txt_adressfourn.Text = Nothing
        txt_telefourn.Text = Nothing
        txt_emailfourn.Text = Nothing
        txt_notefourn.Text = Nothing

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un fournisseur!")
        Else
            cn.Open()
            cmd.CommandText = " select * from fournisseurs where id_fourn='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idfourn.Text = dr.Item(0).ToString
                Me.txt_nomfourn.Text = dr.Item(1).ToString
                Me.txt_adressfourn.Text = dr.Item(2).ToString
                Me.txt_telefourn.Text = dr.Item(3).ToString
                Me.txt_emailfourn.Text = dr.Item(5).ToString
                Me.txt_notefourn.Text = dr.Item(4).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        If txt_idfourn.Text = Nothing Or txt_nomfourn.Text = Nothing Or txt_adressfourn.Text = Nothing Or txt_telefourn.Text = Nothing Or txt_emailfourn.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
        If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cn.Open()
                cmd.CommandText = " update fournisseurs set nom_fourn = '" & txt_nomfourn.Text & "', adresse_fourn = '" & txt_adressfourn.Text & "', tele_fourn = '" & txt_telefourn.Text & "', note_fourn = '" & txt_notefourn.Text & "', email_fourn = '" & txt_emailfourn.Text & "' where id_fourn = '" & txt_idfourn.Text & "'"
                cmd.ExecuteNonQuery()
            MsgBox("Modifier Avec Succès")
            cn.Close()
            Afficher()

        End If
        End If
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_idfourn.Text = Nothing Then
            MsgBox("veuillez remplir id_fournisseur pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from fournisseurs where id_fourn='" & txt_idfourn.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("supprision Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub
End Class