using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Services;
using System;

namespace MailMergeExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        #region #main
        static void Main() {
            Workbook workbook = new DevExpress.Spreadsheet.Workbook();
            workbook.ReplaceService<IObjectDataSourceValidationService>(new MyObjectDataSourceValidationService());
            workbook.LoadDocument("EmployeesMailMergeTemplate.xlsx");
            var result = workbook.GenerateMailMergeDocuments();
            result[0].SaveDocument("result.xlsx");
            System.Diagnostics.Process.Start("result.xlsx");
        }
        #endregion #main
    }
}
