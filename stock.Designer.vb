﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 66)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(424, 326)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(248, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(73, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 17)
        Label1.TabIndex = 2
        Label1.Text = "Stock Quantity (Inbound) :"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DeepSkyBlue
        Button1.Location = New Point(346, 477)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 33)
        Button1.TabIndex = 3
        Button1.Text = "Save Entry"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 487)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(75, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 468)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 5
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(109, 468)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 15)
        Label3.TabIndex = 7
        Label3.Text = "Department / Personnel"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(470, 66)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(412, 326)
        DataGridView2.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.DeepSkyBlue
        Button2.Location = New Point(807, 468)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 33)
        Button2.TabIndex = 9
        Button2.Text = "Logs"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(12, 424)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(183, 23)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(248, 424)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(188, 23)
        TextBox4.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 406)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 5
        Label4.Text = "Item Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(248, 406)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 5
        Label5.Text = "Item Type"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(109, 487)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(197, 23)
        TextBox5.TabIndex = 4
        ' 
        ' stock
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(896, 578)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(DataGridView2)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Name = "stock"
        Text = "Stocks Manager"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
End Class
