<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlights
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblArrive = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblFlightname = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblDepart = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 364)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 20)
        Me.DateTimePicker1.TabIndex = 37
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(606, 284)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(195, 20)
        Me.TextBox5.TabIndex = 36
        '
        'lblArrive
        '
        Me.lblArrive.AutoSize = True
        Me.lblArrive.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrive.Location = New System.Drawing.Point(479, 281)
        Me.lblArrive.Name = "lblArrive"
        Me.lblArrive.Size = New System.Drawing.Size(111, 23)
        Me.lblArrive.TabIndex = 35
        Me.lblArrive.Text = "Arrive Airport"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(249, 210)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(206, 20)
        Me.TextBox4.TabIndex = 34
        '
        'lblFlightname
        '
        Me.lblFlightname.AutoSize = True
        Me.lblFlightname.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightname.Location = New System.Drawing.Point(107, 205)
        Me.lblFlightname.Name = "lblFlightname"
        Me.lblFlightname.Size = New System.Drawing.Size(100, 23)
        Me.lblFlightname.TabIndex = 33
        Me.lblFlightname.Text = "Flight Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(606, 210)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(195, 20)
        Me.TextBox3.TabIndex = 32
        '
        'lblSeats
        '
        Me.lblSeats.AutoSize = True
        Me.lblSeats.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.Location = New System.Drawing.Point(490, 207)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(100, 23)
        Me.lblSeats.TabIndex = 31
        Me.lblSeats.Text = "No. of Seats"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(249, 279)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(206, 20)
        Me.TextBox2.TabIndex = 30
        '
        'lblDepart
        '
        Me.lblDepart.AutoSize = True
        Me.lblDepart.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepart.Location = New System.Drawing.Point(91, 289)
        Me.lblDepart.Name = "lblDepart"
        Me.lblDepart.Size = New System.Drawing.Size(116, 23)
        Me.lblDepart.TabIndex = 29
        Me.lblDepart.Text = "Depart Airport"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(39, 361)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(168, 23)
        Me.lblDate.TabIndex = 28
        Me.lblDate.Text = "Departure Date & Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Heiti Std R", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(363, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 34)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Flight Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(236, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(479, 76)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "KuchiUchi Air Travel"
        '
        'frmFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(842, 445)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.lblArrive)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblFlightname)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblDepart)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmFlights"
        Me.Text = "frmFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents lblArrive As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblFlightname As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblSeats As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDepart As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
