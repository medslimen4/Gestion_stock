Imports System.Data.SqlClient
Public Class admin
    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub Afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from users"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While (dr.Read)
            listems = Me.ListView1.Items.Add(dr("id_user"))
            listems.SubItems.Add(dr("username"))
            listems.SubItems.Add(dr("password_user"))
            listems.SubItems.Add(dr("nom_user"))
            listems.SubItems.Add(dr("prenom_user"))
            listems.SubItems.Add(dr("tele_user"))
            listems.SubItems.Add(dr("type_user"))
            listems.SubItems.Add(dr("note_user"))
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Afficher()
    End Sub

    Private Sub Enregistre_Click(sender As Object, e As EventArgs) Handles Enregistre.Click
        If txt_iduser.Text = Nothing Or txt_username.Text = Nothing Or txt_password.Text = Nothing Or txt_nom.Text = Nothing Or txt_prenom.Text = Nothing Or txt_teleuser.Text = Nothing Or Combo_typeuser.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Ajoute?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " insert into users values('" & txt_iduser.Text & "','" & txt_username.Text & "','" & txt_password.Text & "','" & txt_nom.Text & "','" & txt_prenom.Text & "','" & txt_teleuser.Text & "','" & Combo_typeuser.Text & "','" & txt_noteuser.Text & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        txt_iduser.Text = Nothing
        txt_username.Text = Nothing
        txt_password.Text = Nothing
        txt_nom.Text = Nothing
        txt_prenom.Text = Nothing
        txt_teleuser.Text = Nothing
        Combo_typeuser.Text = Nothing
        txt_noteuser.Text = Nothing

    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Admin!")
        Else
            cn.Open()
            cmd.CommandText = " select * from users where id_user='" & ListView1.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_iduser.Text = dr.Item(0).ToString
                Me.txt_username.Text = dr.Item(1).ToString
                Me.txt_password.Text = dr.Item(2).ToString
                Me.txt_nom.Text = dr.Item(3).ToString
                Me.txt_prenom.Text = dr.Item(4).ToString
                Me.txt_teleuser.Text = dr.Item(5).ToString
                Me.Combo_typeuser.Text = dr.Item(6).ToString
                Me.txt_noteuser.Text = dr.Item(7).ToString

                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        If txt_iduser.Text = Nothing Or txt_username.Text = Nothing Or txt_password.Text = Nothing Or txt_nom.Text = Nothing Or txt_prenom.Text = Nothing Or txt_teleuser.Text = Nothing Or Combo_typeuser.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs obligatoires pour sauvegarder")
        Else
            If MsgBox("Voulez Vous  Modifier?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = " update users set username = '" & txt_username.Text & "', password_user = '" & txt_password.Text & "', nom_user = '" & txt_nom.Text & "', prenom_user = '" & txt_prenom.Text & "', tele_user = '" & txt_teleuser.Text & "', type_user = '" & Combo_typeuser.Text & "', note_user = '" & txt_noteuser.Text & "' where id_user = '" & txt_iduser.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Modifier Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If txt_iduser.Text = Nothing Then
            MsgBox("veuillez remplir id_user pour supprimer")
        Else
            If MsgBox("Voulez Vous  supprimer?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Open()
                cmd.CommandText = "delete from users where id_user='" & txt_iduser.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("supprision Avec Succès")
                cn.Close()
                Afficher()

            End If
        End If
    End Sub


End Class