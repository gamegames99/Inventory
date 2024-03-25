Public Class menu
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
        ' Set up the timer for the progress bar animation
        Timer1.Interval = 100
        Timer1.Enabled = False
        AddHandler Timer1.Tick, AddressOf Timer1_Tick
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        ProgressBar1.PerformStep()
    End Sub

    Private Sub menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        If Not BackgroundWorker1.IsBusy Then
            ClearPanel3()
            ShowProgressBar()
            StartBackgroundWorker(clickedButton)
        End If
    End Sub

    Private Sub StartBackgroundWorker(clickedButton As Button)
        BackgroundWorker1.RunWorkerAsync(clickedButton)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim clickedButton As Button = DirectCast(e.Argument, Button)
        System.Threading.Thread.Sleep(1000)
        e.Result = clickedButton
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim clickedButton As Button = DirectCast(e.Result, Button)
        HideProgressBar()
        ShowForm(clickedButton)
    End Sub

    Private Sub ShowForm(clickedButton As Button)
        Dim formToShow As Form = Nothing

        If clickedButton Is Button1 Then
            formToShow = New equip()
        ElseIf clickedButton Is Button2 Then
            formToShow = New stock()
        ElseIf clickedButton Is Button3 Then
            formToShow = New report()
        End If

        If formToShow IsNot Nothing Then
            formToShow.TopLevel = False
            formToShow.FormBorderStyle = FormBorderStyle.None
            formToShow.Dock = DockStyle.Fill
            If Panel3.InvokeRequired Then
                Panel3.Invoke(Sub()
                                  Panel3.Controls.Clear()
                                  Panel3.Controls.Add(formToShow)
                              End Sub)
            Else
                Panel3.Controls.Clear()
                Panel3.Controls.Add(formToShow)
            End If
            formToShow.BringToFront()
            formToShow.Show()
        End If
    End Sub
End Class