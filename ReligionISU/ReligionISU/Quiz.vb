Public Class Quiz


    Private Sub lblNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNext.Click
        Static question As Integer = 0
        Static COUNTER As Integer = 0
        question += 1
        Select question
            Case 1
                lblQuestion.Text = "What was Nero's birth name?"
                radA.Text = "Lucius Gominitus Ahenodarbus"
                radB.Text = "Gnaeus Domitius Ahenodarbus"
                radC.Text = "Burrus Domitius Ahenodarbus"
                radD.Text = "Allen Schenk"
            Case 2
                lblQuestion.Text = "How did Nero become Emperor?"
                radA.Text = "He proved his loyalty to Claudius and to honour his loyalty, Claudius made him his successor"
                radB.Text = "He poisoned Claudius and took the throne himself"
                radC.Text = "He killed Britannicus and then took the throne"
                radD.Text = "His mother persuaded Claudius to make Nero his successor"
            Case 3
                lblQuestion.Text = "When did Claudius die?"
                radA.Text = "52 A.D."
                radB.Text = "53 A.D."
                radC.Text = "54 A.D."
                radD.Text = "55 A.D."
            Case 4
                lblQuestion.Text = "How did Claudius die?"
                radA.Text = "Nero's mother poisoned him"
                radB.Text = "Nero poisoned him"
                radC.Text = "Britannicus poisoned him because he made Nero his successor"
                radD.Text = "He ate some rotten pork."
            Case 5
                lblQuestion.Text = "What was the name of Nero's tutor?"
                radA.Text = "York"
                radB.Text = "Ryerson"
                radC.Text = "Queens"
                radD.Text = "Seneca"
            Case 6
                lblQuestion.Text = "What was the name Nero took as he became emperor?"
                radA.Text = "Nero Caesar Augustus Germanicus Claudius"
                radB.Text = "Nero Claudius Caesar Augustus Germanicus"
                radC.Text = "Nero Augustus Germanicus Claudius Caesar"
                radD.Text = "Nero Germanicus Augustus Caesar Claudius"
            Case 7
                lblQuestion.Text = "What did Nero study while being tutored by Seneca?"
                radA.Text = "Greek philosophy"
                radB.Text = "Roman literature"
                radC.Text = "Greek rhetoric"
                radD.Text = "A and C"
            Case 8
                lblQuestion.Text = "When did Agrippina die?"
                radA.Text = "55 A.D."
                radB.Text = "48 A.D."
                radC.Text = "59 A.D."
                radD.Text = "58 A.D."
            Case 9
                lblQuestion.Text = "How many affairs did Nero have?"
                radA.Text = "3"
                radB.Text = "4"
                radC.Text = "2"
                radD.Text = "1.5"
            Case 10
                lblQuestion.Text = "Who was Poppaea married to when she had an affair with Nero?"
                radA.Text = "Galba"
                radB.Text = "Vitellius"
                radC.Text = "Otho"
                radD.Text = "Vespasianus"
            Case 11
                lblQuestion.Text = "How did Poppaea die?"
                radA.Text = "She died during childbirth"
                radB.Text = "Nero was done with her and poisoned her food"
                radC.Text = "She was killed by Otho who was her husband at the time"
                radD.Text = "Nero kicked her in the stomach and it killed her"
            Case 12
                lblQuestion.Text = "What made Nero a good emperor?"
                radA.Text = "He eliminated capital punishment"
                radB.Text = "He lowered taxes"
                radC.Text = "He allowed slaves to make complaints"
                radD.Text = "All of the above"
            Case 13
                lblQuestion.Text = "What was Nero a huge supporter of?"
                radA.Text = "the Arts"
                radB.Text = "Athetics"
                radC.Text = "Mathematics"
                radD.Text = "A and B"
            Case 14
                lblQuestion.Text = "What made Nero become a tyrant?"
                radA.Text = "Burrus died and Seneca retired"
                radB.Text = "He killed his mother"
                radC.Text = "Many opponents were threatening his position as emperor"
                radD.Text = "A and B"
            Case 15
                lblQuestion.Text = "Why did Nero start the Great Fire?"
                radA.Text = "He saw Rome needed to renovate"
                radB.Text = "He hated Rome and wanted to watch it burn"
                radC.Text = "He wanted to make room to build his Golden Palace"
                radD.Text = "He decided that the only way to gain complete control is showing his true power"
            Case 16
                lblQuestion.Text = "Who was blamed for the Great Fire?"
                radA.Text = "The Jews"
                radB.Text = "Nero"
                radC.Text = "the Christians"
                radD.Text = "Romans themselves"
            Case 17
                lblQuestion.Text = "How did Nero die?"
                radA.Text = "The Senate issued him to be beaten to death"
                radB.Text = "His assistant murdered him"
                radC.Text = "He committed suicide"
                radD.Text = "He was assassinated by Gaius Calpurnius Piso"
        End Select
        If radC.Checked = True And question = 1 Then
            COUNTER += 1
        ElseIf radA.Checked = True And question = 2 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 3 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 4 Then
            COUNTER += 1
        ElseIf radA.Checked = True And question = 5 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 6 Then
            COUNTER += 1
        ElseIf radB.Checked = True And question = 7 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 8 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 9 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 10 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 11 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 12 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 13 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 14 Then
            COUNTER += 1
        ElseIf radD.Checked = True And question = 15 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 16 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 17 Then
            COUNTER += 1
        ElseIf radC.Checked = True And question = 18 Then
            COUNTER += 1
        End If
        If question = 18 Then
            MsgBox("Your score is " & COUNTER & "/17!")
        End If
        radA.Checked = False
        radB.Checked = False
        radC.Checked = False
        radD.Checked = False
    End Sub
End Class