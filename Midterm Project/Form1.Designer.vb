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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDelivery = New System.Windows.Forms.GroupBox()
        Me.rdbPickup = New System.Windows.Forms.RadioButton()
        Me.rdbInstaCart = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cboMilk = New System.Windows.Forms.CheckedListBox()
        Me.cboEggs = New System.Windows.Forms.CheckedListBox()
        Me.cboVegetables = New System.Windows.Forms.CheckedListBox()
        Me.cboFruits = New System.Windows.Forms.CheckedListBox()
        Me.cboMeat = New System.Windows.Forms.CheckedListBox()
        Me.cboWater = New System.Windows.Forms.CheckedListBox()
        Me.cboBread = New System.Windows.Forms.CheckedListBox()
        Me.txtBags = New System.Windows.Forms.TextBox()
        Me.lblBags = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbNone = New System.Windows.Forms.RadioButton()
        Me.rdbPlastic = New System.Windows.Forms.RadioButton()
        Me.rdbPaper = New System.Windows.Forms.RadioButton()
        Me.lblDiscountApplied = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDelivery.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Midterm_Project.My.Resources.Resources.external_content_duckducsdadkgo_com
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(329, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(353, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'grpDelivery
        '
        Me.grpDelivery.Controls.Add(Me.rdbPickup)
        Me.grpDelivery.Controls.Add(Me.rdbInstaCart)
        Me.grpDelivery.Location = New System.Drawing.Point(209, 414)
        Me.grpDelivery.Name = "grpDelivery"
        Me.grpDelivery.Size = New System.Drawing.Size(132, 70)
        Me.grpDelivery.TabIndex = 2
        Me.grpDelivery.TabStop = False
        Me.grpDelivery.Text = "Delivery"
        '
        'rdbPickup
        '
        Me.rdbPickup.AutoSize = True
        Me.rdbPickup.Checked = True
        Me.rdbPickup.Location = New System.Drawing.Point(7, 44)
        Me.rdbPickup.Name = "rdbPickup"
        Me.rdbPickup.Size = New System.Drawing.Size(126, 17)
        Me.rdbPickup.TabIndex = 1
        Me.rdbPickup.TabStop = True
        Me.rdbPickup.Text = "Pickup (5% Discount)"
        Me.rdbPickup.UseVisualStyleBackColor = True
        '
        'rdbInstaCart
        '
        Me.rdbInstaCart.AutoSize = True
        Me.rdbInstaCart.Location = New System.Drawing.Point(7, 20)
        Me.rdbInstaCart.Name = "rdbInstaCart"
        Me.rdbInstaCart.Size = New System.Drawing.Size(66, 17)
        Me.rdbInstaCart.TabIndex = 0
        Me.rdbInstaCart.Text = "Instacart"
        Me.rdbInstaCart.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(163, 516)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Send Order"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(255, 516)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(9, 108)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(75, 105)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(81, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please select the items you would like."
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(255, 105)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(86, 20)
        Me.txtLastName.TabIndex = 17
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(188, 108)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 16
        Me.lblLastName.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(219, 490)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboMilk
        '
        Me.cboMilk.FormattingEnabled = True
        Me.cboMilk.Location = New System.Drawing.Point(12, 165)
        Me.cboMilk.Name = "cboMilk"
        Me.cboMilk.Size = New System.Drawing.Size(329, 19)
        Me.cboMilk.TabIndex = 26
        '
        'cboEggs
        '
        Me.cboEggs.FormattingEnabled = True
        Me.cboEggs.Location = New System.Drawing.Point(12, 202)
        Me.cboEggs.Name = "cboEggs"
        Me.cboEggs.Size = New System.Drawing.Size(329, 19)
        Me.cboEggs.TabIndex = 27
        '
        'cboVegetables
        '
        Me.cboVegetables.FormattingEnabled = True
        Me.cboVegetables.Location = New System.Drawing.Point(12, 240)
        Me.cboVegetables.Name = "cboVegetables"
        Me.cboVegetables.Size = New System.Drawing.Size(329, 19)
        Me.cboVegetables.TabIndex = 28
        '
        'cboFruits
        '
        Me.cboFruits.FormattingEnabled = True
        Me.cboFruits.Location = New System.Drawing.Point(12, 277)
        Me.cboFruits.Name = "cboFruits"
        Me.cboFruits.Size = New System.Drawing.Size(329, 19)
        Me.cboFruits.TabIndex = 29
        '
        'cboMeat
        '
        Me.cboMeat.FormattingEnabled = True
        Me.cboMeat.Location = New System.Drawing.Point(12, 314)
        Me.cboMeat.Name = "cboMeat"
        Me.cboMeat.Size = New System.Drawing.Size(329, 19)
        Me.cboMeat.TabIndex = 30
        '
        'cboWater
        '
        Me.cboWater.FormattingEnabled = True
        Me.cboWater.Location = New System.Drawing.Point(12, 351)
        Me.cboWater.Name = "cboWater"
        Me.cboWater.Size = New System.Drawing.Size(329, 19)
        Me.cboWater.TabIndex = 31
        '
        'cboBread
        '
        Me.cboBread.FormattingEnabled = True
        Me.cboBread.Location = New System.Drawing.Point(12, 389)
        Me.cboBread.Name = "cboBread"
        Me.cboBread.Size = New System.Drawing.Size(329, 19)
        Me.cboBread.TabIndex = 32
        '
        'txtBags
        '
        Me.txtBags.Location = New System.Drawing.Point(174, 412)
        Me.txtBags.MaxLength = 2
        Me.txtBags.Name = "txtBags"
        Me.txtBags.Size = New System.Drawing.Size(23, 20)
        Me.txtBags.TabIndex = 33
        '
        'lblBags
        '
        Me.lblBags.AutoSize = True
        Me.lblBags.Location = New System.Drawing.Point(12, 415)
        Me.lblBags.Name = "lblBags"
        Me.lblBags.Size = New System.Drawing.Size(159, 13)
        Me.lblBags.TabIndex = 34
        Me.lblBags.Text = "How many bags would you like?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbNone)
        Me.GroupBox1.Controls.Add(Me.rdbPlastic)
        Me.GroupBox1.Controls.Add(Me.rdbPaper)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 431)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 68)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bags"
        '
        'rdbNone
        '
        Me.rdbNone.AutoSize = True
        Me.rdbNone.Checked = True
        Me.rdbNone.Location = New System.Drawing.Point(65, 31)
        Me.rdbNone.Name = "rdbNone"
        Me.rdbNone.Size = New System.Drawing.Size(51, 17)
        Me.rdbNone.TabIndex = 2
        Me.rdbNone.TabStop = True
        Me.rdbNone.Text = "None"
        Me.rdbNone.UseVisualStyleBackColor = True
        '
        'rdbPlastic
        '
        Me.rdbPlastic.AutoSize = True
        Me.rdbPlastic.Location = New System.Drawing.Point(7, 43)
        Me.rdbPlastic.Name = "rdbPlastic"
        Me.rdbPlastic.Size = New System.Drawing.Size(56, 17)
        Me.rdbPlastic.TabIndex = 1
        Me.rdbPlastic.Text = "Plastic"
        Me.rdbPlastic.UseVisualStyleBackColor = True
        '
        'rdbPaper
        '
        Me.rdbPaper.AutoSize = True
        Me.rdbPaper.Location = New System.Drawing.Point(6, 19)
        Me.rdbPaper.Name = "rdbPaper"
        Me.rdbPaper.Size = New System.Drawing.Size(53, 17)
        Me.rdbPaper.TabIndex = 0
        Me.rdbPaper.Text = "Paper"
        Me.rdbPaper.UseVisualStyleBackColor = True
        '
        'lblDiscountApplied
        '
        Me.lblDiscountApplied.AutoSize = True
        Me.lblDiscountApplied.Location = New System.Drawing.Point(12, 525)
        Me.lblDiscountApplied.Name = "lblDiscountApplied"
        Me.lblDiscountApplied.Size = New System.Drawing.Size(92, 17)
        Me.lblDiscountApplied.TabIndex = 36
        Me.lblDiscountApplied.Text = "Discount Applied."
        Me.lblDiscountApplied.UseCompatibleTextRendering = True
        Me.lblDiscountApplied.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Milk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Vegetables"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Meat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Fruit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Bread"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Water"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Eggs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 559)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDiscountApplied)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblBags)
        Me.Controls.Add(Me.txtBags)
        Me.Controls.Add(Me.cboBread)
        Me.Controls.Add(Me.cboWater)
        Me.Controls.Add(Me.cboMeat)
        Me.Controls.Add(Me.cboFruits)
        Me.Controls.Add(Me.cboVegetables)
        Me.Controls.Add(Me.cboEggs)
        Me.Controls.Add(Me.cboMilk)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpDelivery)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Stater Bros. Markets"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDelivery.ResumeLayout(False)
        Me.grpDelivery.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpDelivery As GroupBox
    Friend WithEvents rdbPickup As RadioButton
    Friend WithEvents rdbInstaCart As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cboMilk As CheckedListBox
    Friend WithEvents cboEggs As CheckedListBox
    Friend WithEvents cboVegetables As CheckedListBox
    Friend WithEvents cboFruits As CheckedListBox
    Friend WithEvents cboMeat As CheckedListBox
    Friend WithEvents cboWater As CheckedListBox
    Friend WithEvents cboBread As CheckedListBox
    Friend WithEvents txtBags As TextBox
    Friend WithEvents lblBags As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbNone As RadioButton
    Friend WithEvents rdbPlastic As RadioButton
    Friend WithEvents rdbPaper As RadioButton
    Friend WithEvents lblDiscountApplied As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
