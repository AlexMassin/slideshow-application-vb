Public Class Form1

  

    Private Sub lblEarlyLife_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEarlyLife.Click
        Early_Life.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1 = New ToolTip()


        ToolTip1.AutoPopDelay = 10000
        ToolTip1.InitialDelay = 100
        ToolTip1.ReshowDelay = 500

        ToolTip1.ShowAlways = True

        ToolTip1.SetToolTip(PictureBox1, "Summary:" & vbCrLf _
& " •	Born in 37 A.D." & vbCrLf _
& "•	The nephew of the emperor" & vbCrLf _
& "•	Mother married his great uncle Claudius" & vbCrLf _
& "•	Persuaded him to name Nero his successor" & vbCrLf _
& "•	Took the throne at the age of 17" & vbCrLf _
& "•	Killed mother because she was too controlling" & vbCrLf _
& "•	Began executing opponents and Christians" & vbCrLf _
& "•	In 68 A.D. he committed suicide"
)

        ToolTip1.IsBalloon = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Middle_Life.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Late_Life.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Quiz.Show()
    End Sub
End Class
