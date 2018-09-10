// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PublicationParamsForm.cs" company="urb31075">
// All Right Reserved  
// </copyright>
// <summary>
//   Defines the PablishParamForm type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace SchowcaseDisainer
{
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The publication params form.
    /// </summary>
    public partial class PublicationParamsForm : Form
    {
        /// <summary>
        /// The preview.
        /// </summary>
        private byte[] preview;

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicationParamsForm"/> class.
        /// </summary>
        public PublicationParamsForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The get description.
        /// </summary>
        /// <param name="fileName">
        /// The file Name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public PublicationParams GetDescription(string fileName)
        {
            this.MyDashboardViewer.DashboardSource = fileName;

            this.ShowDialog();
            if (this.DialogResult == DialogResult.Cancel)
            {
                return null;
            }

            var pp = new PublicationParams { Description = this.DescriptionTextBox.Text, Preview = this.preview };
            return pp;
        }

        /// <summary>
        /// The ok button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OkButtonClick(object sender, System.EventArgs e)
        {
            if (this.DescriptionTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Публикация графической панели без комментария недопустима", @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rectangle bounds = this.DachboardPanel.Bounds;
            var screenLocation = this.PointToScreen(this.DachboardPanel.Location);

            var previewMemoryStream = new MemoryStream();
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(screenLocation.X, screenLocation.Y), Point.Empty, bounds.Size);
                }

                bitmap.Save(previewMemoryStream, ImageFormat.Png);
            }

            var br = new BinaryReader(previewMemoryStream);
            br.BaseStream.Position = 0;
            this.preview = br.ReadBytes((int)previewMemoryStream.Length);
            this.Close();
            this.DialogResult = DialogResult.OK;

            /*var exportOptions = new ImageExportOptions { Format = ImageFormat.Png, ExportMode = ImageExportMode.SingleFile };
            exportOptions.PageBorderWidth = 3;
            exportOptions.PageBorderColor = Color.Blue;
            this.MyDashboardViewer.ExportToImage(previewMemoryStream, exportOptions);*/
        }

        private void PublicationParamsForm_Load(object sender, System.EventArgs e)
        {

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
