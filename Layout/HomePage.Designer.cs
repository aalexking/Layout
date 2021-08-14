namespace Layout
{
    partial class HomePage
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.clearLayoutButton = new System.Windows.Forms.Button();
            this.selectLayoutBox = new System.Windows.Forms.ComboBox();
            this.homePageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectLayoutButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.editLayoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homePageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clearLayoutButton
            // 
            this.clearLayoutButton.Location = new System.Drawing.Point(42, 182);
            this.clearLayoutButton.Name = "clearLayoutButton";
            this.clearLayoutButton.Size = new System.Drawing.Size(137, 37);
            this.clearLayoutButton.TabIndex = 3;
            this.clearLayoutButton.Text = "Clean Space";
            this.clearLayoutButton.UseVisualStyleBackColor = true;
            this.clearLayoutButton.Click += new System.EventHandler(this.CleanSpace_Click);
            // 
            // selectLayoutBox
            // 
            this.selectLayoutBox.AllowDrop = true;
            this.selectLayoutBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.homePageBindingSource, "Text", true));
            this.selectLayoutBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLayoutBox.FormattingEnabled = true;
            this.selectLayoutBox.Location = new System.Drawing.Point(55, 62);
            this.selectLayoutBox.Name = "selectLayoutBox";
            this.selectLayoutBox.Size = new System.Drawing.Size(267, 24);
            this.selectLayoutBox.TabIndex = 7;
            this.selectLayoutBox.DropDown += new System.EventHandler(this.SelectLayoutBox_DropDown);
            this.selectLayoutBox.SelectedIndexChanged += new System.EventHandler(this.SelectLayoutBox_SelectedIndexChanged);
            //this.selectLayoutBox.Text = " -- Select Item -- ";

            // 
            // homePageBindingSource
            // 
            this.homePageBindingSource.DataSource = typeof(Layout.HomePage);
            // 
            // selectLayoutButton
            // 
            this.selectLayoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLayoutButton.Location = new System.Drawing.Point(78, 109);
            this.selectLayoutButton.Name = "selectLayoutButton";
            this.selectLayoutButton.Size = new System.Drawing.Size(207, 55);
            this.selectLayoutButton.TabIndex = 8;
            this.selectLayoutButton.Text = "Choose";
            this.selectLayoutButton.UseVisualStyleBackColor = true;
            this.selectLayoutButton.Click += new System.EventHandler(this.SelectLayoutButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(97, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 29);
            this.title.TabIndex = 9;
            this.title.Text = "Select Layout";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editLayoutButton
            // 
            this.editLayoutButton.Location = new System.Drawing.Point(196, 182);
            this.editLayoutButton.Name = "editLayoutButton";
            this.editLayoutButton.Size = new System.Drawing.Size(137, 37);
            this.editLayoutButton.TabIndex = 10;
            this.editLayoutButton.Text = "Edit Layout";
            this.editLayoutButton.UseVisualStyleBackColor = true;
            this.editLayoutButton.Click += new System.EventHandler(this.EditLayoutButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 241);
            this.Controls.Add(this.editLayoutButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.selectLayoutButton);
            this.Controls.Add(this.selectLayoutBox);
            this.Controls.Add(this.clearLayoutButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "Layout Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.homePageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button clearLayoutButton;
        private System.Windows.Forms.ComboBox selectLayoutBox;
        private System.Windows.Forms.Button selectLayoutButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button editLayoutButton;
        private System.Windows.Forms.BindingSource homePageBindingSource;
    }
}

