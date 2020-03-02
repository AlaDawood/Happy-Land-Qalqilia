
Module ConvertNoToWord
    Public conv As New PreferenceClass
    Public ConvNO As String

    Public Sub ConvertNoToString(ByVal SourceD As String, ByRef Result As String)
        'convert Total to string
        Dim NO1 = Math.Round(CDbl(Val(SourceD)), 2)
        'متغير دبل واخر انتجر
        Dim NuD As Double = NO1
        Dim NuI As Integer = Math.Truncate(NO1)
        'طرح المتغيرين مع التقريب للحصول على الكسر فقط 
        Dim DS As Double = Math.Round(NuD - NuI, 2)
        'وضع الكسر فى متغير مستقل 
        Dim AF As String = Right(DS, 2)
        'وضع صفر اذا كان الكسر أقل من رقمين
        If AF = ".1" Then
            AF = "10"
        End If
        If AF = ".2" Then
            AF = "20"
        End If
        If AF = ".3" Then
            AF = "30"
        End If
        If AF = ".4" Then
            AF = "40"
        End If
        If (AF = ".5") Then
            AF = "50"
        End If
        If AF = ".6" Then
            AF = "60"
        End If
        If AF = ".7" Then
            AF = "70"
        End If
        If AF = ".8" Then
            AF = "80"
        End If
        If AF = ".9" Then
            AF = "90"
        End If
        conv.ConvertNo(NuI, AF)
        ''''''''''''''''''''''''
        Result = Trim(ConvNO)
    End Sub
End Module
