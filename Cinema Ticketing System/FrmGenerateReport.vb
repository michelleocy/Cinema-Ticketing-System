Imports System.Text

Public Class FrmGenerateReport

    Private fontHeader As New Font("Calibri", 24, FontStyle.Bold)
    Private fontSubHeader As New Font("Calibri", 12)
    Private fontbody As New Font("Consolas", 10)

    Private reportAuthor As String

    Private subHeader As String = String.Format(
            "Printed on {0:dd-MM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by " + reportAuthor, DateTime.Now
            )


    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        If cboReportType.Text = "Seat Report" Then
            Dim header As String = "Number Of Times A Seat Has Booked On" + vbNewLine +
            cboMonth.Text + " " + cboYear.Text + " (Top 40)"
            Dim body As New StringBuilder()
            Dim db As New demoDataContext

            body.AppendLine("No  Seat Number  Hall Number  Book Amount")
            body.AppendLine("--  -----------  -----------  -----------")

            Dim dateStart As Date = Date.Parse("01 " + cboMonth.Text + " " + cboYear.Text)
            Dim dateEnd As Date = dateStart.AddMonths(1)

            Dim rs = From i In db.Seats

            Dim dictionary As New Dictionary(Of Seat, Integer)

            For Each s In rs
                Dim seatcnt As Integer = 0
                For Each m In s.Hall.MovieSchedules
                    If m.Date.CompareTo(dateStart) >= 0 And m.Date.CompareTo(dateEnd) < 0 Then
                        For Each p In m.Purchases
                            For Each ps In p.PurchasedSeats
                                If ps.SeatNum = s.SeatNo AndAlso s.HallId = m.HallId Then
                                    seatcnt += 1
                                End If
                            Next
                        Next
                    End If
                Next
                Dim pair As New DictionaryEntry
                dictionary.Add(s, seatcnt)
            Next

            Dim sorted = From p In dictionary
                         Order By p.Value Descending

            Dim sortedDictionary = sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)
            Dim cnt As Integer = 0

            For index = 1 To 40
                Dim s As Seat = sortedDictionary.ToList(index - 1).Key
                cnt += 1
                body.AppendFormat("{0,2}  {1,11}  {2,11}  {3,11}" & vbNewLine,
                                  cnt, s.SeatNo, s.Hall.Number, sortedDictionary.ToList(index).Value)
            Next

            body.AppendLine()
            body.AppendFormat("{0,2} record(s)", cnt)

            With e.Graphics
                .DrawString(header, fontHeader, Brushes.Purple, 0, 0)
                .DrawString(subHeader, fontSubHeader, Brushes.Black, 0, 80)
                .DrawString(body.ToString, fontbody, Brushes.Black, 0, 160)
            End With
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub FrmGenerateReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindData()
    End Sub

    Private Sub bindData()
        cboYear.Items.Clear()
        cboMonth.Items.Clear()
        cboMonth.Enabled = False
        Dim currentyear As Integer = Date.Now.Year

        Dim year As Integer = 2019

        Do Until year = currentyear + 1
            cboYear.Items.Add(year)
            year += 1
        Loop
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        Dim currentmonth As Integer = Date.Now.Month
        Dim month As Integer = 1
        If cboYear.Text = Date.Now.Year.ToString Then
            Do Until month = currentmonth + 1
                Select Case month
                    Case 1
                        cboMonth.Items.Add("January")
                    Case 2
                        cboMonth.Items.Add("February")
                    Case 3
                        cboMonth.Items.Add("March")
                    Case 4
                        cboMonth.Items.Add("April")
                    Case 5
                        cboMonth.Items.Add("May")
                    Case 6
                        cboMonth.Items.Add("June")
                    Case 7
                        cboMonth.Items.Add("July")
                    Case 8
                        cboMonth.Items.Add("August")
                    Case 9
                        cboMonth.Items.Add("September")
                    Case 10
                        cboMonth.Items.Add("October")
                    Case 11
                        cboMonth.Items.Add("November")
                    Case 12
                        cboMonth.Items.Add("December")
                End Select
                month += 1
            Loop
        Else
            Do Until month = 13
                Select Case month
                    Case 1
                        cboMonth.Items.Add("January")
                    Case 2
                        cboMonth.Items.Add("February")
                    Case 3
                        cboMonth.Items.Add("March")
                    Case 4
                        cboMonth.Items.Add("April")
                    Case 5
                        cboMonth.Items.Add("May")
                    Case 6
                        cboMonth.Items.Add("June")
                    Case 7
                        cboMonth.Items.Add("July")
                    Case 8
                        cboMonth.Items.Add("August")
                    Case 9
                        cboMonth.Items.Add("September")
                    Case 10
                        cboMonth.Items.Add("October")
                    Case 11
                        cboMonth.Items.Add("November")
                    Case 12
                        cboMonth.Items.Add("December")
                End Select
                month += 1
            Loop
        End If
        cboMonth.Enabled = True
    End Sub

    Private Sub cboReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportType.SelectedIndexChanged

    End Sub
End Class