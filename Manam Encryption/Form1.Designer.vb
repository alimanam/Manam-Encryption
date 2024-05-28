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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTolStr = New System.Windows.Forms.ToolStripMenuItem()
        Me.newMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.openMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.helpTolStr = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.FiletolstrStsLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtKey = New System.Windows.Forms.ToolStripTextBox()
        Me.btnRandomKey = New System.Windows.Forms.ToolStripButton()
        Me.btnEncrypt = New System.Windows.Forms.ToolStripButton()
        Me.btnDecrypt = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDecrypt = New System.Windows.Forms.TextBox()
        Me.editTolStr = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.emptyMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteMenItm = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTolStr, Me.editTolStr, Me.helpTolStr})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileTolStr
        '
        Me.FileTolStr.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newMenItm, Me.openMenItm, Me.ToolStripMenuItem1, Me.saveMenItm, Me.ToolStripMenuItem2, Me.exitMenItm})
        Me.FileTolStr.Name = "FileTolStr"
        Me.FileTolStr.Size = New System.Drawing.Size(46, 24)
        Me.FileTolStr.Text = "File"
        '
        'newMenItm
        '
        Me.newMenItm.Name = "newMenItm"
        Me.newMenItm.Size = New System.Drawing.Size(224, 26)
        Me.newMenItm.Text = "New"
        '
        'saveMenItm
        '
        Me.saveMenItm.Name = "saveMenItm"
        Me.saveMenItm.Size = New System.Drawing.Size(224, 26)
        Me.saveMenItm.Text = "Save"
        '
        'openMenItm
        '
        Me.openMenItm.Name = "openMenItm"
        Me.openMenItm.Size = New System.Drawing.Size(224, 26)
        Me.openMenItm.Text = "Open"
        '
        'exitMenItm
        '
        Me.exitMenItm.Name = "exitMenItm"
        Me.exitMenItm.Size = New System.Drawing.Size(224, 26)
        Me.exitMenItm.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 6)
        '
        'helpTolStr
        '
        Me.helpTolStr.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutMenItm})
        Me.helpTolStr.Name = "helpTolStr"
        Me.helpTolStr.Size = New System.Drawing.Size(55, 24)
        Me.helpTolStr.Text = "Help"
        '
        'aboutMenItm
        '
        Me.aboutMenItm.Name = "aboutMenItm"
        Me.aboutMenItm.Size = New System.Drawing.Size(224, 26)
        Me.aboutMenItm.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiletolstrStsLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FiletolstrStsLbl
        '
        Me.FiletolstrStsLbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiletolstrStsLbl.Name = "FiletolstrStsLbl"
        Me.FiletolstrStsLbl.Size = New System.Drawing.Size(39, 20)
        Me.FiletolstrStsLbl.Text = "File :"
        Me.FiletolstrStsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "crack.png")
        Me.ImageList1.Images.SetKeyName(1, "diskette.png")
        Me.ImageList1.Images.SetKeyName(2, "encrypt.png")
        Me.ImageList1.Images.SetKeyName(3, "new-file-64.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtKey, Me.btnRandomKey, Me.btnEncrypt, Me.btnDecrypt})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(957, 30)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(77, 27)
        Me.ToolStripLabel1.Text = "Password :"
        '
        'txtKey
        '
        Me.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKey.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.ForeColor = System.Drawing.Color.Purple
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(250, 30)
        '
        'btnRandomKey
        '
        Me.btnRandomKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRandomKey.Image = CType(resources.GetObject("btnRandomKey.Image"), System.Drawing.Image)
        Me.btnRandomKey.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRandomKey.Name = "btnRandomKey"
        Me.btnRandomKey.Size = New System.Drawing.Size(134, 27)
        Me.btnRandomKey.Text = "Random Password"
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEncrypt.Image = CType(resources.GetObject("btnEncrypt.Image"), System.Drawing.Image)
        Me.btnEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.btnEncrypt.Size = New System.Drawing.Size(74, 27)
        Me.btnEncrypt.Text = "Encrypt"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDecrypt.Image = CType(resources.GetObject("btnDecrypt.Image"), System.Drawing.Image)
        Me.btnDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.btnDecrypt.Size = New System.Drawing.Size(77, 27)
        Me.btnDecrypt.Text = "Decrypt"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 459)
        Me.Panel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEncrypt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(957, 459)
        Me.SplitContainer1.SplitterDistance = 239
        Me.SplitContainer1.TabIndex = 0
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEncrypt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncrypt.Location = New System.Drawing.Point(12, 12)
        Me.txtEncrypt.Multiline = True
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEncrypt.Size = New System.Drawing.Size(933, 215)
        Me.txtEncrypt.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtDecrypt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(957, 216)
        Me.Panel2.TabIndex = 0
        '
        'txtDecrypt
        '
        Me.txtDecrypt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDecrypt.BackColor = System.Drawing.Color.White
        Me.txtDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDecrypt.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecrypt.ForeColor = System.Drawing.Color.Teal
        Me.txtDecrypt.Location = New System.Drawing.Point(12, 13)
        Me.txtDecrypt.Multiline = True
        Me.txtDecrypt.Name = "txtDecrypt"
        Me.txtDecrypt.ReadOnly = True
        Me.txtDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDecrypt.Size = New System.Drawing.Size(933, 190)
        Me.txtDecrypt.TabIndex = 1
        '
        'editTolStr
        '
        Me.editTolStr.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyMenItm, Me.pasteMenItm, Me.ToolStripMenuItem3, Me.emptyMenItm})
        Me.editTolStr.Name = "editTolStr"
        Me.editTolStr.Size = New System.Drawing.Size(49, 24)
        Me.editTolStr.Text = "Edit"
        '
        'copyMenItm
        '
        Me.copyMenItm.Name = "copyMenItm"
        Me.copyMenItm.Size = New System.Drawing.Size(225, 26)
        Me.copyMenItm.Text = "Copy encrypted text"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(222, 6)
        '
        'emptyMenItm
        '
        Me.emptyMenItm.Name = "emptyMenItm"
        Me.emptyMenItm.Size = New System.Drawing.Size(225, 26)
        Me.emptyMenItm.Text = "Empty text"
        '
        'pasteMenItm
        '
        Me.pasteMenItm.Name = "pasteMenItm"
        Me.pasteMenItm.Size = New System.Drawing.Size(225, 26)
        Me.pasteMenItm.Text = "Paste"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manam Encryption"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileTolStr As ToolStripMenuItem
    Friend WithEvents newMenItm As ToolStripMenuItem
    Friend WithEvents openMenItm As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents saveMenItm As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents exitMenItm As ToolStripMenuItem
    Friend WithEvents helpTolStr As ToolStripMenuItem
    Friend WithEvents aboutMenItm As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FiletolstrStsLbl As ToolStripStatusLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txtKey As ToolStripTextBox
    Friend WithEvents btnRandomKey As ToolStripButton
    Friend WithEvents btnEncrypt As ToolStripButton
    Friend WithEvents btnDecrypt As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txtEncrypt As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDecrypt As TextBox
    Friend WithEvents editTolStr As ToolStripMenuItem
    Friend WithEvents copyMenItm As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents emptyMenItm As ToolStripMenuItem
    Friend WithEvents pasteMenItm As ToolStripMenuItem
End Class
