Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Configuration
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Data
Imports DevExpress.XtraReports.Service

Namespace Reporting
	' NOTE: You can use the "Rename" command on the "Refactor" menu
	' to change the class name "ReportService1" in code, svc and config file together.
	<SilverlightFaultBehavior> _
	Public Class ReportService1
		Inherits DevExpress.XtraReports.Service.ReportService
		Shared Sub New()
			DataProviderRepository.Current.Register("nwind", "Northwind", ConfigurationManager.ConnectionStrings("nwindConnectionString").ConnectionString)
		End Sub

		Private Shared ReadOnly layouts As New Dictionary(Of String, Byte())()

		Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
			layouts(reportName) = layoutData
		End Sub

		Protected Overrides Function LoadReportLayout(ByVal reportName As String) As Byte()
            Dim layout() As Byte = {}
			Return If(layouts.TryGetValue(reportName, layout), layout, MyBase.LoadReportLayout(reportName))
		End Function
	End Class
End Namespace
