Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Services
Imports System

Namespace MailMergeExample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        #Region "#main"
        <STAThread> _
        Shared Sub Main()
            Dim workbook As Workbook = New DevExpress.Spreadsheet.Workbook()
            workbook.ReplaceService(Of IObjectDataSourceValidationService)(New MyObjectDataSourceValidationService())
            workbook.LoadDocument("EmployeesMailMergeTemplate.xlsx")
            Dim result = workbook.GenerateMailMergeDocuments()
            result(0).SaveDocument("result.xlsx")
            System.Diagnostics.Process.Start("result.xlsx")
        End Sub
        #End Region ' #main
    End Class
End Namespace
