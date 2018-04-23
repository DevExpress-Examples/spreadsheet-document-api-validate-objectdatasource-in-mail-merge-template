using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraSpreadsheet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailMergeExample {
    #region #MyObjectDataSourceValidationService
    public class MyObjectDataSourceValidationService : IObjectDataSourceValidationService {
        public void Validate(IEnumerable<ObjectDataSource> dataSources) {
            // Do nothing to allow loading.
            // Clear the DataSource and DataMember properties to prohibit loading.
            foreach (ObjectDataSource ds in dataSources) {
                if (ds.Name != "EmployeeDS") {
                    ds.DataSource = null;
                    ds.DataMember = null;
                }
            };
        }
    }
    #endregion #MyObjectDataSourceValidationService
}
