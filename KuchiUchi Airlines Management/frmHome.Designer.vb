<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFlight = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPassenger = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Heiti Std R", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(132, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(638, 40)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Welcome to Airline Management System"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox1.Location = New System.Drawing.Point(38, 242)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(759, 397)
        Me.TextBox1.TabIndex = 14
        '
        'btnFlight
        '
        Me.btnFlight.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFlight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFlight.Location = New System.Drawing.Point(250, 167)
        Me.btnFlight.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFlight.Name = "btnFlight"
        Me.btnFlight.Size = New System.Drawing.Size(133, 49)
        Me.btnFlight.TabIndex = 13
        Me.btnFlight.Text = "Flight"
        Me.btnFlight.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbout.Location = New System.Drawing.Point(417, 167)
        Me.btnAbout.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(133, 49)
        Me.btnAbout.TabIndex = 12
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(588, 167)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 49)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPassenger
        '
        Me.btnPassenger.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPassenger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPassenger.Location = New System.Drawing.Point(-147, 99)
        Me.btnPassenger.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPassenger.Name = "btnPassenger"
        Me.btnPassenger.Size = New System.Drawing.Size(133, 49)
        Me.btnPassenger.TabIndex = 10
        Me.btnPassenger.Text = "Passenger"
        Me.btnPassenger.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(-9, -60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 76)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kuchiuchi Air Travel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(220, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(479, 76)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "KuchiUchi Air Travel"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(80, 167)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 49)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Flight"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(841, 674)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnFlight)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPassenger)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnFlight As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPassenger As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
