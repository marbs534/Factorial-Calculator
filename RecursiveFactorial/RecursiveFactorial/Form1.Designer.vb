<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FactorialCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        userInputLbl = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        factorialTxtbox = New TextBox()
        calculateBtn = New Button()
        answerLbl = New Label()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' userInputLbl
        ' 
        userInputLbl.AutoSize = True
        userInputLbl.Location = New Point(3, 0)
        userInputLbl.Name = "userInputLbl"
        userInputLbl.Size = New Size(85, 15)
        userInputLbl.TabIndex = 0
        userInputLbl.Text = "Enter Factorial:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(userInputLbl)
        FlowLayoutPanel1.Controls.Add(factorialTxtbox)
        FlowLayoutPanel1.Controls.Add(calculateBtn)
        FlowLayoutPanel1.Controls.Add(answerLbl)
        FlowLayoutPanel1.Location = New Point(12, 28)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(416, 142)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' factorialTxtbox
        ' 
        factorialTxtbox.Location = New Point(94, 3)
        factorialTxtbox.Name = "factorialTxtbox"
        factorialTxtbox.Size = New Size(168, 23)
        factorialTxtbox.TabIndex = 1
        ' 
        ' calculateBtn
        ' 
        calculateBtn.Location = New Point(268, 3)
        calculateBtn.Name = "calculateBtn"
        calculateBtn.Size = New Size(75, 23)
        calculateBtn.TabIndex = 2
        calculateBtn.Text = "Calculate"
        calculateBtn.UseVisualStyleBackColor = True
        ' 
        ' answerLbl
        ' 
        answerLbl.AutoSize = True
        answerLbl.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        answerLbl.Location = New Point(349, 0)
        answerLbl.Name = "answerLbl"
        answerLbl.Size = New Size(0, 18)
        answerLbl.TabIndex = 3
        ' 
        ' FactorialCalculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(529, 304)
        Controls.Add(FlowLayoutPanel1)
        Name = "FactorialCalculator"
        Text = "Factorial Calculator"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents userInputLbl As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents factorialTxtbox As TextBox
    Friend WithEvents calculateBtn As Button
    Friend WithEvents answerLbl As Label

End Class
