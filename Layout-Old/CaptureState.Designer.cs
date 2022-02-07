namespace Layout
{
    partial class CaptureState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureState));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeApplicationButton = new System.Windows.Forms.Button();
            this.AddApplicationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(763, 228);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeApplicationButton
            // 
            this.removeApplicationButton.Location = new System.Drawing.Point(35, 298);
            this.removeApplicationButton.Name = "removeApplicationButton";
            this.removeApplicationButton.Size = new System.Drawing.Size(239, 58);
            this.removeApplicationButton.TabIndex = 1;
            this.removeApplicationButton.Text = "Remove Applications";
            this.removeApplicationButton.UseVisualStyleBackColor = true;
            this.removeApplicationButton.Click += new System.EventHandler(this.RemoveApplicationButton_Click);
            // 
            // AddApplicationsButton
            // 
            this.AddApplicationsButton.Location = new System.Drawing.Point(437, 298);
            this.AddApplicationsButton.Name = "AddApplicationsButton";
            this.AddApplicationsButton.Size = new System.Drawing.Size(262, 57);
            this.AddApplicationsButton.TabIndex = 2;
            this.AddApplicationsButton.Text = "Add Applications To Preset";
            this.AddApplicationsButton.UseVisualStyleBackColor = true;
            this.AddApplicationsButton.Click += new System.EventHandler(this.AddApplicationsButton_Click);
            // 
            // CaptureState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddApplicationsButton);
            this.Controls.Add(this.removeApplicationButton);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureState";
            this.Text = "CaptureState";
            this.Load += new System.EventHandler(this.CaptureState_Load);
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeApplicationButton;
        private System.Windows.Forms.Button AddApplicationsButton;
    }
}