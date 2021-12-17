<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnStand = New System.Windows.Forms.Button()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtPlayerScore = New System.Windows.Forms.TextBox()
        Me.txtCompScore = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStand
        '
        Me.btnStand.Location = New System.Drawing.Point(123, 521)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(96, 34)
        Me.btnStand.TabIndex = 0
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(439, 521)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(105, 34)
        Me.btnDeal.TabIndex = 1
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(274, 521)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(111, 34)
        Me.btnHit.TabIndex = 2
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(594, 521)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(102, 34)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Shuffle Deck"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Location = New System.Drawing.Point(178, 461)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(77, 13)
        Me.lblScore1.TabIndex = 4
        Me.lblScore1.Text = "Player's Score:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(179, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(93, 13)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "Computer's Score:"
        '
        'txtPlayerScore
        '
        Me.txtPlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerScore.Location = New System.Drawing.Point(258, 455)
        Me.txtPlayerScore.Name = "txtPlayerScore"
        Me.txtPlayerScore.ReadOnly = True
        Me.txtPlayerScore.Size = New System.Drawing.Size(286, 29)
        Me.txtPlayerScore.TabIndex = 6
        '
        'txtCompScore
        '
        Me.txtCompScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompScore.Location = New System.Drawing.Point(274, 71)
        Me.txtCompScore.Name = "txtCompScore"
        Me.txtCompScore.ReadOnly = True
        Me.txtCompScore.Size = New System.Drawing.Size(286, 29)
        Me.txtCompScore.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 39)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Blackjack"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(358, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Computer Stands on 17"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompScore)
        Me.Controls.Add(Me.txtPlayerScore)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.btnStand)
        Me.Name = "Form1"
        Me.Text = "Blackjack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStand As Button
    Friend WithEvents btnDeal As Button
    Friend WithEvents btnHit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtPlayerScore As TextBox
    Friend WithEvents txtCompScore As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
