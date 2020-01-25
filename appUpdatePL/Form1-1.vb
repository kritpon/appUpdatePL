Public Class frmUpdate

    Dim chkRUN As Boolean = False
    Dim fileName As String
    Dim fileName2 As String
    Dim fileName3 As String
    Dim docType As String = "E"

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

    Private Sub frmUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'แผนผลิต1-2015
        monthSel = Format(Month(Now), "00")
        yearSel = Year(Now) - 543
        ExcelName = "แผนผลิต" & monthSel & "-" & yearSel & ".xlsm"
        ExcelName2 = "แผนผลิตเล็ก" & monthSel & "-" & yearSel & ".xlsm"
        ExcelName3 = "รายงานติดกระดาษ(" & monthSel & "-" & Mid((yearSel + 543), 3, 2) & ").xlsm"
        DBtools.DBConnection()
        'MsgBox(ExcelName)
        lbDataBase.Text = DBConnString.strConn2
        Format(Month(Now), "00")

        fileName = "\\192.168.1.8\pc\วางแผนผลิต\แผ่นใหญ่\ปี 2016\" & ExcelName        
        lbFileName.Text = fileName
        fileName3 = "\\192.168.1.8\pc\รายงานติดกระดาษ\ปี2016\" & ExcelName3
        lbFileName3.Text = fileName3

        fileName2 = "\\192.168.1.8\pc\วางแผนผลิต\แผ่นเล็ก\ปี 2016\" & ExcelName2
        'fileName = "D:\DEV\0.0 แผนผลิต\แผนผลิต07-2014.xlsm"
        lbFileName2.Text = fileName2
        chkDel = False

    End Sub

    Sub runOK()

        If chkRUN = False Then
            Call delData_E(monthSel, yearSel)
            Call updatePL(fileName, 1)
            Call updatePL(fileName2, 2)

            Call delData_M(monthSel, yearSel)
            Call updatePL2(fileName3, 1)
            chkRUN = False
        End If
        ' MsgBox("--- ดึงข้อมูลเรียบร้อย ---", MsgBoxStyle.Information, "แจ้งเตือน !")

    End Sub
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Call runOK()


    End Sub
    Sub delData_M(ByVal strMonth As String, ByVal strYear As String)

        If chkDel = False Then

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataH "
            txtSQL = txtSQL & "Where Trh_Type='M' "
            txtSQL = txtSQL & "And month(Trh_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(Trh_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataD "
            txtSQL = txtSQL & "Where dtl_Type='M' "
            txtSQL = txtSQL & "And month(dtl_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(dtl_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "ReindexSqlDatabase db2012 "

        End If
        chkDel = True



    End Sub

    Sub delData_E(ByVal strMonth As String, ByVal strYear As String)

        If chkDel = False Then

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataH "
            txtSQL = txtSQL & "Where Trh_Type='E' "
            txtSQL = txtSQL & "And month(Trh_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(Trh_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "Delete "
            txtSQL = txtSQL & "From TranDataD "
            txtSQL = txtSQL & "Where dtl_Type='E' "
            txtSQL = txtSQL & "And month(dtl_Date)='" & strMonth & "' "
            txtSQL = txtSQL & "And year(dtl_Date)='" & strYear & "' "

            DBtools.dbDelDATA(txtSQL, "")

            txtSQL = "ReindexSqlDatabase db2012 "

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

    Function addPL2TrhDB(ByVal docType As String, ByVal docNo As String, ByVal docDate As String, ByVal cusID As String, ByVal docDesc As String) As String

        txtSQL = "Insert into TranDataH (Trh_Type,Trh_No,Trh_Cus,Trh_Date,Trh_Detail)"
        txtSQL = txtSQL & "Values ('" & docType & "','" & docNo & "','" & cusID & "','" & docDate & "','" & docDesc & "')"
        Return txtSQL
        'pBar3.PerformStep()
    End Function
    Function addPL2DtlDB(ByVal docType As String, ByVal docNo As String, ByVal docDate As String, ByVal cusID As String, ByVal dtl_idTrade As String, ByVal dtl_n_trade As String, dtl_sticker As String, ByVal dtl_num As Double, ByVal Dtl_cus_Name As String) As String

        txtSQL = "Insert into TranDataD (Dtl_Type,dtl_No,dtl_Date,dtl_idCus,dtl_idTrade,dtl_n_Trade,dtl_sticker,dtl_num,Dtl_cus_name) "
        txtSQL = txtSQL & "Values ('" & docType & "','" & docNo & "','" & docDate & "','" & cusID & "','" & dtl_idTrade & "','" & dtl_n_trade & "','" & dtl_sticker & "','" & dtl_num & "','" & Dtl_cus_Name & "')"
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

   
    
    Sub updatePL(ByVal filename As String, index0 As Integer)

        Dim fileErr As String
        fileErr = CurDir() & "\report\Err_PC_uplink.xlsx"
        Dim dtl_sticker As String = ""  ' ระบบแผ่นใหญ่ / เล็ก

        Dim trh_Type As String
        Dim trh_No As String
        Dim trh_Cus As String = "110098"
        Dim trh_Date As String
        Dim trh_Detail As String = ""

        Dim dtl_idTrade As String = ""
        Dim dtl_N_Trade As String = ""
        Dim dtl_num As Double = 0
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
        'objExcel.Visible = True   'ไม่ต้องเปิด Excel ขึ้นมา

        'objExcelErr = New Microsoft.Office.Interop.Excel.Application
        'objExcelErr.Visible = True  'ไม่ต้องเปิด Excel ขึ้นมา
        'objExcelErr.Visible = False 'ไม่ต้องเปิด Excel ขึ้นมา


        objExcelWorkBook = objExcel.Workbooks.Open(filename, 0, 1)
        objExcelWorkSheet = objExcelWorkBook.Worksheets("วางแผนผลิต") '47
        objExcelWorkSheet.Activate()


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
            countRow = 4

            If index0 = 1 Then
                dtl_sticker = "BS"
            Else
                dtl_sticker = "SS"
            End If
          

            Do Until trh_No = ""
                With objExcel
                    pBar1.PerformStep()
                    lbIndex1.Text = lbIndex1.Text + 1
                    'If index0 = 1 Then
                    '    pBar1.PerformStep()
                    '    lbIndex1.Text = lbIndex1.Text + 1

                    'ElseIf index0 = 2 Then

                    'End If
                    'pBar3.Value = 1
                    objExcelWorkSheet.Activate()
                    '.Range("B" & countRow + 1).Select()
                    '.Range("G" & countRow + 1).Select()
                    trh_No = .Range("G" & countRow + 1).Value
                    trh_Detail = Mid((.Range("R" & countRow + 1).Value), 1, 50)
                    trh_Date = Format(Month((.Range("H" & countRow + 1).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("H" & countRow + 1).Value)), "00") & "/" & (Year((.Range("H" & countRow + 1).Value)) - 543)
                    dtl_idTrade = (.Range("BM" & countRow + 1).Value)
                    dtl_N_Trade = .Range("K" & countRow + 1).Value
                    dtl_num = (.Range("U" & countRow + 1).Value)
                    dtl_Cus_Name = Mid(.Range("AA" & countRow + 1).Value, 1, 49)

                    lbDocNo.Text = trh_No
                    lbStkName.Text = dtl_N_Trade
                    lbStkNameSA.Text = DBtools.getStkName(dtl_idTrade)
                    lbQty.Text = dtl_num
                    lbSheetType.Text = dtl_sticker

                    '.Range("H" & countRow + 1).Select()

                    'trh_Date = Format((.Range("H" & countRow + 1).Value), "yyyy/MM/dd")
                    'If trh_No = "66514GB" Then
                    '    MsgBox("OK")
                    'End If

                    'trh_Date = con2Date(.Range("H" & countRow + 1).Value)
                    'trh_Date = Format((.Range("H" & countRow + 1).Value), "MM/dd/yyyy")
                    'trh_Date = (Format(DateAdd(DateInterval.Year, -543, .Range("H" & countRow + 1).Value), "MM/dd/yyyy"))

                    'trh_Date = (Format(DateAdd(DateInterval.Year, -543, .Range("H" & countRow + 1).Value), "MM/dd/yyyy"))

                    '.Range("BM" & countRow + 1).Select()

                    If chkStkYes(dtl_idTrade) = True Then

                        If getCheStkPCName(dtl_idTrade) = False Then
                            DBtools.updatePCname(dtl_N_Trade, dtl_idTrade)

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
                        '============ update Master ใหม่ =================
                        If DBtools.getDocNumberD(trh_No, trh_Type, dtl_idTrade) = True Then ' ถ่าให้ค่ามาเป็น True แสดงว่ามีเอกสารและสินค้าตรงกัน

                            'MsgBox("มีข้อมูลอยู่")

                        Else

                            txtSQL = addPL2TrhDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_Cus_Name)
                            DBtools.dbSaveDATA(txtSQL, "")

                            'pBar3.PerformStep()
                            txtSQL = addPL2DtlDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_idTrade, dtl_N_Trade, dtl_sticker, dtl_num, dtl_Cus_Name)
                            DBtools.dbSaveDATA(txtSQL, "")
                            'MsgBox("Add")

                            'pBar3.PerformStep()
                        End If



                    Else

                        'MsgBox("ผิดพลาด")
                        'With objExcelWorkSheetErr


                        '    objExcelWorkSheetErr.Activate()
                        '    'objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
                        '    With objExcelErr

                        '        '.Range("B" & rwErr + 1).Select()
                        '        .Range("B" & rwErr + 1).Value = (trh_Date).ToString
                        '        '.Range("C" & rwErr + 1).Select()
                        '        .Range("C" & rwErr + 1).Value = trh_No
                        '        '.Range("D" & rwErr + 1).Select()
                        '        .Range("D" & rwErr + 1).Value = dtl_N_Trade
                        '        '.Range("E" & rwErr + 1).Select()
                        '        .Range("E" & rwErr + 1).Value = dtl_idTrade

                        '    End With
                        'End With

                        ''objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMinimized
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
                If (pBar1.Value >= 98) Then
                    pBar1.Step = -1
                    pBar1.Refresh()
                ElseIf pBar1.Value <= 3 Then
                    pBar1.Step = 1
                    pBar1.Refresh()
                End If
                'If index0 = 1 Then

                'Else
                '    If (pBar1.Value >= 98) Then
                '        pBar1.Step = -1
                '        pBar1.Refresh()
                '    ElseIf pBar1.Value <= 3 Then
                '        pBar1.Step = 1
                '        pBar1.Refresh()
                '    End If
                'End If
              
               
            Loop
            'Next
        End With

        'MsgBox("row  =" & countRow - 4)
        'objExcel.Workbooks.Close()
        'objExcelErr.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        'objExcelErr = Nothing
        'objExcelWorkBookErr = Nothing
        'objExcelWorkSheetErr = Nothing

        objExcel = Nothing
        objExcelWorkBook = Nothing
        objExcelWorkSheet = Nothing

    End Sub
    Sub updatePL2(ByVal filename As String, index0 As Integer)

        Dim fileErr As String
        fileErr = CurDir() & "\report\Err_PC_uplink.xlsx"
        Dim dtl_sticker As String = ""  ' ระบบแผ่นใหญ่ / เล็ก

        Dim trh_Type As String = "N"
        Dim trh_No As String
        Dim trh_Cus As String = "110098"
        Dim trh_Date As String
        Dim trh_Detail As String = ""

        Dim dtl_idTrade As String = ""
        Dim dtl_N_Trade As String = ""
        Dim dtl_num As Double = 0
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

        'objExcel.Visible = False   'ไม่ต้องเปิด Excel ขึ้นมา
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
            trh_Type = "M"  ' ต้องแก้ไข ให้เป็น Type ใหม่ รายงานการติดกระดาษ

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


            Do Until trh_No = "" Or trh_No = Nothing  'ทำจนกว่า Trh_No=""
                With objExcel
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
                    trh_Date = Format(Month((.Range("AW" & countRow).Value)), "00") & "/" & Format(Microsoft.VisualBasic.Day((.Range("AW" & countRow).Value)), "00") & "/" & (Year((.Range("AW" & countRow).Value)) - 543)
                    If trh_No = "67516CA" Then

                        MsgBox("67516CA=" & trh_Date)

                    End If
                    trh_Detail = Mid((.Range("H" & countRow).Value), 1, 50)  ' ชื่อลูกค้าใน Excel                    

                    dtl_idTrade = getStkCodeByPL(trh_No)
                    dtl_num = (.Range("K" & countRow).Value)
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

                            txtSQL = addPL2TrhDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_Cus_Name)
                            DBtools.dbSaveDATA(txtSQL, "")
                            ' pBar3.PerformStep()
                            txtSQL = addPL2DtlDB(trh_Type, trh_No, trh_Date, trh_Cus, dtl_idTrade, dtl_N_Trade, dtl_sticker, dtl_num, dtl_Cus_Name)
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
        objExcel = Nothing
        objExcelWorkBook = Nothing
        objExcelWorkSheet = Nothing

    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now, "HH:mm:ss")
        If lbTime.Text = txtTime.Text Then

            Call runOK()

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


End Class
