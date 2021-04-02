<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyRight = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCNName = New System.Windows.Forms.Label()
        Me.lblPNName = New System.Windows.Forms.Label()
        Me.LblVNName = New System.Windows.Forms.Label()
        Me.LblCopyRightDes = New System.Windows.Forms.Label()
        Me.LblProductName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAboutDes = New System.Windows.Forms.Label()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.InitialImage = CType(resources.GetObject("PicLogo.InitialImage"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(111, 12)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(545, 114)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 3
        Me.PicLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 65)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Zesto Movie Store"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(78, 188)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 7
        Me.lblCompanyName.Text = "Company Name"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(78, 276)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "Version"
        '
        'lblCopyRight
        '
        Me.lblCopyRight.AutoSize = True
        Me.lblCopyRight.Location = New System.Drawing.Point(78, 318)
        Me.lblCopyRight.Name = "lblCopyRight"
        Me.lblCopyRight.Size = New System.Drawing.Size(59, 13)
        Me.lblCopyRight.TabIndex = 9
        Me.lblCopyRight.Text = "Copy Right"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(78, 368)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "Description"
        '
        'lblCNName
        '
        Me.lblCNName.AutoSize = True
        Me.lblCNName.Location = New System.Drawing.Point(349, 188)
        Me.lblCNName.Name = "lblCNName"
        Me.lblCNName.Size = New System.Drawing.Size(137, 13)
        Me.lblCNName.TabIndex = 11
        Me.lblCNName.Text = "Midlands Technical College"
        '
        'lblPNName
        '
        Me.lblPNName.AutoSize = True
        Me.lblPNName.Location = New System.Drawing.Point(349, 234)
        Me.lblPNName.Name = "lblPNName"
        Me.lblPNName.Size = New System.Drawing.Size(88, 13)
        Me.lblPNName.TabIndex = 12
        Me.lblPNName.Text = "ZestoMovieStore"
        '
        'LblVNName
        '
        Me.LblVNName.AutoSize = True
        Me.LblVNName.Location = New System.Drawing.Point(349, 276)
        Me.LblVNName.Name = "LblVNName"
        Me.LblVNName.Size = New System.Drawing.Size(91, 13)
        Me.LblVNName.TabIndex = 13
        Me.LblVNName.Text = "Version {0}.{1:00}"
        '
        'LblCopyRightDes
        '
        Me.LblCopyRightDes.AutoSize = True
        Me.LblCopyRightDes.Location = New System.Drawing.Point(349, 318)
        Me.LblCopyRightDes.Name = "LblCopyRightDes"
        Me.LblCopyRightDes.Size = New System.Drawing.Size(223, 13)
        Me.LblCopyRightDes.TabIndex = 14
        Me.LblCopyRightDes.Text = "Copyright © Midlands Technical College 2021"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(78, 234)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(75, 13)
        Me.LblProductName.TabIndex = 15
        Me.LblProductName.Text = "Product Name"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(365, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAboutDes
        '
        Me.lblAboutDes.AutoSize = True
        Me.lblAboutDes.Location = New System.Drawing.Point(349, 359)
        Me.lblAboutDes.Name = "lblAboutDes"
        Me.lblAboutDes.Size = New System.Drawing.Size(216, 13)
        Me.lblAboutDes.TabIndex = 18
        Me.lblAboutDes.Text = "This Application runs the Zesto Movie Store."
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 471)
        Me.Controls.Add(Me.lblAboutDes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.LblProductName)
        Me.Controls.Add(Me.LblCopyRightDes)
        Me.Controls.Add(Me.LblVNName)
        Me.Controls.Add(Me.lblPNName)
        Me.Controls.Add(Me.lblCNName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCopyRight)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "AboutForm"
        Me.Text = "About"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyRight As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCNName As Label
    Friend WithEvents lblPNName As Label
    Friend WithEvents LblVNName As Label
    Friend WithEvents LblCopyRightDes As Label
    Friend WithEvents LblProductName As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAboutDes As Label
End Class
