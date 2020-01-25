Public Class frmSetTime
    Dim chkDateSL1 As Boolean = False
    Dim chkLoad As Boolean = False
    Dim chkData As Boolean = False
    Dim intNum As Integer = 0
    Sub showData(strDocNo As String)

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        Dim anydata() As String
        Dim lvi As ListViewItem
        Dim iCount As Integer
        Dim strDocdate As String
        ' Dim strDocNo As String
        Dim strStkCode As String
        Dim strStkName As String
        Dim strCrycleTime As Double
        Dim strQty As Integer
        Dim strWeight As Double
        Dim strTrhKeyType As String
        Dim dblTotalQty As Double = CDbl(lbQty_M.Text)
        Dim dblTotalWeight As Double = CDbl(lbWeight_M.Text)
        Dim dblTotalTime As Double = CDbl(lbTotalTimeM.Text)

        txtSQL = "Select Trh_Runid,Trh_No,Trh_KeyType,trh_date,Dtl_Runnum,"
        txtSQL = txtSQL & "Dtl_idTrade,Dtl_n_Trade,Trh_Cre_Lim,Dtl_Num,Dtl_Num_2 "

        txtSQL = txtSQL & "From TranDataH_PM "
        txtSQL = txtSQL & "Left Join TranDataD_PM "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type "
        txtSQL = txtSQL & "And Trh_no=Dtl_No "



        txtSQL = txtSQL & "Where Trh_Detail='" & strDocNo & "' "
        txtSQL = txtSQL & "And Trh_Chk_Print='0' "

        txtSQL = txtSQL & "Order by TranDataH_PM.Trh_Runid "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataList")



        lbTotalTimeM.Text = 0
        lbHH_M.Text = 0
        lbQty_M.Text = 0
        lbWeight_M.Text = 0
        lbCrycleTime_M.Text = 0

        lsvPlan_M.Items.Clear()
        For i = 0 To subDS.Tables("dataList").Rows.Count - 1
            With subDS.Tables("dataList").Rows(i)

                iCount = CInt(.Item("Trh_RunID").ToString)
                strDocNo = .Item("Trh_No").ToString

                strTrhKeyType = .Item("Trh_KeyType")
                strDocdate = .Item("Trh_Date").ToString
                strStkCode = .Item("Dtl_idTrade").ToString
                strStkName = .Item("Dtl_N_Trade").ToString
                strCrycleTime = CDbl(.Item("Trh_Cre_Lim").ToString)
                If IsDBNull(.Item("Dtl_Num")) Then
                    strQty = 0
                    strWeight = 0
                Else
                    strQty = CInt(.Item("Dtl_Num"))
                    strWeight = CDbl(.Item("Dtl_Num_2").ToString)
                End If



                anydata = New String() {iCount, strDocNo, strStkCode, strStkName, strCrycleTime, strQty, strWeight, strTrhKeyType, strDocdate}
                lvi = New ListViewItem(anydata)
                lsvPlan_M.Items.Add(lvi)

                'lsvPlan_E.Items.Remove(lvi0)
                dblTotalTime = strCrycleTime + dblTotalTime
                dblTotalQty = strQty + dblTotalQty
                dblTotalWeight = strWeight + dblTotalWeight
            End With
        Next

        lbTotalTimeM.Text = dblTotalTime.ToString("#,##0.00")
        lbHH_M.Text = HHMM(dblTotalTime)
        lbQty_M.Text = dblTotalQty.ToString("#,##0.00")
        lbWeight_M.Text = dblTotalWeight.ToString("#,##0.00")
        lbCrycleTime_M.Text = (dblTotalTime / dblTotalQty).ToString("#,##0.00")

    End Sub

    Private Sub frmSetTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim optAB As String
        'If getSection() = "A" Then
        '    opt_A.Checked = True
        'Else
        '    opt_B.Checked = True
        'End If
        lbDocNo.Text = selDocNo
        txtDate01.Value = Now
        txtDate02.Value = Now
        HeadList()
        chkLoad = True

        lbTotalCrycleTime.Text = 0
        lbHH0.Text = 0
        lbTotalWeight.Text = 0
        lbTotalQty.Text = 0

        Call showData1()
        Call showData(selDocNo)

        Dim intCountLsv As Integer = lsvPlan_E1.Items.Count
        lbCountList.Text = intCountLsv

    End Sub

    Sub HeadList()
        lsvPlan_E0.Columns.Add("item", 40, HorizontalAlignment.Right) '0
        lsvPlan_E0.Columns.Add("วันที่วางแผน", 80, HorizontalAlignment.Center) '1
        lsvPlan_E0.Columns.Add("กะ", 50, HorizontalAlignment.Center) '1
        lsvPlan_E0.Columns.Add("เลขที่", 80, HorizontalAlignment.Center) '2
        lsvPlan_E0.Columns.Add("id", 1, HorizontalAlignment.Left)
        lsvPlan_E0.Columns.Add("รายการผลิต", 230, HorizontalAlignment.Left) '3
        lsvPlan_E0.Columns.Add("เวลาผลิต", 60, HorizontalAlignment.Right) '4
        lsvPlan_E0.Columns.Add("จำนวน", 60, HorizontalAlignment.Right) '4
        lsvPlan_E0.Columns.Add("น้ำหนัก", 80, HorizontalAlignment.Right) '4

        lsvPlan_E0.View = View.Details
        lsvPlan_E0.GridLines = True

        lsvPlan_E1.Columns.Add("item", 40, HorizontalAlignment.Right) '0
        lsvPlan_E1.Columns.Add("วันที่วางแผน", 90, HorizontalAlignment.Center) '1
        lsvPlan_E1.Columns.Add("เวลา", 0, HorizontalAlignment.Center) '1
        lsvPlan_E1.Columns.Add("เลขที่", 80, HorizontalAlignment.Center) '2
        lsvPlan_E1.Columns.Add("id", 100, HorizontalAlignment.Left)
        lsvPlan_E1.Columns.Add("รายการผลิต", 230, HorizontalAlignment.Left) '3
        lsvPlan_E1.Columns.Add("เวลาผลิต", 60, HorizontalAlignment.Right) '4
        lsvPlan_E1.Columns.Add("จำนวน", 60, HorizontalAlignment.Right) '4
        lsvPlan_E1.Columns.Add("น้ำหนัก", 80, HorizontalAlignment.Right) '4

        lsvPlan_E1.View = View.Details
        lsvPlan_E1.GridLines = True


        'lsvPlan_E2.Columns.Add("item", 40, HorizontalAlignment.Right) '0
        'lsvPlan_E2.Columns.Add("วันที่วางแผน", 80, HorizontalAlignment.Center) '1
        'lsvPlan_E2.Columns.Add("เวลา", 0, HorizontalAlignment.Center) '1
        'lsvPlan_E2.Columns.Add("เลขที่", 80, HorizontalAlignment.Center) '2
        'lsvPlan_E2.Columns.Add("id", 1, HorizontalAlignment.Left)
        'lsvPlan_E2.Columns.Add("รายการผลิต", 230, HorizontalAlignment.Left) '3
        'lsvPlan_E2.Columns.Add("เวลาผลิต", 60, HorizontalAlignment.Right) '4
        'lsvPlan_E2.Columns.Add("จำนวน", 60, HorizontalAlignment.Right) '4
        'lsvPlan_E2.Columns.Add("น้ำนหนัก", 80, HorizontalAlignment.Right) '4

        'lsvPlan_E2.View = View.Details
        'lsvPlan_E2.GridLines = True

        ' lsvPlan_M.Columns.Add("item", 50, HorizontalAlignment.Right) '0
        'lsvPlan_M.Columns.Add("วันที่วางแผน", 80, HorizontalAlignment.Center) '1
        lsvPlan_M.Columns.Add("item", 40, HorizontalAlignment.Right) '0
        lsvPlan_M.Columns.Add("เลขที่", 80, HorizontalAlignment.Center) '1
        lsvPlan_M.Columns.Add("id", 100, HorizontalAlignment.Left) '2
        lsvPlan_M.Columns.Add("รายการผลิต", 230, HorizontalAlignment.Left) '3
        lsvPlan_M.Columns.Add("เวลาผลิต", 60, HorizontalAlignment.Right) '4
        lsvPlan_M.Columns.Add("จำนวน", 60, HorizontalAlignment.Right) '4
        lsvPlan_M.Columns.Add("น้ำนหนัก", 80, HorizontalAlignment.Right) '4
        lsvPlan_M.Columns.Add("กะผลิต", 80, HorizontalAlignment.Right) '4
        lsvPlan_M.Columns.Add("วันที่", 100, HorizontalAlignment.Center)

        lsvPlan_M.View = View.Details
        lsvPlan_M.GridLines = True

        'chkTB = True

    End Sub
    Function getSection() As String

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ClockMast "
        txtSQL = txtSQL & "Order by Clock_Update desc "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "clock")

        Return subDS.Tables("clock").Rows(0).Item("Clock_Section")

    End Function

    Function getSQL0() As String
        Dim strSection As String = getSection()
        Dim strdate01 As Date = txtDate01.Value ' DateAdd(DateInterval.Day, 1, )

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ("
        txtSQL = txtSQL & "Select trh_no "
        txtSQL = txtSQL & "From TranDataH_E  "
        txtSQL = txtSQL & "Left Join TranDataD_E "
        txtSQL = txtSQL & "On Trh_Type=Dtl_type And TRh_no=Dtl_no "
        txtSQL = txtSQL & "where trh_type ='E' "

        txtSQL = txtSQL & "And year(trh_date) ='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(trh_date) >='" & Month(Now) - 1 & "' "
        'txtSQL = txtSQL & "And month(trh_date) >='" & Month(Now) - 1 & "' "
        txtSQL = txtSQL & "And Dtl_sticker ='BS' "

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='M' "
        'txtSQL = txtSQL & "And Dtl_Sticker='BS' "
        'txtSQL=txtSQL & ""
        'txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & "And year(trh_date) ='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(trh_date) >='" & Month(Now) - 1 & "' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='D' "
        ' txtSQL = txtSQL & "And trh_date >='2019-06-01 00:00:00' "
        txtSQL = txtSQL & "And year(trh_date) ='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(trh_date) >='" & Month(Now) - 1 & "' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_No "
        txtSQL = txtSQL & "From TranDataH_PM )"
        'txtSQL = txtSQL & "Order By trh_no "
        txtSQL = txtSQL & ")tbMaster "


        txtSQL = txtSQL & "Left Join TranDataH_E "
        txtSQL = txtSQL & "On tbMaster.Trh_No=TranDataH_E.Trh_No "
        txtSQL = txtSQL & "left Join TranDataD_E "
        txtSQL = txtSQL & "On TranDataH_E.Trh_Type=TranDataD_E.Dtl_Type "
        txtSQL = txtSQL & "And TranDataH_E.Trh_No=TranDataD_E.Dtl_No "
        Dim optAB As String = ""
        optAB = strSection
        'If opt_A.Checked = True Then
        'Else
        '    optAB = "B"
        'End If

        Dim strDateNow As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM-dd-yyyy").ToString & " 00:00:00"

        txtSQL = txtSQL & "where tranDataH_E.trh_type ='E' "
        txtSQL = txtSQL & "And Dtl_Sticker='BS' "
        txtSQL = txtSQL & "And TranDataD_E.Dtl_Num > 0 "
        txtSQL = txtSQL & "And not(TranDataH_E.Trh_No='')  "
        ' txtSQL = txtSQL & "And TranDataH_E.Trh_KeyType='" & optAB & "' "
        txtSQL = txtSQL & "And TranDataH_E.Trh_Date <'" & strDateNow & "' "
        txtSQL = txtSQL & "Or ( YEAR(TranDataH_E.Trh_Date)='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(TranDataH_E.Trh_Date)='" & Month(Now) + 1 & "' )"

        txtSQL = txtSQL & "order by TranDataH_E.Trh_Date,right(TranDataH_E.trh_no,1) , tranDataH_E.Trh_No "

        Return txtSQL

    End Function

    Function getSQL1() As String
        Dim strSection As String = getSection()
        Dim strdate01 As Date = txtDate01.Value ' DateAdd(DateInterval.Day, 1, )

        Dim strDateNow As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM-dd-yyyy").ToString & " 00:00:00"

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ("
        txtSQL = txtSQL & "Select trh_no "
        txtSQL = txtSQL & "From TranDataH_E  "
        txtSQL = txtSQL & "Left Join TranDataD_E "
        txtSQL = txtSQL & "On Trh_Type=Dtl_type And TRh_no=Dtl_no "
        'txtSQL = txtSQL & "And year(trh_date) ='" & Year(Now) - 543 & "' "
        'txtSQL = txtSQL & "And month(trh_date)='" & Month(Now) & "' "
        txtSQL = txtSQL & "Where Trh_Type='E' "
        txtSQL = txtSQL & "And Trh_Date>='" & strDateNow & "' "
        txtSQL = txtSQL & "And Dtl_sticker ='BS' "

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='M' "
        txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='D' "
        txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_No "
        txtSQL = txtSQL & "From TranDataH_PM )"
        'txtSQL = txtSQL & "Order By trh_no "

        'txtSQL = txtSQL & "except ("
        'Dim txtsql2 As String = getSQL0()
        'txtSQL = txtSQL & txtsql2
        'txtSQL = txtSQL & ")"

        txtSQL = txtSQL & ")tbMaster "


        txtSQL = txtSQL & "Left Join TranDataH_E "
        txtSQL = txtSQL & "On tbMaster.Trh_No=TranDataH_E.Trh_No "
        txtSQL = txtSQL & "left Join TranDataD_E "
        txtSQL = txtSQL & "On TranDataH_E.Trh_Type=TranDataD_E.Dtl_Type "
        txtSQL = txtSQL & "And TranDataH_E.Trh_No=TranDataD_E.Dtl_No "
        Dim optAB As String = ""
        optAB = strSection
        'If opt_A.Checked = True Then
        'Else
        '    optAB = "B"
        'End If

        txtSQL = txtSQL & "where tranDataH_E.trh_type ='E' "
        txtSQL = txtSQL & "And TranDataD_E.Dtl_Num > 0 "
        txtSQL = txtSQL & "And not(TranDataH_E.Trh_No='')  "
        txtSQL = txtSQL & "And TranDataH_E.Trh_KeyType='" & optAB & "' "
        txtSQL = txtSQL & "And TranDataH_E.Trh_Date>='" & strDateNow & "' "
        txtSQL = txtSQL & "Or ( YEAR(TranDataH_E.Trh_Date)='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(TranDataH_E.Trh_Date)='" & Month(Now) + 1 & "' )"

        txtSQL = txtSQL & "order by TranDataH_E.Trh_Date,right(TranDataH_E.trh_no,1) , tranDataH_E.Trh_No "

        Return txtSQL

    End Function

    Function getSQL2() As String
        Dim strSection As String = getSection()
        Dim strdate01 As Date = txtDate01.Value ' DateAdd(DateInterval.Day, 1, )

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ("
        txtSQL = txtSQL & "Select trh_no "
        txtSQL = txtSQL & "From TranDataH_E  "
        txtSQL = txtSQL & "Left Join TranDataD_E "
        txtSQL = txtSQL & "On Trh_Type=Dtl_type And TRh_no=Dtl_no "
        txtSQL = txtSQL & "where trh_type ='E' "
        txtSQL = txtSQL & "And year(trh_date) ='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(trh_date) ='" & Month(Now) & "' "
        txtSQL = txtSQL & "And Dtl_sticker ='BS' "

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='M' "
        txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except " 'เพิ่มตัดการรับจาก QC 
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='0' "
        txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_no "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_no "
        txtSQL = txtSQL & "Where Trh_type ='D' "
        txtSQL = txtSQL & "And trh_date >='2019-05-01 00:00:00' "
        txtSQL = txtSQL & ")"

        txtSQL = txtSQL & "except "
        txtSQL = txtSQL & "(Select trh_No "
        txtSQL = txtSQL & "From TranDataH_PM )"
        txtSQL = txtSQL & ")tbMaster "

        txtSQL = txtSQL & "Left Join TranDataH_E "
        txtSQL = txtSQL & "On tbMaster.Trh_No=TranDataH_E.Trh_No "
        txtSQL = txtSQL & "left Join TranDataD_E "
        txtSQL = txtSQL & "On TranDataH_E.Trh_Type=TranDataD_E.Dtl_Type "
        txtSQL = txtSQL & "And TranDataH_E.Trh_No=TranDataD_E.Dtl_No "
        Dim optAB As String = ""
        optAB = strSection
        'If opt_A.Checked = True Then
        'Else
        '    optAB = "B"
        'End If

        Dim strDateNow As String = Format(DateAdd(DateInterval.Year, -543, DateAdd(DateInterval.Day, -3, Now)), "MM-dd-yyyy").ToString & " 00:00:00"

        txtSQL = txtSQL & "where TranDataD_E.Dtl_Num > 0 "
        txtSQL = txtSQL & "And not(TranDataH_E.Trh_No='')  "
        '' txtSQL = txtSQL & "And TranDataH_E.Trh_KeyType='" & optAB & "' "
        txtSQL = txtSQL & "And TranDataH_E.Trh_Date>='" & strDateNow & "' "
        ''txtSQL = txtSQL & "And (TranDataH_E.Trh_KeyType='" & optAB & "') "
        txtSQL = txtSQL & "Or ( YEAR(TranDataH_E.Trh_Date)='" & Year(Now) - 543 & "' "
        txtSQL = txtSQL & "And month(TranDataH_E.Trh_Date)='" & Month(Now) + 0 & "' )"
        txtSQL = txtSQL & "order by TranDataH_E.Trh_Date,right(TranDataH_E.trh_no,1) , tranDataH_E.Trh_No "

        Return txtSQL

    End Function
    Function HHMM(dMinute As Long) As String
        Dim dHH As String
        Dim dMin As String
        dHH = dMinute \ 60
        dMin = dMinute Mod 60
        If Val(dMin) < 10 Then
            dMin = "0" & dMin
        End If
        HHMM = dHH & ":" & dMin
    End Function

    Sub showData1()
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        Dim anydata() As String
        Dim lvi As ListViewItem

        Dim strItem As String = ""
        Dim strDocDate As String = ""
        Dim strDocTime As String = ""
        Dim strDocNO As String = ""
        Dim strStkCode As String = ""
        Dim strStkName As String = ""
        Dim strFirstDoc As String = ""

        Dim strCryCleTime As Double = "0"
        Dim strQty As Double = 0
        Dim strWeight As Double = 0
        Dim dblTotalQty As Double = 0
        Dim dblTotalWeight As Double = 0
        Dim dblTotalTime As Double = 0

        Dim iColor As Integer = 0

        lbTotalCrycleTime.Text = 0
        lbHH0.Text = 0
        lbTotalWeight.Text = 0
        lbTotalQty.Text = 0

        lbTotalCrycleTime.Text = 0
        lbTotalQty.Text = 0 'dblTotalQty.ToString("#,##0.00")
        lbTotalWeight.Text = 0 ' dblTotalWeight.ToString("#,##0.00")

        'txtSQL = getSQL0()
        'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDA.Fill(subDS, "dataList0")
        'lsvPlan_E1.Items.Clear()

        'For i = 0 To subDS.Tables("dataList0").Rows.Count - 1
        '    'Exit For
        '    With subDS.Tables("dataList0").Rows(i)
        '        strItem = (i + 1).ToString
        '        If IsDBNull(.Item("Trh_Date")) Then
        '            strDocDate = ""
        '            strDocDate = "ไม่พบรหัสลูกค้า"
        '        Else
        '            strDocDate = .Item("Trh_Date")
        '            strDocTime = .Item("Trh_KeyType")
        '        End If

        '        If IsDBNull(.Item("Trh_No")) = True Then
        '            strDocNO = ""
        '        Else
        '            strDocNO = .Item("Trh_No")
        '            strFirstDoc = Mid(strDocNO, Len(strDocNO), 1)
        '            If strFirstDoc = "B" Then
        '                iColor = 2
        '            Else
        '                iColor = 0
        '            End If
        '        End If

        '        If IsDBNull(.Item("Dtl_idTrade")) Then
        '            strStkCode = ""
        '        Else
        '            strStkCode = .Item("Dtl_idTrade")
        '        End If

        '        If IsDBNull(.Item("Dtl_n_Trade")) Then
        '            strStkName = ""
        '        Else
        '            strStkName = .Item("Dtl_n_Trade")
        '        End If
        '        strCryCleTime = .Item("Trh_Cre_Lim")

        '        '===================================================
        '        Dim str1 As String = ""
        '        Dim str2 As String = ""

        '        Dim i0 As Integer = 0
        '        Dim iBake As Integer = 0
        '        For n = Len(strStkName) To 1 Step -1
        '            i0 = i0 + 1
        '            'strArTitleID = ""
        '            str1 = Mid(strStkName, n, 1)
        '            str2 = Trim(str1) + str2  ' ตัดตัวอักษรที่ละตัว  ใช้หาคำปิดท้าย เช่น (สำนักงานใหญ่)
        '            iBake = iBake + 1
        '            If iBake = 4 Then
        '                Exit For
        '            End If
        '        Next
        '        Dim xTime As Integer = 0

        '        If str2 = "(3T)" Then
        '            'MsgBox("3t" & " = " & dtl_N_Trade)
        '            strCryCleTime = strCryCleTime / 2
        '        Else
        '            strCryCleTime = strCryCleTime
        '        End If
        '        '========================================
        '        dblTotalTime = strCryCleTime + dblTotalTime
        '        lbHH0.Text = HHMM(dblTotalTime)

        '        strQty = .Item("Dtl_Num")
        '        strWeight = .Item("Dtl_Num_2")
        '        dblTotalQty = dblTotalQty + strQty
        '        dblTotalWeight = dblTotalWeight + strWeight

        '        lbTotalCrycleTime.Text = dblTotalTime.ToString("#,##0.00")
        '        lbTotalQty.Text = dblTotalQty.ToString("#,##0.00")
        '        lbTotalWeight.Text = dblTotalWeight.ToString("#,##0.00")

        '    End With
        '    anydata = New String() {strItem, strDocDate, strDocTime, strDocNO, strStkCode, strStkName, strCryCleTime.ToString("#,##0.00"), strQty.ToString("#,##0"), strWeight.ToString("#,##0.00")}
        '    lvi = New ListViewItem(anydata)
        '    lsvPlan_E1.Items.Add(lvi)
        '    If strDocTime = "A" Then
        '        lvi.BackColor = Color.Yellow
        '        lvi.ForeColor = Color.Black
        '    Else
        '        lvi.BackColor = Color.YellowGreen
        '        lvi.ForeColor = Color.Black
        '    End If

        'Next

        'txtSQL = getSQL1()
        'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDA.Fill(subDS, "dataList")
        'chkData = True
        'chkDateSL1 = True

        ''lsvPlan_E1.Items.Clear()
        ''lsvPlan_M.Items.Clear()

        'For i = 0 To subDS.Tables("dataList").Rows.Count - 1
        '    With subDS.Tables("dataList").Rows(i)
        '        strItem = (i + 1).ToString
        '        If IsDBNull(.Item("Trh_Date")) Then
        '            strDocDate = ""
        '            strDocDate = "ไม่พบรหัสลูกค้า"
        '        Else
        '            strDocDate = .Item("Trh_Date")
        '            strDocTime = .Item("Trh_KeyType")
        '        End If

        '        If IsDBNull(.Item("Trh_No")) = True Then
        '            strDocNO = ""
        '        Else
        '            strDocNO = .Item("Trh_No")
        '            strFirstDoc = Mid(strDocNO, Len(strDocNO), 1)
        '            If strFirstDoc = "B" Then
        '                iColor = 2
        '            Else
        '                iColor = 0
        '            End If
        '        End If

        '        If IsDBNull(.Item("Dtl_idTrade")) Then
        '            strStkCode = ""
        '        Else
        '            strStkCode = .Item("Dtl_idTrade")

        '        End If

        '        If IsDBNull(.Item("Dtl_n_Trade")) Then

        '            strStkName = ""
        '        Else
        '            strStkName = .Item("Dtl_n_Trade")

        '        End If

        '        strCryCleTime = .Item("Trh_Cre_Lim")

        '        '===================================================
        '        Dim str1 As String = ""
        '        Dim str2 As String = ""

        '        Dim i0 As Integer = 0
        '        Dim iBake As Integer = 0
        '        For n = Len(strStkName) To 1 Step -1
        '            i0 = i0 + 1
        '            'strArTitleID = ""
        '            str1 = Mid(strStkName, n, 1)
        '            str2 = Trim(str1) + str2  ' ตัดตัวอักษรที่ละตัว  ใช้หาคำปิดท้าย เช่น (สำนักงานใหญ่)
        '            iBake = iBake + 1

        '            If iBake = 4 Then
        '                Exit For
        '            End If
        '        Next
        '        Dim xTime As Integer = 0

        '        If str2 = "(3T)" Then
        '            'MsgBox("3t" & " = " & dtl_N_Trade)
        '            strCryCleTime = strCryCleTime / 2
        '        Else
        '            strCryCleTime = strCryCleTime
        '        End If

        '        '========================================
        '        dblTotalTime = strCryCleTime + dblTotalTime

        '        lbHH0.Text = HHMM(dblTotalTime)

        '        strQty = .Item("Dtl_Num")
        '        strWeight = .Item("Dtl_Num_2")
        '        dblTotalQty = dblTotalQty + strQty
        '        dblTotalWeight = dblTotalWeight + strWeight

        '        lbTotalCrycleTime.Text = dblTotalTime.ToString("#,##0.00")
        '        lbTotalQty.Text = dblTotalQty.ToString("#,##0.00")
        '        lbTotalWeight.Text = dblTotalWeight.ToString("#,##0.00")

        '    End With

        '    'iColor = 0
        '    anydata = New String() {strItem, strDocDate, strDocTime, strDocNO, strStkCode, strStkName, strCryCleTime.ToString("#,##0.00"), strQty.ToString("#,##0"), strWeight.ToString("#,##0.00")}
        '    lvi = New ListViewItem(anydata)
        '    lsvPlan_E1.Items.Add(lvi)
        '    If strDocTime = "A" Then
        '        lvi.BackColor = Color.Orange
        '        lvi.ForeColor = Color.Black
        '    Else
        '        lvi.BackColor = Color.DarkOrange
        '        lvi.ForeColor = Color.Black
        '    End If

        '    'If iColor = 0 Then
        '    '    lvi.BackColor = Color.DarkOrange
        '    '    lvi.ForeColor = Color.Black
        '    'ElseIf iColor = 1 Then
        '    '    lvi.BackColor = Color.White
        '    '    lvi.ForeColor = Color.Black
        '    'ElseIf iColor = 2 Then

        '    'ElseIf iColor = 3 Then
        '    '    lvi.BackColor = Color.GreenYellow
        '    '    lvi.ForeColor = Color.White
        '    'End If

        '    'lbCusSalesQ01.Text = Format(i + 1, "#,##0")

        'Next


        txtSQL = getSQL2()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataList2")
        chkData = True

        'lsvPlan_E2.Items.Clear()
        'lsvPlan_M.Items.Clear()
        For i = 0 To subDS.Tables("dataList2").Rows.Count - 1

            With subDS.Tables("dataList2").Rows(i)
                strItem = (i + 1).ToString
                If IsDBNull(.Item("Trh_Date")) Then
                    strDocDate = ""
                    strDocDate = "ไม่พบรหัสลูกค้า"
                Else
                    strDocDate = Format(.Item("Trh_Date"), "dd-MM-yyyy HH:mm:ss")
                    strDocTime = .Item("Trh_KeyType")
                    'If .Item("Trh_Data") Then

                End If

                If IsDBNull(.Item("Trh_No")) = True Then
                    strDocNO = ""
                Else
                    strDocNO = .Item("Trh_No")
                    strFirstDoc = Mid(strDocNO, Len(strDocNO), 1)
                    If strFirstDoc = "B" Then
                        iColor = 2
                    Else
                        iColor = 0
                    End If
                End If

                If IsDBNull(.Item("Dtl_idTrade")) Then
                    strStkCode = ""
                Else
                    strStkCode = .Item("Dtl_idTrade")
                End If

                If IsDBNull(.Item("Dtl_n_Trade")) Then

                    strStkName = ""
                Else
                    strStkName = .Item("Dtl_n_Trade")
                End If
                strCryCleTime = .Item("Trh_Cre_Lim")

                '===================================================
                Dim str1 As String = ""
                Dim str2 As String = ""

                Dim i0 As Integer = 0
                Dim iBake As Integer = 0
                For n = Len(strStkName) To 1 Step -1
                    i0 = i0 + 1
                    'strArTitleID = ""
                    str1 = Mid(strStkName, n, 1)
                    str2 = Trim(str1) + str2  ' ตัดตัวอักษรที่ละตัว  ใช้หาคำปิดท้าย เช่น (สำนักงานใหญ่)
                    iBake = iBake + 1

                    If iBake = 4 Then
                        Exit For
                    End If
                Next
                Dim xTime As Integer = 0

                If str2 = "(3T)" Then
                    'MsgBox("3t" & " = " & dtl_N_Trade)
                    strCryCleTime = strCryCleTime / 2
                Else
                    strCryCleTime = strCryCleTime
                End If

                '========================================
                dblTotalTime = strCryCleTime + dblTotalTime

                lbHH0.Text = HHMM(dblTotalTime)

                strQty = .Item("Dtl_Num")
                strWeight = .Item("Dtl_Num_2")
                dblTotalQty = dblTotalQty + strQty
                dblTotalWeight = dblTotalWeight + strWeight

                lbTotalCrycleTime.Text = dblTotalTime.ToString("#,##0.00")
                lbTotalQty.Text = dblTotalQty.ToString("#,##0.00")
                lbTotalWeight.Text = dblTotalWeight.ToString("#,##0.00")

            End With

            anydata = New String() {strItem, strDocDate, strDocTime, strDocNO, strStkCode, strStkName, strCryCleTime.ToString("#,##0.00"), strQty.ToString("#,##0"), strWeight.ToString("#,##0.00")}
            lvi = New ListViewItem(anydata)
            lsvPlan_E1.Items.Add(lvi)
            'If iColor = 0 Then
            If strDocTime = "A" Then
                lvi.BackColor = Color.Yellow
                lvi.ForeColor = Color.Black
            Else
                lvi.BackColor = Color.YellowGreen
                lvi.ForeColor = Color.Black
            End If
        Next

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles txtDate02.ValueChanged

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        Call showData1()
    End Sub

    Private Sub chkByDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkByDoc.CheckedChanged
        If chkLoad = True Then
            Call showData1()
        End If

    End Sub

    Private Sub chkByStkName_CheckedChanged(sender As Object, e As EventArgs) Handles chkByStkName.CheckedChanged
        If chkLoad = True Then
            Call showData1()
        End If

    End Sub

    Private Sub lsvPlan_E_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvPlan_E1.SelectedIndexChanged

    End Sub


    Private Sub lsvPlan_M_Click(sender As Object, e As EventArgs) Handles lsvPlan_M.Click
        Dim strDocNo As String = ""
        Dim lvi0 As ListViewItem

        For i = 0 To lsvPlan_M.SelectedItems.Count - 1

            lvi0 = lsvPlan_M.SelectedItems(i)
            strDocNo = lsvPlan_M.Items(lvi0.Index).SubItems(1).Text
            lbItemDocNo.Text = strDocNo
            i_Item.Text = lsvPlan_M.Items(lvi0.Index).SubItems(0).Text
            intNum = lsvPlan_M.Items(lvi0.Index).SubItems(0).Text
            lbStkCode.Text = lsvPlan_M.Items(lvi0.Index).SubItems(2).Text
            lbStkName.Text = lsvPlan_M.Items(lvi0.Index).SubItems(3).Text
        Next

    End Sub
    Private Sub lsvPlan_M_DoubleClick(sender As Object, e As EventArgs) Handles lsvPlan_M.DoubleClick

        Dim lvi0 As ListViewItem
        'Dim anyData() As String

        Dim strDocNo As String = ""
        Dim strItem As String = ""
        Dim strDocDate As String = ""
        Dim strDocTime As String = ""
        Dim strStkCode As String = ""
        Dim strStkName As String = ""

        Dim strCryCleTime As Double = "0"
        Dim strQty As Double = 0
        Dim strWeight As Double = 0

        Dim dblTotalQty As Double = CDbl(lbQty_M.Text)
        Dim dblTotalWeight As Double = CDbl(lbWeight_M.Text)
        Dim dblTotalTime As Double = CDbl(lbTotalTimeM.Text)

        For i = 0 To lsvPlan_M.SelectedItems.Count - 1

            lvi0 = lsvPlan_M.SelectedItems(i)
            strDocNo = lsvPlan_M.Items(lvi0.Index).SubItems(1).Text
            delTranDataPM(strDocNo)

            strCryCleTime = lsvPlan_M.Items(lvi0.Index).SubItems(4).Text  ' เวลาในการผลิต
            strQty = lsvPlan_M.Items(lvi0.Index).SubItems(5).Text
            strWeight = lsvPlan_M.Items(lvi0.Index).SubItems(6).Text
            lsvPlan_M.Items.Remove(lvi0)

            dblTotalTime = +dblTotalTime - strCryCleTime
            dblTotalQty = +dblTotalQty - strQty
            dblTotalWeight = +dblTotalWeight - strWeight

        Next

        lbItem.Text = lbItem.Text - 1
        lbTotalTimeM.Text = dblTotalTime.ToString("#,##0.00")
        lbHH_M.Text = HHMM(dblTotalTime)
        lbQty_M.Text = dblTotalQty.ToString("#,##0.00")
        lbWeight_M.Text = dblTotalWeight.ToString("#,##0.00")
        lbCrycleTime_M.Text = (dblTotalTime / dblTotalQty).ToString("#,##0.00")

        Call showData1()

    End Sub

    Private Sub lsvPlan_E_DoubleClick(sender As Object, e As EventArgs) Handles lsvPlan_E1.DoubleClick

        Dim lvi0 As ListViewItem
        Dim anyData() As String

        Dim strItem As String = ""
        Dim strDocDate As String = ""
        Dim strDocTime As String = ""
        Dim strDocNO As String = ""
        Dim strStkCode As String = ""
        Dim strStkName As String = ""

        Dim strCryCleTime As Double = "0"
        Dim strQty As Double = 0
        Dim strWeight As Double = 0
        Dim dblTotalQty As Double = CDbl(lbQty_M.Text)
        Dim dblTotalWeight As Double = CDbl(lbWeight_M.Text)
        Dim dblTotalTime As Double = CDbl(lbTotalTimeM.Text)

        'Dim lvi1 As ListViewItem
        Dim strTarget As String = ""
        Dim iCount As Integer = lsvPlan_M.Items.Count
        Dim strSection As String = ""
        lbItem.Text = iCount + 1
        For i = 0 To lsvPlan_E1.SelectedItems.Count - 1

            lvi0 = lsvPlan_E1.SelectedItems(i)  ' Item ที่เลือก
            iCount = iCount + 1
            strSection = lsvPlan_E1.Items(lvi0.Index).SubItems(2).Text
            strDocNO = lsvPlan_E1.Items(lvi0.Index).SubItems(3).Text
            strStkCode = lsvPlan_E1.Items(lvi0.Index).SubItems(4).Text
            strStkName = lsvPlan_E1.Items(lvi0.Index).SubItems(5).Text

            If strStkCode = "" Then
                txtSQL = "Select * "
                txtSQL = txtSQL & "From BaseMast "
                txtSQL = txtSQL & "Where Stk_PC_Name like '" & strStkName & "'"
                subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDa.Fill(subDs, "chkName")
                If subDs.Tables("chkName").Rows.Count > 0 Then
                    If IsDBNull(subDs.Tables("chkName").Rows(0).Item("Stk_Code")) Then
                        strStkCode = ""
                    Else
                        strStkCode = subDs.Tables("chkName").Rows(0).Item("Stk_Code")
                    End If
                Else
                    strStkCode = ""
                End If

            End If
            strCryCleTime = lsvPlan_E1.Items(lvi0.Index).SubItems(6).Text
            strQty = lsvPlan_E1.Items(lvi0.Index).SubItems(7).Text
            strWeight = lsvPlan_E1.Items(lvi0.Index).SubItems(8).Text
            '===========  ลบข้อมูลใน List ที่เลือก
            lsvPlan_E1.Items.Remove(lvi0)

            dblTotalTime = strCryCleTime + dblTotalTime
            dblTotalQty = strQty + dblTotalQty
            dblTotalWeight = strWeight + dblTotalWeight

            '=========== เพิ่มข้อมูลใน List ใหม่
            anyData = New String() {iCount, strDocNO, strStkCode, strStkName, strCryCleTime, strQty, strWeight, strSection}
            lvi0 = New ListViewItem(anyData)
            lsvPlan_M.Items.Add(lvi0)

        Next

        'lbItem.Text = lbItem.Text - 1
        lbTotalTimeM.Text = dblTotalTime.ToString("#,##0.00")
        lbHH_M.Text = HHMM(dblTotalTime)
        lbQty_M.Text = dblTotalQty.ToString("#,##0.00")
        lbWeight_M.Text = dblTotalWeight.ToString("#,##0.00")
        lbCrycleTime_M.Text = (dblTotalTime / dblTotalQty).ToString("#,##0.00")

        Call saveData()
        Call showData1()


    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'End
        Me.Close()

    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Call saveData()
        MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.MsgBoxRight, "แจ้งเตือน")
        Me.Close()

    End Sub

    Private Sub lsvPlan_M_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvPlan_M.SelectedIndexChanged

    End Sub

    Private Sub CmbPrint_Click(sender As Object, e As EventArgs) Handles cmbReload.Click

        lbTotalTimeM.Text = 0
        lbHH_M.Text = 0
        lbQty_M.Text = 0
        lbWeight_M.Text = 0
        lbCrycleTime_M.Text = 0

        Call showData("")

    End Sub

    Private Sub Opt_A_CheckedChanged(sender As Object, e As EventArgs)
        Call showData1()

    End Sub

    Private Sub Opt_B_CheckedChanged(sender As Object, e As EventArgs)
        Call showData1()
    End Sub

    Private Sub CmbDown_Click(sender As Object, e As EventArgs) Handles cmbDown.Click
        'Dim strDocNo As String = ""
        'Dim lvi0 As ListViewItem
        'Dim intNum As Integer

        'For i = 0 To lsvPlan_M.SelectedItems.Count - 1
        '    lvi0 = lsvPlan_M.SelectedItems(i)
        '    intNum = lsvPlan_M.Items(lvi0.Index).SubItems(0).Text
        'Next

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select Trh_Runid,Trh_No,trh_date,Dtl_Runnum,"
        txtSQL = txtSQL & "Dtl_idTrade,Dtl_n_Trade,Trh_Cre_Lim,Dtl_Num,Dtl_Num_2 "

        txtSQL = txtSQL & "From TranDataH_PM "
        txtSQL = txtSQL & "Left Join TranDataD_PM "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type "
        txtSQL = txtSQL & "And Trh_no=Dtl_No "

        txtSQL = txtSQL & "Where Trh_Detail='' "
        txtSQL = txtSQL & "And Trh_Chk_Print='0' "

        txtSQL = txtSQL & "Order by TranDataH_PM.Trh_Runid "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataList")
        'Dim intNumBefor As Integer = 0
        If intNum = subDS.Tables("dataList").Rows.Count Then
            'MsgBox(subDS.Tables("dataList").Rows.Count & "--" & intNum)
            Exit Sub
        End If
        For i = 0 To subDS.Tables("dataList").Rows.Count - 1

            With subDS.Tables("dataList").Rows(i)

                If .Item("Trh_Runid") = intNum Then
                    txtSQL = "Update TranDataH_PM "
                    txtSQL = txtSQL & "Set Trh_runid='" & intNum + 1 & "' "
                    txtSQL = txtSQL & "Where Trh_No='" & .Item("Trh_No") & "'"
                    DBtools.dbSaveDATA(txtSQL, "")
                    txtSQL = txtSQL & "Update TranDataD_PM "
                    txtSQL = txtSQL & "Set Dtl_Runnum='" & intNum + 1 & "' "
                    txtSQL = txtSQL & "Where Dtl_No='" & .Item("Trh_No") & "' "
                    DBtools.dbSaveDATA(txtSQL, "")

                ElseIf .Item("Trh_Runid") = intNum + 1 Then

                    txtSQL = "Update TranDataH_PM "
                    txtSQL = txtSQL & "Set Trh_runid='" & intNum & "' "
                    txtSQL = txtSQL & "Where Trh_No='" & .Item("Trh_No") & "'"
                    DBtools.dbSaveDATA(txtSQL, "")

                    txtSQL = txtSQL & "Update TranDataD_PM "
                    txtSQL = txtSQL & "Set Dtl_Runnum='" & intNum & "' "
                    txtSQL = txtSQL & "Where Dtl_No='" & .Item("Trh_No") & "' "
                    DBtools.dbSaveDATA(txtSQL, "")
                    i_Item.Text = intNum - 1
                    intNum = intNum - 1

                    'Exit Sub

                End If

            End With
        Next
        Call showData("")
    End Sub


    Private Sub CmbUp_Click(sender As Object, e As EventArgs) Handles cmbUp.Click
        'Dim strDocNo As String = ""
        'Dim lvi0 As ListViewItem
        'Dim intNum As Integer

        'For i = 0 To lsvPlan_M.SelectedItems.Count - 1
        '    lvi0 = lsvPlan_M.SelectedItems(i)
        '    intNum = lsvPlan_M.Items(lvi0.Index).SubItems(0).Text
        'Next

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select Trh_Runid,Trh_No,trh_date,Dtl_Runnum,"
        txtSQL = txtSQL & "Dtl_idTrade,Dtl_n_Trade,Trh_Cre_Lim,Dtl_Num,Dtl_Num_2 "

        txtSQL = txtSQL & "From TranDataH_PM "
        txtSQL = txtSQL & "Left Join TranDataD_PM "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type "
        txtSQL = txtSQL & "And Trh_no=Dtl_No "

        txtSQL = txtSQL & "Where Trh_Detail='' "
        txtSQL = txtSQL & "And Trh_Chk_Print='0' "

        txtSQL = txtSQL & "Order by TranDataH_PM.Trh_Runid "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataList")
        'Dim intNumBefor As Integer = 0
        'If intNum = subDS.Tables("dataList").Rows.Count Then
        '    MsgBox(subDS.Tables("dataList").Rows.Count & "--" & intNum)
        '    Exit Sub
        'End If
        If intNum = 1 Then
            'MsgBox(intNum)
            Exit Sub

        End If
        For i = 0 To subDS.Tables("dataList").Rows.Count - 1

            With subDS.Tables("dataList").Rows(i)

                If .Item("Trh_Runid") = intNum - 1 Then
                    txtSQL = "Update TranDataH_PM "
                    txtSQL = txtSQL & "Set Trh_runid='" & intNum & "' "
                    txtSQL = txtSQL & "Where Trh_No='" & .Item("Trh_No") & "'"
                    DBtools.dbSaveDATA(txtSQL, "")
                    txtSQL = txtSQL & "Update TranDataD_PM "
                    txtSQL = txtSQL & "Set Dtl_Runnum='" & intNum & "' "
                    txtSQL = txtSQL & "Where Dtl_No='" & .Item("Trh_No") & "' "
                    DBtools.dbSaveDATA(txtSQL, "")

                ElseIf .Item("Trh_Runid") = intNum Then

                    txtSQL = "Update TranDataH_PM "
                    txtSQL = txtSQL & "Set Trh_runid='" & intNum - 1 & "' "
                    txtSQL = txtSQL & "Where Trh_No='" & .Item("Trh_No") & "'"
                    DBtools.dbSaveDATA(txtSQL, "")

                    txtSQL = txtSQL & "Update TranDataD_PM "
                    txtSQL = txtSQL & "Set Dtl_Runnum='" & intNum - 1 & "' "
                    txtSQL = txtSQL & "Where Dtl_No='" & .Item("Trh_No") & "' "
                    DBtools.dbSaveDATA(txtSQL, "")
                    i_Item.Text = intNum - 1
                    intNum = intNum - 1

                    'Exit Sub

                End If

            End With
        Next
        Call showData("")
        ''lvi0 = lsvPlan_M.SelectedItems(i)
        'For i = 0 To lsvPlan_M.Items.Count - 1
        '    ' If lvi_i = i_Item.Text Then
        '    'MsgBox("^^" & lsvPlan_M.Items(i).SubItems(0).Text)
        '    ' update  TranDataH.Trh_Trh_RunID  + 1
        '    ' update TranDataD.dtl_runnum  + 1
        '    'End If
        '    If lvi_i = i Then
        '        MsgBox("^^ อันนี้เท่ากับ " & lvi_i)
        '        ' update  TranDataH.Trh_Trh_RunID  + 1
        '        ' update TranDataD.dtl_runnum  + 1
        '    End If

        'Next



    End Sub

    Private Sub CmbCutQ_Click(sender As Object, e As EventArgs) Handles cmbCutQ.Click
        txtSQL = "Update TranDataH_PM "
        txtSQL = txtSQL & "Set TranDataH_PM.Trh_Chk_Print = 1  "

        txtSQL = txtSQL & "Where Trh_type='M' "
        txtSQL = txtSQL & "And Trh_No ='" & lbItemDocNo.Text & "' "

        DBtools.dbSaveDATA(txtSQL, "")
        Call showData("")

    End Sub
    Sub runSetQTime()

        Dim lvi0 As ListViewItem
        Dim anyData() As String
        Dim icount As Integer = 0
        Dim strSection As String : Dim strDocNo As String : Dim strDocDate As String
        Dim strStkCode As String : Dim strStkName As String
        Dim strCryCleTime As String : Dim strQty As String
        Dim strWeight As String
        Dim intCount As Integer = lsvPlan_E1.Items.Count
        Dim i As Integer = 0

        lbCountList.Text = intCount
        Do While lsvPlan_E1.Items.Count > 0
            lbCountList.Text = lsvPlan_E1.Items.Count
            'For i = 0 To lsvPlan_E1.Items.Count - 1
            i = 0
            'lbDocNo_E1.Text = lsvPlan_E1.Items(i).SubItems(1).Text
            'lbDate_E1.Text = lsvPlan_E1.Items(i).SubItems(2).Text
            '===============================================
            lvi0 = lsvPlan_E1.Items(i) 'lsvPlan_E1.SelectedItems(i)  ' Item ที่เลือก
            icount = icount + 1
            strDocNo = lsvPlan_E1.Items(lvi0.Index).SubItems(3).Text
            strDocDate = lsvPlan_E1.Items(lvi0.Index).SubItems(1).Text
            strSection = lsvPlan_E1.Items(lvi0.Index).SubItems(2).Text
            strStkCode = lsvPlan_E1.Items(lvi0.Index).SubItems(4).Text
            strStkName = lsvPlan_E1.Items(lvi0.Index).SubItems(5).Text

            If strStkCode = "" Then
                txtSQL = "Select * "
                txtSQL = txtSQL & "From BaseMast "
                txtSQL = txtSQL & "Where Stk_PC_Name like '" & strStkName & "'"
                subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDa.Fill(subDs, "chkName")
                If subDs.Tables("chkName").Rows.Count > 0 Then
                    If IsDBNull(subDs.Tables("chkName").Rows(0).Item("Stk_Code")) Then
                        strStkCode = ""
                    Else
                        strStkCode = subDs.Tables("chkName").Rows(0).Item("Stk_Code")
                    End If
                Else
                    strStkCode = ""
                End If
            End If
            strCryCleTime = lsvPlan_E1.Items(lvi0.Index).SubItems(6).Text
            strQty = lsvPlan_E1.Items(lvi0.Index).SubItems(7).Text
            strWeight = lsvPlan_E1.Items(lvi0.Index).SubItems(8).Text
            '===========  ลบข้อมูลใน List ที่เลือก
            lsvPlan_E1.Items.Remove(lvi0)
            lsvPlan_E1.Refresh()
            'Exit For
            'dblTotalTime = strCryCleTime + dblTotalTime
            'dblTotalQty = strQty + dblTotalQty
            'dblTotalWeight = strWeight + dblTotalWeight

            '=========== เพิ่มข้อมูลใน List ใหม่
            anyData = New String() {icount, strDocNo, strStkCode, strStkName, strCryCleTime, strQty, strWeight, strSection, strDocDate}
            lvi0 = New ListViewItem(anyData)
            lsvPlan_M.Items.Add(lvi0)
            lsvPlan_M.Refresh()

            '===============================================
            lbCounter1.Text = i + 1
            'For p = 0 To 10
            '    p = p + 1
            '    Me.Refresh()
            'Next
            'If i = 3 Then
            '    Exit For

            'End If

            ' Next
        Loop
        Call saveData()

        Call showData1()
        Call showData(selDocNo)
        'For i = 0 To lsvPlan_M.Items.Count - 1
        '    iCount = i + 1
        'Next
    End Sub


    Sub saveData()

        Dim lvi0 As ListViewItem
        Dim strDocNo As String = ""
        Dim StrDocNo2 As String = selDocNo
        Dim strDocDate As String '= ((((Year(Now) - 543 & "-" & Month(Now) & "-" & DateAndTime.Day(Now)))).ToString)
        Dim strStkCode As String = ""
        Dim strStkName As String = ""
        Dim strCryCleTime As Double = 0
        Dim strQty As Integer = 0
        Dim strWeight As Double = 0
        Dim intRuning As Integer = 0
        Dim iCount As Integer = 0
        Dim strTrhKeyType As String = ""
        'Try
        lsvPlan_M.Refresh()
        Dim intCountRow As Integer
        If lsvPlan_M.Items.Count - 1 > 0 Then
            intCountRow = lsvPlan_M.Items.Count - 1
        End If


        For i = 0 To intCountRow

            lvi0 = lsvPlan_M.Items(i)
            iCount = i + 1
            strDocNo = lsvPlan_M.Items(i).SubItems(1).Text
            strStkCode = lsvPlan_M.Items(i).SubItems(2).Text
            strStkName = lsvPlan_M.Items(i).SubItems(3).Text
            strCryCleTime = lsvPlan_M.Items(i).SubItems(4).Text
            strQty = lsvPlan_M.Items(i).SubItems(5).Text
            strWeight = lsvPlan_M.Items(i).SubItems(6).Text
            strTrhKeyType = lsvPlan_M.Items(i).SubItems(7).Text

            strDocDate = (lsvPlan_M.Items(i).SubItems(8).Text)
            'strDocDate = strToDate(strDocDate)
            'Exit Sub
            'If strDocNo = "21819KB" Then
            '    MsgBox("21819kb")
            'End If

            delTranDataPM(strDocNo)

            '==============  จุดสำคัญ ========================
            saveTranDataH(strDocNo, strDocDate, strCryCleTime, StrDocNo2, iCount, strTrhKeyType)
            saveTranDataD(strDocNo, strDocDate, iCount, strStkCode, strStkName, strQty, strWeight, StrDocNo2)
            ' lsvPlan_M.Items.Remove(lvi0)
            i_Item.Text = i + 1
            lbItemDocNo.Text = strDocNo

            Me.Refresh()
        Next

        'Catch ex As Exception

        '    MsgBox("พบข้อผิดพลาด โปรดแจ้งผู้จัดการฝ่าย หรือ ICT ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End Try
    End Sub
    Sub delTranDataPM(strDocNo As String)

        txtSQL = "Delete TranDataD_PM "
        txtSQL = txtSQL & "Where Dtl_No='" & strDocNo & "' "
        DBtools.dbSaveDATA(txtSQL, "")
        txtSQL = ""

        txtSQL = "Delete TranDataH_PM "
        txtSQL = txtSQL & "Where Trh_No='" & strDocNo & "' "
        DBtools.dbSaveDATA(txtSQL, "")
        txtSQL = ""

    End Sub
    Sub saveTranDataH(ByVal trhNO As String, ByVal docDate As String, CycleTime As Double, trhNo2 As String, running As Integer, strKeyType As String)
        ' docDate = Format(DateAdd(DateInterval.Year, -543, CDate(docDate)), "dd/MM/yyyy HH:mm:ss")
        If getDocNumberH_PM(trhNO) = True Then

            'txtSQL = "Update TranDataH_PM "
            'txtSQL = txtSQL & "Set Trh_Date='" & docDate & "',"
            'txtSQL = txtSQL & "Where trh_type='M' "
            'txtSQL = txtSQL & "And trh_No='" & trhNO & "' "

            'DBtools.dbSaveSQLsrv(txtSQL, "")

        Else
            '  ใช้เพิ่มข้อมูลส่วนหัวเอกสารรับผลิต

            txtSQL = "Insert into TranDataH_PM(Trh_Type,Trh_KeyType,trh_NO,Trh_Cre_Lim,"
            txtSQL = txtSQL & "Trh_Date,Trh_Detail,Trh_RunID,Trh_Chk_Print)"
            txtSQL = txtSQL & "Values('M','" & strKeyType & "','" & trhNO & "','" & CycleTime & "',"
            txtSQL = txtSQL & "'" & strToDate2(docDate) & "','" & trhNo2 & "','" & running & "','0')"
            DBtools.dbSaveDATA(txtSQL, "")
            txtSQL = ""

            txtSQL = "Update TranDataH_E set Trh_Print=1 "
            txtSQL = txtSQL & "Where Trh_No='" & trhNO & "' "
            txtSQL = txtSQL & "And Trh_Type='E' "
            DBtools.dbSaveDATA(txtSQL, "")
        End If

    End Sub

    Sub saveTranDataD(ByVal dtlNO As String, ByVal docDate As String, running As Integer, ByVal stkCode As String, stkName As String, ByVal stkQty As Double, ByVal stkQty2 As Double, strDocNo2 As String)

        'Dim stkSumPrice As Double
        'Dim runNumber As Integer

        Dim docDate2 As String ' = docDate 'Format(DateAdd(DateInterval.Year, -543, CDate(docDate)), "MM/dd/yyyy HH:mm:ss")
        'Dim intYear As Integer = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(docDate, 11), 4)
        'Dim intYearNow As Integer = Year(Now)

        'If intYear = intYearNow Then

        'Else
        '    'docDate2 = Format(DateAdd(DateInterval.Year, -543, CDate(docDate)), "dd/MM/yyyy HH:mm:ss")
        '    docDate2 = strToDate(docDate)
        'End If

        docDate2 = strToDate2(docDate)
        If getDocNumberD_PM(dtlNO) = False Then

            txtSQL = "Insert into TranDataD_PM(Dtl_Type,Dtl_Date,Dtl_No,"
            txtSQL = txtSQL & "Dtl_idTrade,DtL_N_Trade,dtl_num,dtl_num_2,"
            txtSQL = txtSQL & "Dtl_runnum,Dtl_Detail"
            txtSQL = txtSQL & ") "

            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'M','" & docDate2 & "','" & dtlNO & "',"
            txtSQL = txtSQL & "'" & stkCode & "','" & stkName & "'," & stkQty & "," & stkQty2 & ","
            txtSQL = txtSQL & "'" & running & "','" & strDocNo2 & "' "
            txtSQL = txtSQL & ")"

            DBtools.dbSaveDATA(txtSQL, "")
            txtSQL = ""

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim intCountLsv As Integer = lsvPlan_E1.Items.Count
        lbCountList.Text = intCountLsv

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub lsvPlan_M_TextChanged(sender As Object, e As EventArgs) Handles lsvPlan_M.TextChanged

    End Sub

    Private Sub cmbRun_Click(sender As Object, e As EventArgs) Handles cmbRun.Click
        runSetQTime()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTimer.Text = lbTimer.Text + 1
        If lbTimer.Text = 5 Then
            runSetQTime()
            lbTimer.Text = 1
            Me.Close()
        End If

    End Sub
End Class
