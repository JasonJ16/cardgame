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
        Me.btnStand = New System.Windows.Forms.Button()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStand
        '
        Me.btnStand.Location = New System.Drawing.Point(231, 361)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(75, 23)
        Me.btnStand.TabIndex = 0
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(545, 361)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(75, 23)
        Me.btnDeal.TabIndex = 1
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(382, 361)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(75, 23)
        Me.btnHit.TabIndex = 2
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(691, 361)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.Location = New System.Drawing.Point(908, 153)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(39, 13)
        Me.lblCompScore.TabIndex = 4
        Me.lblCompScore.Text = "Label1"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(908, 223)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(39, 13)
        Me.lblPlayerScore.TabIndex = 5
        Me.lblPlayerScore.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 471)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.btnStand)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStand As Button
    Friend WithEvents btnDeal As Button
    Friend WithEvents btnHit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCompScore As Label
    Friend WithEvents lblPlayerScore As Label
End Class
