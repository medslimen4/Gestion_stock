Imports System.Data.SqlClient

Public Class login

    Public dr As SqlDataReader
    Public cmd As New SqlCommand
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        If txt_username.Text = Nothing Or txt_password.Text = Nothing Then
            MsgBox("veuillez remplir tous les champs pour connecter")
        Else
            cn.Open()
            Dim str As String = "select * from users where username='" & txt_username.Text & "'and password_user = '" & txt_password.Text & "'"
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                connection.id_user = dr.Item("id_user").ToString
                connection.nom_user = dr.Item("nom_user").ToString
                connection.prenom_user = dr.Item("prenom_user").ToString

                dashboard.Show()
                dr.Close()
                cn.Close()
                Me.Hide()
            Else
                MsgBox("nom d'utilisateur ou mot de passe incorrect !")
                dr.Close()
                cn.Close()
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub
End Class