<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengers
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNme = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 383)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(210, 329)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(248, 20)
        Me.TextBox3.TabIndex = 26
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(210, 256)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 20)
        Me.TextBox2.TabIndex = 25
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 24
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(77, 380)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(79, 23)
        Me.lblBirthday.TabIndex = 23
        Me.lblBirthday.Text = "Birthday:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(73, 253)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(83, 23)
        Me.lblSurname.TabIndex = 22
        Me.lblSurname.Text = "Surname:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(118, 324)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(38, 23)
        Me.lblID.TabIndex = 21
        Me.lblID.Text = "I.D.:"
        '
        'lblNme
        '
        Me.lblNme.AutoSize = True
        Me.lblNme.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNme.Location = New System.Drawing.Point(98, 181)
        Me.lblNme.Name = "lblNme"
        Me.lblNme.Size = New System.Drawing.Size(58, 23)
        Me.lblNme.TabIndex = 20
        Me.lblNme.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(182, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 34)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Passenger Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(74, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(479, 76)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "KuchiUchi Air Travel"
        '
        'btnSignin
        '
        Me.btnSignin.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSignin.Location = New System.Drawing.Point(210, 434)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(95, 36)
        Me.btnSignin.TabIndex = 34
        Me.btnSignin.Text = "Back"
        Me.btnSignin.UseVisualStyleBackColor = True
        '
        'frmPassengers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(615, 529)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblNme)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmPassengers"
        Me.Text = "frmPassengers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthday As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblNme As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSignin As System.Windows.Forms.Button
End Class
