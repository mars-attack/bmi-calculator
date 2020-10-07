namespace BMI_Calc
{
    partial class BMIMain
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
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GenderLabel1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbsLabel = new System.Windows.Forms.Label();
            this.lbsBox = new System.Windows.Forms.TextBox();
            this.inchBox = new System.Windows.Forms.TextBox();
            this.feetBox = new System.Windows.Forms.TextBox();
            this.GenderBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.impResults = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteBTN2 = new System.Windows.Forms.Button();
            this.UpdateBTN2 = new System.Windows.Forms.Button();
            this.ViewBTN2 = new System.Windows.Forms.Button();
            this.SaveBTN2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.GenderBox2 = new System.Windows.Forms.ComboBox();
            this.GenderLabel2 = new System.Windows.Forms.Label();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.CalcMetricBMI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kgsBox = new System.Windows.Forms.TextBox();
            this.cmHeight = new System.Windows.Forms.Label();
            this.cmBox = new System.Windows.Forms.TextBox();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.NameBox2 = new System.Windows.Forms.TextBox();
            this.categoryBox2 = new System.Windows.Forms.RichTextBox();
            this.metricResults = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanel1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // feetLabel
            // 
            this.feetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.feetLabel.Location = new System.Drawing.Point(15, 116);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(92, 22);
            this.feetLabel.TabIndex = 34;
            this.feetLabel.Text = "Height (ft)";
            // 
            // inchLabel
            // 
            this.inchLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inchLabel.AutoSize = true;
            this.inchLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inchLabel.Location = new System.Drawing.Point(16, 167);
            this.inchLabel.Name = "inchLabel";
            this.inchLabel.Size = new System.Drawing.Size(90, 22);
            this.inchLabel.TabIndex = 34;
            this.inchLabel.Text = "Height(in)";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanel1.Controls.Add(this.GenderLabel1, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.NameBox, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.NameLabel, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.clearBtn1, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.TableLayoutPanel1.Controls.Add(this.lbsLabel, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.lbsBox, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.inchLabel, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.inchBox, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.feetLabel, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.feetBox, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.GenderBox1, 0, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(23, 6);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 6;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(301, 309);
            this.TableLayoutPanel1.TabIndex = 14;
            // 
            // GenderLabel1
            // 
            this.GenderLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderLabel1.AutoSize = true;
            this.GenderLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderLabel1.Location = new System.Drawing.Point(24, 65);
            this.GenderLabel1.Name = "GenderLabel1";
            this.GenderLabel1.Size = new System.Drawing.Size(74, 22);
            this.GenderLabel1.TabIndex = 34;
            this.GenderLabel1.Text = "Gender";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(143, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(136, 29);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLabel.Location = new System.Drawing.Point(31, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name";
            // 
            // clearBtn1
            // 
            this.clearBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn1.Font = new System.Drawing.Font("Arial", 18F);
            this.clearBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn1.Location = new System.Drawing.Point(3, 259);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(115, 46);
            this.clearBtn1.TabIndex = 6;
            this.clearBtn1.Text = "Clear";
            this.clearBtn1.UseVisualStyleBackColor = false;
            this.clearBtn1.Click += new System.EventHandler(this.ClearTabData);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(124, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbsLabel
            // 
            this.lbsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsLabel.AutoSize = true;
            this.lbsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbsLabel.Location = new System.Drawing.Point(5, 218);
            this.lbsLabel.Name = "lbsLabel";
            this.lbsLabel.Size = new System.Drawing.Size(112, 22);
            this.lbsLabel.TabIndex = 34;
            this.lbsLabel.Text = "Weight (lbs)";
            this.lbsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsBox
            // 
            this.lbsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsBox.Location = new System.Drawing.Point(143, 215);
            this.lbsBox.Name = "lbsBox";
            this.lbsBox.Size = new System.Drawing.Size(136, 29);
            this.lbsBox.TabIndex = 5;
            this.lbsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inchBox
            // 
            this.inchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inchBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchBox.Location = new System.Drawing.Point(143, 164);
            this.inchBox.Name = "inchBox";
            this.inchBox.Size = new System.Drawing.Size(136, 29);
            this.inchBox.TabIndex = 4;
            this.inchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feetBox
            // 
            this.feetBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feetBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetBox.Location = new System.Drawing.Point(143, 113);
            this.feetBox.Name = "feetBox";
            this.feetBox.Size = new System.Drawing.Size(136, 29);
            this.feetBox.TabIndex = 3;
            this.feetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GenderBox1
            // 
            this.GenderBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.GenderBox1.FormattingEnabled = true;
            this.GenderBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox1.Location = new System.Drawing.Point(143, 61);
            this.GenderBox1.Name = "GenderBox1";
            this.GenderBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderBox1.Size = new System.Drawing.Size(136, 30);
            this.GenderBox1.TabIndex = 2;
            // 
            // categoryBox1
            // 
            this.categoryBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBox1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox1.Location = new System.Drawing.Point(3, 372);
            this.categoryBox1.Name = "categoryBox1";
            this.categoryBox1.ReadOnly = true;
            this.categoryBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryBox1.Size = new System.Drawing.Size(350, 113);
            this.categoryBox1.TabIndex = 9;
            this.categoryBox1.TabStop = false;
            this.categoryBox1.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 332);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Your BMI is:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // impResults
            // 
            this.impResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.impResults.AutoSize = true;
            this.impResults.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impResults.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.impResults.Location = new System.Drawing.Point(192, 326);
            this.impResults.Name = "impResults";
            this.impResults.Size = new System.Drawing.Size(0, 34);
            this.impResults.TabIndex = 34;
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBTN.Font = new System.Drawing.Font("Arial", 18F);
            this.AddBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBTN.Location = new System.Drawing.Point(21, 491);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(123, 38);
            this.AddBTN.TabIndex = 8;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveBTN.Font = new System.Drawing.Font("Arial", 18F);
            this.SaveBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBTN.Location = new System.Drawing.Point(199, 547);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(123, 38);
            this.SaveBTN.TabIndex = 11;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Tabs
            // 
            this.Tabs.AccessibleName = "";
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(364, 617);
            this.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs.TabIndex = 3;
            this.Tabs.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteBTN);
            this.tabPage1.Controls.Add(this.UpdateBTN);
            this.tabPage1.Controls.Add(this.SaveBTN);
            this.tabPage1.Controls.Add(this.AddBTN);
            this.tabPage1.Controls.Add(this.TableLayoutPanel1);
            this.tabPage1.Controls.Add(this.categoryBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.impResults);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imperial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBTN.Font = new System.Drawing.Font("Arial", 18F);
            this.DeleteBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBTN.Location = new System.Drawing.Point(199, 491);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(123, 38);
            this.DeleteBTN.TabIndex = 9;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateBTN.Font = new System.Drawing.Font("Arial", 18F);
            this.UpdateBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBTN.Location = new System.Drawing.Point(21, 547);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(123, 38);
            this.UpdateBTN.TabIndex = 10;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = false;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteBTN2);
            this.tabPage2.Controls.Add(this.UpdateBTN2);
            this.tabPage2.Controls.Add(this.ViewBTN2);
            this.tabPage2.Controls.Add(this.SaveBTN2);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.categoryBox2);
            this.tabPage2.Controls.Add(this.metricResults);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metric";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteBTN2
            // 
            this.DeleteBTN2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBTN2.Font = new System.Drawing.Font("Arial", 18F);
            this.DeleteBTN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBTN2.Location = new System.Drawing.Point(199, 451);
            this.DeleteBTN2.Name = "DeleteBTN2";
            this.DeleteBTN2.Size = new System.Drawing.Size(123, 38);
            this.DeleteBTN2.TabIndex = 9;
            this.DeleteBTN2.Text = "Delete";
            this.DeleteBTN2.UseVisualStyleBackColor = false;
            this.DeleteBTN2.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN2
            // 
            this.UpdateBTN2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateBTN2.Font = new System.Drawing.Font("Arial", 18F);
            this.UpdateBTN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBTN2.Location = new System.Drawing.Point(27, 517);
            this.UpdateBTN2.Name = "UpdateBTN2";
            this.UpdateBTN2.Size = new System.Drawing.Size(123, 38);
            this.UpdateBTN2.TabIndex = 10;
            this.UpdateBTN2.Text = "Update";
            this.UpdateBTN2.UseVisualStyleBackColor = false;
            this.UpdateBTN2.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // ViewBTN2
            // 
            this.ViewBTN2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewBTN2.Font = new System.Drawing.Font("Arial", 18F);
            this.ViewBTN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewBTN2.Location = new System.Drawing.Point(199, 517);
            this.ViewBTN2.Name = "ViewBTN2";
            this.ViewBTN2.Size = new System.Drawing.Size(123, 38);
            this.ViewBTN2.TabIndex = 11;
            this.ViewBTN2.Text = "Save";
            this.ViewBTN2.UseVisualStyleBackColor = false;
            this.ViewBTN2.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // SaveBTN2
            // 
            this.SaveBTN2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveBTN2.Font = new System.Drawing.Font("Arial", 18F);
            this.SaveBTN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBTN2.Location = new System.Drawing.Point(27, 451);
            this.SaveBTN2.Name = "SaveBTN2";
            this.SaveBTN2.Size = new System.Drawing.Size(123, 38);
            this.SaveBTN2.TabIndex = 8;
            this.SaveBTN2.Text = "Add";
            this.SaveBTN2.UseVisualStyleBackColor = false;
            this.SaveBTN2.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.GenderBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.GenderLabel2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.clearBtn2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.CalcMetricBMI, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.kgsBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmHeight, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.NameLabel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NameBox2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(301, 252);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // GenderBox2
            // 
            this.GenderBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.GenderBox2.FormattingEnabled = true;
            this.GenderBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox2.Location = new System.Drawing.Point(138, 61);
            this.GenderBox2.Name = "GenderBox2";
            this.GenderBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GenderBox2.Size = new System.Drawing.Size(144, 30);
            this.GenderBox2.TabIndex = 2;
            // 
            // GenderLabel2
            // 
            this.GenderLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenderLabel2.AutoSize = true;
            this.GenderLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderLabel2.Location = new System.Drawing.Point(25, 65);
            this.GenderLabel2.Name = "GenderLabel2";
            this.GenderLabel2.Size = new System.Drawing.Size(74, 22);
            this.GenderLabel2.TabIndex = 26;
            this.GenderLabel2.Text = "Gender";
            // 
            // clearBtn2
            // 
            this.clearBtn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBtn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn2.Font = new System.Drawing.Font("Arial", 18F);
            this.clearBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn2.Location = new System.Drawing.Point(8, 202);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(109, 44);
            this.clearBtn2.TabIndex = 5;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = false;
            this.clearBtn2.Click += new System.EventHandler(this.ClearTabData);
            // 
            // CalcMetricBMI
            // 
            this.CalcMetricBMI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalcMetricBMI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CalcMetricBMI.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcMetricBMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CalcMetricBMI.Location = new System.Drawing.Point(124, 202);
            this.CalcMetricBMI.Name = "CalcMetricBMI";
            this.CalcMetricBMI.Size = new System.Drawing.Size(171, 44);
            this.CalcMetricBMI.TabIndex = 6;
            this.CalcMetricBMI.Text = "Calculate BMI";
            this.CalcMetricBMI.UseVisualStyleBackColor = false;
            this.CalcMetricBMI.Click += new System.EventHandler(this.CalcMetricBMI_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Weight (kgs)";
            // 
            // kgsBox
            // 
            this.kgsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kgsBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgsBox.Location = new System.Drawing.Point(138, 160);
            this.kgsBox.Name = "kgsBox";
            this.kgsBox.Size = new System.Drawing.Size(144, 29);
            this.kgsBox.TabIndex = 4;
            this.kgsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmHeight
            // 
            this.cmHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmHeight.AutoSize = true;
            this.cmHeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmHeight.Location = new System.Drawing.Point(9, 114);
            this.cmHeight.Name = "cmHeight";
            this.cmHeight.Size = new System.Drawing.Size(107, 22);
            this.cmHeight.TabIndex = 11;
            this.cmHeight.Text = "Height (cm)";
            // 
            // cmBox
            // 
            this.cmBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBox.Location = new System.Drawing.Point(138, 111);
            this.cmBox.Name = "cmBox";
            this.cmBox.Size = new System.Drawing.Size(144, 29);
            this.cmBox.TabIndex = 3;
            this.cmBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameLabel2
            // 
            this.NameLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameLabel2.Location = new System.Drawing.Point(32, 16);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(60, 22);
            this.NameLabel2.TabIndex = 24;
            this.NameLabel2.Text = "Name";
            // 
            // NameBox2
            // 
            this.NameBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox2.Location = new System.Drawing.Point(138, 13);
            this.NameBox2.Name = "NameBox2";
            this.NameBox2.Size = new System.Drawing.Size(144, 29);
            this.NameBox2.TabIndex = 1;
            this.NameBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryBox2
            // 
            this.categoryBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox2.Location = new System.Drawing.Point(21, 334);
            this.categoryBox2.Name = "categoryBox2";
            this.categoryBox2.ReadOnly = true;
            this.categoryBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryBox2.Size = new System.Drawing.Size(301, 100);
            this.categoryBox2.TabIndex = 7;
            this.categoryBox2.TabStop = false;
            this.categoryBox2.Text = "";
            // 
            // metricResults
            // 
            this.metricResults.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metricResults.AutoSize = true;
            this.metricResults.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricResults.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metricResults.Location = new System.Drawing.Point(188, 285);
            this.metricResults.Name = "metricResults";
            this.metricResults.Size = new System.Drawing.Size(0, 34);
            this.metricResults.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(33, 291);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(140, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "Your BMI is:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 595);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            // 
            // BMIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(811, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tabs);
            this.Name = "BMIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchLabel;
        private System.Windows.Forms.TextBox feetBox;
        private System.Windows.Forms.TextBox inchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label impResults;
        private System.Windows.Forms.RichTextBox categoryBox1;
        private System.Windows.Forms.Label lbsLabel;
        private System.Windows.Forms.TextBox lbsBox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SaveBTN2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cmHeight;
        private System.Windows.Forms.TextBox cmBox;
        private System.Windows.Forms.TextBox kgsBox;
        private System.Windows.Forms.Button CalcMetricBMI;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.RichTextBox categoryBox2;
        private System.Windows.Forms.Label metricResults;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ViewBTN2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox2;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteBTN2;
        private System.Windows.Forms.Button UpdateBTN2;
        private System.Windows.Forms.Label GenderLabel1;
        private System.Windows.Forms.ComboBox GenderBox1;
        private System.Windows.Forms.ComboBox GenderBox2;
        private System.Windows.Forms.Label GenderLabel2;
    }
}

