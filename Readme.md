<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613111/16.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T515368)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [EmployeeInfo.cs](./CS/EmployeeInfo/EmployeeInfo.cs)
* [MyObjectDataSourceValidationService.cs](./CS/MailMergeExample/MyObjectDataSourceValidationService.cs) (VB: [MyObjectDataSourceValidationService.vb](./VB/MailMergeExample/MyObjectDataSourceValidationService.vb))
* [Program.cs](./CS/MailMergeExample/Program.cs) (VB: [Program.vb](./VB/MailMergeExample/Program.vb))
<!-- default file list end -->
# How to validate ObjectDataSource in the Spreadsheet mail merge template


This example illustrates how to use a custom service that implements the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSpreadsheetServicesIObjectDataSourceValidationServicetopic">IObjectDataSourceValidationService</a> interface to validate an <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessObjectBindingObjectDataSourcetopic">ObjectDataSource</a> contained in the loaded <a href="http://help.devexpress.com/#DocumentServer/CustomDocument118747">mail merge template </a>and prevent the data source from loading.

<br/>


