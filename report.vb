Imports System.Data.SQLite
Imports System.Drawing.Printing
Imports OfficeOpenXml
Imports System.IO

Public Class report
    Dim databasePath As String = IO.Path.Combine(Application.StartupPath, "Data\supply.db")
    Dim connectionString As String = "Data Source=" & databasePath & ";Version=3;"
    Dim sda As New SQLiteDataAdapter
    Dim sdr As SQLiteDataReader
    Dim cmd As New SQLiteCommand
    Dim dt As New DataTable
    Dim bp As Bitmap

    Private Sub historytable()
        Dim hdt As New DataTable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT * FROM history", conn)
                    Using sdr As SQLiteDataReader = cmd.ExecuteReader()
                        hdt.Load(sdr)
                    End Using
                End Using
                conn.Close()
            End Using
            'RC()
            DataGridView2.DataSource = hdt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub updatetable()
        Try
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT * FROM equipment", conn)
                    Using sdr As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(sdr)
                    End Using
                End Using
                conn.Close()
            End Using
            ResizeColumns()
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatetable()
        historytable()
        ResizeColumns()
        'RC()
        TextBox1.Text = "search keywords..."
    End Sub
    'Private Sub RC()
    'Dim desiredWidth As Integer = 150 ' Set the desired width for the columns

    'For Each column As DataGridViewColumn In DataGridView2.Columns
    'column.Width = desiredWidth
    'Next
    'End Sub
    Private Sub ResizeColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim height As Integer = DataGridView1.Height
            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
            bp = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
            DataGridView1.DrawToBitmap(bp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
            PrintPreviewDialog1.ShowDialog()
            DataGridView1.Height = height
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If bp IsNot Nothing Then
            e.Graphics.DrawImage(bp, 0, 0)
        End If
    End Sub
    Private filePath As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dt.Clear()
        updatetable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim searchTerm = TextBox1.Text.Trim.ToLower
        If String.IsNullOrWhiteSpace(searchTerm) Then
            MessageBox.Show("Field is empty. Type at least one character", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        DataGridView1.ClearSelection()
        Dim matchFound = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim rowContainsTerm = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString.ToLower.Contains(searchTerm) Then
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ListBox1.Items.Clear()
            For Each cell As DataGridViewCell In DataGridView1.Rows(e.RowIndex).Cells
                ListBox1.Items.Add(cell.Value.ToString())
            Next
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = saveFileDialog.FileName
            SaveDataToFile(ListBox1.Items)
            MessageBox.Show($"Data saved to: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SaveDataToFile(items As ListBox.ObjectCollection)
        Using writer As New StreamWriter(filePath)
            For Each item As Object In items
                writer.WriteLine(item.ToString())
            Next
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = saveFileDialog.FileName
            SaveDataToExcel(DataGridView2)
            MessageBox.Show($"Data saved to: {filePath}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class