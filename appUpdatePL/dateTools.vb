Module dateTools


    Function strToDate(strDate As String, strTime As String) As String

        Dim strDD As String
        Dim strMM As String
        Dim strYY As String
        Dim strDate2 As String



        ' trh_Date = Format(Month((.Range("H" & countRow + 1).Value)), "00") 
        '& "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00")
        '& "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)

        'If Len(strDate) = 17 Then

        strMM = Trim(Microsoft.VisualBasic.Left(strDate, 2))  'Month(strDate) '
        strDD = Trim(Microsoft.VisualBasic.Right((Microsoft.VisualBasic.Left(strDate, 5)), 2)) 'Microsoft.VisualBasic.DateAndTime.Day(strDate) '
        strYY = Trim(Microsoft.VisualBasic.Right(strDate, 4))
        If CInt(strYY) > 2562 Then
            strYY = Str(Int(Year(Now)) - 543)
        Else
            strYY = Str(Int(Year(Now)) - 543)
        End If

        'If CInt(strMM) > 12 Then
        '    strDate2 = strDD & "-" & strMM & "-" & Trim(strYY) & " " & strTime
        'Else

        'End If
        strDate2 = strMM & "-" & strDD & "-" & Trim(strYY) & " " & strTime
        '   Dim strChkDate As DateTime = strDate2
        'Else
        '    strMM = (Microsoft.VisualBasic.Left(strDate, 2))
        '    strDD = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(strDate, 5), 2)
        '    strYY = Year(strDate)
        '    If CInt(strYY) > 2562 Then
        '        strYY = Str(Int(Year(Now)) - 543)
        '    Else
        '        strYY = Str(Int(Year(Now)) - 543)
        '    End If
        '    strTime = Microsoft.VisualBasic.Right(strDate, 8)
        '    strDate2 = strDD & "-" & strMM & "-" & strYY & " " & strTime

        'End If

        Return strDate2


    End Function

    Function strToDate2(strDate As String) As String
        Dim strDD As String
        Dim strMM As String
        Dim strYY As String
        Dim strDate2 As String
        Dim strTime As String


        ' trh_Date = Format(Month((.Range("H" & countRow + 1).Value)), "00") 
        '& "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00")
        '& "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)

        'If Len(strDate) = 17 Then

        strMM = Month(strDate) 'Trim(Microsoft.VisualBasic.Right((Microsoft.VisualBasic.Left(strDate, 5)), 2)) '
        strDD = Microsoft.VisualBasic.DateAndTime.Day(strDate) 'Trim(Microsoft.VisualBasic.Left(strDate, 2)) '
        strYY = Trim(Year(strDate))
        If CInt(strYY) > 2562 Then
            strYY = Str(Int(Year(Now)) - 543)
        Else
            strYY = Str(Int(Year(Now)) - 543)
        End If
        strTime = Microsoft.VisualBasic.Right(strDate, 8)
        strDate2 = strMM & "-" & strDD & "-" & strYY & " " & strTime

        'Else
        '    strMM = (Microsoft.VisualBasic.Left(strDate, 2))
        '    strDD = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(strDate, 5), 2)
        '    strYY = Year(strDate)
        '    If CInt(strYY) > 2562 Then
        '        strYY = Str(Int(Year(Now)) - 543)
        '    Else
        '        strYY = Str(Int(Year(Now)) - 543)
        '    End If
        '    strTime = Microsoft.VisualBasic.Right(strDate, 8)
        '    strDate2 = strDD & "-" & strMM & "-" & strYY & " " & strTime

        'End If

        Return strDate2


    End Function


End Module
