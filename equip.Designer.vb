<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equip
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
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        TextBox9 = New TextBox()
        Button6 = New Button()
        Label7 = New Label()
        TextBox8 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        MonthCalendar1 = New MonthCalendar()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        GroupBox2 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(564, 427)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(TextBox9)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox8)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(MonthCalendar1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox7)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(594, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(469, 500)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item Operation"
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button5.ForeColor = Color.DeepSkyBlue
        Button5.Location = New Point(371, 455)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 30)
        Button5.TabIndex = 2
        Button5.Text = "Add New"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Enabled = False
        TextBox9.Location = New Point(113, 54)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(78, 25)
        TextBox9.TabIndex = 9
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button6.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button6.ForeColor = Color.DeepSkyBlue
        Button6.Location = New Point(270, 455)
        Button6.Name = "Button6"
        Button6.Size = New Size(85, 30)
        Button6.TabIndex = 2
        Button6.Text = "Update"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 297)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 17)
        Label7.TabIndex = 8
        Label7.Text = "Unit Price (PHP)"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(27, 315)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(164, 25)
        TextBox8.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 17)
        Label6.TabIndex = 6
        Label6.Text = "Equipment Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 17)
        Label5.TabIndex = 6
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 17)
        Label4.TabIndex = 6
        Label4.Text = "Equipment Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 17)
        Label3.TabIndex = 6
        Label3.Text = "Equipment Serial"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.DeepSkyBlue
        Button2.Location = New Point(27, 455)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 30)
        Button2.TabIndex = 2
        Button2.Text = "Clear Field"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 17)
        Label2.TabIndex = 6
        Label2.Text = "EQ Identification"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(229, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 17)
        Label1.TabIndex = 5
        Label1.Text = "Purchase Date"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(229, 59)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(331, 31)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 25)
        TextBox6.TabIndex = 3
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(27, 210)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(164, 25)
        TextBox7.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(27, 262)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(164, 25)
        TextBox5.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(27, 155)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(164, 25)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(27, 104)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(164, 25)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(27, 54)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(75, 25)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button1.ForeColor = Color.DeepSkyBlue
        Button1.Location = New Point(17, 456)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 30)
        Button1.TabIndex = 2
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button3.ForeColor = Color.DeepSkyBlue
        Button3.Location = New Point(107, 455)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 30)
        Button3.TabIndex = 2
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button4.ForeColor = Color.DeepSkyBlue
        Button4.Location = New Point(471, 456)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 30)
        Button4.TabIndex = 2
        Button4.Text = "Search"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox1.Location = New Point(220, 462)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 23)
        TextBox1.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(576, 500)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Item Information"
        ' 
        ' equip
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1075, 524)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "equip"
        Text = "Manage Equipment"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
