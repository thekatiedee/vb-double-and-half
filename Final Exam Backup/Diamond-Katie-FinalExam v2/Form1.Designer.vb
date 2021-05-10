<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.intNum = New System.Windows.Forms.TextBox()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnDouble = New System.Windows.Forms.Button()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'intNum
        '
        Me.intNum.Location = New System.Drawing.Point(403, 69)
        Me.intNum.Name = "intNum"
        Me.intNum.Size = New System.Drawing.Size(125, 27)
        Me.intNum.TabIndex = 0
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(197, 72)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(117, 20)
        Me.lblEnter.TabIndex = 1
        Me.lblEnter.Text = "Enter an integer:"
        '
        'btnDouble
        '
        Me.btnDouble.Location = New System.Drawing.Point(229, 203)
        Me.btnDouble.Name = "btnDouble"
        Me.btnDouble.Size = New System.Drawing.Size(94, 29)
        Me.btnDouble.TabIndex = 2
        Me.btnDouble.Text = "DOUBLE"
        Me.btnDouble.UseVisualStyleBackColor = True
        '
        'btnHalf
        '
        Me.btnHalf.Location = New System.Drawing.Point(414, 203)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(94, 29)
        Me.btnHalf.TabIndex = 3
        Me.btnHalf.Text = "HALF"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnDouble)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.intNum)
        Me.Name = "Form1"
        Me.Text = "Katie Diamond's Final Exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents intNum As TextBox
    Friend WithEvents lblEnter As Label
    Friend WithEvents btnDouble As Button
    Friend WithEvents btnHalf As Button
End Class
