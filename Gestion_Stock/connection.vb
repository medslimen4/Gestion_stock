Imports System.Data.SqlClient
Module connection
    Public cn As New SqlConnection("Data Source=DESKTOP-V6QHOU2;Initial Catalog=Gestion_Stock;Integrated Security=True")

    Public id_user As Integer
    Public nom_user As String
    Public prenom_user As String
End Module
