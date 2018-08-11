'//© 2017 Medinology. All rights reserved.
'//이 프로그램은 대한민국 및 국제 저작권법의 보호를 받습니다.

Public Class Form_Process
    Dim IsDone As Boolean
    Private Sub Timer_Process_Tick(sender As Object, e As EventArgs) Handles Timer_Process.Tick
        If IsDone = True Then
            Timer_Process.Enabled = False
            Form_Output.Show()
            Me.Hide()
        Else
            ProgressBar_Process.Value = ProgressBar_Process.Value + 1
        End If
    End Sub
    Private Sub Form_Process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shell("Medinology_cpp.exe")
        IsDone = True
    End Sub
    Private Sub Form_Process_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("정말 종료하시겠습니까?", "Medinology", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class