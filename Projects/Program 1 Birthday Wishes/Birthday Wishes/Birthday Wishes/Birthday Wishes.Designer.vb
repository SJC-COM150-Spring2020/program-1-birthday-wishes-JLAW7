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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHappyBirthday = New System.Windows.Forms.Label()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHappyBirthday
        '
        Me.lblHappyBirthday.AutoSize = True
        Me.lblHappyBirthday.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblHappyBirthday.Font = New System.Drawing.Font("Script MT Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHappyBirthday.ForeColor = System.Drawing.Color.Yellow
        Me.lblHappyBirthday.Location = New System.Drawing.Point(272, 9)
        Me.lblHappyBirthday.Name = "lblHappyBirthday"
        Me.lblHappyBirthday.Size = New System.Drawing.Size(413, 44)
        Me.lblHappyBirthday.TabIndex = 0
        Me.lblHappyBirthday.Text = "Birthday Wishes Program"
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Transparent
        Me.btnClick.BackgroundImage = CType(resources.GetObject("btnClick.BackgroundImage"), System.Drawing.Image)
        Me.btnClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClick.Location = New System.Drawing.Point(211, 248)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(521, 259)
        Me.btnClick.TabIndex = 2
        Me.btnClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.BackColor = System.Drawing.Color.Yellow
        Me.lstOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstOut.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 25
        Me.lstOut.Location = New System.Drawing.Point(211, 537)
        Me.lstOut.MultiColumn = True
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(521, 102)
        Me.lstOut.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Yellow
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtName.Location = New System.Drawing.Point(394, 186)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(156, 32)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "Name?"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBirthday.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.Yellow
        Me.lblBirthday.Location = New System.Drawing.Point(224, 130)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(496, 25)
        Me.lblBirthday.TabIndex = 5
        Me.lblBirthday.Text = "Enter Your Name Then Click On Your Gift !"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Yellow
        Me.btnClear.Location = New System.Drawing.Point(775, 564)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 37)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(775, 771)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 835)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lblHappyBirthday)
        Me.Name = "Form1"
        Me.Text = "Birthday Wishes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHappyBirthday As Label
    Friend WithEvents btnClick As Button
    Friend WithEvents lstOut As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
