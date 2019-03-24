namespace texted
{
    partial class bookmarksWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.offsetListBox = new System.Windows.Forms.ListBox();
            this.importButton = new System.Windows.Forms.Button();
            this.addCsvToBookmarksButton = new System.Windows.Forms.Button();
            this.addOffsetButton = new System.Windows.Forms.Button();
            this.loadOffsetButton = new System.Windows.Forms.Button();
            this.openCSV = new System.Windows.Forms.OpenFileDialog();
            this.saveAsCsvButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.offsetListBox);
            this.flowLayoutPanel1.Controls.Add(this.importButton);
            this.flowLayoutPanel1.Controls.Add(this.addCsvToBookmarksButton);
            this.flowLayoutPanel1.Controls.Add(this.saveAsCsvButton);
            this.flowLayoutPanel1.Controls.Add(this.addOffsetButton);
            this.flowLayoutPanel1.Controls.Add(this.loadOffsetButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 441);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // offsetListBox
            // 
            this.offsetListBox.FormattingEnabled = true;
            this.offsetListBox.HorizontalScrollbar = true;
            this.offsetListBox.Location = new System.Drawing.Point(3, 3);
            this.offsetListBox.Name = "offsetListBox";
            this.offsetListBox.Size = new System.Drawing.Size(318, 290);
            this.offsetListBox.Sorted = true;
            this.offsetListBox.TabIndex = 0;
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.importButton.Location = new System.Drawing.Point(3, 299);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(318, 23);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import bookmark file";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importCsvAtClick);
            // 
            // addCsvToBookmarksButton
            // 
            this.addCsvToBookmarksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCsvToBookmarksButton.Enabled = false;
            this.addCsvToBookmarksButton.Location = new System.Drawing.Point(3, 328);
            this.addCsvToBookmarksButton.Name = "addCsvToBookmarksButton";
            this.addCsvToBookmarksButton.Size = new System.Drawing.Size(318, 23);
            this.addCsvToBookmarksButton.TabIndex = 4;
            this.addCsvToBookmarksButton.Text = "Merge from bookmark file";
            this.addCsvToBookmarksButton.UseVisualStyleBackColor = true;
            // 
            // addOffsetButton
            // 
            this.addOffsetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addOffsetButton.Enabled = false;
            this.addOffsetButton.Location = new System.Drawing.Point(3, 386);
            this.addOffsetButton.Name = "addOffsetButton";
            this.addOffsetButton.Size = new System.Drawing.Size(318, 23);
            this.addOffsetButton.TabIndex = 3;
            this.addOffsetButton.Text = "Add this offset";
            this.addOffsetButton.UseVisualStyleBackColor = true;
            this.addOffsetButton.Click += new System.EventHandler(this.addNewOffsetToListOnClick);
            // 
            // loadOffsetButton
            // 
            this.loadOffsetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadOffsetButton.Enabled = false;
            this.loadOffsetButton.Location = new System.Drawing.Point(3, 415);
            this.loadOffsetButton.Name = "loadOffsetButton";
            this.loadOffsetButton.Size = new System.Drawing.Size(318, 23);
            this.loadOffsetButton.TabIndex = 2;
            this.loadOffsetButton.Text = "Load offset";
            this.loadOffsetButton.UseVisualStyleBackColor = true;
            this.loadOffsetButton.Click += new System.EventHandler(this.sendOffsetOnClick);
            // 
            // openCSV
            // 
            this.openCSV.Filter = "CSV files|*.csv";
            // 
            // saveAsCsvButton
            // 
            this.saveAsCsvButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveAsCsvButton.Location = new System.Drawing.Point(3, 357);
            this.saveAsCsvButton.Name = "saveAsCsvButton";
            this.saveAsCsvButton.Size = new System.Drawing.Size(318, 23);
            this.saveAsCsvButton.TabIndex = 5;
            this.saveAsCsvButton.Text = "Save bookmark file as...";
            this.saveAsCsvButton.UseVisualStyleBackColor = true;
            // 
            // bookmarksWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 441);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bookmarksWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bookmarks";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox offsetListBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button loadOffsetButton;
        private System.Windows.Forms.OpenFileDialog openCSV;
        private System.Windows.Forms.Button addOffsetButton;
        private System.Windows.Forms.Button addCsvToBookmarksButton;
        private System.Windows.Forms.Button saveAsCsvButton;
    }
}