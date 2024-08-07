Public Class frmWageCalculator

    Dim hourlyWage As Double
    Dim weeklyHours As Double
    Dim regHours As Integer = 40
    Dim grossEarnings As Double
    Dim taxRate As Decimal = 0.15
    Dim overTimeHours As Decimal
    Dim fwt As Decimal
    Dim netEarnings As Decimal


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        hourlyWage = Double.Parse(txtHourlyWage.Text)
        weeklyHours = Double.Parse(txtWeeklyHours.Text)

        If weeklyHours <= 40 Then
            regHours = weeklyHours
            overTimeHours = 0


        Else
            regHours = 40
            overTimeHours = weeklyHours - regHours

        End If

        'Computation
        grossEarnings = (hourlyWage * regHours) + (overTimeHours * 1.5 * hourlyWage)
        fwt = grossEarnings * taxRate
        netEarnings = grossEarnings - fwt

        'Displaying the output
        txtGrossEarnings.Text = grossEarnings.ToString("0.00")
        txtLessFWT.Text = fwt.ToString("0.00")
        txtNetEarnings.Text = netEarnings.ToString("0.00")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossEarnings.Clear()
        txtHourlyWage.Clear()
        txtLessFWT.Clear()
        txtNetEarnings.Clear()
        txtWeeklyHours.Clear()
    End Sub
End Class
