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

    Private Sub newtable()
        Dim stockTable As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                ' Retrieve data from stock table with eq_name instead of eq_id
                Dim selectCommand As New SQLiteCommand("SELECT s.SID, s.quantity, s.receiver, e.eq_name AS equipment FROM stock s INNER JOIN equipment e ON s.equipment = e.eq_id", conn)
                Dim dataAdapter As New SQLiteDataAdapter(selectCommand)
                dataAdapter.Fill(stockTable)

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGridView2.DataSource = stockTable
    End Sub
    Private Sub updatetable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT eq_id, eq_name, eq_type, eq_quantity FROM equipment", conn)
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

                ' Display the sum in TextBox1
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
        newtable()
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                TextBox3.Text = If(selectedRow.Cells("eq_name").Value IsNot Nothing, selectedRow.Cells("eq_name").Value.ToString(), "")
                TextBox4.Text = If(selectedRow.Cells("eq_type").Value IsNot Nothing, selectedRow.Cells("eq_type").Value.ToString(), "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Try
            If DataGridView2.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
                TextBox2.Text = If(selectedRow.Cells("quantity").Value IsNot Nothing, selectedRow.Cells("quantity").Value.ToString(), "")
                TextBox5.Text = If(selectedRow.Cells("receiver").Value IsNot Nothing, selectedRow.Cells("receiver").Value.ToString(), "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim eqId As Integer = Convert.ToInt32(selectedRow.Cells("eq_id").Value)
                Dim quantity As Integer = 0

                If Integer.TryParse(TextBox2.Text, quantity) Then
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to transfer?", "Confirmation",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Using conn As New SQLiteConnection(connectionString)
                            conn.Open()

                            ' Deduct quantity from equipment table
                            Using deductCmd As New SQLiteCommand("UPDATE equipment SET eq_quantity = eq_quantity - @deductQty WHERE eq_id = @eqId", conn)
                                deductCmd.Parameters.AddWithValue("@deductQty", quantity)
                                deductCmd.Parameters.AddWithValue("@eqId", eqId)
                                deductCmd.ExecuteNonQuery()
                            End Using

                            ' Add quantity to stock table
                            Using addCmd As New SQLiteCommand("INSERT INTO stock(quantity, receiver, equipment) VALUES (@qy, @rv, @eqId)", conn)
                                addCmd.Parameters.AddWithValue("@qy", quantity)
                                addCmd.Parameters.AddWithValue("@rv", TextBox5.Text)
                                addCmd.Parameters.AddWithValue("@eqId", eqId)
                                addCmd.ExecuteNonQuery()
                            End Using

                            conn.Close()
                        End Using

                        MsgBox("Saved!")
                        updatetable()
                        newtable()
                        ResizeColumns()
                    End If
                Else
                    Throw New Exception("Invalid value for Quantity.")
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class