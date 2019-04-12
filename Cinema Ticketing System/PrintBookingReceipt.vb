Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class PrintBookingReceipt

    Public selectedBooking As String

    Private Sub PrintBookingReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lblName.Text = selectedBooking

        'Dim db As New demoDataContext
        'Dim rs = (From o In db.Bookings).Last


        'Dim ds As New DatabaseDataSet
        'Dim ad As New DatabaseDataSetTableAdapters.BookingTableAdapter

        'ad.Fill(ds.Booking)

        'Dim rpt As New BookingReceipt
        'rpt.SetDataSource(ds)

        'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        'Dim crParameterFieldDefinition As ParameterFieldDefinition
        'Dim crParameterValues As New ParameterValues
        'Dim crParameterDiscreteValue As New ParameterDiscreteValue

        'crParameterDiscreteValue.Value = lblName.Text
        'crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields
        'crParameterFieldDefinition = crParameterFieldDefinitions.Item("Customer Name")
        'crParameterValues = crParameterFieldDefinition.CurrentValues

        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'crvBookingReceipt.ReportSource = rpt
        'crvBookingReceipt.Refresh()

    End Sub

    Private Sub mnuBookingMakeBooking_Click(sender As Object, e As EventArgs) Handles mnuBookingMakeBooking.Click

        Me.Hide()
        MakeBooking.ShowDialog()

    End Sub

    Private Sub mnuBookingList_Click(sender As Object, e As EventArgs) Handles mnuBookingList.Click

        Me.Hide()
        ViewBookingList.ShowDialog()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End

    End Sub

End Class