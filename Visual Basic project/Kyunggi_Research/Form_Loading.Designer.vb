<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Loading
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar_Loading = New System.Windows.Forms.ProgressBar()
        Me.Timer_Loading = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Medinology = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_Copyright = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar_Loading
        '
        Me.ProgressBar_Loading.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ProgressBar_Loading.Location = New System.Drawing.Point(-4, 555)
        Me.ProgressBar_Loading.Maximum = 200
        Me.ProgressBar_Loading.Name = "ProgressBar_Loading"
        Me.ProgressBar_Loading.Size = New System.Drawing.Size(568, 4)
        Me.ProgressBar_Loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar_Loading.TabIndex = 0
        Me.ProgressBar_Loading.UseWaitCursor = True
        '
        'Timer_Loading
        '
        Me.Timer_Loading.Enabled = True
        Me.Timer_Loading.Interval = 1
        '
        'Label_Medinology
        '
        Me.Label_Medinology.AutoSize = True
        Me.Label_Medinology.Font = New System.Drawing.Font("맑은 고딕", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label_Medinology.ForeColor = System.Drawing.Color.White
        Me.Label_Medinology.Location = New System.Drawing.Point(26, 43)
        Me.Label_Medinology.Name = "Label_Medinology"
        Me.Label_Medinology.Size = New System.Drawing.Size(221, 47)
        Me.Label_Medinology.TabIndex = 1
        Me.Label_Medinology.Text = "Medinology"
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label_Version.ForeColor = System.Drawing.Color.White
        Me.Label_Version.Location = New System.Drawing.Point(30, 126)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(170, 21)
        Me.Label_Version.TabIndex = 2
        Me.Label_Version.Text = "Alpha 20170826.0005"
        '
        'Label_Copyright
        '
        Me.Label_Copyright.AutoSize = True
        Me.Label_Copyright.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label_Copyright.ForeColor = System.Drawing.Color.Silver
        Me.Label_Copyright.Location = New System.Drawing.Point(12, 515)
        Me.Label_Copyright.Name = "Label_Copyright"
        Me.Label_Copyright.Size = New System.Drawing.Size(224, 15)
        Me.Label_Copyright.TabIndex = 3
        Me.Label_Copyright.Text = "© 2017 Medinology. All rights reserved."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "이 프로그램은 대한민국 및 국제 저작권법의 보호를 받습니다."
        '
        'Form_Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Copyright)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.Label_Medinology)
        Me.Controls.Add(Me.ProgressBar_Loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medinology"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar_Loading As ProgressBar
    Friend WithEvents Timer_Loading As Timer
    Friend WithEvents Label_Medinology As Label
    Friend WithEvents Label_Version As Label
    Friend WithEvents Label_Copyright As Label
    Friend WithEvents Label1 As Label
End Class
