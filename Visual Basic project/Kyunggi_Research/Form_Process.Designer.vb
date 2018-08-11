<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Process
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
        Me.Label_Process = New System.Windows.Forms.Label()
        Me.ProgressBar_Process = New System.Windows.Forms.ProgressBar()
        Me.Timer_Process = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Process
        '
        Me.Label_Process.AutoSize = True
        Me.Label_Process.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label_Process.Location = New System.Drawing.Point(76, 156)
        Me.Label_Process.Name = "Label_Process"
        Me.Label_Process.Size = New System.Drawing.Size(365, 20)
        Me.Label_Process.TabIndex = 0
        Me.Label_Process.Text = "잠시만 기다려주세요. 이 작업은 수 초 정도 걸립니다."
        '
        'ProgressBar_Process
        '
        Me.ProgressBar_Process.Location = New System.Drawing.Point(12, 434)
        Me.ProgressBar_Process.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar_Process.Maximum = 200
        Me.ProgressBar_Process.Name = "ProgressBar_Process"
        Me.ProgressBar_Process.Size = New System.Drawing.Size(503, 12)
        Me.ProgressBar_Process.TabIndex = 1
        '
        'Timer_Process
        '
        Me.Timer_Process.Enabled = True
        Me.Timer_Process.Interval = 1
        '
        'Form_Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(530, 350)
        Me.Controls.Add(Me.ProgressBar_Process)
        Me.Controls.Add(Me.Label_Process)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form_Process"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medinology"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Process As Label
    Friend WithEvents ProgressBar_Process As ProgressBar
    Friend WithEvents Timer_Process As Timer
End Class
