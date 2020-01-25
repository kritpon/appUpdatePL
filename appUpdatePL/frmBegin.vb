Public Class frmBegin
    Dim trh_Date As String = ""

    Dim trh_No As String = ""
    Dim chkRUN As Boolean = False
    Dim fileName As String
    Dim fileName2 As String
    Dim fileName3 As String
    Dim docType As String = "E"

    Dim chkUpdateTime As Boolean = False
    Dim chkDel As Boolean = False


    Dim monthSel As String = Format(Month(Now), "00")
    'Dim monthSel As String = "02"

    Dim yearSel As String = Year(Now) - 543
    'Dim ExcelName As String = "แผนผลิต" & monthSel & "-" & yearSel & ".xlsm"
    'Dim ExcelName2 As String = "แผนผลิตเล็ก" & monthSel & "-" & yearSel & ".xlsm"
    'Dim ExcelName3 As String = "รายงานติดกระดาษ(" & monthSel & "-" & Mid((yearSel + 543), 3, 2) & ").xlsm"

    Dim ExcelName As String = "แผนผลิต02-" & yearSel & ".xlsm"
    Dim ExcelName2 As String = "แผนผลิตเล็ก02-" & yearSel & ".xlsm"
    Dim ExcelName3 As String = "รายงานติดกระดาษ(02-" & Mid((yearSel + 543), 3, 2) & ").xlsm"


    Private Sub cmdFindFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindFile.Click

        'CurDir() & 
        'openFile01.FileName = fileName
        'openFile01.InitialDirectory = fileName
        'openFile01.ShowDialog()

        'lbFileName.Text = openFile01.FileName

    End Sub
    Sub getFileName()

        monthSel = Format(Month(Now), "00")
        yearSel = Year(Now) - 543
        ExcelName = "แผนผลิต" & monthSel & "-" & yearSel & ".xlsm"
        ExcelName2 = "แผนผลิตเล็ก" & monthSel & "-" & yearSel & ".xlsm"
        ExcelName3 = "รายงานติดกระดาษ(" & monthSel & "-" & Mid((yearSel + 543), 3, 2) & ").xlsm"
        'DBtools.DBConnection()
        'MsgBox(ExcelName)
        lbDataBase.Text = strConn
        Format(Month(Now), "00")

        fileName = "\\192.168.1.4\pc\วางแผนผลิต\แผ่นใหญ่\ปี 2020\" & ExcelName
        lbFileName.Text = fileName
        fileName3 = "\\192.168.1.4\pc\รายงานติดกระดาษ\ปี2020\" & ExcelName3
        lbFileName3.Text = fileName3

        fileName2 = "\\192.168.1.4\pc\วางแผนผลิต\แผ่นเล็ก\ปี 2020\" & ExcelName2
        'fileName = "D:\DEV\0.0 แผนผลิต\แผนผลิต07-2014.xlsm"
        lbFileName2.Text = fileName2
        chkDel = False

    End Sub
    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HeadList()
        'แผนผลิต1-2015
        Call getFileName()


        Me.WindowState = FormWindowState.Maximized
    End Sub
    Sub runUpQAuto()
        Dim frmSetTime As New frmSetTime
        frmSetTime.ShowDialog()

    End Sub
    Sub runOK()

        Call getFileName()
        If chkRUN = False Then

            'Call delData_E(monthSel, yearSel)
            Call updatePL(fileName, 1)

            '========================
            Call runUpQAuto()
            Call updatePL(fileName2, 2)  'เอาแผนผลิตแผ่นเล็กออก เพราะมี Error
            If chkLoadBOM.Checked = True Then
                Call reload()
            End If
            '========================

            'Call delData_M(monthSel, yearSel)
            'Call updatePL2(fileName3, 1)  ' รายงานติดกระดาษ
            chkRUN = False
        End If
        ' MsgBox("--- ดึงข้อมูลเรียบร้อย ---", MsgBoxStyle.Information, "แจ้งเตือน !")

    End Sub

    Sub delData_M(ByVal strMonth As String, ByVal strYear As String)

        If chkDel = False Then

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataH_E "
            txtSQL = txtSQL & "Where Trh_Type='W' "
            txtSQL = txtSQL & "And month(Trh_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(Trh_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataD_E "
            txtSQL = txtSQL & "Where dtl_Type='W' "
            txtSQL = txtSQL & "And month(dtl_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(dtl_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "ReindexSqlDatabase db2012 "


        End If
        chkDel = True



    End Sub
    Sub delDataByDoc_E(ByVal strDocID As String)

        ' If chkDel = False Then
        txtSQL = "Delete "
        txtSQL = txtSQL & "From TranDataH_E "
        txtSQL = txtSQL & "Where Trh_Type='E' "
        txtSQL = txtSQL & "And Trh_No='" & strDocID & "' "
        'txtSQL = txtSQL & "And year(Trh_Date)='" & strYear & "' "

        DBtools.dbDelDATA(txtSQL, "")

        txtSQL = "Delete "
        txtSQL = txtSQL & "From TranDataD_E "
        txtSQL = txtSQL & "Where dtl_Type='E' "
        txtSQL = txtSQL & "And Dtl_No='" & strDocID & "' "
        'txtSQL = txtSQL & "And year(dtl_Date)='" & strYear & "' "

        DBtools.dbDelDATA(txtSQL, "")
        ' txtSQL = "ReindexSqlDatabase db2012 "
        'End If
        'chkDel = True
    End Sub
    Sub delData_E(ByVal strMonth As String, ByVal strYear As String)

        If chkDel = False Then
            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataH_E "
            txtSQL = txtSQL & "Where Trh_Type='E' "
            txtSQL = txtSQL & "And month(Trh_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(Trh_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataD_E "
            txtSQL = txtSQL & "Where dtl_Type='E' "
            txtSQL = txtSQL & "And month(dtl_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(dtl_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")
            ' txtSQL = "ReindexSqlDatabase db2012 "
        End If
        chkDel = True
    End Sub


    Function con2Date(ByVal strDate As String) As Date

        Dim D As String = ""
        Dim M As String = 0
        Dim Y As String
        Dim Date_A As String
        Dim dateAns As Date
        Try
            Date_A = CDate(strDate)
            M = Microsoft.VisualBasic.Left(strDate, 1)
            Do Until IsNumeric(M) = False


                strDate = Microsoft.VisualBasic.Right(strDate, Len(strDate) - 1)
                D = D & M
                M = Microsoft.VisualBasic.Left(strDate, 1)
            Loop

            'D = Microsoft.VisualBasic.Left(Date_A, 1)  ' วันที่ผิด  ตัดมาแค่ตัวเดียว ต้องตัด 2 ตัวในกรณีวันที่มากกว่า 9
            M = Month(Date_A)
            Y = Year(Date_A) ' - 543

            Date_A = (Y & "/" & M & "/" & D)
            dateAns = CDate(Date_A)

            Return CDate(dateAns)

        Catch errprocess As Exception

            ' MessageBox.Show("วันที่ไม่ถูกต้อง " & "-" & Date_A & "-" & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return Now
        End Try

    End Function

    Function addPL2TrhDB(ByVal docType As String, ByVal docNo As String, ByVal docDate As String, ByVal cusID As String, ByVal docDesc As String, TimeCreLim As Double, TrhAmt As Double, TrhDAmt As Double, TrhTime As String, Running As Integer) As String

        txtSQL = "Insert into TranDataH_E (Trh_Type,Trh_No,Trh_KeyType,Trh_Cus,Trh_Date,Trh_Detail,Trh_Cre_Lim,Trh_Amt,Trh_D_Amt,Trh_Time,Trh_RunID)"
        txtSQL = txtSQL & "Values ('" & docType & "','" & docNo & "','" & Microsoft.VisualBasic.Right(docNo, 1) & "','" & cusID & "','"
        txtSQL = txtSQL & docDate & "','" & docDesc & "','" & TimeCreLim & "','"
        txtSQL = txtSQL & TrhAmt & "','" & TrhDAmt & "',' "
        txtSQL = txtSQL & TrhTime & "','" & Running & "' "
        txtSQL = txtSQL & ")"
        Return txtSQL
        'pBar3.PerformStep()
    End Function
    Function addPL2DtlDB(ByVal docType As String, ByVal docNo As String, ByVal docDate As String,
                         ByVal cusID As String, ByVal dtl_idTrade As String, ByVal dtl_n_trade As String,
                         dtl_sticker As String, ByVal dtl_num As Double, dtl_num2 As Double,
                         ByVal Dtl_cus_Name As String,
                         Dtl_Color_A As String, Dtl_Th_A As String, Dtl_Size_A As String, dtl_cutA_Name As String) As String

        txtSQL = "Insert into TranDataD_E (Dtl_Type,dtl_No,dtl_Date,dtl_idCus,dtl_idTrade,dtl_n_Trade,dtl_sticker,dtl_num,dtl_num_2,dtl_Num_3,Dtl_cus_name,Dtl_Color_A,Dtl_Th_A,Dtl_Size_A,dtl_cutA_Name) "
        txtSQL = txtSQL & "Values ('" & docType & "','" & docNo & "','" & docDate & "','" & cusID & "','" & dtl_idTrade & "','" & dtl_n_trade & "','" & dtl_sticker & "','" & dtl_num & "','" & dtl_num2 & "','0','" & Dtl_cus_Name & "','" & Dtl_Color_A & "','" & Dtl_Th_A & "','" & Dtl_Size_A & "','" & dtl_cutA_Name & "')"
        Return txtSQL
        'pBar3.PerformStep()
    End Function

    Function chkStkYes(ByVal stk_Code As String) As Boolean
        Dim Ans As Boolean = False
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet


        txtSQL = "Select * "
        txtSQL = txtSQL & "From BaseMast "
        txtSQL = txtSQL & "Where Stk_Code ='" & stk_Code & "'"

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "StkList")

        If subDS.Tables("StkList").Rows.Count > 0 Then

            Ans = True

        Else

            Ans = False

        End If

        subDS = Nothing
        subDA = Nothing
        Return Ans

    End Function

    Function chkTimeMast(strTimeCode As String) As Boolean

        Dim subDs As New DataSet
        Dim subDa As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TimeMast "
        txtSQL = txtSQL & "Where Time_Stk_Code='" & strTimeCode & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDs, "TimeChk")

        If subDs.Tables("TimeChk").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub updateTime(chkData As Boolean, strStkCode As String, intQty As Integer, t0 As Double)
        Dim t_s1 As Double
        Dim t_s2 As Double
        Dim t_s3 As Double

        'If trh_No = "56919CA" Then

        '    MsgBox("56919CA")

        'End If
        If t0 > 0 Then
            t_s1 = (t0 * 60) / intQty
            t_s2 = t_s1
            t_s3 = t_s1
        Else
            t_s1 = 0
            t_s2 = 0
            t_s3 = 0
        End If

        If chkData = True Then

            txtSQL = "Update TimeMast "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "Time_T_S1='" & t_s1 & "',"
            txtSQL = txtSQL & "Time_T_S2='" & t_s2 & "',"
            txtSQL = txtSQL & "Time_T_S3='" & t_s3 & "' "

            txtSQL = txtSQL & "Where Time_Stk_Code='" & strStkCode & "' "
            DBtools.dbSaveDATA(txtSQL, "")

        Else
            'Dim strStkName As String = getStkName(strStkCode)
            txtSQL = "Insert Into TimeMast "
            txtSQL = txtSQL & "(Time_Stk_Code,Time_T_S1,Time_T_S2,Time_T_S3,Time_T_S4,Time_Chk)"
            txtSQL = txtSQL & "Values('" & strStkCode & "',"
            txtSQL = txtSQL & "'" & t_s1 & "','" & t_s2 & "','" & t_s3 & "',0,0 "
            txtSQL = txtSQL & ")"

            DBtools.dbSaveDATA(txtSQL, "")
        End If

    End Sub
    Function chkTrhWorkPrint(strDocID As String, strDocType As String) As Integer
        Dim subDs As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select Trh_Chk_Print "
        txtSQL = txtSQL & "FRom TranDataH "
        txtSQL = txtSQL & "Where TRh_Type='" & strDocType & "' "
        txtSQL = txtSQL & "And Trh_No='" & strDocID & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDs, "ChkPrint")

        If subDs.Tables("ChkPrint").Rows.Count > 0 Then

            'If subDs.Tables("ChkPrint").Rows(0).Item("Trh_Chk_Print") = 0 Then
            '    Return False  ' ถ้ายังไม่ผลิตก็ส่งค่าเป็น Fales 
            'Else
            Return True
            'End If
        Else
            Return False  '  ถ้ายังไม่มีข้อมูลใบคุมในระบบ ก็ให้ส่ง False
        End If

    End Function


    Sub updatePL(ByVal filename As String, index0 As Integer)

        'Dim fileErr As String
        'fileErr = CurDir() & "\report\Err_PC_uplink.xlsx"
        Dim dtl_sticker As String = ""  ' ระบบแผ่นใหญ่ / เล็ก

        Dim trh_Type As String
        ' Dim trh_No As String
        Dim trh_Cus As String = "110098"

        'Dim trh_date As DateTime
        Dim trh_Detail As String = ""
        Dim trh_Cre_LIm As String = ""  ' CrycleTime เวลาการผลิต รวม (จำนวนแผ่น * เวลาผลิตต่อแผ่น)
        Dim trh_Cost As String = "" ' CrycleTime เวลาการผลิต รวม (จำนวนแผ่น * เวลาผลิตต่อแผ่น)
        Dim trh_Amt As String = ""  ' CrycleTime เวลาการต้ม
        Dim trh_D_Amt As String = ""  ' CrycleTime เวลาการอบ
        Dim trh_Time As String ' เวลาผลิต
        Dim dtl_cutA_Name As String = ""
        Dim dtl_idTrade As String = ""
        Dim dtl_N_Trade As String = ""
        Dim dtl_num As Double = 0
        Dim dtl_Num2 As Double = 0

        Dim Dtl_Color_A As String = ""
        Dim Dtl_Size_A As String = ""
        Dim Dtl_Th_A As String = ""

        Dim dtl_Price As Double = 0
        Dim dtl_Cus_Name As String = ""
        Dim PC_stk_Name As String = ""

        'Dim strDocNo As String = ""
        'Dim myExcel As New Microsoft.Office.Interop.Excel.Application
        'Dim myWorkBook As New Microsoft.Office.Interop.Excel.Workbook
        'Dim myWorkSheet As New Microsoft.Office.Interop.Excel.Worksheet

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        'Dim objExcelErr As Microsoft.Office.Interop.Excel.Application
        'Dim objExcelWorkBookErr As Microsoft.Office.Interop.Excel.Workbook
        'Dim objExcelWorkSheetErr As Microsoft.Office.Interop.Excel.Worksheet

        Dim rwErr As Integer = 4
        Dim countRow As Integer
        'Dim countRow2 As Integer
        Dim rowExcel As Integer = 6 '  เริ่ม รายการบรรทัดที่ 6
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim rwLast As Long = 0

        lbState.Text = "กำลังดึงข้อมูล แผนผลิต !" & filename

        objExcel = New Microsoft.Office.Interop.Excel.Application

        'objExcel.Visible = False   'ไม่ต้องเปิด Excel ขึ้นมา
        objExcel.Visible = True   'ไม่ต้องเปิด Excel ขึ้นมา

        ' objExcelErr = New Microsoft.Office.Interop.Excel.Application
        'objExcelErr.Visible = True  'ไม่ต้องเปิด Excel ขึ้นมา
        'objExcelErr.Visible = False 'ไม่ต้องเปิด Excel ขึ้นมา

        objExcelWorkBook = objExcel.Workbooks.Open(filename, 0, 1)
        objExcelWorkSheet = objExcelWorkBook.Worksheets("วางแผนผลิต") '47
        objExcelWorkSheet.Activate()
        'objExcel.Visible = False
        'objExcelWorkBookErr = objExcelErr.Workbooks.Open(fileErr, 0, 1)
        'objExcelWorkSheetErr = objExcelWorkBookErr.Worksheets("sheet1") '47
        'objExcelWorkSheetErr.Activate()

        rwLast = objExcelWorkSheet.Rows.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible).Row
        'ActiveCell.SpecialCells(xlCellTypeLastCell).Row
        If index0 = 1 Then
            pBar1.Maximum = 100 'rwLast
            pBar1.Minimum = 1
            pBar1.Value = 1
            pBar1.Step = 1
            lbIndex1.Text = 0
            lbCondition.Text = "ดึงข้อมูลแผ่นใหญ่"

        ElseIf index0 = 2 Then
            pBar1.Maximum = 100 'rwLast
            pBar1.Minimum = 1
            pBar1.Value = 1
            pBar1.Step = 1
            lbIndex1.Text = 0
            lbCondition.Text = "ดึงข้อมูลแผ่นเล็ก"
            'Else
            '    pBar3.Maximum = 100
            '    pBar3.Minimum = 1
            '    pBar3.Value = 1
            '    pBar3.Step = 1
        End If

        With objExcelWorkSheet
            'For countRow = 3 To rwLast - 1
            trh_Type = docType   '  E
            trh_No = "-"
            countRow = 3

            If index0 = 1 Then
                dtl_sticker = "BS"
            Else
                dtl_sticker = "SS"
            End If
            Dim runing As Integer = 0
            Dim chkDo As Boolean = True

            updateClockLock(1)

            Do Until trh_No = ""
                chkDo = True
                With objExcel
                    runing = runing + 1
                    Try
                        pBar1.PerformStep()
                        lbIndex1.Text = lbIndex1.Text + 1
                        objExcelWorkSheet.Activate()

                        'If index0 = 1 Then
                        '    pBar1.PerformStep()
                        '    lbIndex1.Text = lbIndex1.Text + 1
                        'ElseIf index0 = 2 Then
                        'End If
                        'pBar3.Value = 1
                        '.Range("B" & countRow + 1).Select()
                        .Range("G" & countRow + 1).Select()
                        trh_No = .Range("G" & countRow + 1).Value
                        '======================================================================================
                        'If trh_No = "12020AB" Then
                        '    MsgBox("12020AB")
                        'End If
                        If chkDocNo.Checked = True Then
                            If trh_No = txtDocNo.Text Then
                                chkDo = True
                            Else
                                chkDo = False
                            End If
                        End If
                        If chkDo = True Then
                            If chkTrhWorkPrint(trh_No, "M") = False Then
                                'If trh_No = "34219EB" Then
                                '    MsgBox("34219EB")
                                'End If
                                'trh_Cre_LIm = .Range("Q" & countRow + 1).Value
                                'trh_Cre_LIm = .Range("Q" & countRow + 1).Value
                                'If dtl_sticker = "BS" Then
                                '    'trh_Date = DateAdd(DateInterval.Year, -543, .Range("DG" & countRow + 1).Value)
                                '    '  ข้อมูลวันที่มีปัญหา 
                                '    trh_Date = strToDate(trh_Date, trh_Time)
                                'Else
                                'End If
                                'trh_Date = Format(DateAdd(DateInterval.Year, -543, (.Range("H" & countRow + 1).Value)), "yyyy/MM/dd")
                                delDataByDoc_E(trh_No)  ' ลบข้อมูลเอกสาร ใน TranDataH_E และ TranDataD_E ทั้งสองอัน
                                .Range("U" & countRow + 1).Select()
                                dtl_num = (.Range("U" & countRow + 1).Value)
                                If dtl_num = 0 Then

                                Else

                                    If IsDBNull(.Range("AE" & countRow + 1).Value) Then  ' AE  เวลาต้ม
                                        trh_Amt = 0
                                    Else
                                        trh_Amt = .Range("AE" & countRow + 1).Value
                                    End If

                                    If IsDBNull(.Range("AF" & countRow + 1).Value) Then   ' AF  เวลาอบ
                                        trh_D_Amt = 0
                                    Else
                                        trh_D_Amt = .Range("AF" & countRow + 1).Value
                                    End If

                                    If IsDBNull(.Range("M" & countRow + 1).Value) Or Trim(.Range("M" & countRow + 1).Value) = "#N/A:00" Or IsDate((.Range("M" & countRow + 1).Value)) Then
                                        trh_Time = Format(Now, "HH:mm:ss")
                                    Else
                                        trh_Time = (.Range("M" & countRow + 1).Text).ToString & ":00" '((.Range("M" & countRow + 1).Value).ToString) 'เวลา เวลาผลิตตามแผน
                                    End If 'Format(Now, "HH:mm:ss")

                                    Dim str1 As String = ""
                                    Dim str2 As String = ""
                                    ' Dim strNameBlock As String
                                    Dim i0 As Integer = 0
                                    Dim iBake As Integer = 0

                                    dtl_idTrade = (.Range("BM" & countRow + 1).Value)
                                    dtl_N_Trade = .Range("K" & countRow + 1).Value

                                    If IsDBNull(dtl_idTrade) Then

                                        dtl_idTrade = ""

                                    End If
                                    updatePCbaseMast(dtl_idTrade, dtl_N_Trade)

                                    trh_Detail = (Mid((.Range("R" & countRow + 1).Value), 1, 50))
                                    trh_Date = Format(Month((.Range("H" & countRow + 1).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00") & "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)
                                    trh_Date = trh_Date '& " " & trh_Time

                                    .Range("J" & countRow + 1).Select()  '  Block กระจก
                                    If (.Range("J" & countRow + 1).Value).ToString = "" Then
                                        dtl_cutA_Name = ""
                                    Else
                                        dtl_cutA_Name = (.Range("J" & countRow + 1).Text)
                                    End If

                                    If IsDBNull(.Range("Q" & countRow + 1).Value) Then  '  Q เวลาผลิต
                                        trh_Cre_LIm = 0
                                    Else
                                        trh_Cre_LIm = .Range("Q" & countRow + 1).Value
                                    End If


                                    .Range("AK" & countRow + 1).Select()
                                    If (.Range("AK" & countRow + 1).Value).ToString = "" Then
                                        dtl_Num2 = 0
                                    Else
                                        dtl_Num2 = (.Range("AK" & countRow + 1).Value)
                                    End If

                                    dtl_Cus_Name = Mid(.Range("AA" & countRow + 1).Value, 1, 49)

                                    .Range("S" & countRow + 1).Select()
                                    If (.Range("S" & countRow + 1).Value).ToString = "" Then
                                        Dtl_Color_A = ""
                                    Else
                                        Dtl_Color_A = (.Range("S" & countRow + 1).Text)
                                    End If

                                    .Range("T" & countRow + 1).Select()
                                    If (.Range("T" & countRow + 1).Value).ToString = "" Then
                                        Dtl_Th_A = ""
                                    Else
                                        Dtl_Th_A = (.Range("T" & countRow + 1).Text)
                                    End If

                                    .Range("Y" & countRow + 1).Select()
                                    If (.Range("Y" & countRow + 1).Value).ToString = "" Then
                                        Dtl_Size_A = ""
                                    Else
                                        Dtl_Size_A = (.Range("Y" & countRow + 1).Text)
                                    End If

                                    lbDocNo.Text = trh_No
                                    lbStkName.Text = dtl_N_Trade
                                    lbStkNameSA.Text = DBtools.getStkName(dtl_idTrade)
                                    lbQty.Text = dtl_num
                                    lbWeight.Text = dtl_Num2
                                    lbSheetType.Text = dtl_sticker

                                    .Range("BM" & countRow + 1).Select()
                                    DBtools.updatePCname(dtl_N_Trade, dtl_idTrade)

                                    If chkStkYes(dtl_idTrade) = True Then
                                        If getCheStkPCName(dtl_idTrade) = False Then
                                            Call updateStkName2Naw(dtl_idTrade)
                                        End If
                                        '============ update Master ใหม่ =================
                                        If getCheStkCodeN(dtl_idTrade) = False Then
                                            Call updateStkCodeNaw(dtl_idTrade)
                                            'pBar3.PerformStep()
                                        End If
                                        If getCheStkFindWord(dtl_idTrade) = False Then
                                            Call updateStkFindWord(dtl_idTrade)
                                            'pBar3.PerformStep()
                                        End If
                                        '=================  update CryCle Time  =================
                                        Dim chkTime As Boolean = chkTimeMast(dtl_idTrade) = True
                                        If dtl_sticker = "SS" Then
                                        Else
                                            For n = Len(dtl_N_Trade) To 1 Step -1
                                                i0 = i0 + 1
                                                str1 = Mid(dtl_N_Trade, n, 1)
                                                str2 = Trim(str1) + str2  ' ตัดตัวอักษรที่ละตัว  ใช้หาคำปิดท้าย เช่น (สำนักงานใหญ่)
                                                iBake = iBake + 1

                                                If iBake = 4 Then
                                                    Exit For
                                                End If
                                            Next
                                            'Dim xTime As Integer

                                            If str2 = "(3T)" Then
                                                'MsgBox("3t" & " = " & dtl_N_Trade)
                                                'trh_Cre_LIm = trh_Cre_LIm / 2
                                                'trh_Cre_LIm = trh_Cre_LIm
                                                updateTime(chkTime, dtl_idTrade, dtl_num, trh_Cre_LIm * 2)
                                            Else
                                                '    trh_Cre_LIm = trh_Cre_LIm / 1
                                                updateTime(chkTime, dtl_idTrade, dtl_num, trh_Cre_LIm)
                                            End If
                                        End If   '  ตรวจว่าเป็น แผ่น เล็ก หรือไม่

                                        '============ update Master ใหม่ =================
                                        If DBtools.chkDocTranDataH(trh_No, "M", "") = True Then

                                        Else
                                            txtSQL = addPL2TrhDB(trh_Type, trh_No, strToDate(trh_Date, trh_Time), trh_Cus, dtl_Cus_Name, trh_Cre_LIm, trh_Amt, trh_D_Amt, trh_Time, runing)
                                            DBtools.dbSaveDATA(txtSQL, "")
                                            '()
                                        End If

                                        If DBtools.chkDocTranDataD(trh_No, "M", dtl_idTrade) = True Then ' ถ้าให้ค่ามาเป็น True แสดงว่ามีเอกสารและสินค้าตรงกัน

                                            'MsgBox("มีข้อมูลอยู่")
                                        Else
                                            'pBar3.PerformStep()
                                            txtSQL = addPL2DtlDB(trh_Type, trh_No, strToDate(trh_Date, trh_Time), trh_Cus, dtl_idTrade, dtl_N_Trade, dtl_sticker, dtl_num, dtl_Num2, dtl_Cus_Name, Dtl_Color_A, Dtl_Th_A, Dtl_Size_A, dtl_cutA_Name)
                                            DBtools.dbSaveDATA(txtSQL, "")
                                        End If
                                    Else

                                        dtl_idTrade = ""
                                        txtSQL = addPL2TrhDB(trh_Type, trh_No, strToDate(trh_Date, trh_Time), trh_Cus, dtl_Cus_Name, trh_Cre_LIm, trh_Amt, trh_D_Amt, trh_Time, runing)
                                        DBtools.dbSaveDATA(txtSQL, "")

                                        'pBar3.PerformStep()
                                        txtSQL = addPL2DtlDB(trh_Type, trh_No, strToDate(trh_Date, trh_Time), trh_Cus, dtl_idTrade, dtl_N_Trade, dtl_sticker, dtl_num, dtl_Num2, dtl_Cus_Name, Dtl_Color_A, Dtl_Th_A, Dtl_Size_A, dtl_cutA_Name)
                                        DBtools.dbSaveDATA(txtSQL, "")
                                        rwErr = rwErr + 1
                                    End If

                                End If
                                objExcelWorkSheet.Activate()
                                'dtl_Price = (.Range("BM" & countRow + 1).Value)
                                'MsgBox(.Range("N" & countRow + 1).Value.ToString)
                                'If MsgBox(trh_No & "==" & trh_Date & "=" & trh_Detail, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                                '    Exit Do
                                'End If
                            End If   '////////////////////////  จบ if  ในการเช็คข้อมูลซ้ำ  /////////////////////////////
                        End If
                        '======================================================================================

                        '======================================================================================
                        ' จบ 
                        '======================================================================================
                    Catch errprocess As Exception
                        MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try

                End With
                'If countRow > 500 Then
                countRow = countRow + 1 ' + 400
                'Else
                '    countRow = countRow + 1 + 530
                'End If
                trh_No = .Range("G" & countRow + 1).Value
                If (pBar1.Value >= 98) Then
                    pBar1.Step = -1
                    pBar1.Refresh()
                ElseIf pBar1.Value <= 3 Then
                    pBar1.Step = 1
                    pBar1.Refresh()
                End If
            Loop
            'Next
            updateClockLock(0)
        End With
        'objExcelWorkBook.Close(False)

        objExcelWorkBook.Close(SaveChanges:=0)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcelWorkBook)
        objExcelWorkBook = Nothing
        objExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)
        objExcel = Nothing


        'MsgBox("row  =" & countRow - 4)
        'objExcel.Workbooks.Close()
        'objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        'objExcelErr = Nothing
        'objExcelWorkBookErr = Nothing
        'objExcelWorkSheetErr = Nothing

        'objExcelWorkSheet = Nothing
        'objExcelWorkBook = Nothing
        'objExcel = Nothing



    End Sub
    Sub updatePCbaseMast(strCode As String, strName As String)

        txtSQL = "Insert Into BasePCMast(Stk_Code,Stk_PC_Name,Stk_Name) "
        txtSQL = txtSQL & "Values('" & strCode & "','" & strName & "','')"
        DBtools.dbSaveSQLsrv(txtSQL, "")

    End Sub
    Sub updateCrycleTime(ByVal filename As String)

        Dim fileErr As String
        fileErr = CurDir() & "\report\Err_PC_uplink.xlsx"
        Dim dtl_sticker As String = ""  ' ระบบแผ่นใหญ่ / เล็ก

        Dim trh_Type As String
        Dim trh_No As String
        Dim trh_Cus As String = "110098"
        Dim trh_Date As String = ""
        'Dim trh_date As DateTime
        Dim trh_Detail As String = ""
        Dim trh_Cre_LIm As String = ""  ' CrycleTime เวลาการผลิต รวม (จำนวนแผ่น * เวลาผลิตต่อแผ่น)
        Dim trh_Amt As String = ""  ' CrycleTime เวลาการต้ม
        Dim trh_D_Amt As String = ""  ' CrycleTime เวลาการอบ
        Dim trh_Time As String ' เวลาผลิต

        Dim dtl_idTrade As String = ""
        Dim dtl_N_Trade As String = ""
        Dim dtl_num As Double = 0
        Dim dtl_Num2 As Double = 0

        Dim Dtl_Color_A As String = ""
        Dim Dtl_Size_A As String = ""
        Dim Dtl_Th_A As String = ""

        Dim dtl_Price As Double = 0
        Dim dtl_Cus_Name As String = ""
        Dim PC_stk_Name As String = ""

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim rwErr As Integer = 4
        Dim countRow As Integer

        Dim rowExcel As Integer = 6 '  เริ่ม รายการบรรทัดที่ 6
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim rwLast As Long = 0

        lbState.Text = "กำลังดึงข้อมูล แผนผลิต !" & filename
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True   'ไม่ต้องเปิด Excel ขึ้นมา

        objExcelWorkBook = objExcel.Workbooks.Open(filename, 0, 1)
        objExcelWorkSheet = objExcelWorkBook.Worksheets("วางแผนผลิต") '47
        objExcelWorkSheet.Activate()
        rwLast = objExcelWorkSheet.Rows.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeVisible).Row

        pBar1.Maximum = 100 'rwLast
        pBar1.Minimum = 1
        pBar1.Value = 1
        pBar1.Step = 1
        lbIndex1.Text = 0
        lbCondition.Text = "ดึงข้อมูล Crycle Time แผ่นใหญ่"

        With objExcelWorkSheet

            trh_Type = docType   '  E
            trh_No = "-"
            countRow = 3
            dtl_sticker = "BS"
            Dim runing As Integer = 0

            Do Until trh_No = ""
                With objExcel
                    runing = runing + 1
                    pBar1.PerformStep()
                    lbIndex1.Text = lbIndex1.Text + 1
                    objExcelWorkSheet.Activate()
                    .Range("G" & countRow + 1).Select()
                    trh_No = .Range("G" & countRow + 1).Value
                    If IsDBNull(.Range("Q" & countRow + 1).Value) Then  '  Q เวลาผลิต
                        trh_Cre_LIm = 0
                    Else
                        trh_Cre_LIm = .Range("Q" & countRow + 1).Value
                    End If

                    If IsDBNull(.Range("AE" & countRow + 1).Value) Then  ' AE  เวลาต้ม
                        trh_Amt = 0
                    Else
                        trh_Amt = .Range("AE" & countRow + 1).Value

                    End If

                    If IsDBNull(.Range("AF" & countRow + 1).Value) Then   ' AF  เวลาอบ
                        trh_D_Amt = 0
                    Else
                        trh_D_Amt = .Range("AF" & countRow + 1).Value
                    End If

                    If IsDBNull(.Range("M" & countRow + 1).Value) Or Trim(.Range("M" & countRow + 1).Value) = "#N/A:00" Or IsDate((.Range("M" & countRow + 1).Value)) Then
                        trh_Time = Format(Now, "HH:mm:ss")
                    Else
                        trh_Time = (.Range("M" & countRow + 1).Text).ToString & ":00" '((.Range("M" & countRow + 1).Value).ToString) 'เวลา เวลาผลิตตามแผน
                    End If

                    trh_Detail = (Mid((.Range("R" & countRow + 1).Value), 1, 50))
                    trh_Date = Format(Month((.Range("H" & countRow + 1).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00") & "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)
                    dtl_idTrade = (.Range("BM" & countRow + 1).Value)

                    dtl_N_Trade = .Range("K" & countRow + 1).Value
                    'If trh_No = "50818JA" Then
                    '    MsgBox("50818JA")
                    'End If
                    Dim str1 As String = ""
                    Dim str2 As String = ""
                    Dim strNameBlock As String = ""
                    Dim i0 As Integer = 0
                    Dim iBake As Integer = 0
                    For n = Len(dtl_N_Trade) To 1 Step -1
                        i0 = i0 + 1
                        'strArTitleID = ""
                        strNameBlock = ""

                        str1 = Mid(dtl_N_Trade, n, 1)
                        str2 = Trim(str1) + str2  ' ตัดตัวอักษรที่ละตัว  ใช้หาคำปิดท้าย เช่น (สำนักงานใหญ่)
                        iBake = iBake + 1

                        If iBake = 4 Then
                            Exit For
                        End If
                    Next
                    Dim xTime As Integer = 0

                    If str2 = "(3T)" Then
                        'MsgBox("3t" & " = " & dtl_N_Trade)
                        trh_Cre_LIm = 2 * trh_Cre_LIm
                    Else
                        trh_Cre_LIm = 1 * trh_Cre_LIm
                    End If


                    .Range("U" & countRow + 1).Select()
                    dtl_num = (.Range("U" & countRow + 1).Value)

                    .Range("AK" & countRow + 1).Select()
                    If (.Range("AK" & countRow + 1).Value).ToString = "" Then
                        dtl_Num2 = 0
                    Else
                        dtl_Num2 = (.Range("AK" & countRow + 1).Value)
                    End If

                    dtl_Cus_Name = Mid(.Range("AA" & countRow + 1).Value, 1, 49)

                    .Range("S" & countRow + 1).Select()
                    If (.Range("S" & countRow + 1).Value).ToString = "" Then
                        Dtl_Color_A = ""
                    Else
                        Dtl_Color_A = (.Range("S" & countRow + 1).Text)
                    End If

                    .Range("T" & countRow + 1).Select()
                    If (.Range("T" & countRow + 1).Value).ToString = "" Then
                        Dtl_Th_A = ""
                    Else
                        Dtl_Th_A = (.Range("T" & countRow + 1).Text)
                    End If

                    .Range("Y" & countRow + 1).Select()
                    If (.Range("Y" & countRow + 1).Value).ToString = "" Then
                        Dtl_Size_A = ""
                    Else
                        Dtl_Size_A = (.Range("Y" & countRow + 1).Text)
                    End If

                    lbDocNo.Text = trh_No
                    lbStkName.Text = dtl_N_Trade
                    lbStkNameSA.Text = DBtools.getStkName(dtl_idTrade)
                    lbQty.Text = dtl_num
                    lbWeight.Text = dtl_Num2
                    lbSheetType.Text = dtl_sticker
                    .Range("BM" & countRow + 1).Select()

                    '=================  update CryCle Time  =================
                    Dim chkTime As Boolean = chkTimeMast(dtl_idTrade) = True
                    'If trh_No = "46118JB" Then
                    '    MsgBox("46118JB")

                    'End If
                    updateTime(chkTime, dtl_idTrade, dtl_num, trh_Cre_LIm)

                    objExcelWorkSheet.Activate()

                End With
                countRow = countRow + 1
                trh_No = .Range("G" & countRow + 1).Value
                If (pBar1.Value >= 98) Then
                    pBar1.Step = -1
                    pBar1.Refresh()
                ElseIf pBar1.Value <= 3 Then
                    pBar1.Step = 1
                    pBar1.Refresh()
                End If
            Loop

        End With

        objExcelWorkBook.Close(SaveChanges:=0)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcelWorkBook)
        objExcelWorkBook = Nothing
        objExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)
        objExcel = Nothing



    End Sub

    Sub updatePL2(ByVal filename As String, index0 As Integer)

        Dim fileErr As String
        fileErr = CurDir() & "\report\Err_PC_uplink.xlsx"
        Dim dtl_sticker As String = ""  ' ระบบแผ่นใหญ่ / เล็ก

        Dim trh_Type As String = "W"
        Dim trh_No As String
        Dim trh_Cus As String = "110098"
        Dim trh_Date As String
        Dim trh_Detail As String = ""
        Dim trh_Cre_LIm As String = ""  ' CrycleTime เวลาการผลิต รวม (จำนวนแผ่น * เวลาผลิตต่อแผ่น)
        Dim trh_Amt As String = ""  ' CrycleTime เวลาการต้ม
        Dim trh_D_Amt As String = ""  ' CrycleTime เวลาการอบ
        Dim trh_time As String = ""

        Dim Dtl_Color_A As String = ""
        Dim Dtl_Size_A As String = ""
        Dim Dtl_Th_A As String = ""

        Dim dtl_idTrade As String = ""
        Dim dtl_N_Trade As String = ""
        Dim dtl_num As Double = 0
        Dim dtl_Num2 As Double = 0
        Dim dtl_Price As Double = 0
        Dim dtl_Cus_Name As String = ""
        Dim PC_stk_Name As String = ""



        'Dim strDocNo As String = ""
        'Dim myExcel As New Microsoft.Office.Interop.Excel.Application
        'Dim myWorkBook As New Microsoft.Office.Interop.Excel.Workbook
        'Dim myWorkSheet As New Microsoft.Office.Interop.Excel.Worksheet

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        'Dim objExcelErr As Microsoft.Office.Interop.Excel.Application
        'Dim objExcelWorkBookErr As Microsoft.Office.Interop.Excel.Workbook
        'Dim objExcelWorkSheetErr As Microsoft.Office.Interop.Excel.Worksheet

        Dim rwErr As Integer = 4
        Dim countRow As Integer
        'Dim countRow2 As Integer
        Dim rowExcel As Integer = 4 '  เริ่ม รายการบรรทัดที่ 6
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim rwLast As Long = 0



        objExcel = New Microsoft.Office.Interop.Excel.Application

        objExcel.Visible = False   'ไม่ต้องเปิด Excel ขึ้นมา
        'objExcel.Visible = True   'ไม่ต้องเปิด Excel ขึ้นมา

        'objExcelErr = New Microsoft.Office.Interop.Excel.Application
        'objExcelErr.Visible = True  'ไม่ต้องเปิด Excel ขึ้นมา
        'objExcelErr.Visible = False 'ไม่ต้องเปิด Excel ขึ้นมา


        objExcelWorkBook = objExcel.Workbooks.Open(fileName3, 0, 1)
        objExcelWorkSheet = objExcelWorkBook.Worksheets("รายงานติดกระดาษ(แผ่นใหญ่)") '47
        objExcelWorkSheet.Activate()

        lbState.Text = "กำลังดึงข้อมูล รายงานติดกระดาษ !" & filename


        'objExcelWorkBookErr = objExcelErr.Workbooks.Open(fileErr, 0, 1)
        'objExcelWorkSheetErr = objExcelWorkBookErr.Worksheets("sheet1") '47
        'objExcelWorkSheetErr.Activate()
        lbState.Text = "กำลังดึงข้อมูล แผนผลิต !" & filename
        rwLast = objExcelWorkSheet.Rows.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row

        pBar1.Maximum = 100
        pBar1.Minimum = 1
        pBar1.Value = 1
        pBar1.Step = 1
        lbIndex1.Text = 0
        lbCondition.Text = "ดึงข้อมูลรายงานติดกระดาษ"

        With objExcelWorkSheet
            'For countRow = 3 To rwLast - 1
            trh_Type = "W"  ' ต้องแก้ไข ให้เป็น Type ใหม่ รายงานการติดกระดาษ

            trh_No = "-"
            countRow = 4

            'If index0 = 1 Then
            '    dtl_sticker = "BS"
            'Else
            '    dtl_sticker = "SS"
            'End If
            If index0 = 1 Then
                dtl_sticker = "BS"
            Else
                dtl_sticker = "SS"
            End If
            Dim running As Integer = 0

            Do Until trh_No = "" Or trh_No = Nothing  'ทำจนกว่า Trh_No=""
                With objExcel
                    running = running + 1

                    pBar1.PerformStep()
                    lbIndex1.Text = lbIndex1.Text + 1
                    objExcelWorkSheet.Activate()

                    '.Range("B" & countRow).Select()
                    '
                    trh_No = .Range("A" & countRow).Value
                    If trh_No = "67516CA" Then

                        MsgBox("67516CA")

                    End If
                    dtl_N_Trade = .Range("B" & countRow).Value

                    If trh_No = Nothing Then
                        Exit Do
                    End If
                    'Format(Month((.Range("H" & countRow + 1).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00") & "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)
                    Try
                        trh_Date = Format(Month((.Range("AW" & countRow).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("AW" & countRow).Value)), "00") & "/" & (Year((.Range("AW" & countRow).Value)) - 543)

                    Catch ex As Exception
                        trh_Date = ""
                    End Try

                    If IsDBNull(.Range("Q" & countRow + 1).Value) Then
                        trh_Cre_LIm = 0
                    Else
                        trh_Cre_LIm = .Range("Q" & countRow + 1).Value
                    End If
                    If IsDBNull(.Range("AE" & countRow + 1).Value) Then
                        trh_Amt = 0
                    Else
                        trh_Amt = .Range("AE" & countRow + 1).Value * 60 'เวลา ต้ม 
                    End If

                    If IsDBNull(.Range("AF" & countRow + 1).Value) Then
                        trh_D_Amt = 0
                    Else
                        trh_D_Amt = .Range("AF" & countRow + 1).Value * 60  'เวลา อบ
                    End If
                    If IsDBNull(.Range("M" & countRow + 1).Value) Or Trim(.Range("M" & countRow + 1).Value) = "#N/A:00" Then
                        trh_time = Format(Now, "HH:mm:ss")
                    Else
                        trh_time = .Range("M" & countRow + 1).Value.ToString 'เวลา เวลาผลิตตามแผน
                    End If


                    .Range("S" & countRow + 1).Select()
                    If (.Range("S" & countRow + 1).Value).ToString = "" Then
                        Dtl_Color_A = ""
                    Else
                        Dtl_Color_A = (.Range("S" & countRow + 1).Text)
                    End If

                    .Range("T" & countRow + 1).Select()
                    If (.Range("T" & countRow + 1).Value).ToString = "" Then
                        Dtl_Th_A = ""
                    Else
                        Dtl_Th_A = (.Range("T" & countRow + 1).Text)
                    End If

                    .Range("Y" & countRow + 1).Select()
                    If (.Range("Y" & countRow + 1).Value).ToString = "" Then
                        Dtl_Size_A = ""
                    Else
                        Dtl_Size_A = (.Range("Y" & countRow + 1).Text)
                    End If
                    'If trh_No = "67516CA" Then

                    '    MsgBox("67516CA=" & trh_Date)

                    'End If
                    trh_Detail = Mid((.Range("H" & countRow).Value), 1, 50)  ' ชื่อลูกค้าใน Excel                    

                    dtl_idTrade = getStkCodeByPL(trh_No)
                    dtl_num = (.Range("K" & countRow).Value)
                    dtl_Num2 = 0
                    dtl_Cus_Name = Mid(.Range("H" & countRow).Value, 1, 50)

                    lbDocNo.Text = trh_No
                    lbStkName.Text = dtl_N_Trade
                    lbStkNameSA.Text = DBtools.getStkName(dtl_idTrade)
                    lbQty.Text = dtl_num




                    If chkStkYes(dtl_idTrade) = True Then

                        '============ update Master ใหม่ =================
                        If DBtools.getDocNumberD(trh_No, trh_Type, dtl_idTrade) = True Then ' ถ่าให้ค่ามาเป็น True แสดงว่ามีเอกสารและสินค้าตรงกัน

                            'MsgBox("มีข้อมูลอยู่")

                        Else

                            txtSQL = addPL2TrhDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_Cus_Name, trh_Cre_LIm, trh_Amt, trh_D_Amt, trh_time, running)
                            DBtools.dbSaveDATA(txtSQL, "")
                            ' pBar3.PerformStep()
                            txtSQL = addPL2DtlDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_idTrade, dtl_N_Trade, dtl_sticker, dtl_num, dtl_Num2, dtl_Cus_Name, Dtl_Color_A, Dtl_Th_A, Dtl_Size_A, "")
                            DBtools.dbSaveDATA(txtSQL, "")
                            'MsgBox("Add")
                            'pBar3.PerformStep()

                        End If

                    Else

                        'MsgBox("ผิดพลาด")
                        'objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMinimized
                        rwErr = rwErr + 1
                    End If
                    objExcelWorkSheet.Activate()
                    'dtl_Price = (.Range("BM" & countRow + 1).Value)
                    'MsgBox(.Range("N" & countRow + 1).Value.ToString)

                    'If MsgBox(trh_No & "==" & trh_Date & "=" & trh_Detail, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    '    Exit Do
                    'End If

                End With
                countRow = countRow + 1
                trh_No = .Range("G" & countRow + 1).Value
                If index0 = 1 Then
                    If (pBar1.Value >= 98) Then
                        pBar1.Step = -1
                        pBar1.Refresh()
                    ElseIf pBar1.Value <= 3 Then
                        pBar1.Step = 1
                        pBar1.Refresh()
                    End If
                Else
                    If (pBar1.Value >= 98) Then
                        pBar1.Step = -1
                        pBar1.Refresh()
                    ElseIf pBar1.Value <= 3 Then
                        pBar1.Step = 1
                        pBar1.Refresh()
                    End If
                End If
            Loop
            'Next
        End With
        lbState.Text = "ดึงข้อมูลเรียบร้อย !"
        'MsgBox("row  =" & countRow - 4)

        'objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        'objExcelErr = Nothing
        'objExcelWorkBookErr = Nothing
        'objExcelWorkSheetErr = Nothing
        'objExcel.Workbooks.Close()
        ' objExcel.Quit()
        objExcelWorkBook.Close(SaveChanges:=0)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcelWorkBook)
        objExcelWorkBook = Nothing
        objExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)
        objExcel = Nothing

    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click

        Dim strDateTimeEnd As String
        Dim strDateTimeStar As String = Now.ToString

        If chkSelFile.Checked = True Then
            Call updatePL(fileName3, 1)
        Else
            Call runOK()
            'Call reload()
        End If

        Dim anydata() As String
        Dim lvi As ListViewItem
        strDateTimeEnd = Now.ToString
        anydata = New String() {strDateTimeStar, strDateTimeEnd}
        lvi = New ListViewItem(anydata)
        lsvUploadTime.Items.Add(lvi)

    End Sub
    Sub HeadList()

        ' lsvPlan_M.Columns.Add("item", 50, HorizontalAlignment.Right) '0
        'lsvPlan_M.Columns.Add("วันที่วางแผน", 80, HorizontalAlignment.Center) '1
        lsvUploadTime.Columns.Add("วัน-เวลาเริ่ม", 200, HorizontalAlignment.Center) '0
        lsvUploadTime.Columns.Add("วัน-เวลาเสร็จ", 200, HorizontalAlignment.Center) '0
        lsvUploadTime.View = View.Details
        lsvUploadTime.GridLines = True
        'chkTB = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim strdateTimeStart As String = Now.ToString

        lbTime.Text = Format(Now, "HH:mm:ss")
        If lbTime.Text = txtTime01.Text Then
            Call runOK()
            txtEnd01.Text = Now
            chkUpdateTime = True
        ElseIf lbTime.Text = txtTime02.Text Then
            Call runOK()
            txtEnd02.Text = Now
            chkUpdateTime = True
        ElseIf lbTime.Text = txtTime03.Text Then
            Call runOK()

            txtEnd03.Text = Now
            chkUpdateTime = True
        ElseIf lbTime.Text = txtTime04.Text Then
            Call runOK()

            txtEnd04.Text = Now
            chkUpdateTime = True
        ElseIf lbTime.Text = txtTime05.Text Then
            Call runOK()

            txtEnd05.Text = Now
            chkUpdateTime = True
        ElseIf lbTime.Text = txtTime06.Text Then
            Call runOK()
            txtEnd06.Text = Now
            chkUpdateTime = True
        End If
        '===============  RM  ============
        'lbTimer.Text = Format(Now, "HH:mm:ss")

        If lbTime.Text = txtTimeRM01.Text Then
            Call reload()
            lbTime01.Text = Now
        ElseIf lbTime.Text = txtTimeRM02.Text Then
            Call reload()

            lbTime02.Text = Now
        End If
        Dim strDateTime As String
        Dim anydata() As String
        Dim lvi As ListViewItem

        If chkUpdateTime = True Then
            strDateTime = Now.ToString
            anydata = New String() {strdateTimeStart, strDateTime}
            lvi = New ListViewItem(anydata)
            lsvUploadTime.Items.Add(lvi)
            chkUpdateTime = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim subDa As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From BaseMast "
        txtSQL = txtSQL & "Where stk_prod='01' "
        txtSQL = txtSQL & "Order by Stk_Name_1 "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "StkList")
        pBar1.Maximum = subDS.Tables("StkList").Rows.Count - 1
        pBar1.Minimum = 1
        pBar1.Value = 1
        pBar1.Step = 1

        For i = 0 To subDS.Tables("StkList").Rows.Count - 1

            Call DBtools.updateStkFindWord(subDS.Tables("StkList").Rows(i).Item("Stk_Code"))
            Call DBtools.updateStkCodeNaw(subDS.Tables("StkList").Rows(i).Item("Stk_Code"))
            pBar1.PerformStep()

        Next

    End Sub

    Function getStkCodeByPL(docNo As String) As String
        Dim ANS As String = ""
        Dim subDa0 As New SqlClient.SqlDataAdapter
        Dim subDS0 As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataD "
        txtSQL = txtSQL & "Where Dtl_Type='E' "
        txtSQL = txtSQL & "And Dtl_No='" & docNo & "' "


        subDa0 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa0.Fill(subDS0, "master0")

        If subDS0.Tables("master0").Rows.Count > 0 Then
            ANS = subDS0.Tables("master0").Rows(0).Item("Dtl_idTrade")

        Else
            ' ANS = subDS0.Tables("master0").Rows(0).Item("Dtl_idTrade")

            ANS = "" 'subDS0.Tables("master0").Rows(0).Item("Dtl_idTrade")
            'MsgBox("ไม่พบข้อมูล")
        End If


        Return ANS


    End Function

    Private Sub lbTime_Click(sender As Object, e As EventArgs) Handles lbTime.Click

    End Sub

    Private Sub cmbSelFile3_Click(sender As Object, e As EventArgs) Handles cmbSelFile3.Click
        'CurDir() & 

        openFile.FileName = fileName
        openFile.InitialDirectory = fileName
        openFile.ShowDialog()

        lbFileName3.Text = openFile.FileName
        fileName3 = lbFileName3.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmbUpCrycleTime.Click
        ' Call getFileName()
        updateCrycleTime(fileName)

    End Sub


    '==================================  up สูตรการผลิต ==================================================
    Sub getFileName_RM()
        ' lbFileName.text
        '\\192.168.1.8\pc\Link Data\2018  
        'Link Data 07-2018.xlsm
        monthSel = Format(Month(Now), "00")
        yearSel = Year(Now) - 543
        'ExcelName = "แผนผลิต" & monthSel & "-" & yearSel & ".xlsm"
        ExcelName = "Link Data " & monthSel & "-" & yearSel & ".xlsm"
        ' ExcelName = "Link Data 01-2019.xlsm"
        Format(Month(Now), "00")
        'Data Link
        fileName = lbFileName.Text '"\\192.168.1.8\pc\Link Data\2019\" & ExcelName
        lbFileName.Text = fileName

    End Sub

    Sub openExcel_RM()

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim rwLast As Integer = 0

        Dim rowExcel As Integer = 9 '  àÃÔèÁ ÃÒÂ¡ÒÃºÃÃ·Ñ´·Õè 9
        Dim bufferExcel As Integer = 0 ' ãªéã¹¡Ã³Õ¢Öé¹ sheet ãËÁè áÅÐ ãËé buffer ¤èÒµèÍ¨Ò¡ sheet à´ÔÁ à¾×èÍ¹ÑºµèÍ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0
        Dim runing As Integer = 0

        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(fileName, 0, 1)
        objExcelWorkSheet = objExcelWorkBook.Worksheets("Data Link") '47
        objExcelWorkSheet.Activate()
        objExcel.Visible = False
        rwLast = objExcelWorkSheet.Rows.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row
        pBar1.Maximum = rwLast
        pBar1.Minimum = 1
        pBar1.Value = 1
        pBar1.Step = 1

        With objExcelWorkSheet

            objExcelWorkSheet.Activate()
            Dim stkCode As String = ""
            Dim strPCCode As String = ""
            Dim TrhNO As String = "-"
            Dim stkName As String = ""
            Dim strDate As DateTime
            Dim countRow As Integer = 4
            Dim strRMcode As String = ""
            Dim dblQtyW As Double = 0
            Dim strRMgrpID As String = ""
            Dim rmName1 As String = ""
            Dim dblRM_QtyW0 As Double = 0
            Dim dblRM_QtyW As Double = 0
            Dim dblQty As Double = 0
            lbCounter.Text = 0
            'Dim chkNo1 As String = ""
            'Dim chkNo2 As String = ""

            Do Until TrhNO = ""
                runing = runing + 1

                stkCode = .Range("B" & countRow).Value
                TrhNO = .Range("C" & countRow).Value
                stkName = .Range("E" & countRow).Value
                If IsNumeric(.Range("G" & countRow).Value) Then
                    dblQty = 0 : dblQty = .Range("G" & countRow).Value
                Else
                    dblQty = 0
                    MsgBox("พบข้อมูลผิดพลาดใน Excel ;=" & "G" & countRow)
                End If

                If dblQty = 0 Then

                Else
                    lbCounter.Text = (lbCounter.Text + 1).ToString("#,##0")
                    lbTime.Text = Format(Now, "HH:mm:ss")
                    '===========  Clear Data เก่า  ================
                    txtSQL = "Update   BOMmastD "
                    txtSQL = txtSQL & "Set BOM_RM_Values=0 "
                    txtSQL = txtSQL & "Where BOM_No='" & TrhNO & "' "
                    DBtools.dbSaveSQLsrv(txtSQL, "")
                    '===========  Clear Data เก่า  ================

                    Call updatePCname(stkCode, stkName) '  update pc_name in BaseMast
                    strPCCode = getPCcode(stkCode)
                    'strDate = Format(.Range("D" & countRow + 1).Value, "MM-dd-yyyy")
                    strDate = Format(Microsoft.VisualBasic.Day((.Range("D" & countRow).Value)), "00") & "/" & Format(Month((.Range("D" & countRow).Value)), "00") & "/" & (Year((.Range("D" & countRow).Value)) - 543)
                    '=============  น้ำหนักเผื่อ 8 มิล ======================
                    strRMcode = "" : strRMcode = "04004"
                    dblQtyW = 0 : dblQtyW = .Range("BQ" & countRow).Value 'น้ำหนักเผื่อ
                    'dblQty = 0 : dblQty = .Range("BQ" & countRow).Value

                    If dblQtyW > 0 Then
                        insertRM2BOM(stkCode, strRMcode, dblQtyW, strPCCode) ' ได้น้ำหนักต่อแผ่น
                    End If
                    '=============  น้ำหนักเผื่อ มากกว่า 40 แผ่น ======================
                    strRMcode = "" : strRMcode = "04005"
                    dblQtyW = 0 : dblQtyW = .Range("BR" & countRow).Value 'น้ำหนักเผื่อ
                    'dblQty = 0 : dblQty = .Range("BQ" & countRow).Value

                    If dblQtyW > 0 Then
                        insertRM2BOM(stkCode, strRMcode, dblQtyW, strPCCode) ' ได้น้ำหนักต่อแผ่น
                    End If
                    '=============  น้ำหนักเผื่อ 80 มิล ======================
                    strRMcode = "" : strRMcode = "04006"
                    dblQtyW = 0 : dblQtyW = .Range("BT" & countRow).Value 'น้ำหนักเผื่อ
                    'dblQty = 0 : dblQty = .Range("BQ" & countRow).Value

                    If dblQtyW > 0 Then
                        insertRM2BOM(stkCode, strRMcode, dblQtyW, strPCCode) ' ได้น้ำหนักต่อแผ่น
                    End If

                    '=============  น้ำหนักรวม/แผ่น ======================
                    strRMcode = "" : strRMcode = "04003"
                    dblQtyW = 0 : dblQtyW = .Range("AF" & countRow).Value

                    If dblQtyW > 0 Then
                        insertRM2BOM(stkCode, strRMcode, dblQtyW / dblQty, strPCCode) ' ได้น้ำหนักต่อแผ่น
                    End If
                    lbQty.Text = dblQty

                    '===========================================
                    '   อ่านข้อมูลจาก Excel และ ใส่ลงใน Table  BOMtranH และ  BOMtranD  
                    '===========  insert BOMtranH =============

                    Call insertBOMtranH(strDate, TrhNO, stkCode, dblQty, stkName)
                    Call insertBOMtranD(strDate, TrhNO, strRMcode, dblQtyW)

                    '=============  น้ำหนักต่อแผ่น ======================
                    strRMcode = "" : strRMcode = "04001"
                    dblQtyW = 0 : dblQtyW = .Range("F" & countRow).Value 'น้ำหนักต่อแผ่น
                    'dblQty = 0 : dblQty = .Range("BQ" & countRow).Value
                    lbPageWeight.Text = Format(dblQtyW, "#,##0.00")
                    If dblQtyW > 0 Then
                        insertRM2BOM(stkCode, strRMcode, dblQtyW, strPCCode) ' ได้น้ำหนักต่อแผ่น
                        Call insertBOMtranD(strDate, TrhNO, strRMcode, dblQtyW)
                    End If

                    '============== Color 1 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AG" & countRow).Select()
                    rmName1 = (.Range("AG" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AH" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName1.Text = rmName1
                    lbValues1.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If

                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '===========================================
                    '============== Color 2 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AI" & countRow).Select()
                    rmName1 = (.Range("AI" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AJ" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName2.Text = rmName1
                    lbValues2.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '===========================================
                    '============== Color 3 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AK" & countRow).Select()
                    rmName1 = (.Range("AK" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AL" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName3.Text = rmName1
                    lbValues3.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '===========================================
                    '============== Color 4 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AM" & countRow).Select()
                    rmName1 = (.Range("AM" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AN" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName4.Text = rmName1
                    lbValues4.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '===========================================
                    '============== Color 5 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AO" & countRow).Select()
                    rmName1 = (.Range("AO" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AP" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName5.Text = rmName1
                    lbValues5.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If

                    End If
                    '===========================================
                    '============== Color 6 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AQ" & countRow).Select()
                    rmName1 = (.Range("AQ" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AR" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName6.Text = rmName1
                    lbValues6.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== Color 7 ====================
                    strRMgrpID = "02"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AS" & countRow).Select()
                    rmName1 = (.Range("AS" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AT" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbColorName7.Text = rmName1
                    lbValues7.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If

                    '===============    จบส่วนของสี ==================================================================

                    '============== เคมี 1 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AU" & countRow).Select()
                    rmName1 = Trim(.Range("AU3").Value)
                    dblRM_QtyW0 = (.Range("AU" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname1.Text = rmName1
                    lbRMvalue1.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 2 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AV" & countRow).Select()
                    rmName1 = Trim(.Range("AV3").Value)
                    dblRM_QtyW0 = (.Range("AV" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname2.Text = rmName1
                    lbRMvalue2.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 3 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AW" & countRow).Select()
                    rmName1 = Trim(.Range("AW3").Value)
                    dblRM_QtyW0 = (.Range("AW" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname3.Text = rmName1
                    lbRMvalue3.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 4 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AX" & countRow).Select()
                    rmName1 = Trim(.Range("AX3").Value)
                    dblRM_QtyW0 = (.Range("AX" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname4.Text = rmName1
                    lbRMvalue4.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 5 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AY" & countRow).Select()
                    rmName1 = Trim(.Range("AY3").Value)
                    dblRM_QtyW0 = (.Range("AY" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname5.Text = rmName1
                    lbRMvalue5.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 6 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AZ" & countRow).Select()
                    rmName1 = Trim(.Range("AZ3").Value)
                    dblRM_QtyW0 = (.Range("AZ" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname6.Text = rmName1
                    lbRMvalue6.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 7 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BA" & countRow).Select()
                    rmName1 = Trim(.Range("BA3").Value)
                    dblRM_QtyW0 = (.Range("BA" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname7.Text = rmName1
                    lbRMvalue7.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 8 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BB" & countRow).Select()
                    rmName1 = Trim(.Range("BB3").Value)
                    dblRM_QtyW0 = (.Range("BB" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname8.Text = rmName1
                    lbRMvalue8.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 9 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BC" & countRow).Select()
                    rmName1 = Trim(.Range("BC3").Value)
                    dblRM_QtyW0 = (.Range("BC" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname9.Text = rmName1
                    lbRMvalue9.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 10 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BD" & countRow).Select()
                    rmName1 = Trim(.Range("BD3").Value)
                    dblRM_QtyW0 = (.Range("BD" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname10.Text = rmName1
                    lbRMvalue10.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 11 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BE" & countRow).Select()
                    rmName1 = Trim(.Range("BE3").Value)
                    dblRM_QtyW0 = (.Range("BE" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname11.Text = rmName1
                    lbRMvalue11.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 12 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BF" & countRow).Select()
                    rmName1 = Trim(.Range("BF3").Value)
                    dblRM_QtyW0 = (.Range("BF" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname12.Text = rmName1
                    lbRMvalue12.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 13 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BG" & countRow).Select()
                    rmName1 = Trim(.Range("BG3").Value)
                    dblRM_QtyW0 = (.Range("BG" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname13.Text = rmName1
                    lbRMvalue13.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== เคมี 14 ====================
                    strRMgrpID = "01"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BH" & countRow).Select()
                    rmName1 = Trim(.Range("BH3").Value)
                    dblRM_QtyW0 = (.Range("BH" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQtyW
                    lbRMname14.Text = rmName1
                    lbRMvalue14.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== ผ้ากรอง ====================
                    strRMgrpID = "06"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BI" & countRow).Select()
                    rmName1 = (.Range("BI" & countRow).Value)
                    'dblRM_QtyW0 =
                    dblRM_QtyW = 1 '(.Range("AJ" & countRow).Value) / dblQtyW
                    dblRM_QtyW0 = 1
                    lbRM00.Text = rmName1
                    'lbValues2.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        If chkNameRMmast(rmName1) = False Then
                            strRMcode = insertRM(strRMgrpID, rmName1)
                        End If
                        If dblRM_QtyW > 0 Then
                            strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '====================== เวลาต้ม =====================
                    strRMgrpID = "05"
                    strRMcode = "05001"  '  เวลาต้ม ระบุตรงๆ ได้เลย
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("Q" & countRow).Select()
                    dblRM_QtyW = (.Range("Q" & countRow).Value)

                    'dblRM_QtyW = (.Range("AE" & countRow).Value)
                    'dblRM_QtyW0 = (.Range("Q" & countRow).Value)
                    'lbTank.Text = rmName1
                    'strRMcode = getRMcode(rmName1)
                    Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                    '============== ขนาดถังผสม ====================
                    strRMgrpID = "08"
                    strRMcode = ""
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("AD" & countRow).Select()
                    rmName1 = (.Range("AD" & countRow).Value)
                    'dblRM_QtyW = (.Range("AE" & countRow).Value)
                    dblRM_QtyW0 = (.Range("AE" & countRow).Value)
                    lbTank.Text = rmName1
                    'lbValues2.Text = dblRM_QtyW
                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 

                        'insertRM2BOM(stkCode, strRMcode, dblRM_QtyW) 

                        strRMcode = getRMcode(rmName1)
                        Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)

                        'If chkNameRMmast(rmName1) = False Then
                        '    ' strRMcode = insertRM(strRMgrpID, rmName1)
                        'End If
                        'If dblRM_QtyW > 0 Then

                        '    ' ไม่เก็บข้อมูลการใช้ถังใน BOM เพราะคำนวนตามปริมาณน้ำหนักผลิต
                        'End If
                    End If
                    '===========================================
                    '============== น้ำยา 10 ====================
                    strRMgrpID = "07"
                    strRMcode = "07001"
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BV" & countRow).Select()
                    rmName1 = Trim(.Range("BV3").Value)
                    dblRM_QtyW0 = (.Range("BV" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQty
                    'lbMMA10.Text = rmName1
                    lbMMA10.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        'If chkNameRMmast(rmName1) = False Then
                        '    strRMcode = insertRM(strRMgrpID, rmName1)
                        'End If
                        If dblRM_QtyW > 0 Then
                            'strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== น้ำยา 22 ====================
                    strRMgrpID = "07"
                    strRMcode = "07002"
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BW" & countRow).Select()
                    rmName1 = Trim(.Range("BW3").Value)
                    dblRM_QtyW0 = (.Range("BW" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQty
                    ' lbRMname14.Text = rmName1
                    lbMMA22.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then
                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        'If chkNameRMmast(rmName1) = False Then
                        '    strRMcode = insertRM(strRMgrpID, rmName1)
                        'End If
                        If dblRM_QtyW > 0 Then
                            'strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '============== น้ำยา 60 ====================
                    strRMgrpID = "07"
                    strRMcode = "07003"
                    rmName1 = ""
                    dblRM_QtyW = 0
                    dblRM_QtyW0 = 0
                    .Range("BX" & countRow).Select()
                    rmName1 = Trim(.Range("BX3").Value)
                    dblRM_QtyW0 = (.Range("BX" & countRow).Value)
                    dblRM_QtyW = dblRM_QtyW0 / dblQty
                    'lbRMname14.Text = rmName1
                    lbMMA60.Text = dblRM_QtyW

                    If rmName1 = "0:00:00" Then

                    Else
                        '  เช็คว่าชื่อนี้มีในฐานข้อมูลหรือยัง ถ้ายัง insert 
                        'If chkNameRMmast(rmName1) = False Then
                        '    strRMcode = insertRM(strRMgrpID, rmName1)
                        'End If
                        If dblRM_QtyW > 0 Then
                            'strRMcode = getRMcode(rmName1)
                            insertRM2BOM(stkCode, strRMcode, dblRM_QtyW, strPCCode)
                            Call insertBOMtranD(strDate, TrhNO, strRMcode, dblRM_QtyW0)
                        End If
                    End If
                    '=================================
                    '=================================

                    pBar1.Value = runing
                    lbPbar.Text = rwLast - runing

                    lbName.Text = stkName
                    lbCode.Text = stkCode
                    lbDocNo.Text = TrhNO
                    lbDate01.Text = strDate
                    lbQtyW.Text = dblQtyW
                    pBar1.PerformStep()
                    Me.Refresh()
                    .Range("B" & countRow).Select()
                    .Range("E" & countRow).Select()
                    '==========================================
                End If

                countRow = countRow + 1
            Loop
        End With

        objExcelWorkBook.Close(SaveChanges:=0)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcelWorkBook)
        objExcelWorkBook = Nothing
        objExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)
        objExcel = Nothing
    End Sub

    Function chkNameRMmast(strRMname As String)
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        txtSQL = "Select * "
        txtSQL = txtSQL & "From BOM_RMmast "
        txtSQL = txtSQL & "Where BOM_Dtl_Name = '" & strRMname & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")
        If subDS.Tables("master").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function chkRMinBOM(strStkCode As String, strRMcode As String) As Boolean
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From BOMmast "
        txtSQL = txtSQL & "Where BOM_RM_Code='" & strRMcode & "' "
        txtSQL = txtSQL & "And BOM_Stk_Code='" & strStkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")

        If subDS.Tables("master").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub insertRM2BOM(StkCode As String, RmCode As String, dblValues As Double, strPCcode As String)

        If chkRMinBOM(StkCode, RmCode) = False Then

            txtSQL = "Insert into BOMmast "
            txtSQL = txtSQL & "Values('" & StkCode & "','" & RmCode & "',"
            txtSQL = txtSQL & "'" & dblValues & "',"
            txtSQL = txtSQL & "'" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "', "
            txtSQL = txtSQL & "'" & strPCcode & "')"

            DBtools.dbSaveSQLsrv(txtSQL, "")
        Else
            If IsNumeric(dblValues) = True Then


                txtSQL = "Update BOMmast "
                txtSQL = txtSQL & "set BOM_RM_Values='" & dblValues & "' "

                txtSQL = txtSQL & "Where BOM_Stk_Code='" & StkCode & "' "
                txtSQL = txtSQL & "And BOM_RM_Code='" & RmCode & "' "
                DBtools.dbSaveSQLsrv(txtSQL, "")
            End If
        End If

    End Sub

    Function chkBOM_Dno(bom_no As String, rm_code As String) As Boolean
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From BOMmastD "
        txtSQL = txtSQL & "Where BOM_No='" & bom_no & "' "
        txtSQL = txtSQL & "And BOM_Rm_Code='" & rm_code & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")

        If subDS.Tables("master").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Sub insertBOMtranD(bom_date As String, bom_no As String, rm_code As String, rm_values As Double)

        If chkBOM_Dno(bom_no, rm_code) = False Then
            txtSQL = "Insert into BOMmastD "
            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'" & bom_no & "',"
            txtSQL = txtSQL & "'" & rm_code & "','" & rm_values & "',"
            txtSQL = txtSQL & "'" & Year(Now) - 543 & "/" & Month(Now) & "/" & Microsoft.VisualBasic.Day(Now) & "',"
            txtSQL = txtSQL & "'" & Year(bom_date) & "/" & Month(bom_date) & "/" & Microsoft.VisualBasic.Day(bom_date) & "', "
            txtSQL = txtSQL & "'0',"
            txtSQL = txtSQL & "'" & Year(bom_date) & "/" & Month(bom_date) & "/" & Microsoft.VisualBasic.Day(bom_date) & "' "
            txtSQL = txtSQL & ")"
        Else
            txtSQL = "Update BOMmastD "
            txtSQL = txtSQL & "set "
            txtSQL = txtSQL & "BOM_rm_Values='" & rm_values & "',"
            txtSQL = txtSQL & "BOM_Update='" & Year(Now) - 543 & "/" & Month(Now) & "/" & Microsoft.VisualBasic.Day(Now) & "', "
            txtSQL = txtSQL & "BOM_Date='" & Year(bom_date) & "/" & Month(bom_date) & "/" & Microsoft.VisualBasic.Day(bom_date) & "' "

            txtSQL = txtSQL & "Where BOM_No='" & bom_no & "' "
            txtSQL = txtSQL & "And BOM_RM_Code='" & rm_code & "' "
        End If


        DBtools.dbSaveSQLsrv(txtSQL, "")

    End Sub

    Function insertRM(strGrpCode As String, strRMname As String) As String
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select max(BOM_Dtl_SE)as SEmax "
        txtSQL = txtSQL & "From BOM_RMmast "
        txtSQL = txtSQL & "Where BOM_Grp_ID='" & strGrpCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "max")

        Dim SEmax As Integer = 0
        If IsDBNull(subDS.Tables("max").Rows(0).Item("SEmax")) Then
            SEmax = 1
        Else

            SEmax = subDS.Tables("max").Rows(0).Item("SEmax") + 1
        End If
        Dim strDtl_ID As String = Format(SEmax, "0##")
        Dim strRM_Code As String = strGrpCode & strDtl_ID
        Dim strUnit As String = ""
        If strGrpCode = "02" Then
            strUnit = "%"
        Else

        End If
        txtSQL = "Insert Into BOM_RMmast "
        txtSQL = txtSQL & "Values("
        txtSQL = txtSQL & "'" & strGrpCode & "',"
        txtSQL = txtSQL & "'" & strDtl_ID & "',"
        txtSQL = txtSQL & "'" & strRM_Code & "',"
        txtSQL = txtSQL & "'" & SEmax & "',"
        txtSQL = txtSQL & "'" & strRMname & "',"
        txtSQL = txtSQL & "'" & strUnit & "',"
        txtSQL = txtSQL & "'" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "' "
        txtSQL = txtSQL & ")"
        DBtools.dbSaveSQLsrv(txtSQL, "")
        Return strRM_Code
    End Function


    Function getRMcode(rmName As String) As String

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim ans As String = ""

        If rmName = "" Then
            ans = ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From BOM_RMmast "
            txtSQL = txtSQL & "Where BOM_Dtl_Name Like '%" & rmName & "%' "
            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "master")
            ans = subDS.Tables("master").Rows(0).Item("RM_Code")
        End If

        Return ans

    End Function


    Function getPCcode(strStkCode As String) As String
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim strPCcode As String = ""
        txtSQL = "Select * "
        txtSQL = txtSQL & "From BaseMast "
        txtSQL = txtSQL & "Where Stk_Code='" & strStkCode & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")
        If subDS.Tables("master").Rows.Count > 0 Then
            If IsDBNull(subDS.Tables("master").Rows(0).Item("Stk_Code_PC")) Then
                strPCcode = Trim(subDS.Tables("master").Rows(0).Item("color_code") + subDS.Tables("master").Rows(0).Item("th_code") + subDS.Tables("master").Rows(0).Item("Size_Code"))
            Else
                strPCcode = subDS.Tables("master").Rows(0).Item("Stk_Code_PC")
            End If
        Else
            strPCcode = ""
        End If


        Return strPCcode
    End Function


    Sub insertBOMtranH(bom_date As String, bom_no As String, stk_code As String, bom_qty As Double, PC_Name As String)
        ', bom_tank As Integer, bom_tank_qty As Double,
        'bom_Tank_Qty_W As Double, bom_Tank_Qty_W2 As Double, bom_Tank_Qty_W3 As Double
        If chkBOMno(bom_no) = False Then
            txtSQL = "Insert into BOMmastH (BOM_Date,BOM_No,BOM_Stk_Code,BOM_Qty,BOM_Update,BOM_PC_Name)"
            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'" & Year(bom_date) & "/" & Month(bom_date) & "/" & Microsoft.VisualBasic.Day(bom_date) & "','" & bom_no & "',"
            txtSQL = txtSQL & "'" & stk_code & "','" & bom_qty & "',"
            txtSQL = txtSQL & "'" & Year(Now) - 543 & "/" & Month(Now) & "/" & Microsoft.VisualBasic.Day(Now) & "',"
            txtSQL = txtSQL & "'" & PC_Name & "' "
            txtSQL = txtSQL & ")"
        Else
            txtSQL = "Update BOMmastH "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "BOM_Stk_Code='" & stk_code & "',"
            txtSQL = txtSQL & "BOM_PC_Name='" & PC_Name & "',"
            txtSQL = txtSQL & "BOM_Qty='" & bom_qty & "',"
            txtSQL = txtSQL & "BOM_Update='" & Year(Now) - 543 & "/" & Month(Now) & "/" & Microsoft.VisualBasic.Day(Now) & "',"
            txtSQL = txtSQL & "BOM_Date='" & Year(bom_date) & "/" & Month(bom_date) & "/" & Microsoft.VisualBasic.Day(bom_date) & "' "

            txtSQL = txtSQL & "Where BOM_No='" & bom_no & "' "

        End If

        DBtools.dbSaveSQLsrv(txtSQL, "")

        'txtSQL = txtSQL & "'" & bom_tank & "','" & bom_tank_qty & "',"
        'txtSQL = txtSQL & "'" & bom_Tank_Qty_W & "','" & bom_Tank_Qty_W2 & "',"
        'txtSQL = txtSQL & "'" & bom_Tank_Qty_W3 & "'"

    End Sub


    Function chkBOMno(bom_no As String) As Boolean
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From BOMmastH "
        txtSQL = txtSQL & "Where BOM_No='" & bom_no & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")

        If subDS.Tables("master").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Sub reload()

        getFileName_RM()
        openExcel_RM()

    End Sub
    Private Sub cmbFindBOM_Click(sender As Object, e As EventArgs)
        Call reload()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim frmSetQTime As New frmSetTime
        frmSetQTime.ShowDialog()


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmbUpBOM_Click(sender As Object, e As EventArgs) Handles cmbUpBOM.Click
        Call reload()
    End Sub
End Class
