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
        Me.VTabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VCheckBox7 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox6 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox5 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.VCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VCheckBox8 = New System.Windows.Forms.CheckBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.VTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VTabControl1
        '
        Me.VTabControl1.Controls.Add(Me.TabPage1)
        Me.VTabControl1.Controls.Add(Me.TabPage2)
        Me.VTabControl1.Controls.Add(Me.TabPage3)
        Me.VTabControl1.Controls.Add(Me.TabPage4)
        Me.VTabControl1.Location = New System.Drawing.Point(2, 87)
        Me.VTabControl1.Name = "VTabControl1"
        Me.VTabControl1.SelectedIndex = 0
        Me.VTabControl1.Size = New System.Drawing.Size(592, 237)
        Me.VTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(584, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sites scraped"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(329, 22)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 186)
        Me.ListBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VCheckBox8)
        Me.GroupBox1.Controls.Add(Me.VCheckBox7)
        Me.GroupBox1.Controls.Add(Me.VCheckBox6)
        Me.GroupBox1.Controls.Add(Me.VCheckBox5)
        Me.GroupBox1.Controls.Add(Me.VCheckBox4)
        Me.GroupBox1.Controls.Add(Me.VCheckBox3)
        Me.GroupBox1.Controls.Add(Me.VCheckBox2)
        Me.GroupBox1.Controls.Add(Me.VCheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sites"
        '
        'VCheckBox7
        '
        Me.VCheckBox7.AutoSize = True
        Me.VCheckBox7.Location = New System.Drawing.Point(5, 157)
        Me.VCheckBox7.Name = "VCheckBox7"
        Me.VCheckBox7.Size = New System.Drawing.Size(167, 17)
        Me.VCheckBox7.TabIndex = 6
        Me.VCheckBox7.Text = "http://www.google-proxy.net/"
        Me.VCheckBox7.UseVisualStyleBackColor = True
        '
        'VCheckBox6
        '
        Me.VCheckBox6.AutoSize = True
        Me.VCheckBox6.Location = New System.Drawing.Point(5, 134)
        Me.VCheckBox6.Name = "VCheckBox6"
        Me.VCheckBox6.Size = New System.Drawing.Size(120, 17)
        Me.VCheckBox6.TabIndex = 5
        Me.VCheckBox6.Text = "http://proxy-list.org/"
        Me.VCheckBox6.UseVisualStyleBackColor = True
        '
        'VCheckBox5
        '
        Me.VCheckBox5.AutoSize = True
        Me.VCheckBox5.Location = New System.Drawing.Point(5, 111)
        Me.VCheckBox5.Name = "VCheckBox5"
        Me.VCheckBox5.Size = New System.Drawing.Size(152, 17)
        Me.VCheckBox5.TabIndex = 4
        Me.VCheckBox5.Text = "http://www.sslproxies.org/"
        Me.VCheckBox5.UseVisualStyleBackColor = True
        '
        'VCheckBox4
        '
        Me.VCheckBox4.AutoSize = True
        Me.VCheckBox4.Location = New System.Drawing.Point(5, 88)
        Me.VCheckBox4.Name = "VCheckBox4"
        Me.VCheckBox4.Size = New System.Drawing.Size(161, 17)
        Me.VCheckBox4.TabIndex = 3
        Me.VCheckBox4.Text = "http://www.proxynova.com/"
        Me.VCheckBox4.UseVisualStyleBackColor = True
        '
        'VCheckBox3
        '
        Me.VCheckBox3.AutoSize = True
        Me.VCheckBox3.Location = New System.Drawing.Point(5, 65)
        Me.VCheckBox3.Name = "VCheckBox3"
        Me.VCheckBox3.Size = New System.Drawing.Size(146, 17)
        Me.VCheckBox3.TabIndex = 2
        Me.VCheckBox3.Text = "http://www.us-proxy.org/"
        Me.VCheckBox3.UseVisualStyleBackColor = True
        '
        'VCheckBox2
        '
        Me.VCheckBox2.AutoSize = True
        Me.VCheckBox2.Location = New System.Drawing.Point(5, 42)
        Me.VCheckBox2.Name = "VCheckBox2"
        Me.VCheckBox2.Size = New System.Drawing.Size(245, 17)
        Me.VCheckBox2.TabIndex = 1
        Me.VCheckBox2.Text = "http://free-proxy-list.net/anonymous-proxy.html"
        Me.VCheckBox2.UseVisualStyleBackColor = True
        '
        'VCheckBox1
        '
        Me.VCheckBox1.AutoSize = True
        Me.VCheckBox1.Location = New System.Drawing.Point(5, 19)
        Me.VCheckBox1.Name = "VCheckBox1"
        Me.VCheckBox1.Size = New System.Drawing.Size(163, 17)
        Me.VCheckBox1.TabIndex = 0
        Me.VCheckBox1.Text = "http://www.socks-proxy.net/"
        Me.VCheckBox1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(584, 211)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Scrape"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Made by Zwembadsniper"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save Proxies"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Scrape"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(3, 6)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(573, 173)
        Me.ListBox2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.ListBox5)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.ListBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(584, 211)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Proxy Checker"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(393, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Clear all"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label5"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(6, 51)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(130, 160)
        Me.ListBox3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Not working"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Working"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Tag = ""
        Me.Label2.Text = "Imported Proxies"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(247, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Export working proxies"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(142, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Check Proxies"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(351, 48)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(225, 160)
        Me.ListBox5.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Import proxies"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(145, 48)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(200, 160)
        Me.ListBox4.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.LinkLabel1)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(584, 211)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Credits"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(18, 132)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "My Leak Profile :)"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "- Thanks for using the tool"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(131, 21)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "@zwembadsniper"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "- thanks correlating! :D"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(331, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "- This tool is completely free and if you did pay for it you got ripped off"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "- This tool was made by "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-180, -194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(828, 286)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'VCheckBox8
        '
        Me.VCheckBox8.AutoSize = True
        Me.VCheckBox8.Location = New System.Drawing.Point(5, 179)
        Me.VCheckBox8.Name = "VCheckBox8"
        Me.VCheckBox8.Size = New System.Drawing.Size(174, 17)
        Me.VCheckBox8.TabIndex = 7
        Me.VCheckBox8.Text = "http://proxylist.hidemyass.com/"
        Me.VCheckBox8.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(284, 182)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 23)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Clear proxies"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 329)
        Me.Controls.Add(Me.VTabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Proxy Scraper made by @Zwembadsniper"
        Me.VTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VTabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents VCheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents VCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents VCheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
