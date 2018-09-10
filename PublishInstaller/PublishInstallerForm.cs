namespace PublishInstaller
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class PublishInstallerForm : Form
    {
        // DachboardDataClassesDataContext model;
        public PublishInstallerForm()
        {
            this.InitializeComponent();
        }

        private void PublishInstallerButtonClick(object sender, EventArgs e)
        {
            try
            {
                var bytes = File.ReadAllBytes(".\\Source\\SchowcaseDisainerSetup.msi");

                var dachboardDataClasses = new DachboardDataClassesDataContext();
                var existInstaller = dachboardDataClasses.DashboardStorages.Where(c => c.StorageType == 1);
                dachboardDataClasses.DashboardStorages.DeleteAllOnSubmit(existInstaller);
                dachboardDataClasses.SubmitChanges();

                var daschboard = new DashboardStorage
                                     {
                                         Identifier = "SchowcaseDisainerSetup", 
                                         Description = "Дистрибутив дизайнера графических панелей", 
                                         DashboardBLOB = bytes, 
                                         PublicationDate = DateTime.Now, 
                                         StorageType = 1
                                     };
                dachboardDataClasses.DashboardStorages.InsertOnSubmit(daschboard);
                dachboardDataClasses.SubmitChanges();

                var msg = $"Дистрибутив дизайнера графических панелей успешно опубликован на сервере!";
                MessageBox.Show(msg, @"Публикация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PublishInstallerFormLoad(object sender, EventArgs e)
        {
            this.DachboardDataGridView.AutoGenerateColumns = false;

            var dachboardDataClasses = new DachboardDataClassesDataContext();
            var existDaschboard = dachboardDataClasses.DashboardStorages.Where(c => c.StorageType == 0).OrderBy(c => c.DashboardOrder);
            this.DachboardDataGridView.DataSource = existDaschboard;
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (this.DachboardDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var id = (int)this.DachboardDataGridView.SelectedRows[0].Cells[0].Value;
            var dachboardDataClasses = new DachboardDataClassesDataContext();
            var existDaschboard = dachboardDataClasses.DashboardStorages.First(c => c.Id == id);
            dachboardDataClasses.DashboardStorages.DeleteOnSubmit(existDaschboard);
            dachboardDataClasses.SubmitChanges();
            this.RefrechButtonClick(sender, e);

        }

        private void RefrechButtonClick(object sender, EventArgs e)
        {
            var dachboardDataClasses = new DachboardDataClassesDataContext();
            var existDaschboard = dachboardDataClasses.DashboardStorages.Where(c => c.StorageType == 0).OrderBy(c => c.DashboardOrder);
            this.DachboardDataGridView.DataSource = null;
            this.DachboardDataGridView.DataSource = existDaschboard;
        }
    }

    interface IDupel
    {
        string GetName();
    }
}