<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbSheetType = New System.Windows.Forms.Label()
        Me.lbStkNameSA = New System.Windows.Forms.Label()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.lbQty0 = New System.Windows.Forms.Label()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbDocNo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbCondition = New System.Windows.Forms.Label()
        Me.lbIndex1 = New System.Windows.Forms.Label()
        Me.lbFileName3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbFileName2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFindFile = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbState = New System.Windows.Forms.Label()
        Me.lbDataBase = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(763, 20)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(109, 45)
        Me.cmdUpdate.TabIndex = 0
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.lbSheetType)
        Me.GroupBox1.Controls.Add(Me.lbStkNameSA)
        Me.GroupBox1.Controls.Add(Me.lbQty)
        Me.GroupBox1.Controls.Add(Me.lbQty0)
        Me.GroupBox1.Controls.Add(Me.lbStkName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbDocNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbCondition)
        Me.GroupBox1.Controls.Add(Me.lbIndex1)
        Me.GroupBox1.Controls.Add(Me.lbFileName3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.pBar1)
        Me.GroupBox1.Controls.Add(Me.lbFileName2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbFileName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdFindFile)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 315)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbSheetType
        '
        Me.lbSheetType.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbSheetType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSheetType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSheetType.Location = New System.Drawing.Point(228, 124)
        Me.lbSheetType.Name = "lbSheetType"
        Me.lbSheetType.Size = New System.Drawing.Size(130, 25)
        Me.lbSheetType.TabIndex = 22
        Me.lbSheetType.Text = "File Name3"
        '
        'lbStkNameSA
        '
        Me.lbStkNameSA.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbStkNameSA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkNameSA.ForeColor = System.Drawing.Color.Yellow
        Me.lbStkNameSA.Location = New System.Drawing.Point(75, 189)
        Me.lbStkNameSA.Name = "lbStkNameSA"
        Me.lbStkNameSA.Size = New System.Drawing.Size(528, 25)
        Me.lbStkNameSA.TabIndex = 21
        Me.lbStkNameSA.Text = "File Name3"
        '
        'lbQty
        '
        Me.lbQty.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbQty.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbQty.Location = New System.Drawing.Point(473, 159)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(130, 25)
        Me.lbQty.TabIndex = 19
        Me.lbQty.Text = "File Name3"
        '
        'lbQty0
        '
        Me.lbQty0.AutoSize = True
        Me.lbQty0.Location = New System.Drawing.Point(430, 170)
        Me.lbQty0.Name = "lbQty0"
        Me.lbQty0.Size = New System.Drawing.Size(86, 31)
        Me.lbQty0.TabIndex = 20
        Me.lbQty0.Text = "จำนวน"
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbStkName.Location = New System.Drawing.Point(75, 159)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(321, 25)
        Me.lbStkName.TabIndex = 17
        Me.lbStkName.Text = "File Name3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 31)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "รายการ"
        '
        'lbDocNo
        '
        Me.lbDocNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbDocNo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDocNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDocNo.Location = New System.Drawing.Point(75, 124)
        Me.lbDocNo.Name = "lbDocNo"
        Me.lbDocNo.Size = New System.Drawing.Size(130, 25)
        Me.lbDocNo.TabIndex = 15
        Me.lbDocNo.Text = "File Name3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 31)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "เลขที่ใบคุม"
        '
        'lbCondition
        '
        Me.lbCondition.BackColor = System.Drawing.Color.DarkTurquoise
        Me.lbCondition.Location = New System.Drawing.Point(74, 220)
        Me.lbCondition.Name = "lbCondition"
        Me.lbCondition.Size = New System.Drawing.Size(587, 26)
        Me.lbCondition.TabIndex = 14
        '
        'lbIndex1
        '
        Me.lbIndex1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbIndex1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbIndex1.ForeColor = System.Drawing.Color.Yellow
        Me.lbIndex1.Location = New System.Drawing.Point(667, 252)
        Me.lbIndex1.Name = "lbIndex1"
        Me.lbIndex1.Size = New System.Drawing.Size(73, 25)
        Me.lbIndex1.TabIndex = 13
        Me.lbIndex1.Text = "0"
        Me.lbIndex1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFileName3
        '
        Me.lbFileName3.BackColor = System.Drawing.Color.YellowGreen
        Me.lbFileName3.Location = New System.Drawing.Point(74, 88)
        Me.lbFileName3.Name = "lbFileName3"
        Me.lbFileName3.Size = New System.Drawing.Size(587, 26)
        Me.lbFileName3.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "File Name3"
        '
        'pBar1
        '
        Me.pBar1.Location = New System.Drawing.Point(74, 252)
        Me.pBar1.Name = "pBar1"
        Me.pBar1.Size = New System.Drawing.Size(587, 25)
        Me.pBar1.TabIndex = 9
        '
        'lbFileName2
        '
        Me.lbFileName2.BackColor = System.Drawing.Color.DarkKhaki
        Me.lbFileName2.Location = New System.Drawing.Point(74, 53)
        Me.lbFileName2.Name = "lbFileName2"
        Me.lbFileName2.Size = New System.Drawing.Size(587, 26)
        Me.lbFileName2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "File Name"
        '
        'lbFileName
        '
        Me.lbFileName.BackColor = System.Drawing.Color.Tan
        Me.lbFileName.Location = New System.Drawing.Point(74, 19)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(587, 26)
        Me.lbFileName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Name"
        '
        'cmdFindFile
        '
        Me.cmdFindFile.Location = New System.Drawing.Point(667, 17)
        Me.cmdFindFile.Name = "cmdFindFile"
        Me.cmdFindFile.Size = New System.Drawing.Size(61, 32)
        Me.cmdFindFile.TabIndex = 1
        Me.cmdFindFile.Text = "..."
        Me.cmdFindFile.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(763, 73)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(109, 52)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.Yellow
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTime.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTime.Location = New System.Drawing.Point(326, 299)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(179, 58)
        Me.txtTime.TabIndex = 3
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.Color.DarkOrange
        Me.lbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTime.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTime.Location = New System.Drawing.Point(85, 298)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(185, 34)
        Me.lbTime.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SET :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Time  :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(751, 354)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Update_Code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbState
        '
        Me.lbState.BackColor = System.Drawing.Color.YellowGreen
        Me.lbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbState.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbState.Location = New System.Drawing.Point(85, 335)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(787, 34)
        Me.lbState.TabIndex = 13
        '
        'lbDataBase
        '
        Me.lbDataBase.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDataBase.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDataBase.Location = New System.Drawing.Point(85, 372)
        Me.lbDataBase.Name = "lbDataBase"
        Me.lbDataBase.Size = New System.Drawing.Size(787, 34)
        Me.lbDataBase.TabIndex = 14
        '
        'frmUpdate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1605, 761)
        Me.Controls.Add(Me.lbDataBase)
        Me.Controls.Add(Me.lbState)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUpdate"
        Me.Text = "Update /24-11-58"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbFileName As System.Windows.Forms.Label
    Friend WithEvents cmdFindFile As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents lbTime As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbFileName2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbState As Label
    Friend WithEvents lbFileName3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbDataBase As System.Windows.Forms.Label
    Friend WithEvents lbIndex1 As System.Windows.Forms.Label
    Friend WithEvents lbCondition As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbDocNo As System.Windows.Forms.Label
    Friend WithEvents lbStkName As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents lbQty0 As System.Windows.Forms.Label
    Friend WithEvents lbStkNameSA As System.Windows.Forms.Label
    Friend WithEvents lbSheetType As System.Windows.Forms.Label
End Class
