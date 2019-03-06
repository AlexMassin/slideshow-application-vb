<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quiz))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.radD = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("DJB Journaling Font", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(176, 74)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(376, 596)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "In what year was the Emperor Nero born?"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNext
        '
        Me.lblNext.BackColor = System.Drawing.Color.Transparent
        Me.lblNext.Font = New System.Drawing.Font("DJB Journaling Font", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(1032, 621)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(80, 58)
        Me.lblNext.TabIndex = 1
        Me.lblNext.Text = "➣"
        Me.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radA
        '
        Me.radA.BackColor = System.Drawing.Color.Transparent
        Me.radA.Font = New System.Drawing.Font("DJB Journaling Font", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radA.Location = New System.Drawing.Point(659, 91)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(408, 87)
        Me.radA.TabIndex = 2
        Me.radA.TabStop = True
        Me.radA.Text = "35 A.D."
        Me.radA.UseVisualStyleBackColor = False
        '
        'radB
        '
        Me.radB.BackColor = System.Drawing.Color.Transparent
        Me.radB.Font = New System.Drawing.Font("DJB Journaling Font", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radB.Location = New System.Drawing.Point(659, 201)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(408, 87)
        Me.radB.TabIndex = 3
        Me.radB.TabStop = True
        Me.radB.Text = "36 A.D."
        Me.radB.UseVisualStyleBackColor = False
        '
        'radC
        '
        Me.radC.BackColor = System.Drawing.Color.Transparent
        Me.radC.Font = New System.Drawing.Font("DJB Journaling Font", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radC.Location = New System.Drawing.Point(659, 319)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(408, 87)
        Me.radC.TabIndex = 4
        Me.radC.TabStop = True
        Me.radC.Text = "37 A.D."
        Me.radC.UseVisualStyleBackColor = False
        '
        'radD
        '
        Me.radD.BackColor = System.Drawing.Color.Transparent
        Me.radD.Font = New System.Drawing.Font("DJB Journaling Font", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radD.Location = New System.Drawing.Point(659, 435)
        Me.radD.Name = "radD"
        Me.radD.Size = New System.Drawing.Size(408, 87)
        Me.radD.TabIndex = 5
        Me.radD.TabStop = True
        Me.radD.Text = "38 A.D."
        Me.radD.UseVisualStyleBackColor = False
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1197, 740)
        Me.Controls.Add(Me.radD)
        Me.Controls.Add(Me.radC)
        Me.Controls.Add(Me.radB)
        Me.Controls.Add(Me.radA)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "Quiz"
        Me.Text = "Quiz"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents radB As System.Windows.Forms.RadioButton
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radD As System.Windows.Forms.RadioButton
End Class
