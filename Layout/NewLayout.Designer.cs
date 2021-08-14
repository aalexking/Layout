namespace Layout
{
    partial class NewLayout
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLayout));
            this.layoutNameInput = new System.Windows.Forms.TextBox();
            this.saveStateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.selectFilesButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveLayoutButton = new System.Windows.Forms.Button();
            this.selectApplicationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // layoutNameInput
            // 
            this.layoutNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutNameInput.Location = new System.Drawing.Point(59, 75);
            this.layoutNameInput.Name = "layoutNameInput";
            this.layoutNameInput.Size = new System.Drawing.Size(448, 45);
            this.layoutNameInput.TabIndex = 0;
            this.layoutNameInput.Text = "Layout Name";
            // 
            // saveStateButton
            // 
            this.saveStateButton.Location = new System.Drawing.Point(42, 159);
            this.saveStateButton.Name = "saveStateButton";
            this.saveStateButton.Size = new System.Drawing.Size(229, 70);
            this.saveStateButton.TabIndex = 1;
            this.saveStateButton.Text = "Capture State";
            this.saveStateButton.UseVisualStyleBackColor = true;
            this.saveStateButton.Click += new System.EventHandler(this.CaptureStateButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(52, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(325, 39);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Create New Layout";
            // 
            // selectFilesButton
            // 
            this.selectFilesButton.Location = new System.Drawing.Point(535, 159);
            this.selectFilesButton.Name = "selectFilesButton";
            this.selectFilesButton.Size = new System.Drawing.Size(229, 71);
            this.selectFilesButton.TabIndex = 3;
            this.selectFilesButton.Text = "Select Files";
            this.selectFilesButton.UseVisualStyleBackColor = true;
            this.selectFilesButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 180);
            this.listBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveLayoutButton
            // 
            this.saveLayoutButton.Location = new System.Drawing.Point(535, 59);
            this.saveLayoutButton.Name = "saveLayoutButton";
            this.saveLayoutButton.Size = new System.Drawing.Size(229, 72);
            this.saveLayoutButton.TabIndex = 5;
            this.saveLayoutButton.Text = "Save Layout";
            this.saveLayoutButton.UseVisualStyleBackColor = true;
            this.saveLayoutButton.Click += new System.EventHandler(this.SaveLayoutButton_Click);
            // 
            // selectApplicationsButton
            // 
            this.selectApplicationsButton.Location = new System.Drawing.Point(289, 159);
            this.selectApplicationsButton.Name = "selectApplicationsButton";
            this.selectApplicationsButton.Size = new System.Drawing.Size(229, 70);
            this.selectApplicationsButton.TabIndex = 6;
            this.selectApplicationsButton.Text = "Select Applications";
            this.selectApplicationsButton.UseVisualStyleBackColor = true;
            this.selectApplicationsButton.Click += new System.EventHandler(this.selectAppsButton_Click);
            // 
            // NewLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectApplicationsButton);
            this.Controls.Add(this.saveLayoutButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.selectFilesButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.saveStateButton);
            this.Controls.Add(this.layoutNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewLayout";
            this.Text = "Create New Layout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox layoutNameInput;
        private System.Windows.Forms.Button saveStateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button selectFilesButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveLayoutButton;
        private System.Windows.Forms.Button selectApplicationsButton;
    }
}