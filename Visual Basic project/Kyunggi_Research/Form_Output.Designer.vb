<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Output
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
        Me.Label_Intro1 = New System.Windows.Forms.Label()
        Me.Label_Di = New System.Windows.Forms.Label()
        Me.Label_Per = New System.Windows.Forms.Label()
        Me.Label_Medi = New System.Windows.Forms.Label()
        Me.Label_1_Di = New System.Windows.Forms.Label()
        Me.Label_1_Per = New System.Windows.Forms.Label()
        Me.Label_1_Medi = New System.Windows.Forms.Label()
        Me.Label_2_Di = New System.Windows.Forms.Label()
        Me.Label_2_Per = New System.Windows.Forms.Label()
        Me.Label_2_Medi = New System.Windows.Forms.Label()
        Me.Label_3_Medi = New System.Windows.Forms.Label()
        Me.Label_3_Per = New System.Windows.Forms.Label()
        Me.Label_3_Di = New System.Windows.Forms.Label()
        Me.Label_1_Warn1 = New System.Windows.Forms.Label()
        Me.Label_2_Warn1 = New System.Windows.Forms.Label()
        Me.Label_3_Warn1 = New System.Windows.Forms.Label()
        Me.Label_1_Warn2 = New System.Windows.Forms.Label()
        Me.Label_2_Warn2 = New System.Windows.Forms.Label()
        Me.Label_3_Warn2 = New System.Windows.Forms.Label()
        Me.Label_Intro2 = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_SAPI = New System.Windows.Forms.Button()
        Me.Label_Intro3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Intro1
        '
        Me.Label_Intro1.AutoSize = True
        Me.Label_Intro1.Location = New System.Drawing.Point(21, 26)
        Me.Label_Intro1.Name = "Label_Intro1"
        Me.Label_Intro1.Size = New System.Drawing.Size(290, 15)
        Me.Label_Intro1.TabIndex = 1
        Me.Label_Intro1.Text = "사용자의 질병 및 확률과 약 처방은 다음과 같습니다."
        '
        'Label_Di
        '
        Me.Label_Di.AutoSize = True
        Me.Label_Di.Location = New System.Drawing.Point(64, 90)
        Me.Label_Di.Name = "Label_Di"
        Me.Label_Di.Size = New System.Drawing.Size(31, 15)
        Me.Label_Di.TabIndex = 2
        Me.Label_Di.Text = "병명"
        '
        'Label_Per
        '
        Me.Label_Per.AutoSize = True
        Me.Label_Per.Location = New System.Drawing.Point(21, 90)
        Me.Label_Per.Name = "Label_Per"
        Me.Label_Per.Size = New System.Drawing.Size(31, 15)
        Me.Label_Per.TabIndex = 3
        Me.Label_Per.Text = "확률"
        '
        'Label_Medi
        '
        Me.Label_Medi.AutoSize = True
        Me.Label_Medi.Location = New System.Drawing.Point(225, 90)
        Me.Label_Medi.Name = "Label_Medi"
        Me.Label_Medi.Size = New System.Drawing.Size(47, 15)
        Me.Label_Medi.TabIndex = 4
        Me.Label_Medi.Text = "약 처방"
        '
        'Label_1_Di
        '
        Me.Label_1_Di.AutoSize = True
        Me.Label_1_Di.Location = New System.Drawing.Point(67, 152)
        Me.Label_1_Di.Name = "Label_1_Di"
        Me.Label_1_Di.Size = New System.Drawing.Size(12, 15)
        Me.Label_1_Di.TabIndex = 5
        Me.Label_1_Di.Text = "-"
        '
        'Label_1_Per
        '
        Me.Label_1_Per.AutoSize = True
        Me.Label_1_Per.Location = New System.Drawing.Point(21, 152)
        Me.Label_1_Per.Name = "Label_1_Per"
        Me.Label_1_Per.Size = New System.Drawing.Size(12, 15)
        Me.Label_1_Per.TabIndex = 6
        Me.Label_1_Per.Text = "-"
        '
        'Label_1_Medi
        '
        Me.Label_1_Medi.AutoSize = True
        Me.Label_1_Medi.Location = New System.Drawing.Point(222, 152)
        Me.Label_1_Medi.Name = "Label_1_Medi"
        Me.Label_1_Medi.Size = New System.Drawing.Size(12, 15)
        Me.Label_1_Medi.TabIndex = 7
        Me.Label_1_Medi.Text = "-"
        '
        'Label_2_Di
        '
        Me.Label_2_Di.AutoSize = True
        Me.Label_2_Di.Location = New System.Drawing.Point(67, 252)
        Me.Label_2_Di.Name = "Label_2_Di"
        Me.Label_2_Di.Size = New System.Drawing.Size(12, 15)
        Me.Label_2_Di.TabIndex = 10
        Me.Label_2_Di.Text = "-"
        '
        'Label_2_Per
        '
        Me.Label_2_Per.AutoSize = True
        Me.Label_2_Per.Location = New System.Drawing.Point(21, 252)
        Me.Label_2_Per.Name = "Label_2_Per"
        Me.Label_2_Per.Size = New System.Drawing.Size(12, 15)
        Me.Label_2_Per.TabIndex = 11
        Me.Label_2_Per.Text = "-"
        '
        'Label_2_Medi
        '
        Me.Label_2_Medi.AutoSize = True
        Me.Label_2_Medi.Location = New System.Drawing.Point(222, 252)
        Me.Label_2_Medi.Name = "Label_2_Medi"
        Me.Label_2_Medi.Size = New System.Drawing.Size(12, 15)
        Me.Label_2_Medi.TabIndex = 12
        Me.Label_2_Medi.Text = "-"
        '
        'Label_3_Medi
        '
        Me.Label_3_Medi.AutoSize = True
        Me.Label_3_Medi.Location = New System.Drawing.Point(222, 352)
        Me.Label_3_Medi.Name = "Label_3_Medi"
        Me.Label_3_Medi.Size = New System.Drawing.Size(12, 15)
        Me.Label_3_Medi.TabIndex = 15
        Me.Label_3_Medi.Text = "-"
        '
        'Label_3_Per
        '
        Me.Label_3_Per.AutoSize = True
        Me.Label_3_Per.Location = New System.Drawing.Point(21, 352)
        Me.Label_3_Per.Name = "Label_3_Per"
        Me.Label_3_Per.Size = New System.Drawing.Size(12, 15)
        Me.Label_3_Per.TabIndex = 14
        Me.Label_3_Per.Text = "-"
        '
        'Label_3_Di
        '
        Me.Label_3_Di.AutoSize = True
        Me.Label_3_Di.Location = New System.Drawing.Point(67, 352)
        Me.Label_3_Di.Name = "Label_3_Di"
        Me.Label_3_Di.Size = New System.Drawing.Size(12, 15)
        Me.Label_3_Di.TabIndex = 13
        Me.Label_3_Di.Text = "-"
        '
        'Label_1_Warn1
        '
        Me.Label_1_Warn1.AutoSize = True
        Me.Label_1_Warn1.Location = New System.Drawing.Point(222, 177)
        Me.Label_1_Warn1.Name = "Label_1_Warn1"
        Me.Label_1_Warn1.Size = New System.Drawing.Size(12, 15)
        Me.Label_1_Warn1.TabIndex = 16
        Me.Label_1_Warn1.Text = "-"
        '
        'Label_2_Warn1
        '
        Me.Label_2_Warn1.AutoSize = True
        Me.Label_2_Warn1.Location = New System.Drawing.Point(222, 277)
        Me.Label_2_Warn1.Name = "Label_2_Warn1"
        Me.Label_2_Warn1.Size = New System.Drawing.Size(12, 15)
        Me.Label_2_Warn1.TabIndex = 17
        Me.Label_2_Warn1.Text = "-"
        '
        'Label_3_Warn1
        '
        Me.Label_3_Warn1.AutoSize = True
        Me.Label_3_Warn1.Location = New System.Drawing.Point(222, 377)
        Me.Label_3_Warn1.Name = "Label_3_Warn1"
        Me.Label_3_Warn1.Size = New System.Drawing.Size(12, 15)
        Me.Label_3_Warn1.TabIndex = 18
        Me.Label_3_Warn1.Text = "-"
        '
        'Label_1_Warn2
        '
        Me.Label_1_Warn2.AutoSize = True
        Me.Label_1_Warn2.Location = New System.Drawing.Point(222, 202)
        Me.Label_1_Warn2.Name = "Label_1_Warn2"
        Me.Label_1_Warn2.Size = New System.Drawing.Size(12, 15)
        Me.Label_1_Warn2.TabIndex = 19
        Me.Label_1_Warn2.Text = "-"
        '
        'Label_2_Warn2
        '
        Me.Label_2_Warn2.AutoSize = True
        Me.Label_2_Warn2.Location = New System.Drawing.Point(222, 302)
        Me.Label_2_Warn2.Name = "Label_2_Warn2"
        Me.Label_2_Warn2.Size = New System.Drawing.Size(12, 15)
        Me.Label_2_Warn2.TabIndex = 20
        Me.Label_2_Warn2.Text = "-"
        '
        'Label_3_Warn2
        '
        Me.Label_3_Warn2.AutoSize = True
        Me.Label_3_Warn2.Location = New System.Drawing.Point(222, 402)
        Me.Label_3_Warn2.Name = "Label_3_Warn2"
        Me.Label_3_Warn2.Size = New System.Drawing.Size(12, 15)
        Me.Label_3_Warn2.TabIndex = 21
        Me.Label_3_Warn2.Text = "-"
        '
        'Label_Intro2
        '
        Me.Label_Intro2.AutoSize = True
        Me.Label_Intro2.Location = New System.Drawing.Point(21, 507)
        Me.Label_Intro2.Name = "Label_Intro2"
        Me.Label_Intro2.Size = New System.Drawing.Size(86, 15)
        Me.Label_Intro2.TabIndex = 22
        Me.Label_Intro2.Text = "쾌유를 빕니다."
        '
        'Button_Close
        '
        Me.Button_Close.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Button_Close.Location = New System.Drawing.Point(847, 497)
        Me.Button_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(125, 41)
        Me.Button_Close.TabIndex = 23
        Me.Button_Close.Text = "확인"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_SAPI
        '
        Me.Button_SAPI.Font = New System.Drawing.Font("돋움", 9.0!)
        Me.Button_SAPI.Location = New System.Drawing.Point(716, 497)
        Me.Button_SAPI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button_SAPI.Name = "Button_SAPI"
        Me.Button_SAPI.Size = New System.Drawing.Size(125, 41)
        Me.Button_SAPI.TabIndex = 24
        Me.Button_SAPI.Text = "말하기"
        Me.Button_SAPI.UseVisualStyleBackColor = True
        '
        'Label_Intro3
        '
        Me.Label_Intro3.AutoSize = True
        Me.Label_Intro3.Location = New System.Drawing.Point(497, 507)
        Me.Label_Intro3.Name = "Label_Intro3"
        Me.Label_Intro3.Size = New System.Drawing.Size(202, 15)
        Me.Label_Intro3.TabIndex = 25
        Me.Label_Intro3.Text = "(말하기 중에는 종료할 수 없습니다.)"
        '
        'Form_Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 551)
        Me.Controls.Add(Me.Label_Intro3)
        Me.Controls.Add(Me.Button_SAPI)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Label_Intro2)
        Me.Controls.Add(Me.Label_3_Warn2)
        Me.Controls.Add(Me.Label_2_Warn2)
        Me.Controls.Add(Me.Label_1_Warn2)
        Me.Controls.Add(Me.Label_3_Warn1)
        Me.Controls.Add(Me.Label_2_Warn1)
        Me.Controls.Add(Me.Label_1_Warn1)
        Me.Controls.Add(Me.Label_3_Medi)
        Me.Controls.Add(Me.Label_3_Per)
        Me.Controls.Add(Me.Label_3_Di)
        Me.Controls.Add(Me.Label_2_Medi)
        Me.Controls.Add(Me.Label_2_Per)
        Me.Controls.Add(Me.Label_2_Di)
        Me.Controls.Add(Me.Label_1_Medi)
        Me.Controls.Add(Me.Label_1_Per)
        Me.Controls.Add(Me.Label_1_Di)
        Me.Controls.Add(Me.Label_Medi)
        Me.Controls.Add(Me.Label_Per)
        Me.Controls.Add(Me.Label_Di)
        Me.Controls.Add(Me.Label_Intro1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form_Output"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medinology"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Intro1 As Label
    Friend WithEvents Label_Di As Label
    Friend WithEvents Label_Per As Label
    Friend WithEvents Label_Medi As Label
    Friend WithEvents Label_1_Di As Label
    Friend WithEvents Label_1_Per As Label
    Friend WithEvents Label_1_Medi As Label
    Friend WithEvents Label_2_Di As Label
    Friend WithEvents Label_2_Per As Label
    Friend WithEvents Label_2_Medi As Label
    Friend WithEvents Label_3_Medi As Label
    Friend WithEvents Label_3_Per As Label
    Friend WithEvents Label_3_Di As Label
    Friend WithEvents Label_1_Warn1 As Label
    Friend WithEvents Label_2_Warn1 As Label
    Friend WithEvents Label_3_Warn1 As Label
    Friend WithEvents Label_1_Warn2 As Label
    Friend WithEvents Label_2_Warn2 As Label
    Friend WithEvents Label_3_Warn2 As Label
    Friend WithEvents Label_Intro2 As Label
    Friend WithEvents Button_Close As Button
    Friend WithEvents Button_SAPI As Button
    Friend WithEvents Label_Intro3 As Label
End Class
