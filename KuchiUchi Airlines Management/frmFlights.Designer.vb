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
        Me.txtArriveAirport = New System.Windows.Forms.TextBox()
        Me.lblArrive = New System.Windows.Forms.Label()
        Me.txtFlightName = New System.Windows.Forms.TextBox()
        Me.lblFlightname = New System.Windows.Forms.Label()
        Me.txtNoOfSeats = New System.Windows.Forms.TextBox()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.txtDepartAirport = New System.Windows.Forms.TextBox()
        Me.lblDepart = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(249, 364)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 20)
        Me.DateTimePicker1.TabIndex = 37
        '
        'txtArriveAirport
        '
        Me.txtArriveAirport.Location = New System.Drawing.Point(606, 284)
        Me.txtArriveAirport.Name = "txtArriveAirport"
        Me.txtArriveAirport.Size = New System.Drawing.Size(195, 20)
        Me.txtArriveAirport.TabIndex = 36
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
        'txtFlightName
        '
        Me.txtFlightName.Location = New System.Drawing.Point(249, 210)
        Me.txtFlightName.Name = "txtFlightName"
        Me.txtFlightName.Size = New System.Drawing.Size(206, 20)
        Me.txtFlightName.TabIndex = 34
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
        'txtNoOfSeats
        '
        Me.txtNoOfSeats.Location = New System.Drawing.Point(606, 210)
        Me.txtNoOfSeats.Name = "txtNoOfSeats"
        Me.txtNoOfSeats.Size = New System.Drawing.Size(195, 20)
        Me.txtNoOfSeats.TabIndex = 32
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
        'txtDepartAirport
        '
        Me.txtDepartAirport.Location = New System.Drawing.Point(249, 279)
        Me.txtDepartAirport.Name = "txtDepartAirport"
        Me.txtDepartAirport.Size = New System.Drawing.Size(206, 20)
        Me.txtDepartAirport.TabIndex = 30
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
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(249, 457)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 49)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancel.Location = New System.Drawing.Point(442, 457)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 49)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(842, 576)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtArriveAirport)
        Me.Controls.Add(Me.lblArrive)
        Me.Controls.Add(Me.txtFlightName)
        Me.Controls.Add(Me.lblFlightname)
        Me.Controls.Add(Me.txtNoOfSeats)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.txtDepartAirport)
        Me.Controls.Add(Me.lblDepart)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmFlights"
        Me.Text = "frmFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtArriveAirport As System.Windows.Forms.TextBox
    Friend WithEvents lblArrive As System.Windows.Forms.Label
    Friend WithEvents txtFlightName As System.Windows.Forms.TextBox
    Friend WithEvents lblFlightname As System.Windows.Forms.Label
    Friend WithEvents txtNoOfSeats As System.Windows.Forms.TextBox
    Friend WithEvents lblSeats As System.Windows.Forms.Label
    Friend WithEvents txtDepartAirport As System.Windows.Forms.TextBox
    Friend WithEvents lblDepart As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
