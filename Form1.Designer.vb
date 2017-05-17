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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTopLeft = New System.Windows.Forms.Label()
        Me.lblTopRight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDownload = New System.Windows.Forms.Label()
        Me.dlBar = New System.Windows.Forms.ProgressBar()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblForgeNotification = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTopLeft
        '
        Me.lblTopLeft.AutoSize = True
        Me.lblTopLeft.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopLeft.ForeColor = System.Drawing.Color.White
        Me.lblTopLeft.Location = New System.Drawing.Point(25, 7)
        Me.lblTopLeft.Name = "lblTopLeft"
        Me.lblTopLeft.Size = New System.Drawing.Size(175, 13)
        Me.lblTopLeft.TabIndex = 0
        Me.lblTopLeft.Text = "DECIMATION - LAUNCHER - v1.0"
        '
        'lblTopRight
        '
        Me.lblTopRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTopRight.AutoSize = True
        Me.lblTopRight.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopRight.ForeColor = System.Drawing.Color.White
        Me.lblTopRight.Location = New System.Drawing.Point(362, 7)
        Me.lblTopRight.Name = "lblTopRight"
        Me.lblTopRight.Size = New System.Drawing.Size(102, 13)
        Me.lblTopRight.TabIndex = 1
        Me.lblTopRight.Text = "OFFICIAL WEBSITE"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblDownload)
        Me.Panel1.Controls.Add(Me.dlBar)
        Me.Panel1.Controls.Add(Me.progBar)
        Me.Panel1.Controls.Add(Me.picMain)
        Me.Panel1.Location = New System.Drawing.Point(-6, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 292)
        Me.Panel1.TabIndex = 6
        '
        'lblDownload
        '
        Me.lblDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDownload.AutoSize = True
        Me.lblDownload.BackColor = System.Drawing.Color.Black
        Me.lblDownload.ForeColor = System.Drawing.Color.Lime
        Me.lblDownload.Location = New System.Drawing.Point(9, 14)
        Me.lblDownload.Name = "lblDownload"
        Me.lblDownload.Size = New System.Drawing.Size(81, 13)
        Me.lblDownload.TabIndex = 10
        Me.lblDownload.Text = "Download Time"
        Me.lblDownload.Visible = False
        '
        'dlBar
        '
        Me.dlBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dlBar.BackColor = System.Drawing.Color.DarkRed
        Me.dlBar.Location = New System.Drawing.Point(0, 6)
        Me.dlBar.Name = "dlBar"
        Me.dlBar.Size = New System.Drawing.Size(480, 5)
        Me.dlBar.Step = 1
        Me.dlBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.dlBar.TabIndex = 2
        Me.dlBar.Visible = False
        '
        'progBar
        '
        Me.progBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progBar.Location = New System.Drawing.Point(0, 0)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(480, 5)
        Me.progBar.Step = 1
        Me.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progBar.TabIndex = 1
        Me.progBar.Visible = False
        '
        'picMain
        '
        Me.picMain.BackColor = System.Drawing.Color.Black
        Me.picMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMain.Image = Global.DecimationLauncher.My.Resources.Resources.launcher_image
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(479, 292)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.ForeColor = System.Drawing.Color.Gray
        Me.lblVersion.Location = New System.Drawing.Point(3, 465)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(42, 13)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "Version"
        '
        'lblForgeNotification
        '
        Me.lblForgeNotification.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblForgeNotification.AutoSize = True
        Me.lblForgeNotification.BackColor = System.Drawing.Color.Transparent
        Me.lblForgeNotification.ForeColor = System.Drawing.Color.IndianRed
        Me.lblForgeNotification.Location = New System.Drawing.Point(3, 447)
        Me.lblForgeNotification.Name = "lblForgeNotification"
        Me.lblForgeNotification.Size = New System.Drawing.Size(0, 13)
        Me.lblForgeNotification.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnLaunch
        '
        Me.btnLaunch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLaunch.BackColor = System.Drawing.Color.Black
        Me.btnLaunch.BackgroundImage = Global.DecimationLauncher.My.Resources.Resources.button
        Me.btnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLaunch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLaunch.FlatAppearance.BorderSize = 0
        Me.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaunch.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.ForeColor = System.Drawing.Color.White
        Me.btnLaunch.Location = New System.Drawing.Point(104, 362)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(262, 70)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "INSTALL/UPDATE"
        Me.btnLaunch.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.DecimationLauncher.My.Resources.Resources.stone_wallpaper
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = Global.DecimationLauncher.My.Resources.Resources.decimation_logo1
        Me.PictureBox4.Location = New System.Drawing.Point(-7, 27)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(479, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DecimationLauncher.My.Resources.Resources.globe
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.ForeColor = System.Drawing.Color.Gray
        Me.lblCopyright.Location = New System.Drawing.Point(277, 466)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(187, 13)
        Me.lblCopyright.TabIndex = 10
        Me.lblCopyright.Text = "Minecraft is a trademark of Mojang AB"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(322, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "© MCDecimation 2016-2017"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(467, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblForgeNotification)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTopRight)
        Me.Controls.Add(Me.lblTopLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decimation Launcher"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopLeft As Label
    Friend WithEvents lblTopRight As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLaunch As Button
    Friend WithEvents lblVersion As Label
    Friend WithEvents picMain As PictureBox
    Friend WithEvents lblForgeNotification As Label
    Friend WithEvents progBar As ProgressBar
    Friend WithEvents dlBar As ProgressBar
    Friend WithEvents lblDownload As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblCopyright As Label
    Friend WithEvents Label1 As Label
End Class
