Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class PrintMovieTicket

    Public purchaseId As Integer

    Private Sub PrintMovieTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPurchaseId.Text = purchaseId.ToString()

        Dim ds As New DatabaseDataSet
        Dim ad As New DatabaseDataSetTableAdapters.BookingTableAdapter

        ad.Fill(ds.Booking)

        Dim rpt As New MovieTicket
        rpt.SetDataSource(ds)

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = lblPurchaseId.Text
        crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("Purchase Id")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        crvMovieTicket.ReportSource = rpt
        crvMovieTicket.Refresh()

    End Sub


End Class