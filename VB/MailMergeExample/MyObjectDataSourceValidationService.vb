Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.XtraSpreadsheet.Services
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MailMergeExample
    #Region "#MyObjectDataSourceValidationService"
    Public Class MyObjectDataSourceValidationService
        Implements IObjectDataSourceValidationService

        Public Sub Validate(ByVal dataSources As IEnumerable(Of ObjectDataSource)) Implements IObjectDataSourceValidationService.Validate
            ' Do nothing to allow loading.
            ' Clear the DataSource and DataMember properties to prohibit loading.
            For Each ds As ObjectDataSource In dataSources
                If ds.Name <> "EmployeeDS" Then
                    ds.DataSource = Nothing
                    ds.DataMember = Nothing
                End If
            Next ds
        End Sub
    End Class
    #End Region ' #MyObjectDataSourceValidationService
End Namespace
