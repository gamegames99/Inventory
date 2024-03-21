Imports System.Data.SQLite
Imports OfficeOpenXml
Imports System.IO
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
                Dim selectCommand As New SQLiteCommand("SELECT s.SID, s.quantity, s.receiver, s.date, e.eq_id AS identifier FROM stock s LEFT JOIN equipment e ON s.identifier = e.eq_id", conn)
                Dim dataAdapter As New SQLiteDataAdapter(selectCommand)
                dataAdapter.Fill(stockTable)

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        RC()
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
                Dim summ As Integer = 0
                Using summCmd As New SQLiteCommand("SELECT SUM(quantity) FROM stock", conn)
                    Dim rt As Object = summCmd.ExecuteScalar()
                    If rt IsNot Nothing AndAlso rt IsNot DBNull.Value Then
                        summ = Convert.ToInt32(rt)
                    End If
                End Using

                conn.Close()

                ' Display the sum in TextBox1 and Txtbox8
                TextBox1.Text = sum.ToString()
                TextBox8.Text = summ.ToString()
            End Using
            ResizeColumns()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ResizeColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub RC()
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
        ResizeColumns()
        newtable()
        RC()
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
                TextBox6.Text = If(selectedRow.Cells("quantity").Value IsNot Nothing, selectedRow.Cells("quantity").Value.ToString(), "")
                TextBox7.Text = If(selectedRow.Cells("identifier").Value IsNot Nothing, selectedRow.Cells("identifier").Value.ToString(), "")
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
                            Using addCmd As New SQLiteCommand("INSERT INTO stock(quantity, receiver, date, identifier) VALUES (@qy, @rv,@dt, @eqId)", conn)
                                addCmd.Parameters.AddWithValue("@qy", quantity)
                                addCmd.Parameters.AddWithValue("@rv", TextBox5.Text)
                                addCmd.Parameters.AddWithValue("@dt", DateTime.Now.ToString("MM/dd/yyyy HH:mm"))
                                addCmd.Parameters.AddWithValue("@eqId", eqId)
                                addCmd.ExecuteNonQuery()
                            End Using

                            conn.Close()
                        End Using

                        MsgBox("Saved!")
                        updatetable()
                        newtable()
                    End If
                Else
                    Throw New Exception("Invalid value")
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
            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirm = DialogResult.Yes Then
                If DataGridView2.SelectedRows.Count > 0 Then
                    Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
                    Dim stockId As Integer = Convert.ToInt32(selectedRow.Cells("SID").Value)
                    Dim newQuantity As Integer = 0

                    If Integer.TryParse(TextBox6.Text, newQuantity) Then
                        Dim difference As Integer = 0
                        Dim equipmentId As Integer = Convert.ToInt32(selectedRow.Cells("identifier").Value)

                        Using conn As New SQLiteConnection(connectionString)
                            conn.Open()

                            ' Retrieve the old quantity from the stock table
                            Using oldQuantityCmd As New SQLiteCommand("SELECT quantity FROM stock WHERE SID = @stockId", conn)
                                oldQuantityCmd.Parameters.AddWithValue("@stockId", stockId)
                                Dim oldQuantityResult As Object = oldQuantityCmd.ExecuteScalar()

                                If oldQuantityResult IsNot Nothing AndAlso oldQuantityResult IsNot DBNull.Value Then
                                    Dim oldQuantity As Integer = Convert.ToInt32(oldQuantityResult)
                                    difference = oldQuantity - newQuantity
                                Else
                                    Throw New Exception("Failed to retrieve old quantity.")
                                End If
                            End Using

                            ' Update the quantity in the stock table
                            Using updateStockCmd As New SQLiteCommand("UPDATE stock SET quantity = @newQuantity WHERE SID = @stockId", conn)
                                updateStockCmd.Parameters.AddWithValue("@newQuantity", newQuantity)
                                updateStockCmd.Parameters.AddWithValue("@stockId", stockId)
                                updateStockCmd.ExecuteNonQuery()
                            End Using

                            ' Update the quantity in the equipment table
                            Using updateEquipmentCmd As New SQLiteCommand("UPDATE equipment SET eq_quantity = eq_quantity + @difference WHERE eq_id = @equipmentId", conn)
                                updateEquipmentCmd.Parameters.AddWithValue("@difference", difference)
                                updateEquipmentCmd.Parameters.AddWithValue("@equipmentId", equipmentId)
                                updateEquipmentCmd.ExecuteNonQuery()
                            End Using

                            ' Recalculate the sum of eq_quantity
                            Dim sum As Integer = 0
                            Using sumCmd As New SQLiteCommand("SELECT SUM(eq_quantity) FROM equipment", conn)
                                Dim result As Object = sumCmd.ExecuteScalar()

                                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                    sum = Convert.ToInt32(result)
                                End If
                            End Using

                            ' Update TextBox1 with the new total quantity
                            TextBox1.Text = sum.ToString()

                            conn.Close()
                        End Using

                        MsgBox("Update Successful!")
                        updatetable()
                        newtable()
                    Else
                        Throw New Exception("Invalid value for Quantity.")
                    End If
                Else
                    MsgBox("No row selected.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private filePath As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = saveFileDialog.FileName
            SaveDataToExcel(DataGridView1)
            MessageBox.Show($"Data saved to: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SaveDataToExcel(dataGridView As DataGridView)
        ExcelPackage.LicenseContext = LicenseContext.Commercial
        Using package As New ExcelPackage()
            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

            ' Write column headers
            For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                worksheet.Cells(1, columnIndex + 1).Value = dataGridView.Columns(columnIndex).HeaderText
            Next

            ' Write data rows
            For rowIndex As Integer = 0 To dataGridView.Rows.Count - 1
                For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
                    worksheet.Cells(rowIndex + 2, columnIndex + 1).Value = dataGridView.Rows(rowIndex).Cells(columnIndex).Value
                Next
            Next

            ' Save the Excel file
            Using fileStream As New FileStream(filePath, FileMode.Create)
                package.SaveAs(fileStream)
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim rd As Integer
            If DataGridView2.SelectedRows.Count > 0 Then
                rd = DataGridView2.SelectedRows(0).Cells("SID").Value
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim conn As New SQLiteConnection(connectionString)
                    conn.Open()
                    cmd.Connection = conn
                    cmd.CommandText = "delete from stock where SID = @sd"
                    cmd.Parameters.AddWithValue("@sd", rd)
                    cmd.ExecuteNonQuery()
                    MsgBox("Deleted!")
                    conn.Close()
                    dt.Clear()
                    updatetable()
                    newtable()
                End If
            Else
                MsgBox("No row selected.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class