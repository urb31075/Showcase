namespace PublishInstaller
{
    partial class PublishInstallerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PublishInstallerButton = new System.Windows.Forms.Button();
            this.DachboardDataGridView = new System.Windows.Forms.DataGridView();
            this.RefrechButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DashboardOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DachboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PublishInstallerButton
            // 
            this.PublishInstallerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PublishInstallerButton.Location = new System.Drawing.Point(534, 404);
            this.PublishInstallerButton.Margin = new System.Windows.Forms.Padding(4);
            this.PublishInstallerButton.Name = "PublishInstallerButton";
            this.PublishInstallerButton.Size = new System.Drawing.Size(203, 25);
            this.PublishInstallerButton.TabIndex = 0;
            this.PublishInstallerButton.Text = "Опубликовать дистрибутив";
            this.PublishInstallerButton.UseVisualStyleBackColor = true;
            this.PublishInstallerButton.Click += new System.EventHandler(this.PublishInstallerButtonClick);
            // 
            // DachboardDataGridView
            // 
            this.DachboardDataGridView.AllowUserToAddRows = false;
            this.DachboardDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DachboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DachboardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DashboardOrder,
            this.Identifier,
            this.Description,
            this.PublicationDate});
            this.DachboardDataGridView.Location = new System.Drawing.Point(12, 9);
            this.DachboardDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DachboardDataGridView.Name = "DachboardDataGridView";
            this.DachboardDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DachboardDataGridView.Size = new System.Drawing.Size(725, 388);
            this.DachboardDataGridView.TabIndex = 1;
            // 
            // RefrechButton
            // 
            this.RefrechButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefrechButton.Location = new System.Drawing.Point(12, 404);
            this.RefrechButton.Name = "RefrechButton";
            this.RefrechButton.Size = new System.Drawing.Size(126, 23);
            this.RefrechButton.TabIndex = 3;
            this.RefrechButton.Text = "Обновить";
            this.RefrechButton.UseVisualStyleBackColor = true;
            this.RefrechButton.Click += new System.EventHandler(this.RefrechButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(144, 404);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // DashboardOrder
            // 
            this.DashboardOrder.DataPropertyName = "DashboardOrder";
            this.DashboardOrder.FillWeight = 50F;
            this.DashboardOrder.HeaderText = "№";
            this.DashboardOrder.MinimumWidth = 50;
            this.DashboardOrder.Name = "DashboardOrder";
            this.DashboardOrder.Width = 50;
            // 
            // Identifier
            // 
            this.Identifier.DataPropertyName = "Identifier";
            this.Identifier.FillWeight = 180F;
            this.Identifier.HeaderText = "Идентификатор";
            this.Identifier.Name = "Identifier";
            this.Identifier.ReadOnly = true;
            this.Identifier.Width = 180;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 35.6959F;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            // 
            // PublicationDate
            // 
            this.PublicationDate.DataPropertyName = "PublicationDate";
            this.PublicationDate.FillWeight = 112.676F;
            this.PublicationDate.HeaderText = "Дата публикации";
            this.PublicationDate.MinimumWidth = 180;
            this.PublicationDate.Name = "PublicationDate";
            this.PublicationDate.ReadOnly = true;
            this.PublicationDate.Width = 180;
            // 
            // PublishInstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 431);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RefrechButton);
            this.Controls.Add(this.DachboardDataGridView);
            this.Controls.Add(this.PublishInstallerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PublishInstallerForm";
            this.Text = "Публикация дистрибутива SchowcaseDisainer";
            this.Load += new System.EventHandler(this.PublishInstallerFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DachboardDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublishInstallerButton;
        private System.Windows.Forms.DataGridView DachboardDataGridView;
        private System.Windows.Forms.Button RefrechButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DashboardOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicationDate;
    }
}

