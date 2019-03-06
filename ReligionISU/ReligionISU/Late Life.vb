Public Class Late_Life



    Private Sub Late_Life_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label2.Text = "•	By 64 A.D., Nero’s scandalous, self-indulgent lifestyle began to cause controversy" & vbCrLf _
& "•	However, the public’s attention was focused towards the Great Fire" & vbCrLf _
& "•	The Great Fire began on July 19th, 64 A.D." & vbCrLf _
& "•	The fire started in stores at the southeastern end of the Circus Maximus" & vbCrLf _
& "•	It ravaged Rome for 10 days and about 75% of the city was destroyed" & vbCrLf _
& "•	Ten of the fourteen districts of the city were destroyed" & vbCrLf _
& "•	Many believed that Nero started the fire to make room for his planned villa (Domus Aurea)" & vbCrLf _
& "•	It is also believed that Nero played his lyre while the city burned" & vbCrLf _
& "•	While the Tower of Maecenas engulfed in flames, Nero called it 'the beauty of the flames'" & vbCrLf _
& "•	Nero directed the blame towards the Christians" & vbCrLf _
& "•	Christianity at the time was still new and underground" & vbCrLf _
& "•	This lead to the persecution and torture of the Christians in Rome" & vbCrLf

        ToolTip1 = New ToolTip()


        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500

        ToolTip1.ShowAlways = True

        ToolTip1.SetToolTip(PictureBox1, "•	Rebuilt residential districts" & vbCrLf _
& "•	Wider streets" & vbCrLf _
& "•	Brick buildings" & vbCrLf _
& "•	Colonnades at street level (Sheltered residents from the sun)" & vbCrLf _
& "•	Nero’s Golden Palace" & vbCrLf _
& "  o	Contained gold plated ceilings, a lake, and exotic animals" & vbCrLf _
& "  o	Many believe he started the fire to build his palace" & vbCrLf)

        ToolTip1.ToolTipTitle = "Benefits of the Great Fire:"
        ToolTip1.ForeColor = Color.Black
        ToolTip1.BackColor = Color.Coral
        ToolTip1.UseAnimation = True
        ToolTip1.IsBalloon = True

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Label2.Text = "•	Nero’s demise started for a number of reasons" & vbCrLf _
& "•	The fire, the conspiracy, the numerous insurrections, and the empty treasury led people to question Nero’s reign" & vbCrLf _
& "•	He wanted to build Domus Aurea still but he needed a lot of money" & vbCrLf _
& "•	He sold positions in public office to the highest bidder, increased taxes and took money from the temples" & vbCrLf _
& "•	He on purposely devalued currency and reinstituted policies to take property in cases of suspected treason" & vbCrLf _
& "•	All these new policies created the Pisonian conspiracy" & vbCrLf _
& "•	It was a plot formed by Gaius Calpurnius Piso, and a number of people, to assassinate Nero and crown Piso the ruler of Rome" & vbCrLf _
& "•	The plan was uncovered and many Romans got executed for it" & vbCrLf _
& "•	The Senate declared him as an enemy and named Galba the new emperor" & vbCrLf _
& "•	Nero, knowing his days were numbered, fled to provinces that were still loyal to him" & vbCrLf _
& "•	This was the plan but he abandoned it after his officers refused to obey him" & vbCrLf _
& "•	The Senate condemned him to death by beating so instead Nero decided to commit suicide" & vbCrLf _
& "•	He could not do it alone so he had Epaphroditos, his secretary, to assist him" & vbCrLf _
& "•	His last words were: 'What an artist dies in me.'" & vbCrLf _
& "•	He was the last of the Julio-Claudian emperors" & vbCrLf
        Me.Label1.Text = "Nero's Death"
        Me.Label3.Visible = False
        ToolTip1.RemoveAll()
        Me.PictureBox1.Image = My.Resources.zpage420
        Me.BackgroundImage = Nothing
        Me.BackColor = Color.Gray
    End Sub

 
End Class