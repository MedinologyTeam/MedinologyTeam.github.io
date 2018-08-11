'//© 2017 Medinology. All rights reserved.
'//이 프로그램은 대한민국 및 국제 저작권법의 보호를 받습니다.

Public Class Form_Loading
    Private Sub Timer_Loading_Tick(sender As Object, e As EventArgs) Handles Timer_Loading.Tick
        If ProgressBar_Loading.Value = "200" Then
            Timer_Loading.Enabled = False
            Form_Input.Show()
            Me.Hide()
        Else
            ProgressBar_Loading.Value = ProgressBar_Loading.Value + 1
        End If

    End Sub

    Private Sub Form_Loading_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("정말 종료하시겠습니까?", "Medinology", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class
