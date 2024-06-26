﻿Imports System.Threading.Tasks

Public Class menu
    Dim loadfrm As New loadscreen
    Private Sub ShowProgressBar()
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = True)
        Else
            ProgressBar1.Visible = True
        End If
        Timer1.Start()
    End Sub

    Private Sub HideProgressBar()
        If ProgressBar1.InvokeRequired Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Visible = False)
        Else
            ProgressBar1.Visible = False
        End If
        Timer1.Stop()
    End Sub

    Private Sub ClearPanel3()
        If Panel3.InvokeRequired Then
            Panel3.Invoke(Sub() Panel3.Controls.Clear())
        Else
            Panel3.Controls.Clear()
        End If
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        ProgressBar1.Visible = False
        Timer1.Interval = 100
        Timer1.Enabled = False
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
    End Sub
    Private Sub menu_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.PerformStep()
    End Sub

    Private Async Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        ClearPanel3()
        ShowProgressBar()

        Dim completedTask1 As Button = Await StartBackgroundWorkAsync(clickedButton)

        HideProgressBar()
        ShowForm(completedTask1)
    End Sub

    Private Async Function StartBackgroundWorkAsync(clickedButton As Button) As Task(Of Button)
        Await Task.Delay(1000) ' Simulate background work
        Return clickedButton
    End Function

    Private Sub ShowForm(clickedButton As Button)
        Dim formToShow As Form = Nothing

        If clickedButton Is Button1 Then
            formToShow = New equip()
        ElseIf clickedButton Is Button2 Then
            formToShow = New stock()
        ElseIf clickedButton Is Button3 Then
            formToShow = New report()
        ElseIf clickedButton Is Label1 Then
            formToShow = New menu()
        End If

        If formToShow IsNot Nothing Then
            formToShow.TopLevel = False
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            Panel3.Controls.Clear()
            Panel3.Controls.Add(formToShow)
            formToShow.BringToFront()
            formToShow.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        loadfrm.TopLevel = False
        loadfrm.FormBorderStyle = FormBorderStyle.None
        loadfrm.Dock = DockStyle.Fill
        Panel3.Controls.Clear()
        Panel3.Controls.Add(loadfrm)
        loadfrm.BringToFront()
        loadfrm.Show()
    End Sub
End Class