Public Class Form1
    Private Graph1 As Graphics
    Private Graph2 As Graphics
    Private Pen1 As New Pen(Color.Black, 1)
    Private Pen2 As New Pen(Color.Black, 2)
    'Private rect As New Rectangle((Tim.Size.Width / 2) - 1, (Tim.Size.Height / 2) - 1, (Tim.Size.Width / 2) + 1, (Tim.Size.Height / 2) + 1)
    Private x_senter, y_senter, x, y, r As Integer
    'Private x_p, y_p, x_, y_ As Integer
    'Private gradus1, radian1 As Double
    Private form As Image
    Private gradus, radian As Double
    Private Sub initialize()

        Tim.Image = Image.FromFile("C:\Users\Валентин\Desktop\tim.jpg")
        Graph1 = Me.Tim.CreateGraphics()
        gradus = -90.5
        radian = gradus * (Math.PI / 180)
        r = Tim.Size.Height / 2 - 40
        x_senter = Tim.Size.Width / 2
        y_senter = Tim.Size.Height / 2
        x = x_senter
        y = 40
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tim.Image = Image.FromFile("C:\Users\Валентин\Desktop\tim.jpg")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Tim.Image = Image.FromFile("C:\Users\Валентин\Desktop\tim.jpg")
        Dim i As Integer
        i = 0
        x = x_senter + r * Math.Cos(radian)
        y = y_senter + r * Math.Sin(radian)
        gradus += 6
        radian = (gradus) * (Math.PI / 180)
        ' Graph1.DrawRectangle(Pen2, rect)
        Graph1.DrawLine(Pen1, x_senter, y_senter, x, y)
        Timer1.Enabled = True
        Beep()


        ' Tim.Image = form
    End Sub

    Private Sub start1_Click(sender As Object, e As EventArgs) Handles start1.Click
        initialize()
        Timer.Enabled = True
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

        Tim.Image = Image.FromFile("C:\Users\Валентин\Desktop\tim.jpg")
        Graph1.DrawLine(Pen1, x_senter, y_senter, x, y)
        Timer.Enabled = True
    End Sub

    Private Sub srop1_Click(sender As Object, e As EventArgs) Handles srop1.Click
        Timer.Enabled = False
        Timer1.Enabled = False
    End Sub
End Class
