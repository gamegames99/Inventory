Imports System.Data.SQLite
Imports System.IO
Imports System.Drawing

Public Class Form1
    Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Data\testdb.db")
    Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
    Dim conn As SQLiteConnection
    Dim cmd As SQLiteCommand
    Dim sdr As SQLiteDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT * FROM logindata WHERE user_name = @username AND user_pass = @password", conn)
                    cmd.Parameters.AddWithValue("@username", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@password", TextBox2.Text)

                    Using sdr As SQLiteDataReader = cmd.ExecuteReader()
                        If (sdr.Read()) Then
                            MsgBox("Connected!")
                            menu.Show()
                            Me.Hide()
                        Else
                            MsgBox("Invalid credentials.")
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                        End If
                    End Using
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "resources\BILECO.jpg")
        Dim image As New Bitmap(imagePath)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = image
        TextBox1.Text = "admin"
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
    End Sub
End Class
