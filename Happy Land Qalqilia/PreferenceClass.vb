Public Class PreferenceClass
    Private Txt1, Txt2, Txt3, Txt4, Txt5, Txt6, Txt7, Txt8, Txt9 As String

    Public Sub ConvertNo(ByVal No As String, ByVal SE As String)
        On Error Resume Next

        Txt1 = ""
        Txt2 = ""
        Txt3 = ""
        Txt4 = ""
        Txt5 = ""
        Txt6 = ""
        Txt7 = ""
        Txt8 = ""
        Txt9 = ""
        Dim I As Integer, N, N2 As Double
        N = Len(No)
        Dim LN(N)
        For I = 1 To N
            LN(I) = Mid(No, I, 1)
        Next
        If LN.Length = 2 Then
            If LN(1) = 1 Then Txt1 = "واحد"
            If LN(1) = 2 Then Txt1 = "أثنين"
            If LN(1) = 3 Then Txt1 = "ثلاثة"
            If LN(1) = 4 Then Txt1 = "أربعة"
            If LN(1) = 5 Then Txt1 = "خمسة"
            If LN(1) = 6 Then Txt1 = "ستة"
            If LN(1) = 7 Then Txt1 = "سبعة"
            If LN(1) = 8 Then Txt1 = "ثمانية"
            If LN(1) = 9 Then Txt1 = "تسعة"
            '  TextBox2.Text = Txt1 & " " & "فقط لا غير"
        End If
        If LN.Length = 3 Then
            If LN(1) = 1 Then
                If LN(2) = 0 And LN(1) = 1 Then Txt1 = "عشرة"
                If LN(2) = 1 And LN(1) = 1 Then Txt1 = "أحدى عشر"
                If LN(2) = 2 And LN(1) = 1 Then Txt1 = "أثنتى عشر"
                If LN(2) = 3 And LN(1) = 1 Then Txt1 = "ثلاثة عشر"
                If LN(2) = 4 And LN(1) = 1 Then Txt1 = "أربعة عشر"
                If LN(2) = 5 And LN(1) = 1 Then Txt1 = "خمسة عشر"
                If LN(2) = 6 And LN(1) = 1 Then Txt1 = "ستة عشر"
                If LN(2) = 7 And LN(1) = 1 Then Txt1 = "سبعة عشر"
                If LN(2) = 8 And LN(1) = 1 Then Txt1 = "ثمانية عشر"
                If LN(2) = 9 And LN(1) = 1 Then Txt1 = "تسعة عشر"
            End If
            If LN(1) > 1 And LN(2) <> 0 Then

                If LN(2) = 1 Then Txt1 = "واحد"
                If LN(2) = 2 Then Txt1 = "أثنين"
                If LN(2) = 3 Then Txt1 = "ثلاثة"
                If LN(2) = 4 Then Txt1 = "أربعة"
                If LN(2) = 5 Then Txt1 = "خمسة"
                If LN(2) = 6 Then Txt1 = "ستة"
                If LN(2) = 7 Then Txt1 = "سبعة"
                If LN(2) = 8 Then Txt1 = "ثمانية"
                If LN(2) = 9 Then Txt1 = "تسعة"

                If LN(1) = 2 Then Txt2 = "وعشرون"
                If LN(1) = 3 Then Txt2 = "وثلاثون"
                If LN(1) = 4 Then Txt2 = "وأربعون"
                If LN(1) = 5 Then Txt2 = "وخمسون"
                If LN(1) = 6 Then Txt2 = "وستون"
                If LN(1) = 7 Then Txt2 = "وسبعون"
                If LN(1) = 8 Then Txt2 = "وثمانون"
                If LN(1) = 9 Then Txt2 = "وتسعون"
            End If
            '  TextBox2.Text = Txt1 & " " & Txt2 & " " & "فقط لا غير"
            If LN(1) > 1 And LN(2) = 0 Then
                If LN(1) = 2 Then Txt2 = "عشرون"
                If LN(1) = 3 Then Txt2 = "ثلاثون"
                If LN(1) = 4 Then Txt2 = "أربعون"
                If LN(1) = 5 Then Txt2 = "خمسون"
                If LN(1) = 6 Then Txt2 = "ستون"
                If LN(1) = 7 Then Txt2 = "سبعون"
                If LN(1) = 8 Then Txt2 = "ثمانون"
                If LN(1) = 9 Then Txt2 = "تسعون"
            End If
        End If
        If LN.Length = 4 Then
            If LN(2) > 1 And LN(2) <> 0 Then
                If LN(3) = 1 Then Txt1 = "وواحد"
                If LN(3) = 2 Then Txt1 = "وأثنين"
                If LN(3) = 3 Then Txt1 = "وثلاثة"
                If LN(3) = 4 Then Txt1 = "وأربعة"
                If LN(3) = 5 Then Txt1 = "وخمسة"
                If LN(3) = 6 Then Txt1 = "وستة"
                If LN(3) = 7 Then Txt1 = "وسبعة"
                If LN(3) = 8 Then Txt1 = "وثمانية"
                If LN(3) = 9 Then Txt1 = "وتسعة"
            Else
                If LN(2) = 1 And LN(3) = 0 Then Txt1 = "وعشرة"
                If LN(2) = 1 And LN(3) = 1 Then Txt1 = "وأحدى عشر"
                If LN(2) = 1 And LN(3) = 2 Then Txt1 = "وأثنتى عشر"
                If LN(2) = 1 And LN(3) = 3 Then Txt1 = "وثلاثة عشر"
                If LN(2) = 1 And LN(3) = 4 Then Txt1 = "وأربعة عشر"
                If LN(2) = 1 And LN(3) = 5 Then Txt1 = "وخمسة عشر"
                If LN(2) = 1 And LN(3) = 6 Then Txt1 = "وستة عشر"
                If LN(2) = 1 And LN(3) = 7 Then Txt1 = "وسبعة عشر"
                If LN(2) = 1 And LN(3) = 8 Then Txt1 = "وثمانية عشر"
                If LN(2) = 1 And LN(3) = 9 Then Txt1 = "وتسعة عشر"
            End If
            If LN(2) = 0 Then
                If LN(3) = 1 Then Txt1 = "وواحد"
                If LN(3) = 2 Then Txt1 = "وأثنين"
                If LN(3) = 3 Then Txt1 = "وثلاثة"
                If LN(3) = 4 Then Txt1 = "وأربعة"
                If LN(3) = 5 Then Txt1 = "وخمسة"
                If LN(3) = 6 Then Txt1 = "وستة"
                If LN(3) = 7 Then Txt1 = "وسبعة"
                If LN(3) = 8 Then Txt1 = "وثمانية"
                If LN(3) = 9 Then Txt1 = "وتسعة"
            End If
            If LN(2) = 2 Then Txt2 = "وعشرون"
            If LN(2) = 3 Then Txt2 = "وثلاثون"
            If LN(2) = 4 Then Txt2 = "وأربعون"
            If LN(2) = 5 Then Txt2 = "وخمسون"
            If LN(2) = 6 Then Txt2 = "وستون"
            If LN(2) = 7 Then Txt2 = "وسبعون"
            If LN(2) = 8 Then Txt2 = "وثمانون"
            If LN(2) = 9 Then Txt2 = "وتسعون"
            If LN(1) = 1 Then Txt3 = "مائة"
            If LN(1) = 2 Then Txt3 = "مئتان"
            If LN(1) = 3 Then Txt3 = "ثلاثمائة"
            If LN(1) = 4 Then Txt3 = "ربعمائة"
            If LN(1) = 5 Then Txt3 = "خمسمائة"
            If LN(1) = 6 Then Txt3 = "ستمائة"
            If LN(1) = 7 Then Txt3 = "سبعمائة"
            If LN(1) = 8 Then Txt3 = "ثمانمائة"
            If LN(1) = 9 Then Txt3 = "تسعمائة"
        End If
        If LN.Length = 5 Then
            If LN(3) > 1 And LN(3) <> 0 Then
                If LN(4) = 1 Then Txt1 = "وواحد"
                If LN(4) = 2 Then Txt1 = "وأثنين"
                If LN(4) = 3 Then Txt1 = "وثلاثة"
                If LN(4) = 4 Then Txt1 = "وأربعة"
                If LN(4) = 5 Then Txt1 = "وخمسة"
                If LN(4) = 6 Then Txt1 = "وستة"
                If LN(4) = 7 Then Txt1 = "وسبعة"
                If LN(4) = 8 Then Txt1 = "وثمانية"
                If LN(4) = 9 Then Txt1 = "وتسعة"
            Else
                If LN(3) = 1 And LN(4) = 0 Then Txt1 = "وعشرة"
                If LN(3) = 1 And LN(4) = 1 Then Txt1 = "وأحدى عشر"
                If LN(3) = 1 And LN(4) = 2 Then Txt1 = "وأثنتى عشر"
                If LN(3) = 1 And LN(4) = 3 Then Txt1 = "وثلاثة عشر"
                If LN(3) = 1 And LN(4) = 4 Then Txt1 = "وأربعة عشر"
                If LN(3) = 1 And LN(4) = 5 Then Txt1 = "وخمسة عشر"
                If LN(3) = 1 And LN(4) = 6 Then Txt1 = "وستة عشر"
                If LN(3) = 1 And LN(4) = 7 Then Txt1 = "وسبعة عشر"
                If LN(3) = 1 And LN(4) = 8 Then Txt1 = "وثمانية عشر"
                If LN(3) = 1 And LN(4) = 9 Then Txt1 = "وتسعة عشر"
            End If
            If LN(3) = 0 Then
                If LN(4) = 1 Then Txt1 = "وواحد"
                If LN(4) = 2 Then Txt1 = "وأثنين"
                If LN(4) = 3 Then Txt1 = "وثلاثة"
                If LN(4) = 4 Then Txt1 = "وأربعة"
                If LN(4) = 5 Then Txt1 = "وخمسة"
                If LN(4) = 6 Then Txt1 = "وستة"
                If LN(4) = 7 Then Txt1 = "وسبعة"
                If LN(4) = 8 Then Txt1 = "وثمانية"
                If LN(4) = 9 Then Txt1 = "وتسعة"
            End If
            If LN(2) = 0 And LN(3) > 1 Then
                If LN(3) = 2 Then Txt2 = "وعشرون"
                If LN(3) = 3 Then Txt2 = "وثلاثون"
                If LN(3) = 4 Then Txt2 = "وأربعون"
                If LN(3) = 5 Then Txt2 = "وخمسون"
                If LN(3) = 6 Then Txt2 = "وستون"
                If LN(3) = 7 Then Txt2 = "وسبعون"
                If LN(3) = 8 Then Txt2 = "وثمانون"
                If LN(3) = 9 Then Txt2 = "وتسعون"
            End If
            If LN(3) = 2 Then Txt2 = "وعشرون"
            If LN(3) = 3 Then Txt2 = "وثلاثون"
            If LN(3) = 4 Then Txt2 = "وأربعون"
            If LN(3) = 5 Then Txt2 = "وخمسون"
            If LN(3) = 6 Then Txt2 = "وستون"
            If LN(3) = 7 Then Txt2 = "وسبعون"
            If LN(3) = 8 Then Txt2 = "وثمانون"
            If LN(3) = 9 Then Txt2 = "وتسعون"
            If LN(2) = 1 Then Txt3 = "ومائة"
            If LN(2) = 2 Then Txt3 = "ومئتان"
            If LN(2) = 3 Then Txt3 = "وثلاثمائة"
            If LN(2) = 4 Then Txt3 = "وربعمائة"
            If LN(2) = 5 Then Txt3 = "وخمسمائة"
            If LN(2) = 6 Then Txt3 = "وستمائة"
            If LN(2) = 7 Then Txt3 = "وسبعمائة"
            If LN(2) = 8 Then Txt3 = "وثمانمائة"
            If LN(2) = 9 Then Txt3 = "وتسعمائة"
            If LN(1) = 1 Then Txt4 = "ألف"
            If LN(1) = 2 Then Txt4 = "ألفان"
            If LN(1) = 3 Then Txt4 = "ثلاث ألاف"
            If LN(1) = 4 Then Txt4 = "أربعة الاف"
            If LN(1) = 5 Then Txt4 = "خمس ألاف"
            If LN(1) = 6 Then Txt4 = "ستة ألاف"
            If LN(1) = 7 Then Txt4 = "سبعة ألاف"
            If LN(1) = 8 Then Txt4 = "ثمان ألاف"
            If LN(1) = 9 Then Txt4 = "تسعة ألاف"
        End If
        If LN.Length = 6 Then
            If LN(4) > 1 And LN(4) <> 0 Then
                If LN(5) = 1 Then Txt1 = "وواحد"
                If LN(5) = 2 Then Txt1 = "وأثنين"
                If LN(5) = 3 Then Txt1 = "وثلاثة"
                If LN(5) = 4 Then Txt1 = "وأربعة"
                If LN(5) = 5 Then Txt1 = "وخمسة"
                If LN(5) = 6 Then Txt1 = "وستة"
                If LN(5) = 7 Then Txt1 = "وسبعة"
                If LN(5) = 8 Then Txt1 = "وثمانية"
                If LN(5) = 9 Then Txt1 = "وتسعة"
            Else
                If LN(4) = 1 And LN(5) = 0 Then Txt1 = "وعشرة"
                If LN(4) = 1 And LN(5) = 1 Then Txt1 = "وأحدى عشر"
                If LN(4) = 1 And LN(5) = 2 Then Txt1 = "وأثنتى عشر"
                If LN(4) = 1 And LN(5) = 3 Then Txt1 = "وثلاثة عشر"
                If LN(4) = 1 And LN(5) = 4 Then Txt1 = "وأربعة عشر"
                If LN(4) = 1 And LN(5) = 5 Then Txt1 = "وخمسة عشر"
                If LN(4) = 1 And LN(5) = 6 Then Txt1 = "وستة عشر"
                If LN(4) = 1 And LN(5) = 7 Then Txt1 = "وسبعة عشر"
                If LN(4) = 1 And LN(5) = 8 Then Txt1 = "وثمانية عشر"
                If LN(4) = 1 And LN(5) = 9 Then Txt1 = "وتسعة عشر"
            End If
            If LN(4) = 0 Then
                If LN(5) = 1 Then Txt1 = "وواحد"
                If LN(5) = 2 Then Txt1 = "وأثنين"
                If LN(5) = 3 Then Txt1 = "وثلاثة"
                If LN(5) = 4 Then Txt1 = "وأربعة"
                If LN(5) = 5 Then Txt1 = "وخمسة"
                If LN(5) = 6 Then Txt1 = "وستة"
                If LN(5) = 7 Then Txt1 = "وسبعة"
                If LN(5) = 8 Then Txt1 = "وثمانية"
                If LN(5) = 9 Then Txt1 = "وتسعة"
            End If
            If LN(3) = 0 And LN(4) > 1 Then
                If LN(4) = 2 Then Txt2 = "وعشرون"
                If LN(4) = 3 Then Txt2 = "وثلاثون"
                If LN(4) = 4 Then Txt2 = "وأربعون"
                If LN(4) = 5 Then Txt2 = "وخمسون"
                If LN(4) = 6 Then Txt2 = "وستون"
                If LN(4) = 7 Then Txt2 = "وسبعون"
                If LN(4) = 8 Then Txt2 = "وثمانون"
                If LN(4) = 9 Then Txt2 = "وتسعون"
            End If
            If LN(4) = 2 Then Txt2 = "وعشرون"
            If LN(4) = 3 Then Txt2 = "وثلاثون"
            If LN(4) = 4 Then Txt2 = "وأربعون"
            If LN(4) = 5 Then Txt2 = "وخمسون"
            If LN(4) = 6 Then Txt2 = "وستون"
            If LN(4) = 7 Then Txt2 = "وسبعون"
            If LN(4) = 8 Then Txt2 = "وثمانون"
            If LN(4) = 9 Then Txt2 = "وتسعون"
            If LN(3) = 1 Then Txt3 = "ومائة"
            If LN(3) = 2 Then Txt3 = "ومئتان"
            If LN(3) = 3 Then Txt3 = "وثلاثمائة"
            If LN(3) = 4 Then Txt3 = "وربعمائة"
            If LN(3) = 5 Then Txt3 = "وخمسمائة"
            If LN(3) = 6 Then Txt3 = "وستمائة"
            If LN(3) = 7 Then Txt3 = "وسبعمائة"
            If LN(3) = 8 Then Txt3 = "وثمانمائة"
            If LN(3) = 9 Then Txt3 = "وتسعمائة"
            If LN(2) = 1 Then Txt4 = "وألف"
            If LN(2) = 2 Then Txt4 = "وألفان"
            If LN(2) = 3 Then Txt4 = "وثلاث ألاف"
            If LN(2) = 4 Then Txt4 = "وأربعة الاف"
            If LN(2) = 5 Then Txt4 = "وخمس ألاف"
            If LN(2) = 6 Then Txt4 = "وستة ألاف"
            If LN(2) = 7 Then Txt4 = "وسبعة ألاف"
            If LN(2) = 8 Then Txt4 = "وثمان ألاف"
            If LN(2) = 9 Then Txt4 = "وتسعة ألاف"
            If LN(1) > 1 Then
                If LN(1) = 2 Then Txt5 = "عشرون ألف"
                If LN(1) = 3 Then Txt5 = "ثلاثون ألف"
                If LN(1) = 4 Then Txt5 = "أربعون الف"
                If LN(1) = 5 Then Txt5 = "خمسون ألف"
                If LN(1) = 6 Then Txt5 = "ستون ألف"
                If LN(1) = 7 Then Txt5 = "سبعون ألف"
                If LN(1) = 8 Then Txt5 = "ثمانون ألف"
                If LN(1) = 9 Then Txt5 = "تسعون ألف"
                If LN(2) = 1 Then Txt6 = "واحد و"
                If LN(2) = 2 Then Txt6 = "أثنين و"
                If LN(2) = 3 Then Txt6 = "ثلاثةو"
                If LN(2) = 4 Then Txt6 = "أربعةو"
                If LN(2) = 5 Then Txt6 = "خمسةو"
                If LN(2) = 6 Then Txt6 = "ستةو"
                If LN(2) = 7 Then Txt6 = "سبعةو"
                If LN(2) = 8 Then Txt6 = "ثمانيةو"
                If LN(2) = 9 Then Txt6 = "تسعةو"
            Else
                If LN(2) = 0 And LN(1) = 1 Then Txt6 = "عشرة ألاف"
                If LN(2) = 1 And LN(1) = 1 Then Txt6 = "أحدى عشر ألف"
                If LN(2) = 2 And LN(1) = 1 Then Txt6 = "أثنتى عشر ألف"
                If LN(2) = 3 And LN(1) = 1 Then Txt6 = "ثلاثة عشر ألف"
                If LN(2) = 4 And LN(1) = 1 Then Txt6 = "أربعة عشر الف"
                If LN(2) = 5 And LN(1) = 1 Then Txt6 = "خمسة عشر ألف"
                If LN(2) = 6 And LN(1) = 1 Then Txt6 = "ستة عشر الف"
                If LN(2) = 7 And LN(1) = 1 Then Txt6 = "سبعة عشر الف"
                If LN(2) = 8 And LN(1) = 1 Then Txt6 = "ثمانية عشر الف"
                If LN(2) = 9 And LN(1) = 1 Then Txt6 = "تسعة عشر ألف"
            End If
        End If
        On Error Resume Next


        'Frection
        N2 = Len(SE)
        Dim LN1(N2)
        For I = 1 To N2
            LN1(I) = Mid(SE, I, 1)
        Next
        If LN1.Length = 3 Then
            If LN1(2) = 0 Then
                If LN1(1) = 2 Then Txt8 = "عشرون"
                If LN1(1) = 3 Then Txt8 = "ثلاثون"
                If LN1(1) = 4 Then Txt8 = "أربعون"
                If LN1(1) = 5 Then Txt8 = "خمسون"
                If LN1(1) = 6 Then Txt8 = "ستون"
                If LN1(1) = 7 Then Txt8 = "سبعون"
                If LN1(1) = 8 Then Txt8 = "ثمانون"
                If LN1(1) = 9 Then Txt8 = "تسعون"
            End If
            If LN1(1) = 1 Then
                If LN1(2) = 0 And LN1(1) = 1 Then Txt8 = "عشرة"
                If LN1(2) = 1 And LN1(1) = 1 Then Txt8 = "أحدى عشر"
                If LN1(2) = 2 And LN1(1) = 1 Then Txt8 = "أثنتى عشر"
                If LN1(2) = 3 And LN1(1) = 1 Then Txt8 = "ثلاثة عشر"
                If LN1(2) = 4 And LN1(1) = 1 Then Txt8 = "أربعة عشر"
                If LN1(2) = 5 And LN1(1) = 1 Then Txt8 = "خمسة عشر"
                If LN1(2) = 6 And LN1(1) = 1 Then Txt8 = "ستة عشر"
                If LN1(2) = 7 And LN1(1) = 1 Then Txt8 = "سبعة عشر"
                If LN1(2) = 8 And LN1(1) = 1 Then Txt8 = "ثمانية عشر"
                If LN1(2) = 9 And LN1(1) = 1 Then Txt8 = "تسعة عشر"
            End If
            If LN1(1) > 1 And LN1(2) <> 0 Then
                If LN1(2) = 1 Then Txt8 = "واحد"
                If LN1(2) = 2 Then Txt8 = "أثنين"
                If LN1(2) = 3 Then Txt8 = "ثلاثة"
                If LN1(2) = 4 Then Txt8 = "أربعة"
                If LN1(2) = 5 Then Txt8 = "خمسة"
                If LN1(2) = 6 Then Txt8 = "ستة"
                If LN1(2) = 7 Then Txt8 = "سبعة"
                If LN1(2) = 8 Then Txt8 = "ثمانية"
                If LN1(2) = 9 Then Txt8 = "تسعة"
                If LN1(1) = 2 Then Txt9 = "وعشرون"
                If LN1(1) = 3 Then Txt9 = "وثلاثون"
                If LN1(1) = 4 Then Txt9 = "وأربعون"
                If LN1(1) = 5 Then Txt9 = "وخمسون"
                If LN1(1) = 6 Then Txt9 = "وستون"
                If LN1(1) = 7 Then Txt9 = "وسبعون"
                If LN1(1) = 8 Then Txt9 = "وثمانون"
                If LN1(1) = 9 Then Txt9 = "وتسعون"
            End If
        End If
        'PRINT RESULTS
        If LN.Length = 2 Then
            If Trim(Txt8) <> "" And Txt1 <> "" Then
                ConvNO = Trim(Txt1 & "دينار و" & Txt8 & " " & Txt9) & " " & "قرش فقط لا غير"
            Else
                If Txt1 <> "" Then
                    ConvNO = Txt1 & " " & "دينار فقط لا غير"
                Else
                    ConvNO = Trim(Txt1 & Txt8 & Txt9) & " " & "قرش فقط لا غير"
                End If
            End If
        End If
        If LN.Length = 3 Then
            If Trim(Txt8) <> "" Then
                ConvNO = Trim(Txt1 & " " & Txt2 & " دينار و" & Txt8 & " " & Txt9) & " " & "قرش فقط لا غير"
            Else
                ConvNO = Trim(Txt1 & " " & Txt2) & " " & "دينار فقط لا غير"
            End If
        End If
        If LN.Length = 4 Then
            If Trim(Txt8) <> "" Then
                ConvNO = Trim(Txt3 & " " & Txt1 & " " & Txt2 & " دينار و" & Txt8 & " " & Txt9) & " " & "قرش فقط لا غير"
            Else
                ConvNO = Trim(Txt3 & " " & Txt1 & " " & Txt2) & " " & "دينار فقط لا غير"
            End If
        End If
        If LN.Length = 5 Then
            If Trim(Txt8) <> "" Then
                ConvNO = Trim(Txt4 & " " & Txt3 & " " & Txt1 & " " & Txt2 & " دينار و" & Txt8 & " " & Txt9) & " " & "قرش فقط لا غير"
            Else
                ConvNO = Trim(Txt4 & " " & Txt3 & " " & Txt1 & " " & Txt2) & " " & "دينار فقط لا غير"
            End If
        End If
        If LN.Length = 6 Then
            If Trim(Txt8) <> "" Then
                ConvNO = Trim(Txt6 & " " & Txt5 & " " & Txt3 & " " & Txt1 & " " & Txt2 & " دينار و" & Txt8 & " " & Txt9) & " " & "قرش فقط لا غير"
            Else
                ConvNO = Trim(Txt6 & " " & Txt5 & " " & Txt3 & " " & Txt1 & " " & Txt2) & " " & "دينار فقط لا غير"
            End If
        End If
    End Sub

End Class
