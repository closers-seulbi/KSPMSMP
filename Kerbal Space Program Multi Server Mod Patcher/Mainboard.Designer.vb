<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainboard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tudy = New System.Windows.Forms.Button()
        Me.Additional = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.KSP_Naver_Cafe_Multi_Server_Mod_Patcher.My.Resources.Resources.kerbals_1920x1080
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Tudy
        '
        Me.Tudy.Dock = System.Windows.Forms.DockStyle.Left
        Me.Tudy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Tudy.Location = New System.Drawing.Point(0, 216)
        Me.Tudy.Name = "Tudy"
        Me.Tudy.Size = New System.Drawing.Size(192, 56)
        Me.Tudy.TabIndex = 1
        Me.Tudy.Text = "터디 서버"
        Me.Tudy.UseVisualStyleBackColor = True
        '
        'Additional
        '
        Me.Additional.Dock = System.Windows.Forms.DockStyle.Right
        Me.Additional.Enabled = False
        Me.Additional.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Additional.Location = New System.Drawing.Point(192, 216)
        Me.Additional.Name = "Additional"
        Me.Additional.Size = New System.Drawing.Size(192, 56)
        Me.Additional.TabIndex = 2
        Me.Additional.Text = "준비 중"
        Me.Additional.UseVisualStyleBackColor = True
        '
        'Mainboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 272)
        Me.Controls.Add(Me.Additional)
        Me.Controls.Add(Me.Tudy)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mainboard"
        Me.Text = "메인 화면"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tudy As System.Windows.Forms.Button
    Friend WithEvents Additional As System.Windows.Forms.Button

End Class
