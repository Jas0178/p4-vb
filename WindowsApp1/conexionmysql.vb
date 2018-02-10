Imports MySql.Data.MySqlClient
Imports System.Data


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


    Public Sub guardar(mo As proalm)

        Dim strl As String = "guardar"
        cmd = New MySqlCommand(strl, con)
        Try


            con.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("pe", mo.pe)
            cmd.Parameters.AddWithValue("po", mo.po)
            cmd.Parameters.AddWithValue("prac", mo.pract)
            cmd.Parameters.AddWithValue("valores", mo.valores)
            cmd.Parameters.AddWithValue("prue", mo.prue)
            cmd.Parameters.AddWithValue("nota", mo.nota)
            cmd.Parameters.AddWithValue("resul", mo.resul)
            cmd.Parameters.AddWithValue("lit", mo.lit)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As MySqlException

            MsgBox("Ha ocurrido un error!  " + ex.Message)


        End Try







    End Sub










End Class



