Imports System.Data.OleDb
Public Class Form1
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\md faisal alam\OneDrive\Documents\Login Form.accdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mycon.Open()

        Dim mycmd As New OleDbCommand("Select * from Account where Uname = '" & TextBox1.Text & "' And My_Password '" & TextBox2.Text & "'", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("Success")
            TextBox1.Clear()
            TextBox2.Clear()

        Else
            MsgBox("The password or username seems incorrect")
        End If
        mycon.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
