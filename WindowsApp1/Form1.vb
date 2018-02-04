Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim uapa As claseuapa = New claseuapa
        txtnot.Text = uapa.nota(Val(txtpe.Text), Val(txtpo.Text), Val(txtprac.Text), Val(txtval.Text), Val(txtprue.Text))
        txtres.Text = uapa.resultado(Val(txtnot.Text))
        txtlit.Text = uapa.literal(Val(txtnot.Text))



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim cnx As String = "server=localhost; database = notas; user id= root; password=genobreaker66;"

        Dim con As New MySqlConnection(cnx)
        Dim sqli As String = "insert into calificacion(pe,po,prac,valores,prue,nota,resul,literal)values(@pe,@po,@prac,@valores,@prue,@nota,@resul,@literal)"
        Dim cmd As MySqlCommand


        Try
            con.Open()
            cmd = New MySqlCommand(sqli, con)
            cmd.Parameters.AddWithValue("@pe", txtpe.Text)
            cmd.Parameters.AddWithValue("@po", txtpo.Text)
            cmd.Parameters.AddWithValue("@prac", txtprac.Text)
            cmd.Parameters.AddWithValue("@valores", txtval.Text)
            cmd.Parameters.AddWithValue("@prue", txtprue.Text)
            cmd.Parameters.AddWithValue("@nota", txtnot.Text)
            cmd.Parameters.AddWithValue("@resul", txtres.Text)
            cmd.Parameters.AddWithValue("@literal", txtlit.Text)
            cmd.ExecuteNonQuery()

            If cmd.ExecuteNonQuery = 1 Then
                MessageBox.Show("Datos guardados")

            Else
                MessageBox.Show("Error datos no guardados")



            End If


            con.Close()



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()



        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mo As proalm = New proalm
        Dim da As conexionmysql = New conexionmysql
        'Try

        mo.pe = Val(txtpe.Text)
        mo.po = Val(txtpo.Text)
        mo.pract = Val(txtprac.Text)
        mo.valores = Val(txtval.Text)
        mo.prue = Val(txtprue.Text)
        mo.nota = Val(txtnot.Text)
        mo.resul = txtres.Text
        mo.lit = txtlit.Text
        da.guardar(mo)
        MessageBox.Show("Datos Gurdados")


        ' Catch ex As Exception
        ' MessageBox.Show(ex.Message)

        'End Try


        'Dim uapa As conexionmysql = New conexionmysql
        'uapa.insert("insert into calificacion(pe,po,prac,valores,prue,nota,resul,literal)values('" + txtpe.Text + "','" + txtpo.Text + "','" + txtprac.Text + "','" + txtval.Text + "','" + txtprue.Text + "','" + txtnot.Text + "','" + txtres.Text + "','" + txtlit.Text + "')")



    End Sub
End Class
