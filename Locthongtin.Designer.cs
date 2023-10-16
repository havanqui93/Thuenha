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
            this.cmbthanhpho = new System.Windows.Forms.ComboBox();
            this.btnlocthem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cmbgiathue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbloainha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // cmbthanhpho
            // 
            this.cmbthanhpho.DisplayMember = "0";
            this.cmbthanhpho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // cmbgiathue
            // 
            this.cmbgiathue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbgiathue, "cmbgiathue");
            this.cmbgiathue.FormattingEnabled = true;
            this.cmbgiathue.Name = "cmbgiathue";
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
            // cmbloainha
            // 
            this.cmbloainha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbloainha, "cmbloainha");
            this.cmbloainha.FormattingEnabled = true;
            this.cmbloainha.Name = "cmbloainha";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // frmlocthongtin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbloainha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbgiathue);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnlocthem);
            this.Controls.Add(this.cmbthanhpho);
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
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.ComboBox cmbthanhpho;
        private System.Windows.Forms.Button btnlocthem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ComboBox cmbgiathue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbloainha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

