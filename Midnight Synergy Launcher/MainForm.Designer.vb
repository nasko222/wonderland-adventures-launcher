'
' Created by SharpDevelop.
' User: nasko222
' Date: 07-Dec-19
' Time: 3:15 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.endbox1 = New System.Windows.Forms.PictureBox()
		Me.tow1 = New System.Windows.Forms.PictureBox()
		Me.tow2 = New System.Windows.Forms.PictureBox()
		Me.tow3 = New System.Windows.Forms.PictureBox()
		Me.tow4 = New System.Windows.Forms.PictureBox()
		Me.wa1 = New System.Windows.Forms.PictureBox()
		Me.wa2 = New System.Windows.Forms.PictureBox()
		Me.wa3 = New System.Windows.Forms.PictureBox()
		Me.wa4 = New System.Windows.Forms.PictureBox()
		Me.piccheck1 = New System.Windows.Forms.PictureBox()
		Me.piccheck2 = New System.Windows.Forms.PictureBox()
		Me.piccheck3 = New System.Windows.Forms.PictureBox()
		Me.buffer1 = New System.Windows.Forms.PictureBox()
		CType(Me.endbox1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tow1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tow2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tow3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.tow4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wa1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wa2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wa3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.wa4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.piccheck1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.piccheck2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.piccheck3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.buffer1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'endbox1
		'
		Me.endbox1.BackColor = System.Drawing.Color.Transparent
		Me.endbox1.Location = New System.Drawing.Point(951, 12)
		Me.endbox1.Name = "endbox1"
		Me.endbox1.Size = New System.Drawing.Size(51, 47)
		Me.endbox1.TabIndex = 13
		Me.endbox1.TabStop = false
		AddHandler Me.endbox1.Click, AddressOf Me.PictureBox1Click
		'
		'tow1
		'
		Me.tow1.BackColor = System.Drawing.Color.Transparent
		Me.tow1.Location = New System.Drawing.Point(63, 277)
		Me.tow1.Name = "tow1"
		Me.tow1.Size = New System.Drawing.Size(104, 84)
		Me.tow1.TabIndex = 14
		Me.tow1.TabStop = false
		AddHandler Me.tow1.Click, AddressOf Me.Tow1Click
		'
		'tow2
		'
		Me.tow2.BackColor = System.Drawing.Color.Transparent
		Me.tow2.Location = New System.Drawing.Point(205, 277)
		Me.tow2.Name = "tow2"
		Me.tow2.Size = New System.Drawing.Size(104, 84)
		Me.tow2.TabIndex = 15
		Me.tow2.TabStop = false
		AddHandler Me.tow2.Click, AddressOf Me.Tow2Click
		'
		'tow3
		'
		Me.tow3.BackColor = System.Drawing.Color.Transparent
		Me.tow3.Location = New System.Drawing.Point(350, 277)
		Me.tow3.Name = "tow3"
		Me.tow3.Size = New System.Drawing.Size(104, 84)
		Me.tow3.TabIndex = 16
		Me.tow3.TabStop = false
		AddHandler Me.tow3.Click, AddressOf Me.Tow3Click
		'
		'tow4
		'
		Me.tow4.BackColor = System.Drawing.Color.Transparent
		Me.tow4.Location = New System.Drawing.Point(493, 277)
		Me.tow4.Name = "tow4"
		Me.tow4.Size = New System.Drawing.Size(104, 84)
		Me.tow4.TabIndex = 17
		Me.tow4.TabStop = false
		AddHandler Me.tow4.Click, AddressOf Me.Tow4Click
		'
		'wa1
		'
		Me.wa1.BackColor = System.Drawing.Color.Transparent
		Me.wa1.Location = New System.Drawing.Point(63, 396)
		Me.wa1.Name = "wa1"
		Me.wa1.Size = New System.Drawing.Size(104, 84)
		Me.wa1.TabIndex = 18
		Me.wa1.TabStop = false
		AddHandler Me.wa1.Click, AddressOf Me.Wa1Click
		'
		'wa2
		'
		Me.wa2.BackColor = System.Drawing.Color.Transparent
		Me.wa2.Location = New System.Drawing.Point(205, 396)
		Me.wa2.Name = "wa2"
		Me.wa2.Size = New System.Drawing.Size(104, 84)
		Me.wa2.TabIndex = 19
		Me.wa2.TabStop = false
		AddHandler Me.wa2.Click, AddressOf Me.Wa2Click
		'
		'wa3
		'
		Me.wa3.BackColor = System.Drawing.Color.Transparent
		Me.wa3.Location = New System.Drawing.Point(350, 396)
		Me.wa3.Name = "wa3"
		Me.wa3.Size = New System.Drawing.Size(104, 84)
		Me.wa3.TabIndex = 20
		Me.wa3.TabStop = false
		AddHandler Me.wa3.Click, AddressOf Me.Wa3Click
		'
		'wa4
		'
		Me.wa4.BackColor = System.Drawing.Color.Transparent
		Me.wa4.Location = New System.Drawing.Point(493, 396)
		Me.wa4.Name = "wa4"
		Me.wa4.Size = New System.Drawing.Size(104, 84)
		Me.wa4.TabIndex = 21
		Me.wa4.TabStop = false
		AddHandler Me.wa4.Click, AddressOf Me.Wa4Click
		'
		'piccheck1
		'
		Me.piccheck1.BackColor = System.Drawing.Color.Transparent
		Me.piccheck1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.piccheck1.Location = New System.Drawing.Point(714, 315)
		Me.piccheck1.Name = "piccheck1"
		Me.piccheck1.Size = New System.Drawing.Size(26, 25)
		Me.piccheck1.TabIndex = 22
		Me.piccheck1.TabStop = false
		AddHandler Me.piccheck1.Click, AddressOf Me.Piccheck1Click
		'
		'piccheck2
		'
		Me.piccheck2.BackColor = System.Drawing.Color.Transparent
		Me.piccheck2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.piccheck2.Location = New System.Drawing.Point(714, 370)
		Me.piccheck2.Name = "piccheck2"
		Me.piccheck2.Size = New System.Drawing.Size(26, 25)
		Me.piccheck2.TabIndex = 23
		Me.piccheck2.TabStop = false
		AddHandler Me.piccheck2.Click, AddressOf Me.Piccheck2Click
		'
		'piccheck3
		'
		Me.piccheck3.BackColor = System.Drawing.Color.Transparent
		Me.piccheck3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.piccheck3.Location = New System.Drawing.Point(714, 430)
		Me.piccheck3.Name = "piccheck3"
		Me.piccheck3.Size = New System.Drawing.Size(26, 25)
		Me.piccheck3.TabIndex = 24
		Me.piccheck3.TabStop = false
		AddHandler Me.piccheck3.Click, AddressOf Me.Piccheck3Click
		'
		'buffer1
		'
		Me.buffer1.BackColor = System.Drawing.Color.Transparent
		Me.buffer1.BackgroundImage = CType(resources.GetObject("buffer1.BackgroundImage"),System.Drawing.Image)
		Me.buffer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.buffer1.Location = New System.Drawing.Point(964, 23)
		Me.buffer1.Name = "buffer1"
		Me.buffer1.Size = New System.Drawing.Size(26, 25)
		Me.buffer1.TabIndex = 25
		Me.buffer1.TabStop = false
		Me.buffer1.Visible = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Olive
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1014, 607)
		Me.Controls.Add(Me.piccheck3)
		Me.Controls.Add(Me.piccheck2)
		Me.Controls.Add(Me.piccheck1)
		Me.Controls.Add(Me.wa4)
		Me.Controls.Add(Me.wa3)
		Me.Controls.Add(Me.wa2)
		Me.Controls.Add(Me.wa1)
		Me.Controls.Add(Me.tow4)
		Me.Controls.Add(Me.tow3)
		Me.Controls.Add(Me.tow2)
		Me.Controls.Add(Me.tow1)
		Me.Controls.Add(Me.endbox1)
		Me.Controls.Add(Me.buffer1)
		Me.DoubleBuffered = true
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Midnight Synergy Launcher"
		Me.TransparencyKey = System.Drawing.Color.Olive
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.endbox1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tow1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tow2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tow3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.tow4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wa1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wa2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wa3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.wa4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.piccheck1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.piccheck2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.piccheck3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.buffer1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private buffer1 As System.Windows.Forms.PictureBox
	Private piccheck3 As System.Windows.Forms.PictureBox
	Private piccheck2 As System.Windows.Forms.PictureBox
	Private piccheck1 As System.Windows.Forms.PictureBox
	Private wa4 As System.Windows.Forms.PictureBox
	Private wa3 As System.Windows.Forms.PictureBox
	Private wa2 As System.Windows.Forms.PictureBox
	Private wa1 As System.Windows.Forms.PictureBox
	Private tow4 As System.Windows.Forms.PictureBox
	Private tow3 As System.Windows.Forms.PictureBox
	Private tow2 As System.Windows.Forms.PictureBox
	Private tow1 As System.Windows.Forms.PictureBox
	Private endbox1 As System.Windows.Forms.PictureBox
	
    Sub MainFormLoad(ByVal sender As Object, ByVal e As EventArgs)
        TOW_Game = GetSettingItem("config.cfg", "TOW_Game")
        TOW_Folder = GetSettingItem("config.cfg", "TOW_Folder")
        TOW_Editor = GetSettingItem("config.cfg", "TOW_Editor")
        TOW_Folder_Editor = GetSettingItem("config.cfg", "TOW_Folder_Editor")
        WSW = GetSettingItem("config.cfg", "WSW")
        WSW_Folder = GetSettingItem("config.cfg", "WSW_Folder")
        RTW_Game = GetSettingItem("config.cfg", "RTW_Game")
        RTW_Editor = GetSettingItem("config.cfg", "RTW_Editor")
        RTW_Folder = GetSettingItem("config.cfg", "RTW_Folder")
        KQ_Game = GetSettingItem("config.cfg", "KQ_Game")
        KQ_Editor = GetSettingItem("config.cfg", "KQ_Editor")
        KQ_Folder = GetSettingItem("config.cfg", "KQ_Folder")
        WA1_Game = GetSettingItem("config.cfg", "WA1_Game")
        WA1_Folder = GetSettingItem("config.cfg", "WA1_Folder")
        WA1_Game_Speedrun = GetSettingItem("config.cfg", "WA1_Game_Speedrun")
        WA1_Folder_Speedrun = GetSettingItem("config.cfg", "WA1_Folder_Speedrun")
        WA1_Editor = GetSettingItem("config.cfg", "WA1_Editor")
        WA1_Folder_Editor = GetSettingItem("config.cfg", "WA1_Folder_Editor")
        WA2_Game = GetSettingItem("config.cfg", "WA2_Game")
        WA2_Folder = GetSettingItem("config.cfg", "WA2_Folder")
        WA2_Game_Speedrun = GetSettingItem("config.cfg", "WA2_Game_Speedrun")
        WA2_Folder_Speedrun = GetSettingItem("config.cfg", "WA2_Folder_Speedrun")
        WA2_Editor = GetSettingItem("config.cfg", "WA2_Editor")
        WA2_Folder_Editor = GetSettingItem("config.cfg", "WA2_Folder_Editor")
        WA3_Game = GetSettingItem("config.cfg", "WA3_Game")
        WA3_Folder = GetSettingItem("config.cfg", "WA3_Folder")
        WA3_Game_Speedrun = GetSettingItem("config.cfg", "WA3_Game_Speedrun")
        WA3_Folder_Speedrun = GetSettingItem("config.cfg", "WA3_Folder_Speedrun")
        WA3_Editor = GetSettingItem("config.cfg", "WA3_Editor")
        WA3_Folder_Editor = GetSettingItem("config.cfg", "WA3_Folder_Editor")
        PQ = GetSettingItem("config.cfg", "PQ")
        PQ_Folder = GetSettingItem("config.cfg", "PQ_Folder")
    End Sub
End Class
