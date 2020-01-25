<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lsvPlan_E1 = New System.Windows.Forms.ListView()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotalWeight = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotalCrycleTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotalQty = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbHH0 = New System.Windows.Forms.Label()
        Me.chkByStkName = New System.Windows.Forms.RadioButton()
        Me.chkByDoc = New System.Windows.Forms.RadioButton()
        Me.txtDate02 = New System.Windows.Forms.DateTimePicker()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbCrycleTime_M = New System.Windows.Forms.Label()
        Me.lbWeight_M = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lbItem = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbHH_M = New System.Windows.Forms.Label()
        Me.lbQty_M = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbTotalTimeM = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbDocNo = New System.Windows.Forms.Label()
        Me.lsvPlan_M = New System.Windows.Forms.ListView()
        Me.cmbReload = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.i_Item = New System.Windows.Forms.Label()
        Me.cmbUp = New System.Windows.Forms.Button()
        Me.cmbDown = New System.Windows.Forms.Button()
        Me.lsvPlan_E0 = New System.Windows.Forms.ListView()
        Me.cmbCutQ = New System.Windows.Forms.Button()
        Me.indexBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbDocNo_E1 = New System.Windows.Forms.Label()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.lbCounter1 = New System.Windows.Forms.Label()
        Me.lbDate_E1 = New System.Windows.Forms.Label()
        Me.lbCountList = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbStkCode = New System.Windows.Forms.Label()
        Me.lbItemDocNo = New System.Windows.Forms.TextBox()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTimer = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvPlan_E1
        '
        Me.lsvPlan_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvPlan_E1.FullRowSelect = True
        Me.lsvPlan_E1.HideSelection = False
        Me.lsvPlan_E1.Location = New System.Drawing.Point(5, 5)
        Me.lsvPlan_E1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lsvPlan_E1.Name = "lsvPlan_E1"
        Me.lsvPlan_E1.Size = New System.Drawing.Size(652, 387)
        Me.lsvPlan_E1.TabIndex = 0
        Me.lsvPlan_E1.UseCompatibleStateImageBehavior = False
        '
        'txtDate01
        '
        Me.txtDate01.Enabled = False
        Me.txtDate01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate01.Location = New System.Drawing.Point(188, 12)
        Me.txtDate01.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(181, 26)
        Me.txtDate01.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "น้ำหนัก"
        '
        'lbTotalWeight
        '
        Me.lbTotalWeight.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalWeight.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTotalWeight.Location = New System.Drawing.Point(464, 14)
        Me.lbTotalWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalWeight.Name = "lbTotalWeight"
        Me.lbTotalWeight.Size = New System.Drawing.Size(152, 27)
        Me.lbTotalWeight.TabIndex = 4
        Me.lbTotalWeight.Text = "0"
        Me.lbTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(620, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kg."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "นาที"
        '
        'lbTotalCrycleTime
        '
        Me.lbTotalCrycleTime.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbTotalCrycleTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalCrycleTime.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTotalCrycleTime.Location = New System.Drawing.Point(246, 14)
        Me.lbTotalCrycleTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalCrycleTime.Name = "lbTotalCrycleTime"
        Me.lbTotalCrycleTime.Size = New System.Drawing.Size(110, 27)
        Me.lbTotalCrycleTime.TabIndex = 7
        Me.lbTotalCrycleTime.Text = "น้ำหนัก"
        Me.lbTotalCrycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "เวลา"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "แผ่น"
        '
        'lbTotalQty
        '
        Me.lbTotalQty.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalQty.ForeColor = System.Drawing.SystemColors.Control
        Me.lbTotalQty.Location = New System.Drawing.Point(464, 49)
        Me.lbTotalQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(152, 27)
        Me.lbTotalQty.TabIndex = 10
        Me.lbTotalQty.Text = "0"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(425, 54)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "แผ่น"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.lbHH0)
        Me.GroupBox1.Controls.Add(Me.chkByStkName)
        Me.GroupBox1.Controls.Add(Me.chkByDoc)
        Me.GroupBox1.Controls.Add(Me.lbTotalWeight)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbTotalQty)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbTotalCrycleTime)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 620)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(660, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(208, 54)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 20)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "เวลา"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(368, 54)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 20)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "ชั่วโมง"
        '
        'lbHH0
        '
        Me.lbHH0.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbHH0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHH0.ForeColor = System.Drawing.SystemColors.Control
        Me.lbHH0.Location = New System.Drawing.Point(246, 49)
        Me.lbHH0.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbHH0.Name = "lbHH0"
        Me.lbHH0.Size = New System.Drawing.Size(110, 27)
        Me.lbHH0.TabIndex = 15
        Me.lbHH0.Text = "น้ำหนัก"
        Me.lbHH0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkByStkName
        '
        Me.chkByStkName.AutoSize = True
        Me.chkByStkName.Enabled = False
        Me.chkByStkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkByStkName.Location = New System.Drawing.Point(17, 52)
        Me.chkByStkName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkByStkName.Name = "chkByStkName"
        Me.chkByStkName.Size = New System.Drawing.Size(111, 24)
        Me.chkByStkName.TabIndex = 13
        Me.chkByStkName.TabStop = True
        Me.chkByStkName.Text = "ตามชื่อชุดงาน"
        Me.chkByStkName.UseVisualStyleBackColor = True
        '
        'chkByDoc
        '
        Me.chkByDoc.AutoSize = True
        Me.chkByDoc.Checked = True
        Me.chkByDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkByDoc.Location = New System.Drawing.Point(17, 24)
        Me.chkByDoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkByDoc.Name = "chkByDoc"
        Me.chkByDoc.Size = New System.Drawing.Size(86, 24)
        Me.chkByDoc.TabIndex = 12
        Me.chkByDoc.TabStop = True
        Me.chkByDoc.Text = "ตามเลขที่"
        Me.chkByDoc.UseVisualStyleBackColor = True
        '
        'txtDate02
        '
        Me.txtDate02.Enabled = False
        Me.txtDate02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate02.Location = New System.Drawing.Point(397, 12)
        Me.txtDate02.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDate02.Name = "txtDate02"
        Me.txtDate02.Size = New System.Drawing.Size(181, 26)
        Me.txtDate02.TabIndex = 13
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdRun.ForeColor = System.Drawing.Color.White
        Me.cmdRun.Location = New System.Drawing.Point(590, 10)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(76, 31)
        Me.cmdRun.TabIndex = 14
        Me.cmdRun.Text = "Update"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbCrycleTime_M)
        Me.GroupBox2.Controls.Add(Me.lbWeight_M)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.lbItem)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lbHH_M)
        Me.GroupBox2.Controls.Add(Me.lbQty_M)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lbTotalTimeM)
        Me.GroupBox2.Location = New System.Drawing.Point(731, 521)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(658, 141)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "เวลาเฉลีย"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 89)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "นาที/แผ่น"
        '
        'lbCrycleTime_M
        '
        Me.lbCrycleTime_M.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbCrycleTime_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCrycleTime_M.ForeColor = System.Drawing.Color.Black
        Me.lbCrycleTime_M.Location = New System.Drawing.Point(246, 85)
        Me.lbCrycleTime_M.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCrycleTime_M.Name = "lbCrycleTime_M"
        Me.lbCrycleTime_M.Size = New System.Drawing.Size(110, 27)
        Me.lbCrycleTime_M.TabIndex = 19
        Me.lbCrycleTime_M.Text = "0"
        Me.lbCrycleTime_M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbWeight_M
        '
        Me.lbWeight_M.BackColor = System.Drawing.Color.DarkGreen
        Me.lbWeight_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWeight_M.ForeColor = System.Drawing.Color.White
        Me.lbWeight_M.Location = New System.Drawing.Point(464, 49)
        Me.lbWeight_M.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWeight_M.Name = "lbWeight_M"
        Me.lbWeight_M.Size = New System.Drawing.Size(152, 27)
        Me.lbWeight_M.TabIndex = 10
        Me.lbWeight_M.Text = "0"
        Me.lbWeight_M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Yellow
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Black
        Me.cmdSave.Location = New System.Drawing.Point(462, 85)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 38)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "บันทึก/ออก"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lbItem
        '
        Me.lbItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItem.ForeColor = System.Drawing.Color.Black
        Me.lbItem.Location = New System.Drawing.Point(53, 15)
        Me.lbItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbItem.Name = "lbItem"
        Me.lbItem.Size = New System.Drawing.Size(110, 27)
        Me.lbItem.TabIndex = 17
        Me.lbItem.Text = "0"
        Me.lbItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(208, 54)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 20)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "เวลา"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(360, 54)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 20)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "ชั่วโมง"
        '
        'lbHH_M
        '
        Me.lbHH_M.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbHH_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHH_M.ForeColor = System.Drawing.Color.Black
        Me.lbHH_M.Location = New System.Drawing.Point(246, 49)
        Me.lbHH_M.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbHH_M.Name = "lbHH_M"
        Me.lbHH_M.Size = New System.Drawing.Size(110, 27)
        Me.lbHH_M.TabIndex = 15
        Me.lbHH_M.Text = "0"
        Me.lbHH_M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty_M
        '
        Me.lbQty_M.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbQty_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty_M.ForeColor = System.Drawing.Color.Black
        Me.lbQty_M.Location = New System.Drawing.Point(464, 14)
        Me.lbQty_M.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty_M.Name = "lbQty_M"
        Me.lbQty_M.Size = New System.Drawing.Size(152, 27)
        Me.lbQty_M.TabIndex = 4
        Me.lbQty_M.Text = "0"
        Me.lbQty_M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(618, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "แผ่น"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(414, 54)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "น้ำหนัก"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(621, 54)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Kg."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(425, 18)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "แผ่น"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(208, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "เวลา"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 18)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "นาที"
        '
        'lbTotalTimeM
        '
        Me.lbTotalTimeM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbTotalTimeM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalTimeM.ForeColor = System.Drawing.Color.Black
        Me.lbTotalTimeM.Location = New System.Drawing.Point(246, 14)
        Me.lbTotalTimeM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalTimeM.Name = "lbTotalTimeM"
        Me.lbTotalTimeM.Size = New System.Drawing.Size(110, 27)
        Me.lbTotalTimeM.TabIndex = 7
        Me.lbTotalTimeM.Text = "0"
        Me.lbTotalTimeM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Maroon
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(1223, 666)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(149, 47)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1089, 16)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "คิวงานเลขที่"
        '
        'lbDocNo
        '
        Me.lbDocNo.BackColor = System.Drawing.Color.Blue
        Me.lbDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDocNo.ForeColor = System.Drawing.Color.Yellow
        Me.lbDocNo.Location = New System.Drawing.Point(1175, 8)
        Me.lbDocNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDocNo.Name = "lbDocNo"
        Me.lbDocNo.Size = New System.Drawing.Size(174, 32)
        Me.lbDocNo.TabIndex = 22
        Me.lbDocNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lsvPlan_M
        '
        Me.lsvPlan_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvPlan_M.FullRowSelect = True
        Me.lsvPlan_M.HideSelection = False
        Me.lsvPlan_M.Location = New System.Drawing.Point(701, 46)
        Me.lsvPlan_M.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lsvPlan_M.Name = "lsvPlan_M"
        Me.lsvPlan_M.Size = New System.Drawing.Size(688, 401)
        Me.lsvPlan_M.TabIndex = 1
        Me.lsvPlan_M.UseCompatibleStateImageBehavior = False
        '
        'cmbReload
        '
        Me.cmbReload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReload.ForeColor = System.Drawing.Color.White
        Me.cmbReload.Location = New System.Drawing.Point(1090, 665)
        Me.cmbReload.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbReload.Name = "cmbReload"
        Me.cmbReload.Size = New System.Drawing.Size(127, 48)
        Me.cmbReload.TabIndex = 21
        Me.cmbReload.Text = "reload"
        Me.cmbReload.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(721, 462)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "ลำดับ"
        '
        'i_Item
        '
        Me.i_Item.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.i_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.i_Item.ForeColor = System.Drawing.Color.Black
        Me.i_Item.Location = New System.Drawing.Point(784, 455)
        Me.i_Item.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.i_Item.Name = "i_Item"
        Me.i_Item.Size = New System.Drawing.Size(110, 27)
        Me.i_Item.TabIndex = 21
        Me.i_Item.Text = "0"
        Me.i_Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbUp
        '
        Me.cmbUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbUp.Location = New System.Drawing.Point(1045, 455)
        Me.cmbUp.Name = "cmbUp"
        Me.cmbUp.Size = New System.Drawing.Size(48, 27)
        Me.cmbUp.TabIndex = 24
        Me.cmbUp.Text = "ขึ้น"
        Me.cmbUp.UseVisualStyleBackColor = False
        '
        'cmbDown
        '
        Me.cmbDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDown.ForeColor = System.Drawing.Color.White
        Me.cmbDown.Location = New System.Drawing.Point(1107, 455)
        Me.cmbDown.Name = "cmbDown"
        Me.cmbDown.Size = New System.Drawing.Size(48, 27)
        Me.cmbDown.TabIndex = 25
        Me.cmbDown.Text = "ลง"
        Me.cmbDown.UseVisualStyleBackColor = False
        '
        'lsvPlan_E0
        '
        Me.lsvPlan_E0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvPlan_E0.FullRowSelect = True
        Me.lsvPlan_E0.HideSelection = False
        Me.lsvPlan_E0.Location = New System.Drawing.Point(10, 5)
        Me.lsvPlan_E0.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lsvPlan_E0.Name = "lsvPlan_E0"
        Me.lsvPlan_E0.Size = New System.Drawing.Size(657, 130)
        Me.lsvPlan_E0.TabIndex = 26
        Me.lsvPlan_E0.UseCompatibleStateImageBehavior = False
        '
        'cmbCutQ
        '
        Me.cmbCutQ.BackColor = System.Drawing.Color.Yellow
        Me.cmbCutQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCutQ.Location = New System.Drawing.Point(1175, 455)
        Me.cmbCutQ.Name = "cmbCutQ"
        Me.cmbCutQ.Size = New System.Drawing.Size(77, 27)
        Me.cmbCutQ.TabIndex = 28
        Me.cmbCutQ.Text = "ผลิตแล้ว"
        Me.cmbCutQ.UseVisualStyleBackColor = False
        '
        'indexBar1
        '
        Me.indexBar1.Location = New System.Drawing.Point(725, 667)
        Me.indexBar1.Name = "indexBar1"
        Me.indexBar1.Size = New System.Drawing.Size(351, 28)
        Me.indexBar1.TabIndex = 29
        '
        'lbDocNo_E1
        '
        Me.lbDocNo_E1.BackColor = System.Drawing.Color.Black
        Me.lbDocNo_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDocNo_E1.ForeColor = System.Drawing.Color.Yellow
        Me.lbDocNo_E1.Location = New System.Drawing.Point(144, 452)
        Me.lbDocNo_E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDocNo_E1.Name = "lbDocNo_E1"
        Me.lbDocNo_E1.Size = New System.Drawing.Size(208, 32)
        Me.lbDocNo_E1.TabIndex = 30
        Me.lbDocNo_E1.Text = "Label17"
        Me.lbDocNo_E1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbRun
        '
        Me.cmbRun.Location = New System.Drawing.Point(373, 452)
        Me.cmbRun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(136, 36)
        Me.cmbRun.TabIndex = 31
        Me.cmbRun.Text = "RUN"
        Me.cmbRun.UseVisualStyleBackColor = True
        '
        'lbCounter1
        '
        Me.lbCounter1.BackColor = System.Drawing.Color.Black
        Me.lbCounter1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCounter1.ForeColor = System.Drawing.Color.Yellow
        Me.lbCounter1.Location = New System.Drawing.Point(144, 538)
        Me.lbCounter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCounter1.Name = "lbCounter1"
        Me.lbCounter1.Size = New System.Drawing.Size(208, 32)
        Me.lbCounter1.TabIndex = 32
        Me.lbCounter1.Text = "Label17"
        Me.lbCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDate_E1
        '
        Me.lbDate_E1.BackColor = System.Drawing.Color.Black
        Me.lbDate_E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate_E1.ForeColor = System.Drawing.Color.Yellow
        Me.lbDate_E1.Location = New System.Drawing.Point(144, 493)
        Me.lbDate_E1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDate_E1.Name = "lbDate_E1"
        Me.lbDate_E1.Size = New System.Drawing.Size(208, 32)
        Me.lbDate_E1.TabIndex = 33
        Me.lbDate_E1.Text = "Label17"
        Me.lbDate_E1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCountList
        '
        Me.lbCountList.BackColor = System.Drawing.Color.Black
        Me.lbCountList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCountList.ForeColor = System.Drawing.Color.Yellow
        Me.lbCountList.Location = New System.Drawing.Point(144, 580)
        Me.lbCountList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCountList.Name = "lbCountList"
        Me.lbCountList.Size = New System.Drawing.Size(208, 32)
        Me.lbCountList.TabIndex = 34
        Me.lbCountList.Text = "Label17"
        Me.lbCountList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(373, 580)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 36)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "นับ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 588)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 20)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "จำนวนข้อมูลใน List"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 43)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(689, 404)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lsvPlan_E1)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(662, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsvPlan_E0)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(662, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbStkCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.Color.Black
        Me.lbStkCode.Location = New System.Drawing.Point(784, 492)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(255, 27)
        Me.lbStkCode.TabIndex = 39
        Me.lbStkCode.Text = "0"
        Me.lbStkCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbItemDocNo
        '
        Me.lbItemDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbItemDocNo.Location = New System.Drawing.Point(899, 455)
        Me.lbItemDocNo.Name = "lbItemDocNo"
        Me.lbItemDocNo.Size = New System.Drawing.Size(140, 26)
        Me.lbItemDocNo.TabIndex = 40
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbStkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStkName.ForeColor = System.Drawing.Color.Black
        Me.lbStkName.Location = New System.Drawing.Point(1043, 492)
        Me.lbStkName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(255, 27)
        Me.lbStkName.TabIndex = 41
        Me.lbStkName.Text = "0"
        Me.lbStkName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbTimer
        '
        Me.lbTimer.Location = New System.Drawing.Point(31, 465)
        Me.lbTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTimer.Name = "lbTimer"
        Me.lbTimer.Size = New System.Drawing.Size(46, 28)
        Me.lbTimer.TabIndex = 42
        Me.lbTimer.Text = "1"
        '
        'frmSetTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1411, 736)
        Me.Controls.Add(Me.lbTimer)
        Me.Controls.Add(Me.lbStkName)
        Me.Controls.Add(Me.lbItemDocNo)
        Me.Controls.Add(Me.lbStkCode)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbCountList)
        Me.Controls.Add(Me.lbDate_E1)
        Me.Controls.Add(Me.lbCounter1)
        Me.Controls.Add(Me.cmbRun)
        Me.Controls.Add(Me.lbDocNo_E1)
        Me.Controls.Add(Me.indexBar1)
        Me.Controls.Add(Me.cmbCutQ)
        Me.Controls.Add(Me.cmbDown)
        Me.Controls.Add(Me.cmbUp)
        Me.Controls.Add(Me.i_Item)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmbReload)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbDocNo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.txtDate02)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDate01)
        Me.Controls.Add(Me.lsvPlan_M)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSetTime"
        Me.Text = "กำหนดแผนการผลิต"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvPlan_E1 As ListView
    Friend WithEvents txtDate01 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotalWeight As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTotalCrycleTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbTotalQty As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDate02 As DateTimePicker
    Friend WithEvents cmdRun As Button
    Friend WithEvents chkByStkName As RadioButton
    Friend WithEvents chkByDoc As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbQty_M As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbWeight_M As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbTotalTimeM As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbDocNo As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbHH_M As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbHH0 As Label
    Friend WithEvents lbItem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbCrycleTime_M As Label
    Friend WithEvents lsvPlan_M As ListView
    Friend WithEvents cmbReload As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents i_Item As Label
    Friend WithEvents cmbUp As Button
    Friend WithEvents cmbDown As Button
    Friend WithEvents lsvPlan_E0 As ListView
    Friend WithEvents cmbCutQ As Button
    Friend WithEvents indexBar1 As ProgressBar
    Friend WithEvents lbDocNo_E1 As Label
    Friend WithEvents cmbRun As Button
    Friend WithEvents lbCounter1 As Label
    Friend WithEvents lbDate_E1 As Label
    Friend WithEvents lbCountList As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbStkCode As Label
    Friend WithEvents lbItemDocNo As TextBox
    Friend WithEvents lbStkName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbTimer As Label
End Class
