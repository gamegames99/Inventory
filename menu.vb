Public Class menu
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eq As New equip()
        eq.TopLevel = False
        eq.FormBorderStyle = FormBorderStyle.None
        eq.Dock = DockStyle.Fill
        Panel3.Controls.Add(eq)
        eq.BringToFront()
        eq.Show()
        UpdateButtonColors(Button1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rt As New report()
        rt.TopLevel = False
        rt.FormBorderStyle = FormBorderStyle.None
        rt.Dock = DockStyle.Fill
        Panel3.Controls.Add(rt)
        rt.BringToFront()
        rt.Show()
        UpdateButtonColors(Button3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim st As New stock()
        st.TopLevel = False
        st.FormBorderStyle = FormBorderStyle.None
        st.Dock = DockStyle.Fill
        Panel3.Controls.Add(st)
        st.BringToFront()
        st.Show()
        UpdateButtonColors(Button2)
    End Sub
    Private previouslyClickedButton As Button
    Private originalButtonColors As New Dictionary(Of Button, Color)()
    Private Sub UpdateButtonColors(clickedButton As Button)
        ' Restore the background color of the previously clicked button (if applicable)
        If previouslyClickedButton IsNot Nothing Then
            previouslyClickedButton.BackColor = originalButtonColors(previouslyClickedButton)
        End If

        ' Store the original color of the clicked button (if not already stored)
        If Not originalButtonColors.ContainsKey(clickedButton) Then
            originalButtonColors.Add(clickedButton, clickedButton.BackColor)
        End If

        ' Set the background color of the clicked button to white
        clickedButton.BackColor = Color.White

        ' Update the previously clicked button
        previouslyClickedButton = clickedButton
    End Sub
End Class