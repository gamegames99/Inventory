<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report))
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        ListBox1 = New ListBox()
        Button5 = New Button()
        DataGridView2 = New DataGridView()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Button6 = New Button()
        GroupBox3 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(650, 174)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.DeepSkyBlue
        Button1.Location = New Point(6, 218)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 30)
        Button1.TabIndex = 2
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.White
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.DeepSkyBlue
        Button2.Location = New Point(100, 218)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 30)
        Button2.TabIndex = 2
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.White
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button3.ForeColor = Color.DeepSkyBlue
        Button3.Location = New Point(197, 218)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 30)
        Button3.TabIndex = 2
        Button3.Text = "Save As"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.White
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button4.ForeColor = Color.DeepSkyBlue
        Button4.Location = New Point(559, 218)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 30)
        Button4.TabIndex = 2
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(340, 224)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(203, 23)
        TextBox1.TabIndex = 3
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' ListBox1
        ' 
        ListBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListBox1.BackColor = Color.Silver
        ListBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 17
        ListBox1.Location = New Point(6, 22)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(364, 174)
        ListBox1.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseOverBackColor = Color.White
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button5.ForeColor = Color.DeepSkyBlue
        Button5.Location = New Point(278, 218)
        Button5.Name = "Button5"
        Button5.Size = New Size(92, 30)
        Button5.TabIndex = 5
        Button5.Text = "Save To File"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 22)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(1032, 221)
        DataGridView2.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(680, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 254)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Info"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 272)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1044, 285)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "History"
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.White
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button6.ForeColor = Color.DeepSkyBlue
        Button6.Location = New Point(946, 249)
        Button6.Name = "Button6"
        Button6.Size = New Size(92, 30)
        Button6.TabIndex = 2
        Button6.Text = "Export"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(DataGridView1)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(12, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(662, 254)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "Item Information"
        ' 
        ' report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1068, 569)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "report"
        Text = "Reports"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
