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
		Me.BtnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.radSmartphone = New System.Windows.Forms.RadioButton()
		Me.radTablet = New System.Windows.Forms.RadioButton()
		Me.radLaptop = New System.Windows.Forms.RadioButton()
		Me.radPersonalComputer = New System.Windows.Forms.RadioButton()
		Me.chkComputer = New System.Windows.Forms.CheckBox()
		Me.chkGraphicsCard = New System.Windows.Forms.CheckBox()
		Me.chkMonitor = New System.Windows.Forms.CheckBox()
		Me.chkKeyboard = New System.Windows.Forms.CheckBox()
		Me.cmbAdditionalRam = New System.Windows.Forms.ComboBox()
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblSurname = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtSurname = New System.Windows.Forms.TextBox()
		Me.chkMouse = New System.Windows.Forms.CheckBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cmbAdditionalDDR4 = New System.Windows.Forms.ComboBox()
		Me.lblAdditionalRam = New System.Windows.Forms.Label()
		Me.lblAdditionalDDR4 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.lstdisplay = New System.Windows.Forms.ListBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BtnCalculate
		'
		Me.BtnCalculate.Location = New System.Drawing.Point(297, 517)
		Me.BtnCalculate.Name = "BtnCalculate"
		Me.BtnCalculate.Size = New System.Drawing.Size(164, 23)
		Me.BtnCalculate.TabIndex = 0
		Me.BtnCalculate.Text = "Calculate"
		Me.BtnCalculate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(549, 517)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(185, 23)
		Me.btnClear.TabIndex = 1
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(816, 517)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(189, 23)
		Me.btnExit.TabIndex = 2
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.radSmartphone)
		Me.GroupBox1.Controls.Add(Me.radTablet)
		Me.GroupBox1.Controls.Add(Me.radLaptop)
		Me.GroupBox1.Controls.Add(Me.radPersonalComputer)
		Me.GroupBox1.Location = New System.Drawing.Point(297, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(708, 73)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Computing Devices"
		'
		'radSmartphone
		'
		Me.radSmartphone.AutoSize = True
		Me.radSmartphone.Location = New System.Drawing.Point(599, 34)
		Me.radSmartphone.Name = "radSmartphone"
		Me.radSmartphone.Size = New System.Drawing.Size(82, 17)
		Me.radSmartphone.TabIndex = 3
		Me.radSmartphone.TabStop = True
		Me.radSmartphone.Text = "Smartphone"
		Me.radSmartphone.UseVisualStyleBackColor = True
		'
		'radTablet
		'
		Me.radTablet.AutoSize = True
		Me.radTablet.Location = New System.Drawing.Point(418, 34)
		Me.radTablet.Name = "radTablet"
		Me.radTablet.Size = New System.Drawing.Size(55, 17)
		Me.radTablet.TabIndex = 2
		Me.radTablet.TabStop = True
		Me.radTablet.Text = "Tablet"
		Me.radTablet.UseVisualStyleBackColor = True
		'
		'radLaptop
		'
		Me.radLaptop.AutoSize = True
		Me.radLaptop.Location = New System.Drawing.Point(231, 34)
		Me.radLaptop.Name = "radLaptop"
		Me.radLaptop.Size = New System.Drawing.Size(58, 17)
		Me.radLaptop.TabIndex = 1
		Me.radLaptop.TabStop = True
		Me.radLaptop.Text = "Laptop"
		Me.radLaptop.UseVisualStyleBackColor = True
		'
		'radPersonalComputer
		'
		Me.radPersonalComputer.AutoSize = True
		Me.radPersonalComputer.Location = New System.Drawing.Point(26, 34)
		Me.radPersonalComputer.Name = "radPersonalComputer"
		Me.radPersonalComputer.Size = New System.Drawing.Size(114, 17)
		Me.radPersonalComputer.TabIndex = 0
		Me.radPersonalComputer.TabStop = True
		Me.radPersonalComputer.Text = "Personal Computer"
		Me.radPersonalComputer.UseVisualStyleBackColor = True
		'
		'chkComputer
		'
		Me.chkComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkComputer.Location = New System.Drawing.Point(69, 31)
		Me.chkComputer.Name = "chkComputer"
		Me.chkComputer.Size = New System.Drawing.Size(107, 27)
		Me.chkComputer.TabIndex = 8
		Me.chkComputer.Text = "Computer"
		Me.chkComputer.UseVisualStyleBackColor = True
		'
		'chkGraphicsCard
		'
		Me.chkGraphicsCard.AutoSize = True
		Me.chkGraphicsCard.Location = New System.Drawing.Point(22, 79)
		Me.chkGraphicsCard.Name = "chkGraphicsCard"
		Me.chkGraphicsCard.Size = New System.Drawing.Size(93, 17)
		Me.chkGraphicsCard.TabIndex = 9
		Me.chkGraphicsCard.Text = "Graphics Card"
		Me.chkGraphicsCard.UseVisualStyleBackColor = True
		'
		'chkMonitor
		'
		Me.chkMonitor.AutoSize = True
		Me.chkMonitor.Location = New System.Drawing.Point(165, 79)
		Me.chkMonitor.Name = "chkMonitor"
		Me.chkMonitor.Size = New System.Drawing.Size(61, 17)
		Me.chkMonitor.TabIndex = 10
		Me.chkMonitor.Text = "Monitor"
		Me.chkMonitor.UseVisualStyleBackColor = True
		'
		'chkKeyboard
		'
		Me.chkKeyboard.AutoSize = True
		Me.chkKeyboard.Location = New System.Drawing.Point(22, 123)
		Me.chkKeyboard.Name = "chkKeyboard"
		Me.chkKeyboard.Size = New System.Drawing.Size(71, 17)
		Me.chkKeyboard.TabIndex = 11
		Me.chkKeyboard.Text = "Keyboard"
		Me.chkKeyboard.UseVisualStyleBackColor = True
		'
		'cmbAdditionalRam
		'
		Me.cmbAdditionalRam.FormattingEnabled = True
		Me.cmbAdditionalRam.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
		Me.cmbAdditionalRam.Location = New System.Drawing.Point(132, 209)
		Me.cmbAdditionalRam.Name = "cmbAdditionalRam"
		Me.cmbAdditionalRam.Size = New System.Drawing.Size(94, 21)
		Me.cmbAdditionalRam.TabIndex = 12
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.Location = New System.Drawing.Point(12, 225)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(35, 13)
		Me.lblName.TabIndex = 13
		Me.lblName.Text = "Name"
		'
		'lblSurname
		'
		Me.lblSurname.AutoSize = True
		Me.lblSurname.Location = New System.Drawing.Point(12, 261)
		Me.lblSurname.Name = "lblSurname"
		Me.lblSurname.Size = New System.Drawing.Size(49, 13)
		Me.lblSurname.TabIndex = 14
		Me.lblSurname.Text = "Surname"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(81, 218)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(188, 20)
		Me.txtName.TabIndex = 15
		'
		'txtSurname
		'
		Me.txtSurname.Location = New System.Drawing.Point(81, 258)
		Me.txtSurname.Name = "txtSurname"
		Me.txtSurname.Size = New System.Drawing.Size(188, 20)
		Me.txtSurname.TabIndex = 16
		'
		'chkMouse
		'
		Me.chkMouse.AutoSize = True
		Me.chkMouse.Location = New System.Drawing.Point(165, 123)
		Me.chkMouse.Name = "chkMouse"
		Me.chkMouse.Size = New System.Drawing.Size(58, 17)
		Me.chkMouse.TabIndex = 17
		Me.chkMouse.Text = "Mouse"
		Me.chkMouse.UseVisualStyleBackColor = True
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.cmbAdditionalDDR4)
		Me.GroupBox2.Controls.Add(Me.lblAdditionalRam)
		Me.GroupBox2.Controls.Add(Me.lblAdditionalDDR4)
		Me.GroupBox2.Controls.Add(Me.chkComputer)
		Me.GroupBox2.Controls.Add(Me.chkMouse)
		Me.GroupBox2.Controls.Add(Me.cmbAdditionalRam)
		Me.GroupBox2.Controls.Add(Me.chkGraphicsCard)
		Me.GroupBox2.Controls.Add(Me.chkMonitor)
		Me.GroupBox2.Controls.Add(Me.chkKeyboard)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 284)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(257, 250)
		Me.GroupBox2.TabIndex = 18
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Computer and Peripherals"
		'
		'cmbAdditionalDDR4
		'
		Me.cmbAdditionalDDR4.FormattingEnabled = True
		Me.cmbAdditionalDDR4.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
		Me.cmbAdditionalDDR4.Location = New System.Drawing.Point(132, 167)
		Me.cmbAdditionalDDR4.Name = "cmbAdditionalDDR4"
		Me.cmbAdditionalDDR4.Size = New System.Drawing.Size(94, 21)
		Me.cmbAdditionalDDR4.TabIndex = 20
		'
		'lblAdditionalRam
		'
		Me.lblAdditionalRam.AutoSize = True
		Me.lblAdditionalRam.Location = New System.Drawing.Point(19, 217)
		Me.lblAdditionalRam.Name = "lblAdditionalRam"
		Me.lblAdditionalRam.Size = New System.Drawing.Size(80, 13)
		Me.lblAdditionalRam.TabIndex = 19
		Me.lblAdditionalRam.Text = "Additional HDD"
		'
		'lblAdditionalDDR4
		'
		Me.lblAdditionalDDR4.AutoSize = True
		Me.lblAdditionalDDR4.Location = New System.Drawing.Point(19, 170)
		Me.lblAdditionalDDR4.Name = "lblAdditionalDDR4"
		Me.lblAdditionalDDR4.Size = New System.Drawing.Size(86, 13)
		Me.lblAdditionalDDR4.TabIndex = 18
		Me.lblAdditionalDDR4.Text = "Additional DDR4"
		'
		'PictureBox2
		'
		Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
		Me.PictureBox2.InitialImage = Nothing
		Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(257, 187)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 20
		Me.PictureBox2.TabStop = False
		'
		'lstdisplay
		'
		Me.lstdisplay.FormattingEnabled = True
		Me.lstdisplay.Location = New System.Drawing.Point(297, 91)
		Me.lstdisplay.Name = "lstdisplay"
		Me.lstdisplay.Size = New System.Drawing.Size(708, 420)
		Me.lstdisplay.TabIndex = 21
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1017, 551)
		Me.Controls.Add(Me.lstdisplay)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.txtSurname)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.lblSurname)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.BtnCalculate)
		Me.Name = "Form1"
		Me.Text = "Bongani Computers Logged"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BtnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSmartphone As RadioButton
    Friend WithEvents radTablet As RadioButton
    Friend WithEvents radLaptop As RadioButton
    Friend WithEvents radPersonalComputer As RadioButton
    Friend WithEvents chkComputer As CheckBox
    Friend WithEvents chkGraphicsCard As CheckBox
    Friend WithEvents chkMonitor As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents cmbAdditionalRam As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAdditionalRam As Label
    Friend WithEvents lblAdditionalDDR4 As Label
    Friend WithEvents cmbAdditionalDDR4 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents lstdisplay As ListBox
End Class
