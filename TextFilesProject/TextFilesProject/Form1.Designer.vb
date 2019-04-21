<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acronyms
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstText = New System.Windows.Forms.ListBox()
        Me.lstTranslation = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtDefinition = New System.Windows.Forms.TextBox()
        Me.txtNewLine = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(605, 576)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(182, 103)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(523, 66)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(391, 146)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Refresh"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstText
        '
        Me.lstText.FormattingEnabled = True
        Me.lstText.ItemHeight = 25
        Me.lstText.Location = New System.Drawing.Point(1002, 25)
        Me.lstText.Name = "lstText"
        Me.lstText.Size = New System.Drawing.Size(449, 729)
        Me.lstText.TabIndex = 2
        '
        'lstTranslation
        '
        Me.lstTranslation.BackColor = System.Drawing.Color.White
        Me.lstTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTranslation.FormattingEnabled = True
        Me.lstTranslation.ItemHeight = 25
        Me.lstTranslation.Location = New System.Drawing.Point(12, 12)
        Me.lstTranslation.Name = "lstTranslation"
        Me.lstTranslation.Size = New System.Drawing.Size(397, 727)
        Me.lstTranslation.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(495, 315)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(464, 31)
        Me.TextBox1.TabIndex = 4
        '
        'txtDefinition
        '
        Me.txtDefinition.Location = New System.Drawing.Point(717, 468)
        Me.txtDefinition.Name = "txtDefinition"
        Me.txtDefinition.Size = New System.Drawing.Size(279, 31)
        Me.txtDefinition.TabIndex = 5
        '
        'txtNewLine
        '
        Me.txtNewLine.Location = New System.Drawing.Point(415, 468)
        Me.txtNewLine.Name = "txtNewLine"
        Me.txtNewLine.Size = New System.Drawing.Size(260, 31)
        Me.txtNewLine.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Translation: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Add New:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 520)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Acronym"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(819, 520)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Meaning"
        '
        'Acronyms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1463, 1042)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewLine)
        Me.Controls.Add(Me.txtDefinition)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstTranslation)
        Me.Controls.Add(Me.lstText)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnAdd)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Acronyms"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents lstText As ListBox
    Friend WithEvents lstTranslation As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtDefinition As TextBox
    Friend WithEvents txtNewLine As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
