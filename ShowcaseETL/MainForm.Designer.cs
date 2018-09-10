namespace ShowcaseETL
{
    partial class MainForm
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
            this.InfoListBox = new System.Windows.Forms.ListBox();
            this.CreateStaffIQButton = new System.Windows.Forms.Button();
            this.UpdateStaffIQButton = new System.Windows.Forms.Button();
            this.UpdateFloorButton = new System.Windows.Forms.Button();
            this.UpdateAgeButton = new System.Windows.Forms.Button();
            this.UpdateGenderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoListBox
            // 
            this.InfoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoListBox.FormattingEnabled = true;
            this.InfoListBox.Location = new System.Drawing.Point(119, 10);
            this.InfoListBox.Name = "InfoListBox";
            this.InfoListBox.Size = new System.Drawing.Size(642, 628);
            this.InfoListBox.TabIndex = 0;
            // 
            // CreateStaffIQButton
            // 
            this.CreateStaffIQButton.Location = new System.Drawing.Point(12, 12);
            this.CreateStaffIQButton.Name = "CreateStaffIQButton";
            this.CreateStaffIQButton.Size = new System.Drawing.Size(101, 23);
            this.CreateStaffIQButton.TabIndex = 1;
            this.CreateStaffIQButton.Text = "CreateIQ";
            this.CreateStaffIQButton.UseVisualStyleBackColor = true;
            this.CreateStaffIQButton.Click += new System.EventHandler(this.CreateStaffIqButtonClick);
            // 
            // UpdateStaffIQButton
            // 
            this.UpdateStaffIQButton.Enabled = false;
            this.UpdateStaffIQButton.Location = new System.Drawing.Point(12, 41);
            this.UpdateStaffIQButton.Name = "UpdateStaffIQButton";
            this.UpdateStaffIQButton.Size = new System.Drawing.Size(101, 23);
            this.UpdateStaffIQButton.TabIndex = 2;
            this.UpdateStaffIQButton.Text = "UpdateIQ";
            this.UpdateStaffIQButton.UseVisualStyleBackColor = true;
            this.UpdateStaffIQButton.Click += new System.EventHandler(this.UpdateStaffIqButtonClick);
            // 
            // UpdateFloorButton
            // 
            this.UpdateFloorButton.Location = new System.Drawing.Point(12, 70);
            this.UpdateFloorButton.Name = "UpdateFloorButton";
            this.UpdateFloorButton.Size = new System.Drawing.Size(101, 23);
            this.UpdateFloorButton.TabIndex = 3;
            this.UpdateFloorButton.Text = "UpdateFloor";
            this.UpdateFloorButton.UseVisualStyleBackColor = true;
            this.UpdateFloorButton.Click += new System.EventHandler(this.UpdateFloorButtonClick);
            // 
            // UpdateAgeButton
            // 
            this.UpdateAgeButton.Location = new System.Drawing.Point(12, 99);
            this.UpdateAgeButton.Name = "UpdateAgeButton";
            this.UpdateAgeButton.Size = new System.Drawing.Size(101, 23);
            this.UpdateAgeButton.TabIndex = 4;
            this.UpdateAgeButton.Text = "UpdateAge";
            this.UpdateAgeButton.UseVisualStyleBackColor = true;
            this.UpdateAgeButton.Click += new System.EventHandler(this.UpdateAgeButtonClick);
            // 
            // UpdateGenderButton
            // 
            this.UpdateGenderButton.Location = new System.Drawing.Point(12, 128);
            this.UpdateGenderButton.Name = "UpdateGenderButton";
            this.UpdateGenderButton.Size = new System.Drawing.Size(101, 23);
            this.UpdateGenderButton.TabIndex = 5;
            this.UpdateGenderButton.Text = "UpdateGender";
            this.UpdateGenderButton.UseVisualStyleBackColor = true;
            this.UpdateGenderButton.Click += new System.EventHandler(this.UpdateGenderButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 648);
            this.Controls.Add(this.UpdateGenderButton);
            this.Controls.Add(this.UpdateAgeButton);
            this.Controls.Add(this.UpdateFloorButton);
            this.Controls.Add(this.UpdateStaffIQButton);
            this.Controls.Add(this.CreateStaffIQButton);
            this.Controls.Add(this.InfoListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InfoListBox;
        private System.Windows.Forms.Button CreateStaffIQButton;
        private System.Windows.Forms.Button UpdateStaffIQButton;
        private System.Windows.Forms.Button UpdateFloorButton;
        private System.Windows.Forms.Button UpdateAgeButton;
        private System.Windows.Forms.Button UpdateGenderButton;
    }
}

