namespace Thuenha
{
    partial class frmlocthongtin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlocthongtin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblt = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbcapnha = new System.Windows.Forms.ComboBox();
            this.cmbgiathue = new System.Windows.Forms.ComboBox();
            this.btnlocthem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblt);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnclose
            // 
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblt
            // 
            resources.ApplyResources(this.lblt, "lblt");
            this.lblt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblt.Name = "lblt";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtsearch, "txtsearch");
            this.txtsearch.Name = "txtsearch";
            // 
            // cmbcapnha
            // 
            this.cmbcapnha.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.cmbcapnha, "cmbcapnha");
            this.cmbcapnha.FormattingEnabled = true;
            this.cmbcapnha.Items.AddRange(new object[] {
            resources.GetString("cmbcapnha.Items"),
            resources.GetString("cmbcapnha.Items1"),
            resources.GetString("cmbcapnha.Items2"),
            resources.GetString("cmbcapnha.Items3"),
            resources.GetString("cmbcapnha.Items4")});
            this.cmbcapnha.Name = "cmbcapnha";
            // 
            // cmbgiathue
            // 
            this.cmbgiathue.DisplayMember = "0";
            resources.ApplyResources(this.cmbgiathue, "cmbgiathue");
            this.cmbgiathue.FormattingEnabled = true;
            this.cmbgiathue.Items.AddRange(new object[] {
            resources.GetString("cmbgiathue.Items"),
            resources.GetString("cmbgiathue.Items1"),
            resources.GetString("cmbgiathue.Items2"),
            resources.GetString("cmbgiathue.Items3"),
            resources.GetString("cmbgiathue.Items4")});
            this.cmbgiathue.Name = "cmbgiathue";
            // 
            // btnlocthem
            // 
            resources.ApplyResources(this.btnlocthem, "btnlocthem");
            this.btnlocthem.Name = "btnlocthem";
            this.btnlocthem.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            resources.ApplyResources(this.btntimkiem, "btntimkiem");
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items1"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items2"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listView1.Items3")))});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // frmlocthongtin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnlocthem);
            this.Controls.Add(this.cmbgiathue);
            this.Controls.Add(this.cmbcapnha);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlocthongtin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbcapnha;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.ComboBox cmbgiathue;
        private System.Windows.Forms.Button btnlocthem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

