<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView2 = New DataGridView()
        Button2 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Button3 = New Button()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button4 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 54)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(433, 326)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(183, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(216, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 17)
        Label1.TabIndex = 2
        Label1.Text = "Quantity (Inbound) :"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DeepSkyBlue
        Button1.Location = New Point(331, 461)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 33)
        Button1.TabIndex = 3
        Button1.Text = "Send Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox2.Location = New Point(211, 467)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Location = New Point(211, 448)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 5
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(10, 448)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 15)
        Label3.TabIndex = 7
        Label3.Text = "Department / Personnel"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 54)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(414, 326)
        DataGridView2.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.White
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DeepSkyBlue
        Button2.Location = New Point(248, 461)
        Button2.Name = "Button2"
        Button2.Size = New Size(165, 33)
        Button2.TabIndex = 9
        Button2.Text = "Save as Excel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(10, 406)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(183, 23)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox4.Enabled = False
        TextBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(211, 406)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(188, 23)
        TextBox4.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(10, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 5
        Label4.Text = "Item Name"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(211, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 5
        Label5.Text = "Item Type"
        ' 
        ' TextBox5
        ' 
        TextBox5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBox5.Location = New Point(10, 467)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(183, 23)
        TextBox5.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.White
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.DeepSkyBlue
        Button3.Location = New Point(239, 400)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 33)
        Button3.TabIndex = 9
        Button3.Text = "Return"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox6.Location = New Point(122, 410)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(111, 23)
        TextBox6.TabIndex = 11
        ' 
        ' TextBox7
        ' 
        TextBox7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox7.Enabled = False
        TextBox7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(6, 410)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(94, 23)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox8
        ' 
        TextBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox8.Enabled = False
        TextBox8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(203, 25)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(194, 23)
        TextBox8.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(43, 26)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 17)
        Label6.TabIndex = 2
        Label6.Text = "Quantity (Outbound) :"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(122, 392)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 5
        Label7.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(6, 392)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 15)
        Label8.TabIndex = 13
        Label8.Text = "Item Identifier"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.White
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.DeepSkyBlue
        Button4.Location = New Point(329, 400)
        Button4.Name = "Button4"
        Button4.Size = New Size(84, 33)
        Button4.TabIndex = 9
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(445, 510)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Inbound Items"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.BackColor = Color.White
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(463, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(426, 510)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Outbound Items"
        ' 
        ' stock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(901, 534)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "stock"
        Text = "Manage Stock"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
