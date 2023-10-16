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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvdata = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvloainha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgaitien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsónv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pichinhanh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
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
            // dgvdata
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvloainha,
            this.dgvgaitien,
            this.dgvdiachi,
            this.dgvsophong,
            this.dgvsónv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.dgvdata, "dgvdata");
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersVisible = false;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdata.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvdata.ThemeStyle.ReadOnly = false;
            this.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdata.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvdata.ThemeStyle.RowsStyle.Height = 24;
            this.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvloainha
            // 
            resources.ApplyResources(this.dgvloainha, "dgvloainha");
            this.dgvloainha.Name = "dgvloainha";
            // 
            // dgvgaitien
            // 
            resources.ApplyResources(this.dgvgaitien, "dgvgaitien");
            this.dgvgaitien.Name = "dgvgaitien";
            // 
            // dgvdiachi
            // 
            resources.ApplyResources(this.dgvdiachi, "dgvdiachi");
            this.dgvdiachi.Name = "dgvdiachi";
            // 
            // dgvsophong
            // 
            resources.ApplyResources(this.dgvsophong, "dgvsophong");
            this.dgvsophong.Name = "dgvsophong";
            // 
            // dgvsónv
            // 
            resources.ApplyResources(this.dgvsónv, "dgvsónv");
            this.dgvsónv.Name = "dgvsónv";
            // 
            // pichinhanh
            // 
            this.pichinhanh.ImageRotate = 0F;
            resources.ApplyResources(this.pichinhanh, "pichinhanh");
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Name = "label2";
            // 
            // frmlocthongtin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pichinhanh);
            this.Controls.Add(this.dgvdata);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloainha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgaitien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsónv;
        private Guna.UI2.WinForms.Guna2PictureBox pichinhanh;
        private System.Windows.Forms.Label label2;
    }
}

