Public Class Form1
    Dim signalIndex As Integer = 0
    Dim signals() As String = {"Red", "Yellow", "Green"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up timer
        Timer1.Interval = 3000 ' 3 seconds for each signal
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update signal
        signalIndex = (signalIndex + 1) Mod signals.Length
        UpdateSignal()
    End Sub
    Private Sub UpdateSignal()
        ' Display current signal
        Select Case signals(signalIndex)
            Case "Red"
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
            Case "Yellow"
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
            Case "Green"
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
        End Select
    End Sub
End Class
