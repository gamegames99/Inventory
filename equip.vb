Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Public Class equip
    Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Data\supply.db")
    Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
    Dim conn As New SQLiteConnection
    Dim sda As New SQLiteDataAdapter
    Dim sdr As SQLiteDataReader
    Dim cmd As New SQLiteCommand
    Dim dt As New DataTable
    Dim rd As Integer
    Private Sub updatetable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT * FROM equipment", conn)
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
                TextBox9.Text = sum.ToString()
            End Using

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox6.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub equip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
        TextBox1.Text = "search keywords.."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each txt In GroupBox1.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand()
                    cmd.Connection = conn
                    cmd.CommandText = "INSERT INTO equipment(eq_serial, eq_name, eq_type, eq_quantity, eq_dop, eq_price) VALUES (@serial, @name, @type, @quantity, @dop, @ep)"

                    ' Validate and set @serial parameter
                    Dim serialParameter As New SQLiteParameter("@serial", TextBox3.Text)
                    cmd.Parameters.Add(serialParameter)

                    ' Validate and set @name parameter
                    Dim nameParameter As New SQLiteParameter("@name", TextBox4.Text)
                    cmd.Parameters.Add(nameParameter)

                    ' Validate and set @type parameter
                    Dim typeParameter As New SQLiteParameter("@type", TextBox7.Text)
                    cmd.Parameters.Add(typeParameter)

                    ' Validate and set @quantity parameter
                    Dim quantityParameter As New SQLiteParameter("@quantity", 0)
                    If Integer.TryParse(TextBox5.Text, Nothing) Then
                        quantityParameter.Value = Integer.Parse(TextBox5.Text)
                    Else
                        Throw New Exception("Invalid value for Quantity.")
                    End If
                    cmd.Parameters.Add(quantityParameter)

                    ' Validate and set @dop parameter
                    Dim dopParameter As New SQLiteParameter("@dop", TextBox6.Text)
                    cmd.Parameters.Add(dopParameter)

                    ' Validate and set @ep parameter
                    Dim epParameter As New SQLiteParameter("@ep", 0)
                    If Integer.TryParse(TextBox8.Text, Nothing) Then
                        epParameter.Value = Integer.Parse(TextBox8.Text)
                    Else
                        Throw New Exception("Invalid value for Unit Price.")
                    End If
                    cmd.Parameters.Add(epParameter)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Saved!")
            updatetable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                rd = DataGridView1.SelectedRows(0).Cells("eq_id").Value
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Using conn As New SQLiteConnection(connectionString)
                        conn.Open()
                        Using cmd As New SQLiteCommand()
                            cmd.Connection = conn
                            cmd.CommandText = "UPDATE equipment SET eq_id = @eq_id, eq_serial = @serial, eq_name = @name, eq_type = @type, eq_quantity = @quantity, eq_dop = @dop, eq_price = @ep WHERE eq_id = @eq_id"

                            ' Validate and set @eq_id parameter
                            Dim eqIdParameter As New SQLiteParameter("@eq_id", rd)
                            cmd.Parameters.Add(eqIdParameter)

                            ' Validate and set @serial parameter
                            Dim serialParameter As New SQLiteParameter("@serial", TextBox3.Text)
                            cmd.Parameters.Add(serialParameter)

                            ' Validate and set @name parameter
                            Dim nameParameter As New SQLiteParameter("@name", TextBox4.Text)
                            cmd.Parameters.Add(nameParameter)

                            ' Validate and set @type parameter
                            Dim typeParameter As New SQLiteParameter("@type", TextBox7.Text)
                            cmd.Parameters.Add(typeParameter)

                            ' Validate and set @quantity parameter
                            Dim quantityParameter As New SQLiteParameter("@quantity", 0)
                            If Integer.TryParse(TextBox5.Text, Nothing) Then
                                quantityParameter.Value = Integer.Parse(TextBox5.Text)
                            Else
                                Throw New Exception("Invalid value for Quantity")
                            End If
                            cmd.Parameters.Add(quantityParameter)

                            ' Validate and set @dop parameter
                            Dim dopParameter As New SQLiteParameter("@dop", TextBox6.Text)
                            cmd.Parameters.Add(dopParameter)

                            ' Validate and set @ep parameter
                            Dim epParameter As New SQLiteParameter("@ep", 0)
                            If Integer.TryParse(TextBox8.Text, Nothing) Then
                                epParameter.Value = Integer.Parse(TextBox8.Text)
                            Else
                                Throw New Exception("Invalid value for Unit Price.")
                            End If
                            cmd.Parameters.Add(epParameter)

                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MsgBox("Updated!")
                    updatetable()
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                rd = DataGridView1.SelectedRows(0).Cells("eq_id").Value
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim conn As New SQLiteConnection(connectionString)
                    conn.Open()
                    cmd.Connection = conn
                    cmd.CommandText = "delete from equipment where eq_id = @eq_id"
                    cmd.Parameters.AddWithValue("@eq_id", rd)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted!")
                    conn.Close()
                    dt.Clear()
                    updatetable()
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                TextBox2.Text = If(selectedRow.Cells("eq_id").Value IsNot Nothing, selectedRow.Cells("eq_id").Value.ToString(), "")
                TextBox3.Text = If(selectedRow.Cells("eq_serial").Value IsNot Nothing, selectedRow.Cells("eq_serial").Value.ToString(), "")
                TextBox4.Text = If(selectedRow.Cells("eq_name").Value IsNot Nothing, selectedRow.Cells("eq_name").Value.ToString(), "")
                TextBox7.Text = If(selectedRow.Cells("eq_type").Value IsNot Nothing, selectedRow.Cells("eq_type").Value.ToString(), "")
                TextBox5.Text = If(selectedRow.Cells("eq_quantity").Value IsNot Nothing, selectedRow.Cells("eq_quantity").Value.ToString(), "")
                TextBox6.Text = If(selectedRow.Cells("eq_dop").Value IsNot Nothing, selectedRow.Cells("eq_dop").Value.ToString(), "")
                TextBox8.Text = If(selectedRow.Cells("eq_price").Value IsNot Nothing, selectedRow.Cells("eq_price").Value.ToString(), "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dt.Clear()
        updatetable()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim searchTerm As String = TextBox1.Text.Trim().ToLower()
        If String.IsNullOrWhiteSpace(searchTerm) Then
            MessageBox.Show("Field is empty. Type at least one character", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        DataGridView1.ClearSelection()
        Dim matchFound As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowContainsTerm As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchTerm) Then
                    rowContainsTerm = True
                    cell.Selected = True
                    Exit For
                End If
            Next
            If rowContainsTerm Then
                row.Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = row.Index
                matchFound = True
            End If
        Next
        If Not matchFound Then
            MessageBox.Show("No matches found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub
End Class