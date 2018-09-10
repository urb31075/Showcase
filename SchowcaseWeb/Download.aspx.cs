// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Download.aspx.cs" company="urb31075">
// All Right Reserved  
// </copyright>
// <summary>
//   Defines the Download type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SchowcaseWeb
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.UI;

    /// <summary>
    /// The download.
    /// </summary>
    public partial class Download : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var daschboardStorage = new SchowcaseDataClassesDataContext();
                var daschboardList = daschboardStorage.DashboardStorages.Where(c => c.StorageType == 1);
                if (daschboardList.Any())
                {
                    var daschboard = daschboardList.First();
                    var bytes = daschboard.DashboardBLOB.ToArray();
                    var stream = new MemoryStream(bytes);
                    this.Response.Clear();
                    this.Response.AppendHeader(@"Content-Type", @"application/vnd.msign"); // Задаем тип документа
                    this.Response.AppendHeader(@"Content-Transfer-Encoding", @"binary");
                    this.Response.AppendHeader(@"Content-Disposition", "attachment; filename=SchowcaseDisainerSetup.msi");
                    stream.WriteTo(this.Response.OutputStream);
                }
                else
                {
                    this.Response.Write("Дистрибутив отсутствует отсутствует в базе данных!");
                }
            }
        }
    }
}