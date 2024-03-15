Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class stock
    Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Data\supply.db")
    Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
    Dim sda As New SQLiteDataAdapter
    Dim sdr As SQLiteDataReader
    Dim cmd As New SQLiteCommand
    Dim dt As New DataTable
    Dim bp As Bitmap
    Private Sub updatetable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT eq_name,eq_type,eq_quantity FROM equipment", conn)
                    Using sdr As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(sdr)
                    End Using
                End Using

                ' Calculate the sum of eq_quantity
                Dim sum As Integer = 0
                Using sumCmd As New SQLiteCommand("SELECT SUM(eq_quantity) FROM equipment", conn)
                    Dim result As Object = sumCmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        sum = Convert.ToInt32(result)
                    End If
                End Using

                conn.Close()

                ' Display the sum in TextBox9
                TextBox1.Text = sum.ToString()
            End Using

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ResizeColumns()
        Dim totalWidth As Integer = DataGridView1.Width
        Dim columnCount As Integer = DataGridView1.Columns.Count

        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.Width = totalWidth / columnCount
        Next
    End Sub
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
        ResizeColumns()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("No data Yet")
    End Sub
End Class