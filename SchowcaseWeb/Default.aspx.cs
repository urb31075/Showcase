// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Default.aspx.cs" company="urb31075">
//  All Right Reserved 
// </copyright>
// <summary>
//   Defines the Default type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SchowcaseWeb
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.UI.WebControls;

    /// <summary>
    /// The default.
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.Title = "Отчеты";
            }

            var table = new Table();
            this.ReportLinkPanel.Controls.Add(table);

            var daschboardStorage = new SchowcaseDataClassesDataContext();
            var distribDaschboarList = daschboardStorage.DashboardStorages.Where(c => c.StorageType == 1);
            if (distribDaschboarList.Any())
            {
                var distribDaschboar = distribDaschboarList.First();
                this.DownloadInstallerLinkButton.Text = $"Загрузить дистрибутив (опубликован {distribDaschboar.PublicationDate})";
            }
            else
            {
                this.DownloadInstallerLinkButton.Text = "Дистрибутив не найден в базе данных";
            }

            foreach (var daschboard in daschboardStorage.DashboardStorages.Where( c=>c.StorageType == 0).OrderBy(c => c.DashboardOrder))
            {
                var text = $"{daschboard.Description}  ({daschboard.Identifier} {daschboard.PublicationDate})";
                var lb = new LinkButton { ID = daschboard.Identifier, Text = text, OnClientClick = "document.forms[0].target='_blank'" };
                lb.Click += this.LinkButtonClick;

                var row = new TableRow();
                table.Controls.Add(row);
                var cell = new TableCell();
                row.Controls.Add(cell);
                cell.Controls.Add(lb);
                if (daschboard.DashboardPreview != null)
                {
                   if (daschboard.DashboardPreview.Length > 0)
                     {
                         var myimage = new Image();
                         myimage.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(daschboard.DashboardPreview.ToArray(), 0, daschboard.DashboardPreview.ToArray().Length);
                         myimage.Height = 150;
                         myimage.Width = 300;
                         var imageCell = new TableCell();
                         row.Controls.Add(imageCell);
                         imageCell.Controls.Add(myimage);
                         //this.Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(daschboard.DashboardPreview.ToArray(), 0, daschboard.DashboardPreview.ToArray().Length);
                     }
                }
            }
        }
        protected void LinkButtonClick(object sender, EventArgs e)
        {
            var src = (LinkButton)sender;
            var url = $"./DashboardViewer.aspx?dashboardId={src.ID}";
            this.Response.Redirect(url);
        }

        protected void DownloadInstallerLinkButtonClick(object sender, EventArgs e)
        {
            this.Response.Redirect("./Download.aspx");
        }
    }
}