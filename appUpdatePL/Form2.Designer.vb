<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbFileName2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 101)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(69, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(288, 118)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(417, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "test  ทดสอบ การใช้งาน"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(759, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(554, 46)
        Me.TextBox1.TabIndex = 3
        '
        'lbFileName2
        '
        Me.lbFileName2.BackColor = System.Drawing.Color.DarkKhaki
        Me.lbFileName2.Location = New System.Drawing.Point(238, 415)
        Me.lbFileName2.Name = "lbFileName2"
        Me.lbFileName2.Size = New System.Drawing.Size(806, 54)
        Me.lbFileName2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 39)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "File Name"
        '
        'lbFileName
        '
        Me.lbFileName.BackColor = System.Drawing.Color.Tan
        Me.lbFileName.Location = New System.Drawing.Point(238, 349)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(806, 54)
        Me.lbFileName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 39)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "File Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 39)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "test  ทดสอบ การใช้งาน"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(759, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(553, 62)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2409, 1014)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbFileName2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbFileName2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbFileName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
