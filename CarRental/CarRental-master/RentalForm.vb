'Logan Garcia
'RCET0265
'Car Rental

Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm
    Dim numofCustomer As Integer
    Dim totalDistance As Double
    Dim totalCost As Double
    Private Sub CarRentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Sub ResetAll()
        'Reset the displayed data
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        DistanceDrivenTextbox.Text = ""
        MileageChargeTextbox.Text = ""
        DayChargeTextbox.Text = ""
        MinusDiscountTextBox.Text = ""
        YouOweTextBox.Text = ""
        MilesRadioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False
        ClearButton.Enabled = False
        CalculateButton.Enabled = True

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Calculate the charge and display for the customers
        Dim testValid As Boolean
        testValid = True

        'Validate the info and calculate
        If NameTextBox.Text = "" Then
            MsgBox("Please enter the customer's name.")
            NameTextBox.Focus()
            testValid = False
        ElseIf AddressTextBox.Text = "" Then
            MsgBox("Please enter the customer's address.")
            AddressTextBox.Focus()
            testValid = False
        ElseIf CityTextBox.Text = "" Then
            MsgBox("Please enter the city that the customer lives in.")
            CityTextBox.Focus()
            testValid = False
        ElseIf StateTextBox.Text = "" Then
            MsgBox("Please enter the state that the customer lives in.")
            StateTextBox.Focus()
            testValid = False
        ElseIf ZipCodeTextBox.Text = "" Then
            MsgBox("Please enter the state that the customer lives in.")
            StateTextBox.Focus()
            testValid = False
        ElseIf BeginOdometerTextBox.Text = "" Then
            MsgBox("Please enter the Beginning Odometer Reading.")
            BeginOdometerTextBox.Focus()
            testValid = False
        ElseIf EndOdometerTextBox.Text = "" Then
            MsgBox("Please enter the Ending Odometer Reading.")
            EndOdometerTextBox.Focus()
            testValid = False
        ElseIf DaysTextBox.Text = "" Then
            MsgBox("Please enter the Number of Days.")
            DaysTextBox.Focus()
            testValid = False
        Else
            Try
                If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then

                    MsgBox("The Beginning Odometer Reading has to be smaller than the Ending Odometer Reading.")
                    BeginOdometerTextBox.Text = ""
                    EndOdometerTextBox.Text = ""
                    BeginOdometerTextBox.Focus()
                    testValid = False

                Else
                    testValid = True
                End If
            Catch ex As Exception

                MsgBox("Please enter a number in the Odometer Reading.")
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
                BeginOdometerTextBox.Focus()
                testValid = False

            End Try

            Try
                If CDec(DaysTextBox.Text) < 1 Then
                    MsgBox("Alert: The Number of Days must be greater than 0!")
                    DaysTextBox.Focus()
                    testValid = False
                ElseIf CDec(DaysTextBox.Text) > 45 Then
                    MsgBox("Alert: The Number of Days cannot be greater than 45.")
                    DaysTextBox.Focus()
                    testValid = False
                Else
                    testValid = True
                End If
            Catch ex As Exception

                MsgBox("Please enter a number in the Number of Days.")
                DaysTextBox.Text = ""
                DaysTextBox.Focus()
                testValid = False

            End Try
        End If

        Dim mileage As Decimal
        Dim dayCharge As Decimal
        Dim totalCharge As Decimal
        Dim totalDiscount As Decimal

        If testValid = True Then
            If MilesRadioButton.Checked = True Then

                mileage = CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)
                DistanceDrivenTextbox.Text = Math.Round(mileage, 2).ToString
                totalDistance += Math.Round(mileage, 2)
                MileageChargeTextbox.Text = "$" & Math.Round(MileageCharge(mileage), 2).ToString
                dayCharge = CDec(DaysTextBox.Text) * 15D
                DayChargeTextbox.Text = "$" & Math.Round(dayCharge, 2).ToString
                totalCharge = CDec(MileageChargeTextbox.Text) + CDec(DayChargeTextbox.Text)

                If Seniorcheckbox.Checked = True And AAAcheckbox.Checked = True Then
                    totalDiscount = totalCharge * 0.08D
                ElseIf Seniorcheckbox.Checked = True And AAAcheckbox.Checked = False Then
                    totalDiscount = totalCharge * 0.03D
                ElseIf Seniorcheckbox.Checked = False And AAAcheckbox.Checked = True Then
                    totalDiscount = totalCharge * 0.05D
                Else
                    totalDiscount = 0.00D
                End If

                MinusDiscountTextbox.Text = "$" & Math.Round(totalDiscount, 2).ToString
                YouOweTextbox.Text = "$" & Math.Round((totalCharge - totalDiscount), 2).ToString
                totalCost += Math.Round((totalCharge - totalDiscount), 2)
                SummaryButton.Enabled = True
                numofCustomer += 1

            ElseIf KilometersRadioButton.Checked = True Then

                mileage = (CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)) / 1.609D
                DistanceDrivenTextbox.Text = Math.Round(mileage, 2).ToString
                totalDistance += Math.Round(mileage, 2)
                MileageChargeTextbox.Text = "$" & Math.Round(MileageCharge(mileage), 2).ToString
                dayCharge = CDec(DaysTextBox.Text) * 15D
                DayChargeTextbox.Text = "$" & Math.Round(dayCharge, 2).ToString
                totalCharge = CDec(MileageChargeTextBox.Text) + CDec(DayChargeTextbox.Text)

                If Seniorcheckbox.Checked = True And AAAcheckbox.Checked = True Then
                    totalDiscount = totalCharge * 0.08D
                ElseIf SeniorCheckBox.Checked = True And AAAcheckbox.Checked = False Then
                    totalDiscount = totalCharge * 0.03D
                ElseIf SeniorCheckBox.Checked = False And AAAcheckbox.Checked = True Then
                    totalDiscount = totalCharge * 0.05D
                Else
                    totalDiscount = 0.00D
                End If

                MinusDiscountTextbox.Text = "$" & Math.Round(totalDiscount, 2).ToString
                YouOweTextbox.Text = "$" & Math.Round(totalCharge - totalDiscount, 2).ToString
                totalCost += Math.Round(totalCharge - totalDiscount, 2)
                SummaryButton.Enabled = True
                numofCustomer += 1

            Else
                MsgBox("Error, please select either Miles or Kilometers.")
            End If

            CalculateButton.Enabled = False
            ClearButton.Enabled = True

        Else
        End If

    End Sub

    Function MileageCharge(ByRef miles As Decimal) As Decimal
        'Calculate mileage charge
        Dim mileCharge As Decimal

        Select Case miles
            Case <= 200
                mileCharge = miles * 0
            Case > 500
                mileCharge = (miles - 500) * 0.1D + 36
            Case Else
                mileCharge = (miles - 200) * 0.12D
        End Select
        Return mileCharge

    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Push Exit Button to close the form
        Me.Close()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MessageBox.Show("Total Customers: " & Str(numofCustomer) & vbNewLine &
               "Total Miles Driven: " & Str(totalDistance) & " mi" & vbNewLine &
               "Total Charge: $" & Str(totalCost), "Detailed Summary")
    End Sub

End Class
