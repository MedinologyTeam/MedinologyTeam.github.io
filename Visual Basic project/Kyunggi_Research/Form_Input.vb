'//© 2017 Medinology. All rights reserved.
'//이 프로그램은 대한민국 및 국제 저작권법의 보호를 받습니다.

Public Class Form_Input
    Dim Gender As String = ""
    Dim Age As Integer = 0
    Dim Preg As String = ""
    Dim Symp01, Symp02, Symp03, Symp04, Symp05, Symp06, Symp07, Symp08, Symp09, Symp10, Symp11, Symp12, Symp13, Symp14, Symp15, Symp16,
        Symp17, Symp18, Symp19, Symp20, Symp21, Symp22, Symp23, Symp24, Symp25, Symp26, Symp27, Symp28, Symp29, Symp30, Symp31, Symp32,
        Symp33, Symp34, Symp35, Symp36, Symp37, Symp38, Symp39, Symp40, Symp41, Symp42, Symp43, Symp44, Symp45, Symp46, Symp47, Symp48,
        Symp49, Symp50, Symp51 As Integer
    Dim His01, His02, His03, His04, His05, His06, His07, His08, His09, His10, His11 As Integer
    Dim Medi01, Medi02, Medi03, Medi04, Medi05, Medi06, Medi07, Medi08, Medi09, Medi10, Medi11 As Integer

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click

        If RadioButton_Male.Checked = True Then
            Gender = "M"
        ElseIf RadioButton_Female.Checked = True Then
            Gender = "F"
        Else
            MsgBox("성별을 선택하세요.", MsgBoxStyle.OkOnly)
            GoTo Here
        End If


        Age = NumericUpDown_Age.Value


        If RadioButton_PregT.Checked = True Then
            Preg = "T"
        ElseIf RadioButton_PregF.Checked = True Then
            Preg = "F"
        Else
            MsgBox("임신 여부를 선택하세요.", MsgBoxStyle.OkOnly)
            GoTo Here
        End If


        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And
                CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False And
                CheckBox9.Checked = False And CheckBox10.Checked = False And CheckBox11.Checked = False And CheckBox12.Checked = False And
                CheckBox13.Checked = False And CheckBox14.Checked = False And CheckBox15.Checked = False And CheckBox16.Checked = False And
                CheckBox17.Checked = False And CheckBox18.Checked = False And CheckBox19.Checked = False And CheckBox20.Checked = False And
                CheckBox21.Checked = False And CheckBox22.Checked = False And CheckBox23.Checked = False And CheckBox24.Checked = False And
                CheckBox25.Checked = False And CheckBox26.Checked = False And CheckBox27.Checked = False And CheckBox28.Checked = False And
                CheckBox29.Checked = False And CheckBox30.Checked = False And CheckBox31.Checked = False And CheckBox32.Checked = False And
                CheckBox33.Checked = False And CheckBox34.Checked = False And CheckBox35.Checked = False And CheckBox36.Checked = False And
                CheckBox37.Checked = False And CheckBox38.Checked = False And CheckBox39.Checked = False And CheckBox40.Checked = False And
                CheckBox41.Checked = False And CheckBox42.Checked = False And CheckBox43.Checked = False And CheckBox44.Checked = False And
                CheckBox45.Checked = False And CheckBox46.Checked = False And CheckBox47.Checked = False And CheckBox48.Checked = False And
                CheckBox49.Checked = False And CheckBox50.Checked = False And CheckBox51.Checked = False Then
            MsgBox("증상을 선택하세요.", MsgBoxStyle.OkOnly And MsgBoxStyle.Critical)
            GoTo Here
        End If

        '//증상
        If CheckBox1.Checked = True Then
            Symp01 = 1
        Else
            Symp01 = 0
        End If

        If CheckBox2.Checked = True Then
            Symp02 = 1
        Else
            Symp02 = 0
        End If

        If CheckBox3.Checked = True Then
            Symp03 = 1
        Else
            Symp03 = 0
        End If

        If CheckBox4.Checked = True Then
            Symp04 = 1
        Else
            Symp04 = 0
        End If

        If CheckBox5.Checked = True Then
            Symp05 = 1
        Else
            Symp05 = 0
        End If

        If CheckBox6.Checked = True Then
            Symp06 = 1
        Else
            Symp06 = 0
        End If

        If CheckBox7.Checked = True Then
            Symp07 = 1
        Else
            Symp07 = 0
        End If

        If CheckBox8.Checked = True Then
            Symp08 = 1
        Else
            Symp08 = 0
        End If

        If CheckBox9.Checked = True Then
            Symp09 = 1
        Else
            Symp09 = 0
        End If

        If CheckBox10.Checked = True Then
            Symp10 = 1
        Else
            Symp10 = 0
        End If

        If CheckBox11.Checked = True Then
            Symp11 = 1
        Else
            Symp11 = 0
        End If

        If CheckBox12.Checked = True Then
            Symp12 = 1
        Else
            Symp12 = 0
        End If

        If CheckBox13.Checked = True Then
            Symp13 = 1
        Else
            Symp13 = 0
        End If

        If CheckBox14.Checked = True Then
            Symp14 = 1
        Else
            Symp14 = 0
        End If

        If CheckBox15.Checked = True Then
            Symp15 = 1
        Else
            Symp15 = 0
        End If

        If CheckBox16.Checked = True Then
            Symp16 = 1
        Else
            Symp16 = 0
        End If

        If CheckBox17.Checked = True Then
            Symp17 = 1
        Else
            Symp17 = 0
        End If

        If CheckBox18.Checked = True Then
            Symp18 = 1
        Else
            Symp18 = 0
        End If

        If CheckBox19.Checked = True Then
            Symp19 = 1
        Else
            Symp19 = 0
        End If

        If CheckBox20.Checked = True Then
            Symp20 = 1
        Else
            Symp20 = 0
        End If

        If CheckBox21.Checked = True Then
            Symp21 = 1
        Else
            Symp21 = 0
        End If

        If CheckBox22.Checked = True Then
            Symp22 = 1
        Else
            Symp22 = 0
        End If

        If CheckBox23.Checked = True Then
            Symp23 = 1
        Else
            Symp23 = 0
        End If

        If CheckBox24.Checked = True Then
            Symp24 = 1
        Else
            Symp24 = 0
        End If

        If CheckBox25.Checked = True Then
            Symp25 = 1
        Else
            Symp25 = 0
        End If

        If CheckBox26.Checked = True Then
            Symp26 = 1
        Else
            Symp26 = 0
        End If

        If CheckBox27.Checked = True Then
            Symp27 = 1
        Else
            Symp27 = 0
        End If

        If CheckBox28.Checked = True Then
            Symp28 = 1
        Else
            Symp28 = 0
        End If

        If CheckBox29.Checked = True Then
            Symp29 = 1
        Else
            Symp29 = 0
        End If

        If CheckBox30.Checked = True Then
            Symp30 = 1
        Else
            Symp30 = 0
        End If

        If CheckBox31.Checked = True Then
            Symp31 = 1
        Else
            Symp31 = 0
        End If

        If CheckBox32.Checked = True Then
            Symp32 = 1
        Else
            Symp32 = 0
        End If

        If CheckBox33.Checked = True Then
            Symp33 = 1
        Else
            Symp33 = 0
        End If

        If CheckBox34.Checked = True Then
            Symp34 = 1
        Else
            Symp34 = 0
        End If

        If CheckBox35.Checked = True Then
            Symp35 = 1
        Else
            Symp35 = 0
        End If

        If CheckBox36.Checked = True Then
            Symp36 = 1
        Else
            Symp36 = 0
        End If

        If CheckBox37.Checked = True Then
            Symp37 = 1
        Else
            Symp37 = 0
        End If

        If CheckBox38.Checked = True Then
            Symp38 = 1
        Else
            Symp38 = 0
        End If

        If CheckBox39.Checked = True Then
            Symp39 = 1
        Else
            Symp39 = 0
        End If

        If CheckBox40.Checked = True Then
            Symp40 = 1
        Else
            Symp40 = 0
        End If

        If CheckBox41.Checked = True Then
            Symp41 = 1
        Else
            Symp41 = 0
        End If

        If CheckBox42.Checked = True Then
            Symp42 = 1
        Else
            Symp42 = 0
        End If

        If CheckBox43.Checked = True Then
            Symp43 = 1
        Else
            Symp43 = 0
        End If

        If CheckBox44.Checked = True Then
            Symp44 = 1
        Else
            Symp44 = 0
        End If

        If CheckBox45.Checked = True Then
            Symp45 = 1
        Else
            Symp45 = 0
        End If

        If CheckBox46.Checked = True Then
            Symp46 = 1
        Else
            Symp46 = 0
        End If

        If CheckBox47.Checked = True Then
            Symp47 = 1
        Else
            Symp47 = 0
        End If

        If CheckBox48.Checked = True Then
            Symp48 = 1
        Else
            Symp48 = 0
        End If

        If CheckBox49.Checked = True Then
            Symp49 = 1
        Else
            Symp49 = 0
        End If

        If CheckBox50.Checked = True Then
            Symp50 = 1
        Else
            Symp50 = 0
        End If

        If CheckBox51.Checked = True Then
            Symp51 = 1
        Else
            Symp51 = 0
        End If

        '//과거병력
        If CheckBox_His01.Checked = True Then
            His01 = 1
        Else
            His01 = 0
        End If

        If CheckBox_His02.Checked = True Then
            His02 = 1
        Else
            His02 = 0
        End If

        If CheckBox_His03.Checked = True Then
            His03 = 1
        Else
            His03 = 0
        End If

        If CheckBox_His04.Checked = True Then
            His04 = 1
        Else
            His04 = 0
        End If

        If CheckBox_His05.Checked = True Then
            His05 = 1
        Else
            His05 = 0
        End If

        If CheckBox_His06.Checked = True Then
            His06 = 1
        Else
            His06 = 0
        End If

        If CheckBox_His07.Checked = True Then
            His07 = 1
        Else
            His07 = 0
        End If

        If CheckBox_His08.Checked = True Then
            His08 = 1
        Else
            His08 = 0
        End If

        If CheckBox_His09.Checked = True Then
            His09 = 1
        Else
            His09 = 0
        End If

        If CheckBox_His10.Checked = True Then
            His10 = 1
        Else
            His10 = 0
        End If

        If CheckBox_His11.Checked = True Then
            His11 = 1
        Else
            His11 = 0
        End If

        '//복용중인 약
        If CheckBox_Medi01.Checked = True Then
            Medi01 = 1
        Else
            Medi01 = 0
        End If

        If CheckBox_Medi02.Checked = True Then
            Medi02 = 1
        Else
            Medi02 = 0
        End If

        If CheckBox_Medi03.Checked = True Then
            Medi03 = 1
        Else
            Medi03 = 0
        End If

        If CheckBox_Medi04.Checked = True Then
            Medi04 = 1
        Else
            Medi04 = 0
        End If

        If CheckBox_Medi05.Checked = True Then
            Medi05 = 1
        Else
            Medi05 = 0
        End If

        If CheckBox_Medi06.Checked = True Then
            Medi06 = 1
        Else
            Medi06 = 0
        End If

        If CheckBox_Medi07.Checked = True Then
            Medi07 = 1
        Else
            Medi07 = 0
        End If

        If CheckBox_Medi08.Checked = True Then
            Medi08 = 1
        Else
            Medi08 = 0
        End If

        If CheckBox_Medi09.Checked = True Then
            Medi09 = 1
        Else
            Medi09 = 0
        End If

        If CheckBox_Medi10.Checked = True Then
            Medi10 = 1
        Else
            Medi10 = 0
        End If

        If CheckBox_Medi11.Checked = True Then
            Medi11 = 1
        Else
            Medi11 = 0
        End If


        Dim Input As New System.IO.StreamWriter("Input.txt", False)
        Input.WriteLine(Gender)
        Input.WriteLine(Age)
        Input.WriteLine(Preg)
        Input.WriteLine(Symp01 & Symp02 & Symp03 & Symp04 & Symp05 & Symp06 & Symp07 & Symp08 & Symp09 & Symp10 & Symp11 & Symp12 &
                        Symp13 & Symp14 & Symp15 & Symp16 & Symp17 & Symp18 & Symp19 & Symp20 & Symp21 & Symp22 & Symp23 & Symp24 &
                        Symp25 & Symp26 & Symp27 & Symp28 & Symp29 & Symp30 & Symp31 & Symp32 & Symp33 & Symp34 & Symp35 & Symp36 &
                        Symp37 & Symp38 & Symp39 & Symp40 & Symp41 & Symp42 & Symp43 & Symp44 & Symp45 & Symp46 & Symp47 & Symp48 &
                        Symp49 & Symp50 & Symp51)
        Input.WriteLine(His01 & His02 & His03 & His04 & His05 & His06 & His07 & His08 & His09 & His10 & His11)
        Input.WriteLine(Medi01 & Medi02 & Medi03 & Medi04 & Medi05 & Medi06 & Medi07 & Medi08 & Medi09 & Medi10 & Medi11)
        Input.Close()

        Me.Hide()
        Form_Process.Show()

Here:
    End Sub

    Private Sub RadioButton_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Male.CheckedChanged
        If RadioButton_Male.Checked = True Then
            RadioButton_PregT.Enabled = False
            RadioButton_PregF.Enabled = False
            RadioButton_PregF.Checked = True
        Else
            RadioButton_PregT.Enabled = True
            RadioButton_PregF.Enabled = True
            RadioButton_PregF.Checked = False
        End If
    End Sub

    Private Sub Form_Input_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("정말 종료하시겠습니까?", "Medinology", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class