Imports System.Text
Imports System.Drawing.Printing
Imports System.Drawing.Printing.StandardPrintController

Public Class PurchaseConfirm

    Public purchaseId As Integer
    Public movieShowDate As Date
    Public movieTitle As String
    Public movieShowTime As String
    Public selectedSeat As String

    Private Sub PurchaseConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblPurchaseId.Text = purchaseId.ToString()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim pageSize As New PaperSize("", 420, 540)

        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)

        doc.PrintController = New StandardPrintController()
        doc.DefaultPageSettings.Margins.Left = 0
        doc.DefaultPageSettings.Margins.Right = 0
        doc.DefaultPageSettings.Margins.Top = 0
        doc.DefaultPageSettings.Margins.Bottom = 0
        doc.DefaultPageSettings.PaperSize = pageSize
        doc.Print()

    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage

        Dim space As Integer = 145
        Dim hallNum As Integer
        Dim pricePerTicket As Decimal
        Dim title As String = "C:\Users\Michelle Ooi\Documents\Degree Y2S3\Visual Studio 2017\Cinema Ticketing System\Cinema Ticketing System\Resources\logo_mt_cl_transparent.png"

        Dim db As New demoDataContext
        Dim rs1 = (From o In db.Purchases
                   Where o.PurchaseID = purchaseId).FirstOrDefault

        hallNum = rs1.MovieSchedule.Hall.Number

        Dim rs2 = (From o In db.Purchases
                   Where o.PurchaseID = purchaseId).FirstOrDefault

        pricePerTicket = rs2.MovieSchedule.TicketPrice

        Dim g As Graphics = e.Graphics

        g.DrawRectangle(Pens.Black, 5, 5, 410, 380)
        g.DrawImage(Image.FromFile(title), 80, 30)

        Dim fbody As New Font("Lucida Console", 15, FontStyle.Bold)
        Dim fBody1 As New Font("Lucida Console", 15, FontStyle.Regular)
        Dim fBody2 As New Font("Lucida Console", 9, FontStyle.Regular)
        Dim rs As New Font("Stencil", 25, FontStyle.Bold)
        Dim fTType As New Font("", 150, FontStyle.Bold)
        Dim sb As New SolidBrush(Color.Black)

        g.DrawString("------------------------------", fBody1, sb, 10, 120)

        g.DrawString("Date :", fbody, sb, 10, space)
        g.DrawString(movieShowDate, fBody1, sb, 100, space)

        g.DrawString("Time :", fbody, sb, 10, space + 30)
        g.DrawString(movieShowTime, fBody1, sb, 100, space + 30)

        g.DrawString("Movie :", fbody, sb, 10, space + 60)
        g.DrawString(movieTitle, fBody1, sb, 115, space + 60)

        g.DrawString("Seat :", fbody, sb, 10, space + 90)
        g.DrawString(selectedSeat, fBody1, sb, 100, space + 90)

        g.DrawString("Price :", fbody, sb, 10, space + 120)
        g.DrawString("RM " + pricePerTicket.ToString() + ".00", rs, sb, 10, space + 140)

        g.DrawString(hallNum, fTType, sb, 255, 150)
        g.Dispose()

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