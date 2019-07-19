﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class CanceledOrderEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CanceledOrderEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function GetOrderReport(fromDate As Nullable(Of Date), toDate As Nullable(Of Date)) As ObjectResult(Of GetOrderReport_Result)
        Dim fromDateParameter As ObjectParameter = If(fromDate.HasValue, New ObjectParameter("FromDate", fromDate), New ObjectParameter("FromDate", GetType(Date)))

        Dim toDateParameter As ObjectParameter = If(toDate.HasValue, New ObjectParameter("ToDate", toDate), New ObjectParameter("ToDate", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of GetOrderReport_Result)("GetOrderReport", fromDateParameter, toDateParameter)
    End Function

    Public Overridable Function GetOrderReportNoOperator(fromDate As Nullable(Of Date), toDate As Nullable(Of Date)) As ObjectResult(Of GetOrderReportNoOperator_Result)
        Dim fromDateParameter As ObjectParameter = If(fromDate.HasValue, New ObjectParameter("FromDate", fromDate), New ObjectParameter("FromDate", GetType(Date)))

        Dim toDateParameter As ObjectParameter = If(toDate.HasValue, New ObjectParameter("ToDate", toDate), New ObjectParameter("ToDate", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of GetOrderReportNoOperator_Result)("GetOrderReportNoOperator", fromDateParameter, toDateParameter)
    End Function

End Class