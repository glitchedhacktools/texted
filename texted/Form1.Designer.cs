namespace texted
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prevBox = new System.Windows.Forms.RichTextBox();
            this.counter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.offsetBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.repointButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.specialCharBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.insertSobButton = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarAlerts = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.loadButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.goButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.offsetBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.specialCharBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 6);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.counter, 2, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = global::texted.Properties.Resources.textbox;
            this.panel1.Controls.Add(this.prevBox);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.panel1.Name = "panel1";
            // 
            // prevBox
            // 
            resources.ApplyResources(this.prevBox, "prevBox");
            this.prevBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.prevBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prevBox.Name = "prevBox";
            this.prevBox.ReadOnly = true;
            // 
            // counter
            // 
            resources.ApplyResources(this.counter, "counter");
            this.counter.Name = "counter";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 6);
            this.groupBox2.Controls.Add(this.hexBox);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // hexBox
            // 
            resources.ApplyResources(this.hexBox, "hexBox");
            this.hexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hexBox.Name = "hexBox";
            this.hexBox.ReadOnly = true;
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadRom);
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.Name = "goButton";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.loadOffsetOnClick);
            // 
            // offsetBox
            // 
            resources.ApplyResources(this.offsetBox, "offsetBox");
            this.offsetBox.Hexadecimal = true;
            this.offsetBox.Maximum = new decimal(new int[] {
            33554431,
            0,
            0,
            0});
            this.offsetBox.Name = "offsetBox";
            this.offsetBox.Value = new decimal(new int[] {
            2001615,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 6);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            this.textBox.TextChanged += new System.EventHandler(this.editText);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.overwriteText);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 6);
            this.tableLayoutPanel2.Controls.Add(this.repointButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // repointButton
            // 
            resources.ApplyResources(this.repointButton, "repointButton");
            this.repointButton.Name = "repointButton";
            this.repointButton.UseVisualStyleBackColor = true;
            this.repointButton.Click += new System.EventHandler(this.repointStart);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveChanges);
            // 
            // specialCharBox
            // 
            resources.ApplyResources(this.specialCharBox, "specialCharBox");
            this.specialCharBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialCharBox.FormattingEnabled = true;
            this.specialCharBox.Items.AddRange(new object[] {
            resources.GetString("specialCharBox.Items"),
            resources.GetString("specialCharBox.Items1"),
            resources.GetString("specialCharBox.Items2"),
            resources.GetString("specialCharBox.Items3"),
            resources.GetString("specialCharBox.Items4"),
            resources.GetString("specialCharBox.Items5"),
            resources.GetString("specialCharBox.Items6"),
            resources.GetString("specialCharBox.Items7"),
            resources.GetString("specialCharBox.Items8"),
            resources.GetString("specialCharBox.Items9"),
            resources.GetString("specialCharBox.Items10"),
            resources.GetString("specialCharBox.Items11"),
            resources.GetString("specialCharBox.Items12"),
            resources.GetString("specialCharBox.Items13"),
            resources.GetString("specialCharBox.Items14"),
            resources.GetString("specialCharBox.Items15"),
            resources.GetString("specialCharBox.Items16"),
            resources.GetString("specialCharBox.Items17"),
            resources.GetString("specialCharBox.Items18"),
            resources.GetString("specialCharBox.Items19"),
            resources.GetString("specialCharBox.Items20"),
            resources.GetString("specialCharBox.Items21"),
            resources.GetString("specialCharBox.Items22"),
            resources.GetString("specialCharBox.Items23"),
            resources.GetString("specialCharBox.Items24"),
            resources.GetString("specialCharBox.Items25"),
            resources.GetString("specialCharBox.Items26"),
            resources.GetString("specialCharBox.Items27"),
            resources.GetString("specialCharBox.Items28"),
            resources.GetString("specialCharBox.Items29"),
            resources.GetString("specialCharBox.Items30"),
            resources.GetString("specialCharBox.Items31"),
            resources.GetString("specialCharBox.Items32"),
            resources.GetString("specialCharBox.Items33"),
            resources.GetString("specialCharBox.Items34"),
            resources.GetString("specialCharBox.Items35"),
            resources.GetString("specialCharBox.Items36"),
            resources.GetString("specialCharBox.Items37"),
            resources.GetString("specialCharBox.Items38"),
            resources.GetString("specialCharBox.Items39"),
            resources.GetString("specialCharBox.Items40"),
            resources.GetString("specialCharBox.Items41"),
            resources.GetString("specialCharBox.Items42"),
            resources.GetString("specialCharBox.Items43"),
            resources.GetString("specialCharBox.Items44"),
            resources.GetString("specialCharBox.Items45"),
            resources.GetString("specialCharBox.Items46"),
            resources.GetString("specialCharBox.Items47"),
            resources.GetString("specialCharBox.Items48"),
            resources.GetString("specialCharBox.Items49"),
            resources.GetString("specialCharBox.Items50"),
            resources.GetString("specialCharBox.Items51"),
            resources.GetString("specialCharBox.Items52"),
            resources.GetString("specialCharBox.Items53"),
            resources.GetString("specialCharBox.Items54"),
            resources.GetString("specialCharBox.Items55"),
            resources.GetString("specialCharBox.Items56"),
            resources.GetString("specialCharBox.Items57"),
            resources.GetString("specialCharBox.Items58"),
            resources.GetString("specialCharBox.Items59"),
            resources.GetString("specialCharBox.Items60"),
            resources.GetString("specialCharBox.Items61"),
            resources.GetString("specialCharBox.Items62"),
            resources.GetString("specialCharBox.Items63"),
            resources.GetString("specialCharBox.Items64"),
            resources.GetString("specialCharBox.Items65"),
            resources.GetString("specialCharBox.Items66"),
            resources.GetString("specialCharBox.Items67"),
            resources.GetString("specialCharBox.Items68"),
            resources.GetString("specialCharBox.Items69"),
            resources.GetString("specialCharBox.Items70"),
            resources.GetString("specialCharBox.Items71"),
            resources.GetString("specialCharBox.Items72"),
            resources.GetString("specialCharBox.Items73"),
            resources.GetString("specialCharBox.Items74"),
            resources.GetString("specialCharBox.Items75"),
            resources.GetString("specialCharBox.Items76"),
            resources.GetString("specialCharBox.Items77"),
            resources.GetString("specialCharBox.Items78"),
            resources.GetString("specialCharBox.Items79"),
            resources.GetString("specialCharBox.Items80"),
            resources.GetString("specialCharBox.Items81"),
            resources.GetString("specialCharBox.Items82"),
            resources.GetString("specialCharBox.Items83"),
            resources.GetString("specialCharBox.Items84"),
            resources.GetString("specialCharBox.Items85"),
            resources.GetString("specialCharBox.Items86"),
            resources.GetString("specialCharBox.Items87"),
            resources.GetString("specialCharBox.Items88"),
            resources.GetString("specialCharBox.Items89"),
            resources.GetString("specialCharBox.Items90"),
            resources.GetString("specialCharBox.Items91"),
            resources.GetString("specialCharBox.Items92"),
            resources.GetString("specialCharBox.Items93"),
            resources.GetString("specialCharBox.Items94"),
            resources.GetString("specialCharBox.Items95"),
            resources.GetString("specialCharBox.Items96"),
            resources.GetString("specialCharBox.Items97"),
            resources.GetString("specialCharBox.Items98"),
            resources.GetString("specialCharBox.Items99"),
            resources.GetString("specialCharBox.Items100"),
            resources.GetString("specialCharBox.Items101")});
            this.specialCharBox.Name = "specialCharBox";
            this.specialCharBox.SelectedIndexChanged += new System.EventHandler(this.specialInput);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 6);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertSobButton,
            this.statusBarAlerts});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // insertSobButton
            // 
            resources.ApplyResources(this.insertSobButton, "insertSobButton");
            this.insertSobButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.insertSobButton.DoubleClickEnabled = true;
            this.insertSobButton.Name = "insertSobButton";
            this.insertSobButton.DoubleClick += new System.EventHandler(this.toggleInsSob);
            // 
            // statusBarAlerts
            // 
            resources.ApplyResources(this.statusBarAlerts, "statusBarAlerts");
            this.statusBarAlerts.Name = "statusBarAlerts";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.openSearchWindow);
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button repointButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox prevBox;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox specialCharBox;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel insertSobButton;
        private System.Windows.Forms.ToolStripStatusLabel statusBarAlerts;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.NumericUpDown offsetBox;
        public System.Windows.Forms.TextBox textBox;
    }
}

