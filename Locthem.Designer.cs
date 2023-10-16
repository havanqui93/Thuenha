namespace Thuenha
{
    partial class Locthem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locthem));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbnsv = new System.Windows.Forms.ComboBox();
            this.cmbphongngu = new System.Windows.Forms.ComboBox();
            this.cmbdientich = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoaloc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(237, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bộ lọc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbnsv);
            this.groupBox1.Controls.Add(this.cmbphongngu);
            this.groupBox1.Controls.Add(this.cmbdientich);
            this.groupBox1.Controls.Add(this.btntimkiem);
            this.groupBox1.Controls.Add(this.btnxoaloc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(123, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 405);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbnsv
            // 
            this.cmbnsv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnsv.FormattingEnabled = true;
            this.cmbnsv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbnsv.Location = new System.Drawing.Point(180, 210);
            this.cmbnsv.Name = "cmbnsv";
            this.cmbnsv.Size = new System.Drawing.Size(305, 24);
            this.cmbnsv.TabIndex = 10;
            // 
            // cmbphongngu
            // 
            this.cmbphongngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbphongngu.FormattingEnabled = true;
            this.cmbphongngu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbphongngu.Location = new System.Drawing.Point(180, 147);
            this.cmbphongngu.Name = "cmbphongngu";
            this.cmbphongngu.Size = new System.Drawing.Size(305, 24);
            this.cmbphongngu.TabIndex = 9;
            // 
            // cmbdientich
            // 
            this.cmbdientich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdientich.FormattingEnabled = true;
            this.cmbdientich.Location = new System.Drawing.Point(180, 83);
            this.cmbdientich.Name = "cmbdientich";
            this.cmbdientich.Size = new System.Drawing.Size(305, 24);
            this.cmbdientich.TabIndex = 8;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Location = new System.Drawing.Point(242, 342);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(216, 46);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            // 
            // btnxoaloc
            // 
            this.btnxoaloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoaloc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnxoaloc.Location = new System.Drawing.Point(94, 342);
            this.btnxoaloc.Name = "btnxoaloc";
            this.btnxoaloc.Size = new System.Drawing.Size(118, 46);
            this.btnxoaloc.TabIndex = 5;
            this.btnxoaloc.Text = "Xóa lọc";
            this.btnxoaloc.UseVisualStyleBackColor = true;
            this.btnxoaloc.Click += new System.EventHandler(this.btnxoaloc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(39, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số nhà vệ sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian đăng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phòng ngủ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diện tích";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 269);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Locthem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Locthem";
            this.Text = "Lọc thêm";
            this.Load += new System.EventHandler(this.Locthem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoaloc;
        private System.Windows.Forms.ComboBox cmbnsv;
        private System.Windows.Forms.ComboBox cmbphongngu;
        private System.Windows.Forms.ComboBox cmbdientich;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}