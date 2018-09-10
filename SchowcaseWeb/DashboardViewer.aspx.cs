using System;
using System.Linq;

namespace SchowcaseWeb
{
    using System.Text;

    public partial class DashboardViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var dashboardId = this.Request["DashboardId"];
                this.Title = dashboardId;
                this.MyDashboardViewer.DashboardId = dashboardId;
            }
        }

        protected void MyDashboardViewer_DashboardLoading(object sender, DevExpress.DashboardWeb.DashboardLoadingEventArgs e)
        {
            try
            {
                var daschboardStorage = new SchowcaseDataClassesDataContext();
                var daschboardList = daschboardStorage.DashboardStorages.Where(c => c.Identifier == e.DashboardId);
                if (daschboardList.Any())
                {
                    var daschboard = daschboardList.First();
                    e.DashboardXml = Encoding.UTF8.GetString(daschboard.DashboardBLOB.ToArray());
                }
                else
                {
                    e.DashboardXml = string.Empty;
                    this.Response.Write($"Графическая панель {e.DashboardId} отсутствует в базе данных!");
                }
            }
            catch (Exception ex)
            {
                this.Response.Write("Ошибка при формировании отчета: " + ex);
            }
        }
    }
}