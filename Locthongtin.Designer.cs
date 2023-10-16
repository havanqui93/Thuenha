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
            this.cmbthanhpho = new System.Windows.Forms.ComboBox();
            this.btnlocthem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cmbgiathuemin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbgiathuemax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // cmbthanhpho
            // 
            this.cmbthanhpho.DisplayMember = "0";
            resources.ApplyResources(this.cmbthanhpho, "cmbthanhpho");
            this.cmbthanhpho.FormattingEnabled = true;
            this.cmbthanhpho.Items.AddRange(new object[] {
            resources.GetString("cmbthanhpho.Items"),
            resources.GetString("cmbthanhpho.Items1"),
            resources.GetString("cmbthanhpho.Items2"),
            resources.GetString("cmbthanhpho.Items3"),
            resources.GetString("cmbthanhpho.Items4")});
            this.cmbthanhpho.Name = "cmbthanhpho";
            // 
            // btnlocthem
            // 
            resources.ApplyResources(this.btnlocthem, "btnlocthem");
            this.btnlocthem.Name = "btnlocthem";
            this.btnlocthem.UseVisualStyleBackColor = true;
            this.btnlocthem.Click += new System.EventHandler(this.btnlocthem_Click);
            // 
            // btntimkiem
            // 
            resources.ApplyResources(this.btntimkiem, "btntimkiem");
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // cmbgiathuemin
            // 
            resources.ApplyResources(this.cmbgiathuemin, "cmbgiathuemin");
            this.cmbgiathuemin.FormattingEnabled = true;
            this.cmbgiathuemin.Name = "cmbgiathuemin";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbgiathuemax
            // 
            resources.ApplyResources(this.cmbgiathuemax, "cmbgiathuemax");
            this.cmbgiathuemax.FormattingEnabled = true;
            this.cmbgiathuemax.Name = "cmbgiathuemax";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Name = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // frmlocthongtin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbgiathuemax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbgiathuemin);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnlocthem);
            this.Controls.Add(this.cmbthanhpho);
            this.Controls.Add(this.cmbcapnha);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlocthongtin";
            this.Load += new System.EventHandler(this.frmlocthongtin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbcapnha;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.ComboBox cmbthanhpho;
        private System.Windows.Forms.Button btnlocthem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbgiathuemin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgiathuemax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

