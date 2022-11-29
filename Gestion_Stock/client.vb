Imports System.Data.SqlClient
Public Class client
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from client"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_client"))
            listems.SubItems.Add(dr("nom_client"))
            listems.SubItems.Add(dr("adresse_client"))
            listems.SubItems.Add(dr("tele_client"))
            listems.SubItems.Add(dr("note_client"))
            listems.SubItems.Add(dr("email_client"))
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_idclient.Text = Nothing Or txt_nomclient.Text = Nothing Or txt_adressclient.Text = Nothing Or txt_teleclient.Text = Nothing Or txt_emailclient.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into client values('" & txt_idclient.Text & "','" & txt_nomclient.Text & "','" & txt_adressclient.Text & "','" & txt_teleclient.Text & "','" & txt_noteclient.Text & "','" & txt_emailclient.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_idclient.Text = Nothing
        txt_nomclient.Text = Nothing
        txt_adressclient.Text = Nothing
        txt_teleclient.Text = Nothing
        txt_emailclient.Text = Nothing
        txt_noteclient.Text = Nothing

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Client!")
        Else
            cn.Open()
            cmd.CommandText = " select * from client where id_client='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idclient.Text = dr.Item(0).ToString
                Me.txt_nomclient.Text = dr.Item(1).ToString
                Me.txt_adressclient.Text = dr.Item(2).ToString
                Me.txt_teleclient.Text = dr.Item(3).ToString
                Me.txt_emailclient.Text = dr.Item(5).ToString
                Me.txt_noteclient.Text = dr.Item(4).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        If txt_idclient.Text = Nothing Or txt_nomclient.Text = Nothing Or txt_adressclient.Text = Nothing Or txt_teleclient.Text = Nothing Or txt_emailclient.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " update client set nom_client = '" & txt_nomclient.Text & "', adresse_client = '" & txt_adressclient.Text & "', tele_client = '" & txt_teleclient.Text & "', note_client = '" & txt_noteclient.Text & "', email_client = '" & txt_emailclient.Text & "' where id_client = '" & txt_idclient.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Modifier Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_idclient.Text = Nothing Then
            MsgBox("veuillez remplir id_client pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from client where id_client='" & txt_idclient.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("supprision Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub
End Class