Public Class loadscreen
    Private Sub loadscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imagePath As String = IO.Path.Combine(Application.StartupPath, "resources\BILECO.jpg")
        Dim image As New Bitmap(imagePath)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = image
    End Sub
End Class