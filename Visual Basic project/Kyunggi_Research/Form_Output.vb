'//© 2017 Medinology. All rights reserved.
'//이 프로그램은 대한민국 및 국제 저작권법의 보호를 받습니다.

Public Class Form_Output
    Private Sub Form_Output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Output As New System.IO.StreamReader("Output.txt")
        'Dim Per1 As Integer = Output.ReadLine()
        'Dim Di1 As Integer = Output.ReadLine()
        'Dim Per2 As Integer = Output.ReadLine()
        'Dim Di2 As Integer = Output.ReadLine()
        'Dim Per3 As Integer = Output.ReadLine()
        'Dim Di3 As Integer = Output.ReadLine()

        Dim Di1 As Integer = Output.ReadLine()
        Dim Per1 As Integer = Output.ReadLine()
        Dim Di2 As Integer = Output.ReadLine()
        Dim Per2 As Integer = Output.ReadLine()
        Dim Di3 As Integer = Output.ReadLine()
        Dim Per3 As Integer = Output.ReadLine()

        Label_1_Per.Text = Per1 & "%"
        Label_2_Per.Text = Per2 & "%"
        Label_3_Per.Text = Per3 & "%"

        Dim Input As New System.IO.StreamReader("Input.txt")
        Dim Trash As String = Input.ReadLine()
        Dim Age As String = Input.ReadLine()
        Dim Preg As String = Input.ReadLine()


        '//1순위
        If Di1 = 0 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_1_Medi.Text = "크라포란주, 독시사이클린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 0 And Age < 13 Then
            Label_1_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_1_Medi.Text = "크라포란주, 독시사이클린"
            Label_1_Warn1.Text = "크라포란주 = 병원 처방이 필요합니다."
            Label_1_Warn2.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 0 And Preg = "T" Then
            Label_1_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_1_Medi.Text = "크라포란주, 독시사이클린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 1 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "렙토스피라병"
            Label_1_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 1 And Age < 13 Then
            Label_1_Di.Text = "렙토스피라병"
            Label_1_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_1_Warn1.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "앰씰린캡슐 = 병원 처방이 필요합니다."
        ElseIf Di1 = 1 And Preg = "T" Then
            Label_1_Di.Text = "렙토스피라병"
            Label_1_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 2 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "대상포진"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di1 = 2 And Age < 13 Then
            Label_1_Di.Text = "대상포진"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 2 And Preg = "T" Then
            Label_1_Di.Text = "대상포진"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 3 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "식중독"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 3 And Age < 13 Then
            Label_1_Di.Text = "식중독"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 3 And Preg = "T" Then
            Label_1_Di.Text = "식중독"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 4 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "장티푸스"
            Label_1_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 4 And Age < 13 Then
            Label_1_Di.Text = "장티푸스"
            Label_1_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_1_Warn1.Text = "화이자시프로플록사신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "세트리악손주 = 병원 처방이 필요합니다."
        ElseIf Di1 = 4 And Preg = "T" Then
            Label_1_Di.Text = "장티푸스"
            Label_1_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 5 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "쯔쯔가무시병"
            Label_1_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 5 And Age < 13 Then
            Label_1_Di.Text = "쯔쯔가무시병"
            Label_1_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 5 And Preg = "T" Then
            Label_1_Di.Text = "쯔쯔가무시병"
            Label_1_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 6 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "헤르페스 구순염"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di1 = 6 And Age < 13 Then
            Label_1_Di.Text = "헤르페스 구순염"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 6 And Preg = "T" Then
            Label_1_Di.Text = "헤르페스 구순염"
            Label_1_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_1_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 7 And Preg = "F" Then
            Label_1_Di.Text = "부신피질 기능부전증"
            Label_1_Medi.Text = "제이알히드로코르티손정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 7 And Preg = "T" Then
            Label_1_Di.Text = "부신피질 기능부전증"
            Label_1_Medi.Text = "제이알히드로코르티손정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 8 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "감염성 장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 8 And Age < 13 Then
            Label_1_Di.Text = "감염성 장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_1_Warn1.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "씨제이메트로니다졸 = 병원 처방이 필요합니다."
        ElseIf Di1 = 8 And Preg = "T" Then
            Label_1_Di.Text = "감염성 장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 9 And Preg = "F" And Age < 65 Then
            Label_1_Di.Text = "과민성 대장 증후군"
            Label_1_Medi.Text = "삼남로페라마이드캡슐"
        ElseIf Di1 = 9 And Age >= 65 Then
            Label_1_Di.Text = "과민성 대장 증후군"
            Label_1_Medi.Text = "삼남로페라마이드캡슐"
            Label_1_Warn1.Text = "어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 9 And Preg = "T" Then
            Label_1_Di.Text = "과민성 대장 증후군"
            Label_1_Medi.Text = "삼남로페라마이드캡슐"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 10 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "간병변증"
            Label_1_Medi.Text = "하원시리마정"
        ElseIf Di1 = 10 And Age < 13 Then
            Label_1_Di.Text = "간병변증"
            Label_1_Medi.Text = "하원시리마정"
            Label_1_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 10 And Preg = "T" Then
            Label_1_Di.Text = "간병변증"
            Label_1_Medi.Text = "하원시리마정"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 11 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "급성 담낭염"
            Label_1_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_1_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다."
        ElseIf Di1 = 11 And Age < 13 Then
            Label_1_Di.Text = "급성 담낭염"
            Label_1_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_1_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "우루사정 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 11 And Preg = "T" Then
            Label_1_Di.Text = "급성 담낭염"
            Label_1_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_1_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "우루사정 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 12 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "급성 췌장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 12 And Age < 13 Then
            Label_1_Di.Text = "급성 췌장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 12 And Preg = "T" Then
            Label_1_Di.Text = "급성 췌장염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 13 Then
            Label_1_Di.Text = "치질"
            Label_1_Medi.Text = "렉센연고"
        ElseIf Di1 = 14 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "심부전"
            Label_1_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 14 And Age < 13 Then
            Label_1_Di.Text = "심부전"
            Label_1_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 14 And Preg = "T" Then
            Label_1_Di.Text = "심부전"
            Label_1_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 15 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_1_Di.Text = "곤충알레르기"
            Label_1_Medi.Text = "에피네프린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 15 And Age >= 65 Then
            Label_1_Di.Text = "곤충알레르기"
            Label_1_Medi.Text = "에피네프린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 15 And Age < 13 Then
            Label_1_Di.Text = "곤충알레르기"
            Label_1_Medi.Text = "에피네프린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 15 And Preg = "T" Then
            Label_1_Di.Text = "곤충알레르기"
            Label_1_Medi.Text = "에피네프린"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 16 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_1_Di.Text = "음식물알레르기"
            Label_1_Medi.Text = "에피네프린, 항히스타민제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 16 And Age >= 65 Then
            Label_1_Di.Text = "음식물알레르기"
            Label_1_Medi.Text = "에피네프린, 항히스타민제"
            Label_1_Warn1.Text = "에피네프린 = 병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "항히스타민제 = 병원 처방이 필요합니다."
        ElseIf Di1 = 16 And Age < 13 Then
            Label_1_Di.Text = "음식물알레르기"
            Label_1_Medi.Text = "에피네프린, 항히스타민제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 16 And Preg = "T" Then
            Label_1_Di.Text = "음식물알레르기"
            Label_1_Medi.Text = "에피네프린, 항히스타민제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 17 And Preg = "F" Then
            Label_1_Di.Text = "기관지 천식"
            Label_1_Medi.Text = "대원부데소니드비액"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 17 And Preg = "T" Then
            Label_1_Di.Text = "기관지 천식"
            Label_1_Medi.Text = "대원부데소니드비액"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 18 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "코알레르기"
            Label_1_Medi.Text = "항히스타민제, 항콜린제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 18 And Age < 13 Then
            Label_1_Di.Text = "코알레르기"
            Label_1_Medi.Text = "항히스타민제, 항콜린제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 18 And Preg = "T" Then
            Label_1_Di.Text = "코알레르기"
            Label_1_Medi.Text = "항히스타민제, 항콜린제"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 19 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "과민성 폐렴"
            Label_1_Medi.Text = "로도트라서방정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 19 And Age < 13 Then
            Label_1_Di.Text = "과민성 폐렴"
            Label_1_Medi.Text = "로도트라서방정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 19 And Preg = "T" Then
            Label_1_Di.Text = "과민성 폐렴"
            Label_1_Medi.Text = "로도트라서방정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 20 Then
            Label_1_Di.Text = "기흉"
            Label_1_Warn1.Text = "병원 방문 후 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 21 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "세균성 폐렴"
            Label_1_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 21 And Age < 13 Then
            Label_1_Di.Text = "세균성 폐렴"
            Label_1_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 21 And Preg = "T" Then
            Label_1_Di.Text = "세균성 폐렴"
            Label_1_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 22 And Preg = "F" Then
            Label_1_Di.Text = "폐결핵"
            Label_1_Medi.Text = "리팜핀정, 유한짓정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 22 And Preg = "T" Then
            Label_1_Di.Text = "폐결핵"
            Label_1_Medi.Text = "리팜핀정, 유한짓정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 23 And Preg = "F" Then
            Label_1_Di.Text = "긴장성 두통"
            Label_1_Medi.Text = "조아이브프로펜, 타이레놀정"
        ElseIf Di1 = 23 And Preg = "T" Then
            Label_1_Di.Text = "긴장성 두통"
            Label_1_Medi.Text = "조아이브프로펜, 타이레놀정"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 24 And Preg = "F" And Age < 65 Then
            Label_1_Di.Text = "편두통"
            Label_1_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
        ElseIf Di1 = 24 And Age >= 65 Then
            Label_1_Di.Text = "편두통"
            Label_1_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_1_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 24 And Preg = "T" Then
            Label_1_Di.Text = "편두통"
            Label_1_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 25 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "습진"
            Label_1_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 25 And Age < 13 Then
            Label_1_Di.Text = "습진"
            Label_1_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 25 And Preg = "T" Then
            Label_1_Di.Text = "습진"
            Label_1_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 26 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "여드름"
            Label_1_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_1_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다."
        ElseIf Di1 = 26 And Age < 13 Then
            Label_1_Di.Text = "여드름"
            Label_1_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_1_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 26 And Preg = "T" Then
            Label_1_Di.Text = "여드름"
            Label_1_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_1_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_1_Warn2.Text = "톡클리어겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 27 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "요로감염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di1 = 27 And Age < 13 Then
            Label_1_Di.Text = "요로감염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 27 And Preg = "T" Then
            Label_1_Di.Text = "요로감염"
            Label_1_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_1_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 28 And Preg = "F" And Age < 65 Then
            Label_1_Di.Text = "골관절염"
            Label_1_Medi.Text = "타이레놀정, 아스피린프로텍트정"
        ElseIf Di1 = 28 And Age >= 65 Then
            Label_1_Di.Text = "골관절염"
            Label_1_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_1_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 28 And Preg = "T" Then
            Label_1_Di.Text = "골관절염"
            Label_1_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 29 And Preg = "F" And Age >= 13 Then
            Label_1_Di.Text = "감기"
            Label_1_Medi.Text = "테라플루나이트"
        ElseIf Di1 = 29 And Age < 13 Then
            Label_1_Di.Text = "감기"
            Label_1_Medi.Text = "테라플루나이트"
            Label_1_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 29 And Preg = "T" Then
            Label_1_Di.Text = "감기"
            Label_1_Medi.Text = "테라플루나이트"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di1 = 30 And Preg = "F" Then
            Label_1_Di.Text = "무좀"
            Label_1_Medi.Text = "터비뉴겔"
        ElseIf Di1 = 30 And Preg = "T" Then
            Label_1_Di.Text = "무좀"
            Label_1_Medi.Text = "터비뉴겔"
            Label_1_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        End If


        '//2순위
        If Di2 = 0 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_2_Medi.Text = "크라포란주, 독시사이클린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 0 And Age < 13 Then
            Label_2_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_2_Medi.Text = "크라포란주, 독시사이클린"
            Label_2_Warn1.Text = "크라포란주 = 병원 처방이 필요합니다."
            Label_2_Warn2.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 0 And Preg = "T" Then
            Label_2_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_2_Medi.Text = "크라포란주, 독시사이클린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 1 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "렙토스피라병"
            Label_2_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 1 And Age < 13 Then
            Label_2_Di.Text = "렙토스피라병"
            Label_2_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_2_Warn1.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "앰씰린캡슐 = 병원 처방이 필요합니다."
        ElseIf Di2 = 1 And Preg = "T" Then
            Label_2_Di.Text = "렙토스피라병"
            Label_2_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 2 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "대상포진"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di2 = 2 And Age < 13 Then
            Label_2_Di.Text = "대상포진"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 2 And Preg = "T" Then
            Label_2_Di.Text = "대상포진"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 3 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "식중독"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 3 And Age < 13 Then
            Label_2_Di.Text = "식중독"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 3 And Preg = "T" Then
            Label_2_Di.Text = "식중독"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 4 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "장티푸스"
            Label_2_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 4 And Age < 13 Then
            Label_2_Di.Text = "장티푸스"
            Label_2_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_2_Warn1.Text = "화이자시프로플록사신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "세트리악손주 = 병원 처방이 필요합니다."
        ElseIf Di2 = 4 And Preg = "T" Then
            Label_2_Di.Text = "장티푸스"
            Label_2_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 5 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "쯔쯔가무시병"
            Label_2_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 5 And Age < 13 Then
            Label_2_Di.Text = "쯔쯔가무시병"
            Label_2_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 5 And Preg = "T" Then
            Label_2_Di.Text = "쯔쯔가무시병"
            Label_2_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 6 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "헤르페스 구순염"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di2 = 6 And Age < 13 Then
            Label_2_Di.Text = "헤르페스 구순염"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 6 And Preg = "T" Then
            Label_2_Di.Text = "헤르페스 구순염"
            Label_2_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_2_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 7 And Preg = "F" Then
            Label_2_Di.Text = "부신피질 기능부전증"
            Label_2_Medi.Text = "제이알히드로코르티손정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 7 And Preg = "T" Then
            Label_2_Di.Text = "부신피질 기능부전증"
            Label_2_Medi.Text = "제이알히드로코르티손정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 8 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "감염성 장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 8 And Age < 13 Then
            Label_2_Di.Text = "감염성 장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_2_Warn1.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "씨제이메트로니다졸 = 병원 처방이 필요합니다."
        ElseIf Di2 = 8 And Preg = "T" Then
            Label_2_Di.Text = "감염성 장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 9 And Preg = "F" And Age < 65 Then
            Label_2_Di.Text = "과민성 대장 증후군"
            Label_2_Medi.Text = "삼남로페라마이드캡슐"
        ElseIf Di2 = 9 And Age >= 65 Then
            Label_2_Di.Text = "과민성 대장 증후군"
            Label_2_Medi.Text = "삼남로페라마이드캡슐"
            Label_2_Warn1.Text = "어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 9 And Preg = "T" Then
            Label_2_Di.Text = "과민성 대장 증후군"
            Label_2_Medi.Text = "삼남로페라마이드캡슐"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 10 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "간병변증"
            Label_2_Medi.Text = "하원시리마정"
        ElseIf Di2 = 10 And Age < 13 Then
            Label_2_Di.Text = "간병변증"
            Label_2_Medi.Text = "하원시리마정"
            Label_2_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 10 And Preg = "T" Then
            Label_2_Di.Text = "간병변증"
            Label_2_Medi.Text = "하원시리마정"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 11 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "급성 담낭염"
            Label_2_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_2_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다."
        ElseIf Di2 = 11 And Age < 13 Then
            Label_2_Di.Text = "급성 담낭염"
            Label_2_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_2_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "우루사정 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 11 And Preg = "T" Then
            Label_2_Di.Text = "급성 담낭염"
            Label_2_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_2_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "우루사정 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 12 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "급성 췌장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 12 And Age < 13 Then
            Label_2_Di.Text = "급성 췌장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 12 And Preg = "T" Then
            Label_2_Di.Text = "급성 췌장염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 13 Then
            Label_2_Di.Text = "치질"
            Label_2_Medi.Text = "렉센연고"
        ElseIf Di2 = 14 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "심부전"
            Label_2_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 14 And Age < 13 Then
            Label_2_Di.Text = "심부전"
            Label_2_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 14 And Preg = "T" Then
            Label_2_Di.Text = "심부전"
            Label_2_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 15 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_2_Di.Text = "곤충알레르기"
            Label_2_Medi.Text = "에피네프린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 15 And Age >= 65 Then
            Label_2_Di.Text = "곤충알레르기"
            Label_2_Medi.Text = "에피네프린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 15 And Age < 13 Then
            Label_2_Di.Text = "곤충알레르기"
            Label_2_Medi.Text = "에피네프린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 15 And Preg = "T" Then
            Label_2_Di.Text = "곤충알레르기"
            Label_2_Medi.Text = "에피네프린"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 16 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_2_Di.Text = "음식물알레르기"
            Label_2_Medi.Text = "에피네프린, 항히스타민제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 16 And Age >= 65 Then
            Label_2_Di.Text = "음식물알레르기"
            Label_2_Medi.Text = "에피네프린, 항히스타민제"
            Label_2_Warn1.Text = "에피네프린 = 병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "항히스타민제 = 병원 처방이 필요합니다."
        ElseIf Di2 = 16 And Age < 13 Then
            Label_2_Di.Text = "음식물알레르기"
            Label_2_Medi.Text = "에피네프린, 항히스타민제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 16 And Preg = "T" Then
            Label_2_Di.Text = "음식물알레르기"
            Label_2_Medi.Text = "에피네프린, 항히스타민제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 17 And Preg = "F" Then
            Label_2_Di.Text = "기관지 천식"
            Label_2_Medi.Text = "대원부데소니드비액"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 17 And Preg = "T" Then
            Label_2_Di.Text = "기관지 천식"
            Label_2_Medi.Text = "대원부데소니드비액"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 18 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "코알레르기"
            Label_2_Medi.Text = "항히스타민제, 항콜린제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 18 And Age < 13 Then
            Label_2_Di.Text = "코알레르기"
            Label_2_Medi.Text = "항히스타민제, 항콜린제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 18 And Preg = "T" Then
            Label_2_Di.Text = "코알레르기"
            Label_2_Medi.Text = "항히스타민제, 항콜린제"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 19 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "과민성 폐렴"
            Label_2_Medi.Text = "로도트라서방정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 19 And Age < 13 Then
            Label_2_Di.Text = "과민성 폐렴"
            Label_2_Medi.Text = "로도트라서방정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 19 And Preg = "T" Then
            Label_2_Di.Text = "과민성 폐렴"
            Label_2_Medi.Text = "로도트라서방정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 20 Then
            Label_2_Di.Text = "기흉"
            Label_2_Warn1.Text = "병원 방문 후 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 21 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "세균성 폐렴"
            Label_2_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 21 And Age < 13 Then
            Label_2_Di.Text = "세균성 폐렴"
            Label_2_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 21 And Preg = "T" Then
            Label_2_Di.Text = "세균성 폐렴"
            Label_2_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 22 And Preg = "F" Then
            Label_2_Di.Text = "폐결핵"
            Label_2_Medi.Text = "리팜핀정, 유한짓정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 22 And Preg = "T" Then
            Label_2_Di.Text = "폐결핵"
            Label_2_Medi.Text = "리팜핀정, 유한짓정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 23 And Preg = "F" Then
            Label_2_Di.Text = "긴장성 두통"
            Label_2_Medi.Text = "조아이브프로펜, 타이레놀정"
        ElseIf Di2 = 23 And Preg = "T" Then
            Label_2_Di.Text = "긴장성 두통"
            Label_2_Medi.Text = "조아이브프로펜, 타이레놀정"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 24 And Preg = "F" And Age < 65 Then
            Label_2_Di.Text = "편두통"
            Label_2_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
        ElseIf Di2 = 24 And Age >= 65 Then
            Label_2_Di.Text = "편두통"
            Label_2_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_2_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 24 And Preg = "T" Then
            Label_2_Di.Text = "편두통"
            Label_2_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 25 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "습진"
            Label_2_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 25 And Age < 13 Then
            Label_2_Di.Text = "습진"
            Label_2_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 25 And Preg = "T" Then
            Label_2_Di.Text = "습진"
            Label_2_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 26 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "여드름"
            Label_2_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_2_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다."
        ElseIf Di2 = 26 And Age < 13 Then
            Label_2_Di.Text = "여드름"
            Label_2_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_2_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 26 And Preg = "T" Then
            Label_2_Di.Text = "여드름"
            Label_2_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_2_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_2_Warn2.Text = "톡클리어겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 27 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "요로감염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di2 = 27 And Age < 13 Then
            Label_2_Di.Text = "요로감염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 27 And Preg = "T" Then
            Label_2_Di.Text = "요로감염"
            Label_2_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_2_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 28 And Preg = "F" And Age < 65 Then
            Label_2_Di.Text = "골관절염"
            Label_2_Medi.Text = "타이레놀정, 아스피린프로텍트정"
        ElseIf Di2 = 28 And Age >= 65 Then
            Label_2_Di.Text = "골관절염"
            Label_2_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_2_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 28 And Preg = "T" Then
            Label_2_Di.Text = "골관절염"
            Label_2_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 29 And Preg = "F" And Age >= 13 Then
            Label_2_Di.Text = "감기"
            Label_2_Medi.Text = "테라플루나이트"
        ElseIf Di2 = 29 And Age < 13 Then
            Label_2_Di.Text = "감기"
            Label_2_Medi.Text = "테라플루나이트"
            Label_2_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 29 And Preg = "T" Then
            Label_2_Di.Text = "감기"
            Label_2_Medi.Text = "테라플루나이트"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di2 = 30 And Preg = "F" Then
            Label_2_Di.Text = "무좀"
            Label_2_Medi.Text = "터비뉴겔"
        ElseIf Di2 = 30 And Preg = "T" Then
            Label_2_Di.Text = "무좀"
            Label_2_Medi.Text = "터비뉴겔"
            Label_2_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        End If


        '//3순위
        If Di3 = 0 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_3_Medi.Text = "크라포란주, 독시사이클린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 0 And Age < 13 Then
            Label_3_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_3_Medi.Text = "크라포란주, 독시사이클린"
            Label_3_Warn1.Text = "크라포란주 = 병원 처방이 필요합니다."
            Label_3_Warn2.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 0 And Preg = "T" Then
            Label_3_Di.Text = "비브리오 블니피쿠스 감염증"
            Label_3_Medi.Text = "크라포란주, 독시사이클린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 1 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "렙토스피라병"
            Label_3_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 1 And Age < 13 Then
            Label_3_Di.Text = "렙토스피라병"
            Label_3_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_3_Warn1.Text = "독시사이클린 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "앰씰린캡슐 = 병원 처방이 필요합니다."
        ElseIf Di3 = 1 And Preg = "T" Then
            Label_3_Di.Text = "렙토스피라병"
            Label_3_Medi.Text = "독시사이클린, 앰씰린캡슐"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 2 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "대상포진"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di3 = 2 And Age < 13 Then
            Label_3_Di.Text = "대상포진"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 2 And Preg = "T" Then
            Label_3_Di.Text = "대상포진"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 3 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "식중독"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 3 And Age < 13 Then
            Label_3_Di.Text = "식중독"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 3 And Preg = "T" Then
            Label_3_Di.Text = "식중독"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 4 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "장티푸스"
            Label_3_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 4 And Age < 13 Then
            Label_3_Di.Text = "장티푸스"
            Label_3_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_3_Warn1.Text = "화이자시프로플록사신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "세트리악손주 = 병원 처방이 필요합니다."
        ElseIf Di3 = 4 And Preg = "T" Then
            Label_3_Di.Text = "장티푸스"
            Label_3_Medi.Text = "화이자시프로플록사신정, 세트리악손주"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 5 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "쯔쯔가무시병"
            Label_3_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 5 And Age < 13 Then
            Label_3_Di.Text = "쯔쯔가무시병"
            Label_3_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 5 And Preg = "T" Then
            Label_3_Di.Text = "쯔쯔가무시병"
            Label_3_Medi.Text = "독시사이클린, 미노씬캡슐"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 6 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "헤르페스 구순염"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다."
        ElseIf Di3 = 6 And Age < 13 Then
            Label_3_Di.Text = "헤르페스 구순염"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대유아씨클로버겔 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 6 And Preg = "T" Then
            Label_3_Di.Text = "헤르페스 구순염"
            Label_3_Medi.Text = "대유아씨클로버겔, 대한팜씨클로버정"
            Label_3_Warn1.Text = "대유아씨클로버겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "대한팜씨클로버정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 7 And Preg = "F" Then
            Label_3_Di.Text = "부신피질 기능부전증"
            Label_3_Medi.Text = "제이알히드로코르티손정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 7 And Preg = "T" Then
            Label_3_Di.Text = "부신피질 기능부전증"
            Label_3_Medi.Text = "제이알히드로코르티손정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 8 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "감염성 장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 8 And Age < 13 Then
            Label_3_Di.Text = "감염성 장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_3_Warn1.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "씨제이메트로니다졸 = 병원 처방이 필요합니다."
        ElseIf Di3 = 8 And Preg = "T" Then
            Label_3_Di.Text = "감염성 장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 한올레보플록사신수화물정, 씨제이메트로니다졸"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 9 And Preg = "F" And Age < 65 Then
            Label_3_Di.Text = "과민성 대장 증후군"
            Label_3_Medi.Text = "삼남로페라마이드캡슐"
        ElseIf Di3 = 9 And Age >= 65 Then
            Label_3_Di.Text = "과민성 대장 증후군"
            Label_3_Medi.Text = "삼남로페라마이드캡슐"
            Label_3_Warn1.Text = "어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 9 And Preg = "T" Then
            Label_3_Di.Text = "과민성 대장 증후군"
            Label_3_Medi.Text = "삼남로페라마이드캡슐"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 10 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "간병변증"
            Label_3_Medi.Text = "하원시리마정"
        ElseIf Di3 = 10 And Age < 13 Then
            Label_3_Di.Text = "간병변증"
            Label_3_Medi.Text = "하원시리마정"
            Label_3_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 10 And Preg = "T" Then
            Label_3_Di.Text = "간병변증"
            Label_3_Medi.Text = "하원시리마정"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 11 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "급성 담낭염"
            Label_3_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_3_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다."
        ElseIf Di3 = 11 And Age < 13 Then
            Label_3_Di.Text = "급성 담낭염"
            Label_3_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_3_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "우루사정 = 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 11 And Preg = "T" Then
            Label_3_Di.Text = "급성 담낭염"
            Label_3_Medi.Text = "한올레보플록사신수화물정, 우루사정"
            Label_3_Warn1.Text = "한올레보플록사신수화물정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "우루사정 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 12 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "급성 췌장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 12 And Age < 13 Then
            Label_3_Di.Text = "급성 췌장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 12 And Preg = "T" Then
            Label_3_Di.Text = "급성 췌장염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 이미페넴"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 13 Then
            Label_3_Di.Text = "치질"
            Label_3_Medi.Text = "렉센연고"
        ElseIf Di3 = 14 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "심부전"
            Label_3_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 14 And Age < 13 Then
            Label_3_Di.Text = "심부전"
            Label_3_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 14 And Preg = "T" Then
            Label_3_Di.Text = "심부전"
            Label_3_Medi.Text = "고려칸데사르탄정, 동구발사르탄정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 15 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_3_Di.Text = "곤충알레르기"
            Label_3_Medi.Text = "에피네프린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 15 And Age >= 65 Then
            Label_3_Di.Text = "곤충알레르기"
            Label_3_Medi.Text = "에피네프린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 15 And Age < 13 Then
            Label_3_Di.Text = "곤충알레르기"
            Label_3_Medi.Text = "에피네프린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 15 And Preg = "T" Then
            Label_3_Di.Text = "곤충알레르기"
            Label_3_Medi.Text = "에피네프린"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 16 And Preg = "F" And Age < 65 And Age >= 13 Then
            Label_3_Di.Text = "음식물알레르기"
            Label_3_Medi.Text = "에피네프린, 항히스타민제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 16 And Age >= 65 Then
            Label_3_Di.Text = "음식물알레르기"
            Label_3_Medi.Text = "에피네프린, 항히스타민제"
            Label_3_Warn1.Text = "에피네프린 = 병원 처방이 필요합니다. 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "항히스타민제 = 병원 처방이 필요합니다."
        ElseIf Di3 = 16 And Age < 13 Then
            Label_3_Di.Text = "음식물알레르기"
            Label_3_Medi.Text = "에피네프린, 항히스타민제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 16 And Preg = "T" Then
            Label_3_Di.Text = "음식물알레르기"
            Label_3_Medi.Text = "에피네프린, 항히스타민제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 17 And Preg = "F" Then
            Label_3_Di.Text = "기관지 천식"
            Label_3_Medi.Text = "대원부데소니드비액"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 17 And Preg = "T" Then
            Label_3_Di.Text = "기관지 천식"
            Label_3_Medi.Text = "대원부데소니드비액"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 18 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "코알레르기"
            Label_3_Medi.Text = "항히스타민제, 항콜린제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 18 And Age < 13 Then
            Label_3_Di.Text = "코알레르기"
            Label_3_Medi.Text = "항히스타민제, 항콜린제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 18 And Preg = "T" Then
            Label_3_Di.Text = "코알레르기"
            Label_3_Medi.Text = "항히스타민제, 항콜린제"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 19 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "과민성 폐렴"
            Label_3_Medi.Text = "로도트라서방정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 19 And Age < 13 Then
            Label_3_Di.Text = "과민성 폐렴"
            Label_3_Medi.Text = "로도트라서방정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 19 And Preg = "T" Then
            Label_3_Di.Text = "과민성 폐렴"
            Label_3_Medi.Text = "로도트라서방정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 20 Then
            Label_3_Di.Text = "기흉"
            Label_3_Warn1.Text = "병원 방문 후 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 21 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "세균성 폐렴"
            Label_3_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 21 And Age < 13 Then
            Label_3_Di.Text = "세균성 폐렴"
            Label_3_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 21 And Preg = "T" Then
            Label_3_Di.Text = "세균성 폐렴"
            Label_3_Medi.Text = "유유클래리트로마이신정, 산도스아지트로마이신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 22 And Preg = "F" Then
            Label_3_Di.Text = "폐결핵"
            Label_3_Medi.Text = "리팜핀정, 유한짓정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 22 And Preg = "T" Then
            Label_3_Di.Text = "폐결핵"
            Label_3_Medi.Text = "리팜핀정, 유한짓정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 23 And Preg = "F" Then
            Label_3_Di.Text = "긴장성 두통"
            Label_3_Medi.Text = "조아이브프로펜, 타이레놀정"
        ElseIf Di3 = 23 And Preg = "T" Then
            Label_3_Di.Text = "긴장성 두통"
            Label_3_Medi.Text = "조아이브프로펜, 타이레놀정"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 24 And Preg = "F" And Age < 65 Then
            Label_3_Di.Text = "편두통"
            Label_3_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
        ElseIf Di3 = 24 And Age >= 65 Then
            Label_3_Di.Text = "편두통"
            Label_3_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_3_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 24 And Preg = "T" Then
            Label_3_Di.Text = "편두통"
            Label_3_Medi.Text = "조아이브프로펜, 타이레놀정, 아스피린프로텍트정"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 25 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "습진"
            Label_3_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 25 And Age < 13 Then
            Label_3_Di.Text = "습진"
            Label_3_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 25 And Preg = "T" Then
            Label_3_Di.Text = "습진"
            Label_3_Medi.Text = "항히스타민제, 파마프레드니솔론정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 26 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "여드름"
            Label_3_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_3_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다."
        ElseIf Di3 = 26 And Age < 13 Then
            Label_3_Di.Text = "여드름"
            Label_3_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_3_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 26 And Preg = "T" Then
            Label_3_Di.Text = "여드름"
            Label_3_Medi.Text = "산도스아지트로마이신정, 톡클리어겔"
            Label_3_Warn1.Text = "산도스아지트로마이신정 = 병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
            Label_3_Warn2.Text = "톡클리어겔 = 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 27 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "요로감염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다."
        ElseIf Di3 = 27 And Age < 13 Then
            Label_3_Di.Text = "요로감염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 27 And Preg = "T" Then
            Label_3_Di.Text = "요로감염"
            Label_3_Medi.Text = "화이자시프로플록사신정, 비씨오플록사신정"
            Label_3_Warn1.Text = "병원 처방이 필요합니다. 임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 28 And Preg = "F" And Age < 65 Then
            Label_3_Di.Text = "골관절염"
            Label_3_Medi.Text = "타이레놀정, 아스피린프로텍트정"
        ElseIf Di3 = 28 And Age >= 65 Then
            Label_3_Di.Text = "골관절염"
            Label_3_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_3_Warn1.Text = "아스피린프로텍트정 = 어르신에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 28 And Preg = "T" Then
            Label_3_Di.Text = "골관절염"
            Label_3_Medi.Text = "타이레놀정, 아스피린프로텍트정"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 29 And Preg = "F" And Age >= 13 Then
            Label_3_Di.Text = "감기"
            Label_3_Medi.Text = "테라플루나이트"
        ElseIf Di3 = 29 And Age < 13 Then
            Label_3_Di.Text = "감기"
            Label_3_Medi.Text = "테라플루나이트"
            Label_3_Warn1.Text = "어린이에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 29 And Preg = "T" Then
            Label_3_Di.Text = "감기"
            Label_3_Medi.Text = "테라플루나이트"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        ElseIf Di3 = 30 And Preg = "F" Then
            Label_3_Di.Text = "무좀"
            Label_3_Medi.Text = "터비뉴겔"
        ElseIf Di3 = 30 And Preg = "T" Then
            Label_3_Di.Text = "무좀"
            Label_3_Medi.Text = "터비뉴겔"
            Label_3_Warn1.Text = "임산부에게 위험하므로 의사 및 약사와 상담이 필요합니다."
        End If

        If Label_1_Warn1.Text = "-" Then
            Label_1_Warn1.Text = ""
        End If
        If Label_1_Warn2.Text = "-" Then
            Label_1_Warn2.Text = ""
        End If
        If Label_2_Warn1.Text = "-" Then
            Label_2_Warn1.Text = ""
        End If
        If Label_2_Warn2.Text = "-" Then
            Label_2_Warn2.Text = ""
        End If
        If Label_3_Warn1.Text = "-" Then
            Label_3_Warn1.Text = ""
        End If
        If Label_3_Warn2.Text = "-" Then
            Label_3_Warn2.Text = ""
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        If MessageBox.Show("정말 종료하시겠습니까?", "Medinology", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Form_Output_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("정말 종료하시겠습니까?", "Medinology", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button_SAPI_Click(sender As Object, e As EventArgs) Handles Button_SAPI.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak(Label_Intro1.Text & "," & Label_1_Di.Text & "," & Label_1_Per.Text & "," & Label_1_Medi.Text & "," & Label_1_Warn1.Text & "," & Label_1_Warn2.Text & "," &
            Label_2_Di.Text & "," & Label_2_Per.Text & "," & Label_2_Medi.Text & "," & Label_2_Warn1.Text & "," & Label_2_Warn2.Text & "," &
            Label_3_Di.Text & "," & Label_3_Per.Text & "," & Label_3_Medi.Text & "," & Label_3_Warn1.Text & "," & Label_3_Warn2.Text & "," & Label_Intro2.Text)
    End Sub
End Class