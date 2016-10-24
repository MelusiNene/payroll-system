Imports MySql.Data.MySqlClient

Module modCodes

    Public MySQLConnection As New MySqlConnection


    ' Connection to database goes here
    Public Sub getMySQLConnection()

        MySQLConnection.ConnectionString = "SERVER = localhost; USER = root; DATABASE = pay_system; PWD = "

        Try

            MySQLConnection.Open()

        Catch showError As Exception

            MsgBox(showError.ToString)

        End Try

    End Sub


End Module
