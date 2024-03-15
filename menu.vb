Public Class menu
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result = MessageBox.Show("Would you like to exit? Any unsaved changes will be lost", "Confirm Exit",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eq As New equip()
        eq.TopLevel = False
        eq.FormBorderStyle = FormBorderStyle.None
        eq.Dock = DockStyle.Fill
        Panel3.Controls.Add(eq)
        eq.BringToFront()
        eq.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rt As New report()
        rt.TopLevel = False
        rt.FormBorderStyle = FormBorderStyle.None
        rt.Dock = DockStyle.Fill
        Panel3.Controls.Add(rt)
        rt.BringToFront()
        rt.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim st As New stock()
        st.TopLevel = False
        st.FormBorderStyle = FormBorderStyle.None
        st.Dock = DockStyle.Fill
        Panel3.Controls.Add(st)
        st.BringToFront()
        st.Show()
    End Sub
End Class