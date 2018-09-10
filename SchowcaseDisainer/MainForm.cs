// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="urb31075">
// All Right Reserved 
// </copyright>
// <summary>
//   The form 1.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SchowcaseDisainer
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using DevExpress.XtraBars;

    /// <summary>
    /// The form 1.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void filePublishBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                FileName = this.MyDashboardDesigner.DashboardFileName,
                Filter = @"Dashboard Files|*.xml",
                Title = @"Select a Dashboard Files"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var publicationParams = new PublicationParamsForm().GetDescription(openFileDialog.FileName);
                if (publicationParams.Description == string.Empty)
                {
                    return;
                }

                var identifier = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                var blob = File.ReadAllBytes(openFileDialog.FileName);


                var model = new StaffIQTestEntities();
                var existDaschboard = model.DashboardStorage.Where(c => c.Identifier == identifier);
                foreach (var d in existDaschboard)
                {
                    model.DashboardStorage.Remove(d);
                }

                var order = model.DashboardStorage.Max(c => c.DashboardOrder) + 1 ?? 0;

                var daschboard = new DashboardStorage
                {
                    Identifier = identifier,
                    Description = publicationParams.Description,
                    DashboardBLOB = blob,
                    PublicationDate = DateTime.Now,
                    StorageType = 0,
                    DashboardPreview = publicationParams.Preview,
                    DashboardOrder = order
                };

                model.DashboardStorage.Add(daschboard);
                model.SaveChanges();

                var msg = $"Графическая панель {identifier} успешно опубликована на сервере!";
                MessageBox.Show(msg, @"Публикация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

/*private void PublishBarItem1ItemClick(object sender, ItemClickEventArgs e)
{
    var openFileDialog = new OpenFileDialog
    {
        FileName = this.MyDashboardDesigner.DashboardFileName,
        Filter = @"Dashboard Files|*.xml",
        Title = @"Select a Dashboard Files"
    };

    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
        var publicationParams = new PublicationParamsForm().GetDescription(openFileDialog.FileName);
        if (publicationParams.Description == string.Empty)
        {
            return;
        }

        var identifier = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
        var blob = File.ReadAllBytes(openFileDialog.FileName);


        var model = new StaffIQTestEntities();
        var existDaschboard = model.DashboardStorage.Where(c => c.Identifier == identifier);
        foreach (var d in existDaschboard)
        {
            model.DashboardStorage.Remove(d);
        }

        var order = model.DashboardStorage.Max(c => c.DashboardOrder) + 1 ?? 0;

        var daschboard = new DashboardStorage
        {
            Identifier = identifier,
            Description = publicationParams.Description,
            DashboardBLOB = blob,
            PublicationDate = DateTime.Now,
            StorageType = 0,
            DashboardPreview = publicationParams.Preview,
            DashboardOrder = order
        };

        model.DashboardStorage.Add(daschboard);
        model.SaveChanges();

        var msg = $"Графическая панель {identifier} успешно опубликована на сервере!";
        MessageBox.Show(msg, @"Публикация", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}*/