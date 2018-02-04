Imports MySql.Data.MySqlClient
Public Class conexionmysql
    Private MysqlCommand As New MySqlCommand
    Dim cmd As MySqlCommand
    Dim cnx As String = "server=localhost; database = notas; user id= root ; password=genobreaker66"
    Public con As MySqlConnection = New MySqlConnection(cnx)

    Public Sub Probarconexion()
        Try
            con.Open()
            MsgBox("la conexión fue exitosa")
            con.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub

    Public Sub insert(sql As String)
        Try
            con.Open()
            MysqlCommand = New MySqlCommand(sql, con)
            MysqlCommand.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error!  " + ex.Message)
        End Try


    End Sub










End Class



