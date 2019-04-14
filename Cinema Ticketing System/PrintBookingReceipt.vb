Public Class PrintBookingReceipt

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage

        Dim x As Integer = 170
        Dim y As Integer = 360
        Dim xwidth As Integer = 190
        Dim yheight As Integer = 20
        Dim cellwidth As Integer = 300
        Dim cellheight As Integer = 370
        Dim fon As New Font(FontFamily.GenericSerif, 12, FontStyle.Regular)
        Dim fontTitle As New Font(FontFamily.GenericSerif, 16, FontStyle.Bold)

        e.Graphics.DrawString("Booking Receipt", fontTitle, Brushes.Black, 100, 20)

        Dim rect1 As New Rectangle(x, 70, xwidth, yheight)
        Dim strings1 As New StringFormat

        strings1.Alignment = StringAlignment.Center
        strings1.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect1)
        e.Graphics.DrawRectangle(Pens.Black, rect1)
        e.Graphics.DrawString(ViewBookingList.DataGridViewTextBoxColumn1.HeaderText, fon, Brushes.Black, rect1, strings1)


        Dim rect2 As New Rectangle(x, 90, xwidth, yheight)
        Dim strings2 As New StringFormat

        strings2.Alignment = StringAlignment.Center
        strings2.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect2)
        e.Graphics.DrawRectangle(Pens.Black, rect2)
        e.Graphics.DrawString(ViewBookingList.DataGridViewTextBoxColumn2.HeaderText, fon, Brushes.Black, rect2, strings2)

        Dim rect3 As New Rectangle(x, 110, xwidth, yheight)
        Dim strings3 As New StringFormat

        strings3.Alignment = StringAlignment.Center
        strings3.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect3)
        e.Graphics.DrawRectangle(Pens.Black, rect3)
        e.Graphics.DrawString(ViewBookingList.DataGridViewTextBoxColumn3.HeaderText, fon, Brushes.Black, rect3, strings3)

        Dim rect4 As New Rectangle(x, 130, xwidth, yheight)
        Dim strings4 As New StringFormat

        strings4.Alignment = StringAlignment.Center
        strings4.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect4)
        e.Graphics.DrawRectangle(Pens.Black, rect4)
        e.Graphics.DrawString(ViewBookingList.DataGridViewTextBoxColumn5.HeaderText, fon, Brushes.Black, rect4, strings4)

        Dim rect5 As New Rectangle(x, 150, xwidth, yheight)
        Dim strings5 As New StringFormat

        strings5.Alignment = StringAlignment.Center
        strings5.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect5)
        e.Graphics.DrawRectangle(Pens.Black, rect5)
        e.Graphics.DrawString(ViewBookingList.DataGridViewTextBoxColumn6.HeaderText, fon, Brushes.Black, rect5, strings5)

        Dim rect6 As New Rectangle(x, 170, xwidth, yheight)
        Dim strings6 As New StringFormat

        strings6.Alignment = StringAlignment.Center
        strings6.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect6)
        e.Graphics.DrawRectangle(Pens.Black, rect6)
        e.Graphics.DrawString("Time", fon, Brushes.Black, rect6, strings6)

        Dim rect7 As New Rectangle(x, 190, xwidth, yheight)
        Dim strings7 As New StringFormat

        strings7.Alignment = StringAlignment.Center
        strings7.LineAlignment = StringAlignment.Center
        e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect7)
        e.Graphics.DrawRectangle(Pens.Black, rect7)
        e.Graphics.DrawString("Movie", fon, Brushes.Black, rect7, strings7)

        '-------------------------------------------------------------------------------------------------------------------

        Dim rek1 As New Rectangle(y, 70, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek1)
        Dim row1 = ViewBookingList.dgvBooking.CurrentRow.Cells(0).Value.ToString
        e.Graphics.DrawString(row1, fon, Brushes.Black, cellheight, 72)

        Dim rek2 As New Rectangle(y, 90, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek2)
        Dim row2 = ViewBookingList.dgvBooking.CurrentRow.Cells(1).Value.ToString
        e.Graphics.DrawString(row2, fon, Brushes.Black, cellheight, 92)

        Dim rek3 As New Rectangle(y, 110, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek3)
        Dim row3 = ViewBookingList.dgvBooking.CurrentRow.Cells(2).Value.ToString
        e.Graphics.DrawString(row3, fon, Brushes.Black, cellheight, 112)

        Dim rek4 As New Rectangle(y, 130, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek4)
        Dim row4 = ViewBookingList.dgvBooking.CurrentRow.Cells(4).Value.ToString
        e.Graphics.DrawString(row4, fon, Brushes.Black, cellheight, 132)

        Dim rek5 As New Rectangle(y, 150, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek5)
        Dim row5 = Convert.ToDateTime(ViewBookingList.dgvBooking.CurrentRow.Cells(5).Value.ToString).ToShortDateString
        e.Graphics.DrawString(row5, fon, Brushes.Black, cellheight, 152)

        Dim rek6 As New Rectangle(y, 170, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek6)
        Dim screeningTime = ViewBookingList.dgvBooking.CurrentRow.Cells(6).Value.ToString

        Select Case screeningTime
            Case 1
                screeningTime = "11.00AM"
            Case 2
                screeningTime = "1.30PM"
            Case 3
                screeningTime = "4.00PM"
            Case 4
                screeningTime = "6.30PM"
            Case 5
                screeningTime = "9.00PM"
        End Select

        Dim row6 = screeningTime
        e.Graphics.DrawString(row6, fon, Brushes.Black, cellheight, 172)

        Dim rek7 As New Rectangle(y, 190, cellwidth, yheight)
        e.Graphics.DrawRectangle(Pens.Black, rek7)
        Dim row7 = ViewBookingList.dgvBooking.CurrentRow.Cells(7).Value.ToString
        e.Graphics.DrawString(row7, fon, Brushes.Black, cellheight, 192)

    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click

        control.Zoom = 1.2

    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click

        control.AutoZoom = True

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        dialog.Document = doc

        If dialog.ShowDialog = Windows.Forms.DialogResult.Yes Then
            doc.Print()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()
        ViewBookingList.Show()

    End Sub
End Class