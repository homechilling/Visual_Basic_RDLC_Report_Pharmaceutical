Imports System
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        'ReportViewer1.RefreshReport()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim db As New CanceledOrderEntities
        GetOrderReport_ResultBindingSource.DataSource = db.GetOrderReport(DTP1.Value, DTP2.Value).ToList 'why tolist?

        'Dim rParams As Microsoft.Reporting.WinForms.ReportParameter()
        'rParams = {New ReportParameter()
        Dim fromDate As ReportParameter = New ReportParameter("fromDate", DTP1.Text.Trim)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {fromDate})
        Dim toDate As ReportParameter = New ReportParameter("toDate", DTP2.Text.Trim)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {toDate})
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub IncludeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IncludeCheckBox.CheckedChanged
        Dim db As New CanceledOrderEntities
        If (IncludeCheckBox.Checked.Equals(False)) Then
            GetOrderReport_ResultBindingSource.DataSource = db.GetOrderReportNoOperator(DTP1.Value, DTP2.Value).ToList
        Else
            GetOrderReport_ResultBindingSource.DataSource = db.GetOrderReport(DTP1.Value, DTP2.Value).ToList
        End If

        'Dim rParams As Microsoft.Reporting.WinForms.ReportParameter()
        'rParams = {New ReportParameter()
        Dim fromDate As ReportParameter = New ReportParameter("fromDate", DTP1.Text.Trim)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {fromDate})
        Dim toDate As ReportParameter = New ReportParameter("toDate", DTP2.Text.Trim)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {toDate})
        ReportViewer1.RefreshReport()
    End Sub
End Class

