using System.Collections.Generic;
using System.Configuration;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Data;
using DevExpress.XtraReports.Service;

namespace Reporting {
    // NOTE: You can use the "Rename" command on the "Refactor" menu
    // to change the class name "ReportService1" in code, svc and config file together.
    [SilverlightFaultBehavior]
    public class ReportService1 : DevExpress.XtraReports.Service.ReportService {
        static ReportService1() {
            DataProviderRepository.Current.Register(
                "nwind", 
                "Northwind", 
                ConfigurationManager.ConnectionStrings["nwindConnectionString"].ConnectionString);
        }

        static readonly Dictionary<string, byte[]> layouts = new Dictionary<string, byte[]>();

        protected override void SaveReportLayout(string reportName, byte[] layoutData) {
            layouts[reportName] = layoutData;
        }

        protected override byte[] LoadReportLayout(string reportName) {
            byte[] layout;
            return layouts.TryGetValue(reportName, out layout) ? layout : base.LoadReportLayout(reportName);
        }
    }
}
