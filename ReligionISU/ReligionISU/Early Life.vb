Public Class Early_Life

    Private Sub Early_Life_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ToolTip1 = New ToolTip()


        ToolTip1.AutoPopDelay = 5000
        ToolTip1.InitialDelay = 1000
        ToolTip1.ReshowDelay = 500

        ToolTip1.ShowAlways = True

        ToolTip1.SetToolTip(PictureBox1,
                             "As a child,he liked to put on a disguise and then kill people who argued with him." & vbCrLf _
                            & "As Nero got older, he liked to engage in the games at the coliseum by dressing " & vbCrLf _
                            & "up in animal skins and attacking the people bound to stakes there. In specific, " & vbCrLf _
                            & "he liked to bite off their genitals.")
        ToolTip1.ToolTipTitle = "Fun Facts"
        ToolTip1.ForeColor = Color.Black
        ToolTip1.BackColor = Color.Coral
        ToolTip1.UseAnimation = True
        ToolTip1.IsBalloon = True
        Me.Label2.Text = "•	Born as Lucius Domitius Ahenodarbus" & vbCrLf _
& "•	He was the son of Gnaeus Domitius Ahenobarbus and Agrippina" & vbCrLf _
& "•	He was educated in the classical tradition by the philosopher Seneca" & vbCrLf _
& "•	Studied Greek, philosophy and rhetoric" & vbCrLf _
& "•	Ahenobarbus died in 48 A.D" & vbCrLf _
& "•	Agrippina married her uncle and persuaded him to make Nero his successor rather than his own son Britannicus" & vbCrLf _
& "•	Octavia becomes Nero’s wife because Claudius offers her to Nero" & vbCrLf _
& "•	Claudius died in 54 A.D." & vbCrLf _
& "•	Suspected that Agrippina had poisoned him" & vbCrLf _
& " •	When Nero took the throne he took the name Nero Claudius Caesar Augustus Germanicus"

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Static counter = 0
        counter += 1
        Me.PictureBox1.Image = My.Resources.nero2
        ToolTip1.RemoveAll()
        Me.Label1.Text = "Agrippina"
        Me.Label2.Text = "•	Was very domineering and attempted to control her son" & vbCrLf _
& "•	She hated Nero’s advisors and did not like the advice they gave" & vbCrLf _
& "•	Nero’s advisors were Seneca, his former tutor, and Burrus, the Praetorian Guard." & vbCrLf _
& "•	Agrippina tried to gain access to Nero’s personal life" & vbCrLf _
& "•	Got involved in affairs such as Nero’s affair with Claudia Acte" & vbCrLf _
& "•	After Nero denied his mother’s influence in both public and private matters, she got extremely mad." & vbCrLf _
& "•	She began supporting Britannicus as the new emperor even though he was a minor" & vbCrLf _
& "•	When Britannicus was about to become an adult he died. (55 A.D)" & vbCrLf _
& "•	Suspected that Nero poisoned Britannicus although Nero claimed he died of a seizure" & vbCrLf _
& "•	Agrippina tried to get the public against Nero but he banished her from the family palace" & vbCrLf _
& "•	Nero had another affair and his mother tried to get involved again" & vbCrLf _
& "•	This was the last straw and Nero had her killed in 59 A.D." & vbCrLf
        Me.Label3.Text = "Nero's father"
        If Me.Label3.Text = "Nero's father" And counter = 2 Then
            Me.Label1.Text = "Gnaeus Domitius"
            Me.PictureBox1.Image = My.Resources.Nero_s_Father
            Me.Label2.Text = "•	Some believe Nero’s fate was inevitable" & vbCrLf _
& "•	Nero’s father, Gnaeus Domitius, died when he was three" & vbCrLf _
& "•	His father was extremely violent and ruthless" & vbCrLf _
& "•	People described him as a despicable character." & vbCrLf _
& "•	One he deliberately ran over a young boy with his chariot" & vbCrLf _
& "•	When Nero was born, people were congratulating Gnaeus" & vbCrLf _
& "•	Gnaeus responded by saying that anything born to Agrippina and him would be unlikeable and a disaster" & vbCrLf
            Me.Label3.Visible = False


        End If
    End Sub
End Class