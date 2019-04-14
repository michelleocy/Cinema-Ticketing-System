Imports System.Text

Public Class FrmGenerateReport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontbody As New Font("Consolas", 10)

        Dim header As String = "Seat Report"
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by SOMEBODY", DateTime.Now
            )

        Dim body As New StringBuilder()

        body.AppendLine("No  Hall Number  Book Amount")
        body.AppendLine("--  -----------  -----------")

        Dim db As New demoDataContext

        Dim dateStart As Date = Date.Parse("01 " + cboMonth.Text + " " + cboYear.Text)
        Dim dateEnd As Date = dateStart.AddMonths(1)

        Dim rs = From i In db.Halls

        Dim hashtable As New Hashtable

        For Each hall In rs
            Dim hallcnt As Integer = 0
            For Each m In hall.MovieSchedules
                If m.Date.CompareTo(dateStart) >= 0 And m.Date.CompareTo(dateEnd) < 0 Then
                    For Each p In m.Purchases
                        hallcnt += p.PurchasedSeats.Count
                    Next
                End If
            Next
            Dim pair As New DictionaryEntry
            hashtable.Add(hall, hallcnt)
        Next

        Dim cnt As Integer = 0
        For Each p In hashtable
            Dim h As Hall = p.Key
            cnt += 1
            body.AppendFormat("{0,2}  {1,-11}  {2,-11}" & vbNewLine,
                              cnt, h.Number, p.Value)
        Next

        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        With e.Graphics
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString, fontbody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class