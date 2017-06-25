<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuZoomIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFullScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuality = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHigh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRewind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuForward = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLoop = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Flash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuControl})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(421, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuClose, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(58, 21)
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(174, 22)
        Me.mnuOpen.Text = "打开(&O)..."
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuClose.Size = New System.Drawing.Size(174, 22)
        Me.mnuClose.Text = "关闭(&C)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(174, 22)
        Me.mnuExit.Text = "退出(&X)"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShowAll, Me.ToolStripSeparator2, Me.mnuZoomIn, Me.mnuZoomOut, Me.mnuFullScreen, Me.ToolStripSeparator3, Me.mnuQuality})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(60, 21)
        Me.mnuView.Text = "查看(&V)"
        '
        'mnuShowAll
        '
        Me.mnuShowAll.Name = "mnuShowAll"
        Me.mnuShowAll.Size = New System.Drawing.Size(158, 22)
        Me.mnuShowAll.Text = "显示全部(&A)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(155, 6)
        '
        'mnuZoomIn
        '
        Me.mnuZoomIn.Name = "mnuZoomIn"
        Me.mnuZoomIn.Size = New System.Drawing.Size(158, 22)
        Me.mnuZoomIn.Text = "放大(&I)"
        '
        'mnuZoomOut
        '
        Me.mnuZoomOut.Name = "mnuZoomOut"
        Me.mnuZoomOut.Size = New System.Drawing.Size(158, 22)
        Me.mnuZoomOut.Text = "缩小(&O)"
        '
        'mnuFullScreen
        '
        Me.mnuFullScreen.Name = "mnuFullScreen"
        Me.mnuFullScreen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFullScreen.Size = New System.Drawing.Size(158, 22)
        Me.mnuFullScreen.Text = "全屏(&S)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(155, 6)
        '
        'mnuQuality
        '
        Me.mnuQuality.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHigh, Me.mnuMedium, Me.mnuLow})
        Me.mnuQuality.Name = "mnuQuality"
        Me.mnuQuality.Size = New System.Drawing.Size(158, 22)
        Me.mnuQuality.Text = "品质"
        '
        'mnuHigh
        '
        Me.mnuHigh.Name = "mnuHigh"
        Me.mnuHigh.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuHigh.Size = New System.Drawing.Size(152, 22)
        Me.mnuHigh.Text = "高(&H)"
        '
        'mnuMedium
        '
        Me.mnuMedium.Name = "mnuMedium"
        Me.mnuMedium.Size = New System.Drawing.Size(152, 22)
        Me.mnuMedium.Text = "中"
        '
        'mnuLow
        '
        Me.mnuLow.Name = "mnuLow"
        Me.mnuLow.Size = New System.Drawing.Size(152, 22)
        Me.mnuLow.Text = "低"
        '
        'mnuControl
        '
        Me.mnuControl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlay, Me.mnuRewind, Me.ToolStripSeparator4, Me.mnuForward, Me.mnuBack, Me.ToolStripSeparator5, Me.mnuLoop})
        Me.mnuControl.Name = "mnuControl"
        Me.mnuControl.Size = New System.Drawing.Size(60, 21)
        Me.mnuControl.Text = "控制(&C)"
        '
        'mnuPlay
        '
        Me.mnuPlay.Name = "mnuPlay"
        Me.mnuPlay.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPlay.Size = New System.Drawing.Size(181, 22)
        Me.mnuPlay.Text = "播放(&P)"
        '
        'mnuRewind
        '
        Me.mnuRewind.Name = "mnuRewind"
        Me.mnuRewind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRewind.Size = New System.Drawing.Size(181, 22)
        Me.mnuRewind.Text = "后退(&R)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(178, 6)
        '
        'mnuForward
        '
        Me.mnuForward.Name = "mnuForward"
        Me.mnuForward.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.mnuForward.Size = New System.Drawing.Size(181, 22)
        Me.mnuForward.Text = "向前(&F)"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.mnuBack.Size = New System.Drawing.Size(181, 22)
        Me.mnuBack.Text = "向后(&B)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(178, 6)
        '
        'mnuLoop
        '
        Me.mnuLoop.Name = "mnuLoop"
        Me.mnuLoop.Size = New System.Drawing.Size(181, 22)
        Me.mnuLoop.Text = "循环(&L)"
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 243)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(421, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(406, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'Flash1
        '
        Me.Flash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Flash1.Enabled = True
        Me.Flash1.Location = New System.Drawing.Point(0, 25)
        Me.Flash1.Name = "Flash1"
        Me.Flash1.OcxState = CType(resources.GetObject("Flash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Flash1.Size = New System.Drawing.Size(421, 218)
        Me.Flash1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 265)
        Me.Controls.Add(Me.Flash1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Flash播放器"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Flash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShowAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuZoomIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuZoomOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFullScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuQuality As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHigh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMedium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRewind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuForward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLoop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Flash1 As AxShockwaveFlashObjects.AxShockwaveFlash

End Class
