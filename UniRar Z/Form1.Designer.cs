namespace UniRar_Z
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.localeCombobox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeUniRarZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listView = new System.Windows.Forms.ListView();
            this.File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.extractBTN = new System.Windows.Forms.Button();
            this.loadBTN = new System.Windows.Forms.Button();
            this.loadCmpressedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // localeCombobox
            // 
            this.localeCombobox.FormattingEnabled = true;
            this.localeCombobox.Items.AddRange(new object[] {
            "Japan : ja-JP",
            "China : zh-CN",
            "Korea : ko-KR",
            "India : hi-IN",
            "Italy : it-IT",
            "United States : en-US",
            "Egypt : ar-EG"});
            this.localeCombobox.Location = new System.Drawing.Point(15, 66);
            this.localeCombobox.Name = "localeCombobox";
            this.localeCombobox.Size = new System.Drawing.Size(303, 21);
            this.localeCombobox.TabIndex = 2;
            this.localeCombobox.Text = "Japan : ja-JP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCmpressedFileToolStripMenuItem,
            this.extractDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeUniRarZToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // closeUniRarZToolStripMenuItem
            // 
            this.closeUniRarZToolStripMenuItem.Name = "closeUniRarZToolStripMenuItem";
            this.closeUniRarZToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeUniRarZToolStripMenuItem.Text = "Close UniRar Z";
            this.closeUniRarZToolStripMenuItem.Click += new System.EventHandler(this.closeUniRarZToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "1.Select Original Locale\r\n(note: restart the program for different locale)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "2.Select file to extract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "3.Extract your data";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 435);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(303, 12);
            this.progressBar.TabIndex = 8;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.File,
            this.Size,
            this.Ext});
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(15, 183);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(303, 165);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // File
            // 
            this.File.Text = "File";
            this.File.Width = 179;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Size.Width = 80;
            // 
            // Ext
            // 
            this.Ext.Text = "Ext";
            this.Ext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ext.Width = 40;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1447393984_OK.png");
            this.imageList1.Images.SetKeyName(1, "1447394030_No_entry.png");
            // 
            // stopBtn
            // 
            this.stopBtn.Image = global::UniRar_Z.Properties.Resources.f34434cf;
            this.stopBtn.Location = new System.Drawing.Point(168, 369);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(150, 60);
            this.stopBtn.TabIndex = 10;
            this.stopBtn.Text = "Stop Process";
            this.stopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // extractBTN
            // 
            this.extractBTN.Image = global::UniRar_Z.Properties.Resources.extract_love1;
            this.extractBTN.Location = new System.Drawing.Point(15, 369);
            this.extractBTN.Name = "extractBTN";
            this.extractBTN.Size = new System.Drawing.Size(150, 60);
            this.extractBTN.TabIndex = 1;
            this.extractBTN.Text = "Extract Data";
            this.extractBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.extractBTN.UseVisualStyleBackColor = true;
            this.extractBTN.Click += new System.EventHandler(this.extractBTN_Click);
            // 
            // loadBTN
            // 
            this.loadBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loadBTN.Image = global::UniRar_Z.Properties.Resources.Folder_Archive_zip_icon;
            this.loadBTN.Location = new System.Drawing.Point(15, 117);
            this.loadBTN.Name = "loadBTN";
            this.loadBTN.Size = new System.Drawing.Size(303, 60);
            this.loadBTN.TabIndex = 0;
            this.loadBTN.Text = "Load Compressed File(s)";
            this.loadBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadBTN.UseVisualStyleBackColor = true;
            this.loadBTN.Click += new System.EventHandler(this.loadBTN_Click);
            // 
            // loadCmpressedFileToolStripMenuItem
            // 
            this.loadCmpressedFileToolStripMenuItem.Image = global::UniRar_Z.Properties.Resources.Folder_Archive_zip_icon;
            this.loadCmpressedFileToolStripMenuItem.Name = "loadCmpressedFileToolStripMenuItem";
            this.loadCmpressedFileToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loadCmpressedFileToolStripMenuItem.Text = "Load Compressed File(s)";
            this.loadCmpressedFileToolStripMenuItem.Click += new System.EventHandler(this.loadCmpressedFileToolStripMenuItem_Click);
            // 
            // extractDataToolStripMenuItem
            // 
            this.extractDataToolStripMenuItem.Image = global::UniRar_Z.Properties.Resources.extract_love1;
            this.extractDataToolStripMenuItem.Name = "extractDataToolStripMenuItem";
            this.extractDataToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.extractDataToolStripMenuItem.Text = "Extract Data";
            this.extractDataToolStripMenuItem.Click += new System.EventHandler(this.extractDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 451);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localeCombobox);
            this.Controls.Add(this.extractBTN);
            this.Controls.Add(this.loadBTN);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniRar Z - Unicode File Decompressor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadBTN;
        private System.Windows.Forms.Button extractBTN;
        private System.Windows.Forms.ComboBox localeCombobox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCmpressedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeUniRarZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Ext;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button stopBtn;
    }
}

