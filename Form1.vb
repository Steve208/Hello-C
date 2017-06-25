Imports System.IO
Public Class Form1
    Private IsOpen As Boolean = False
    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Flash影片(*.swf)|*.swf"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Flash1.Movie = OpenFileDialog1.FileName
            mnuPlay.Checked = True
            Me.Text = Path.GetFileName(OpenFileDialog1.FileName) & " - Flash播放器"
            Timer1.Enabled = True
            IsOpen = True
        End If
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Flash1.Movie = "http://"
        Timer1.Enabled = False
        ToolStripStatusLabel1.Text = ""
    End Sub
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowAll.Click
        Flash1.Zoom(0)
    End Sub


    Private Sub mnuZoomIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuZoomIn.Click
        Flash1.Zoom(50)
    End Sub

    Private Sub mnuZoomOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuZoomOut.Click
        Flash1.Zoom(200)
    End Sub

    Private Sub mnuFullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFullScreen.Click
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        MenuStrip1.Visible = False
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Me.WindowState = FormWindowState.Normal Then Exit Sub
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            MenuStrip1.Visible = True
        End If
    End Sub

    Private Sub mnuHigh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHigh.Click
        Flash1.Quality2 = "High"
        mnuHigh.Checked = True
        mnuMedium.Checked = False
    End Sub

    Private Sub mnuMedium_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuMedium.Click
        Flash1.Quality2 = "Medium"
        mnuHigh.Checked = False
        mnuMedium.Checked = True
        mnuLow.Checked = False
    End Sub

    Private Sub mnuLow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnulow.Click
        Flash1.Quality2 = "Low"
        mnuHigh.Checked = False
        mnuMedium.Checked = False
        mnuLow.Checked = True
    End Sub

    Private Sub mnuPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlay.Click
        If Flash1.Playing = True Then
            Flash1.StopPlay()
            Flash1.Playing = False
            mnuPlay.Checked = False
        Else
            Flash1.Play()
            Flash1.Playing = True
            mnuPlay.Checked = True
        End If
    End Sub

    Private Sub mnuRewind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRewind.Click
        Flash1.Rewind()
    End Sub

    Private Sub mnuForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuForward.Click
        Flash1.Forward()
    End Sub

    Private Sub mnuBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBack.Click
        Flash1.Back()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = "总帧数：" & Flash1.TotalFrames & "，当前帧：" & (Flash1.CurrentFrame + 1) & If(Flash1.Playing, "，播放中...", "，暂停")
    End Sub

    Private Sub mnuLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLoop.Click
        mnuLoop.Checked = Not mnuLoop.Checked
        Flash1.Loop = mnuLoop.Checked
    End Sub


    Public Function GetSize(ByVal strPath As String) As Size
        Dim fs As FileStream = New FileStream(strPath, FileMode.Open)
        Dim br As New BinaryReader(fs)
        Dim _sFileType As New String(br.ReadChars(3))  '文件类型。可能的类型为 "FWS" - 未压缩，"CWS" - zlib压缩
        Dim _sVersion As String = br.ReadByte().ToString("D")  'Flash 版本
        Dim _iDataLength As Integer = br.ReadInt32()   ' 数据长度
        Dim nBit As Integer = CInt(br.ReadByte())   ' 开始取得nBit
        nBit = nBit >> 3
        fs.Seek(8, SeekOrigin.Begin)   ' 从第8个字节读取
        Dim RetByteArray As Byte() = br.ReadBytes((5 + nBit * 4 - 1) / 8 + 1)
        fs.Close()
        br.Close()
        Dim Ret As String = ""
        For i As Integer = 0 To RetByteArray.Length - 1
            Ret += Convert.ToString(RetByteArray(i), 2).PadLeft(8, "0")
        Next
        Ret = Ret.Remove(0, 5)   ' 去除5为长度位
        Dim RetIntArray(4) As Integer
        For j As Integer = 0 To 3   ' 每8位截取一次
            RetIntArray(j) = Convert.ToInt32(Ret.Substring(j * nBit, nBit), 2)
        Next
        Dim _iWidth As Integer = (RetIntArray(1) - RetIntArray(0)) / 20   ' (x2-x1)/20
        Dim _iHeight As Integer = (RetIntArray(3) - RetIntArray(2)) / 20   ' (y2-y1)/20
        Return New Size(_iWidth, _iHeight)
    End Function

    Private Sub mnuView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuView.Click, mnuView.MouseEnter
        mnuShowAll.Enabled = IsOpen
        mnuZoomIn.Enabled = IsOpen
        mnuZoomOut.Enabled = IsOpen
    End Sub

    Private Sub mnuControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuControl.Click, mnuControl.MouseEnter
        mnuPlay.Enabled = IsOpen
        mnuRewind.Enabled = IsOpen
        mnuForward.Enabled = IsOpen
        mnuBack.Enabled = IsOpen
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
