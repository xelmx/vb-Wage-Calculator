<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWageCalculator
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
        Me.lblHourlyWage = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.txtWeeklyHours = New System.Windows.Forms.TextBox()
        Me.lblWeeklyHours = New System.Windows.Forms.Label()
        Me.txtGrossEarnings = New System.Windows.Forms.TextBox()
        Me.lblGrossEarnings = New System.Windows.Forms.Label()
        Me.txtLessFWT = New System.Windows.Forms.TextBox()
        Me.lblLessFWT = New System.Windows.Forms.Label()
        Me.txtNetEarnings = New System.Windows.Forms.TextBox()
        Me.lblNetEarnings = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHourlyWage
        '
        Me.lblHourlyWage.AutoSize = True
        Me.lblHourlyWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyWage.Location = New System.Drawing.Point(52, 56)
        Me.lblHourlyWage.Name = "lblHourlyWage"
        Me.lblHourlyWage.Size = New System.Drawing.Size(80, 15)
        Me.lblHourlyWage.TabIndex = 0
        Me.lblHourlyWage.Text = "Hourly Wage:"
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourlyWage.Location = New System.Drawing.Point(169, 53)
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(97, 21)
        Me.txtHourlyWage.TabIndex = 1
        '
        'txtWeeklyHours
        '
        Me.txtWeeklyHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeeklyHours.Location = New System.Drawing.Point(169, 89)
        Me.txtWeeklyHours.Name = "txtWeeklyHours"
        Me.txtWeeklyHours.Size = New System.Drawing.Size(97, 21)
        Me.txtWeeklyHours.TabIndex = 3
        '
        'lblWeeklyHours
        '
        Me.lblWeeklyHours.AutoSize = True
        Me.lblWeeklyHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklyHours.Location = New System.Drawing.Point(52, 92)
        Me.lblWeeklyHours.Name = "lblWeeklyHours"
        Me.lblWeeklyHours.Size = New System.Drawing.Size(85, 15)
        Me.lblWeeklyHours.TabIndex = 2
        Me.lblWeeklyHours.Text = "Weekly Hours:"
        '
        'txtGrossEarnings
        '
        Me.txtGrossEarnings.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtGrossEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossEarnings.Location = New System.Drawing.Point(169, 141)
        Me.txtGrossEarnings.Name = "txtGrossEarnings"
        Me.txtGrossEarnings.ReadOnly = True
        Me.txtGrossEarnings.Size = New System.Drawing.Size(97, 21)
        Me.txtGrossEarnings.TabIndex = 5
        Me.txtGrossEarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrossEarnings
        '
        Me.lblGrossEarnings.AutoSize = True
        Me.lblGrossEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossEarnings.Location = New System.Drawing.Point(52, 144)
        Me.lblGrossEarnings.Name = "lblGrossEarnings"
        Me.lblGrossEarnings.Size = New System.Drawing.Size(94, 15)
        Me.lblGrossEarnings.TabIndex = 4
        Me.lblGrossEarnings.Text = "Gross Earnings:"
        '
        'txtLessFWT
        '
        Me.txtLessFWT.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLessFWT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLessFWT.Location = New System.Drawing.Point(169, 180)
        Me.txtLessFWT.Name = "txtLessFWT"
        Me.txtLessFWT.ReadOnly = True
        Me.txtLessFWT.Size = New System.Drawing.Size(97, 21)
        Me.txtLessFWT.TabIndex = 7
        Me.txtLessFWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLessFWT
        '
        Me.lblLessFWT.AutoSize = True
        Me.lblLessFWT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLessFWT.Location = New System.Drawing.Point(52, 183)
        Me.lblLessFWT.Name = "lblLessFWT"
        Me.lblLessFWT.Size = New System.Drawing.Size(64, 15)
        Me.lblLessFWT.TabIndex = 6
        Me.lblLessFWT.Text = "Less FWT:"
        '
        'txtNetEarnings
        '
        Me.txtNetEarnings.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNetEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetEarnings.Location = New System.Drawing.Point(169, 217)
        Me.txtNetEarnings.Name = "txtNetEarnings"
        Me.txtNetEarnings.ReadOnly = True
        Me.txtNetEarnings.Size = New System.Drawing.Size(97, 21)
        Me.txtNetEarnings.TabIndex = 9
        Me.txtNetEarnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNetEarnings
        '
        Me.lblNetEarnings.AutoSize = True
        Me.lblNetEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetEarnings.Location = New System.Drawing.Point(52, 220)
        Me.lblNetEarnings.Name = "lblNetEarnings"
        Me.lblNetEarnings.Size = New System.Drawing.Size(81, 15)
        Me.lblNetEarnings.TabIndex = 8
        Me.lblNetEarnings.Text = "Net Earnings:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(55, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 27)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(149, 280)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(117, 27)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmWageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 342)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtNetEarnings)
        Me.Controls.Add(Me.lblNetEarnings)
        Me.Controls.Add(Me.txtLessFWT)
        Me.Controls.Add(Me.lblLessFWT)
        Me.Controls.Add(Me.txtGrossEarnings)
        Me.Controls.Add(Me.lblGrossEarnings)
        Me.Controls.Add(Me.txtWeeklyHours)
        Me.Controls.Add(Me.lblWeeklyHours)
        Me.Controls.Add(Me.txtHourlyWage)
        Me.Controls.Add(Me.lblHourlyWage)
        Me.Name = "frmWageCalculator"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHourlyWage As Label
    Friend WithEvents txtHourlyWage As TextBox
    Friend WithEvents txtWeeklyHours As TextBox
    Friend WithEvents lblWeeklyHours As Label
    Friend WithEvents txtGrossEarnings As TextBox
    Friend WithEvents lblGrossEarnings As Label
    Friend WithEvents txtLessFWT As TextBox
    Friend WithEvents lblLessFWT As Label
    Friend WithEvents txtNetEarnings As TextBox
    Friend WithEvents lblNetEarnings As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
End Class
