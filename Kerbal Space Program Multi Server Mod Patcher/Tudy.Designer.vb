<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tudy
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tudy))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DownloadButton1 = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DownloadButton2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 30)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(784, 380)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://cafe.naver.com/kerbal/42477", System.UriKind.Absolute)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 410)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(540, 33)
        Me.ProgressBar1.TabIndex = 3
        '
        'DownloadButton1
        '
        Me.DownloadButton1.Enabled = False
        Me.DownloadButton1.Location = New System.Drawing.Point(540, 410)
        Me.DownloadButton1.Name = "DownloadButton1"
        Me.DownloadButton1.Size = New System.Drawing.Size(124, 31)
        Me.DownloadButton1.TabIndex = 2
        Me.DownloadButton1.Text = "#1 (위키 서버)"
        Me.DownloadButton1.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(0, 30)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(50, 20)
        Me.HomeButton.TabIndex = 4
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "터디 멀티 서버"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DownloadButton2
        '
        Me.DownloadButton2.Enabled = False
        Me.DownloadButton2.Location = New System.Drawing.Point(660, 410)
        Me.DownloadButton2.Name = "DownloadButton2"
        Me.DownloadButton2.Size = New System.Drawing.Size(124, 31)
        Me.DownloadButton2.TabIndex = 6
        Me.DownloadButton2.Text = "#2 (드랍박스 서버)"
        Me.DownloadButton2.UseVisualStyleBackColor = True
        '
        'Tudy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.DownloadButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DownloadButton1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tudy"
        Me.Text = "Tudy"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DownloadButton1 As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DownloadButton2 As System.Windows.Forms.Button
End Class
