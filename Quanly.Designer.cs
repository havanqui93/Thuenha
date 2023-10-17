namespace Thuenha
{
    partial class Quanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanly));
            this.dgvqldl = new System.Windows.Forms.DataGridView();
            this.dgvmanha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvloainha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdientich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsopn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsonvs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgiatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngaydang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.picanhnha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbsonvs = new System.Windows.Forms.ComboBox();
            this.cmbsopn = new System.Windows.Forms.ComboBox();
            this.cmbloainha = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtgiatien = new System.Windows.Forms.TextBox();
            this.txtdientich = new System.Windows.Forms.TextBox();
            this.txtmanha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqldl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanhnha)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvqldl
            // 
            this.dgvqldl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqldl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmanha,
            this.dgvloainha,
            this.dgvdientich,
            this.dgvsopn,
            this.dgvsonvs,
            this.dgvdiachi,
            this.dgvgiatien,
            this.dgvngaydang});
            this.dgvqldl.Location = new System.Drawing.Point(326, 239);
            this.dgvqldl.Name = "dgvqldl";
            this.dgvqldl.RowHeadersWidth = 51;
            this.dgvqldl.RowTemplate.Height = 24;
            this.dgvqldl.Size = new System.Drawing.Size(915, 467);
            this.dgvqldl.TabIndex = 0;
            this.dgvqldl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqldl_CellClick);
            // 
            // dgvmanha
            // 
            this.dgvmanha.HeaderText = "Mã nhà";
            this.dgvmanha.MinimumWidth = 6;
            this.dgvmanha.Name = "dgvmanha";
            this.dgvmanha.Width = 80;
            // 
            // dgvloainha
            // 
            this.dgvloainha.HeaderText = "Loại nhà";
            this.dgvloainha.MinimumWidth = 6;
            this.dgvloainha.Name = "dgvloainha";
            this.dgvloainha.Width = 125;
            // 
            // dgvdientich
            // 
            this.dgvdientich.HeaderText = "Diện tích";
            this.dgvdientich.MinimumWidth = 6;
            this.dgvdientich.Name = "dgvdientich";
            this.dgvdientich.Width = 70;
            // 
            // dgvsopn
            // 
            this.dgvsopn.HeaderText = "Số phòng ngủ";
            this.dgvsopn.MinimumWidth = 6;
            this.dgvsopn.Name = "dgvsopn";
            this.dgvsopn.Width = 50;
            // 
            // dgvsonvs
            // 
            this.dgvsonvs.HeaderText = "Số nhà vệ sinh";
            this.dgvsonvs.MinimumWidth = 6;
            this.dgvsonvs.Name = "dgvsonvs";
            this.dgvsonvs.Width = 50;
            // 
            // dgvdiachi
            // 
            this.dgvdiachi.HeaderText = "Địa chỉ";
            this.dgvdiachi.MinimumWidth = 6;
            this.dgvdiachi.Name = "dgvdiachi";
            this.dgvdiachi.Width = 125;
            // 
            // dgvgiatien
            // 
            this.dgvgiatien.HeaderText = "Giá tiền";
            this.dgvgiatien.MinimumWidth = 6;
            this.dgvgiatien.Name = "dgvgiatien";
            this.dgvgiatien.Width = 125;
            // 
            // dgvngaydang
            // 
            this.dgvngaydang.HeaderText = "Ngày đăng";
            this.dgvngaydang.MinimumWidth = 6;
            this.dgvngaydang.Name = "dgvngaydang";
            this.dgvngaydang.Width = 125;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Location = new System.Drawing.Point(1066, 18);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(71, 67);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Location = new System.Drawing.Point(1066, 91);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(148, 64);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Location = new System.Drawing.Point(1143, 18);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(71, 67);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            // 
            // picanhnha
            // 
            this.picanhnha.Location = new System.Drawing.Point(12, 457);
            this.picanhnha.Name = "picanhnha";
            this.picanhnha.Size = new System.Drawing.Size(297, 249);
            this.picanhnha.TabIndex = 4;
            this.picanhnha.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(424, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý nhà ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmbsonvs);
            this.groupBox1.Controls.Add(this.cmbsopn);
            this.groupBox1.Controls.Add(this.cmbloainha);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtgiatien);
            this.groupBox1.Controls.Add(this.txtdientich);
            this.groupBox1.Controls.Add(this.txtmanha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý thông tin nhà";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(704, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cmbsonvs
            // 
            this.cmbsonvs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsonvs.FormattingEnabled = true;
            this.cmbsonvs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbsonvs.Location = new System.Drawing.Point(433, 77);
            this.cmbsonvs.Name = "cmbsonvs";
            this.cmbsonvs.Size = new System.Drawing.Size(152, 26);
            this.cmbsonvs.TabIndex = 18;
            // 
            // cmbsopn
            // 
            this.cmbsopn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsopn.FormattingEnabled = true;
            this.cmbsopn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbsopn.Location = new System.Drawing.Point(433, 36);
            this.cmbsopn.Name = "cmbsopn";
            this.cmbsopn.Size = new System.Drawing.Size(152, 26);
            this.cmbsopn.TabIndex = 17;
            // 
            // cmbloainha
            // 
            this.cmbloainha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloainha.FormattingEnabled = true;
            this.cmbloainha.Location = new System.Drawing.Point(80, 77);
            this.cmbloainha.Name = "cmbloainha";
            this.cmbloainha.Size = new System.Drawing.Size(185, 26);
            this.cmbloainha.TabIndex = 16;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(704, 36);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(334, 24);
            this.txtdiachi.TabIndex = 15;
            // 
            // txtgiatien
            // 
            this.txtgiatien.Location = new System.Drawing.Point(704, 121);
            this.txtgiatien.Name = "txtgiatien";
            this.txtgiatien.Size = new System.Drawing.Size(334, 24);
            this.txtgiatien.TabIndex = 14;
            // 
            // txtdientich
            // 
            this.txtdientich.Location = new System.Drawing.Point(80, 121);
            this.txtdientich.Name = "txtdientich";
            this.txtdientich.Size = new System.Drawing.Size(185, 24);
            this.txtdientich.TabIndex = 13;
            // 
            // txtmanha
            // 
            this.txtmanha.Location = new System.Drawing.Point(80, 36);
            this.txtmanha.Name = "txtmanha";
            this.txtmanha.Size = new System.Drawing.Size(185, 24);
            this.txtmanha.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(620, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày đăng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số nhà vệ sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số phòng ngủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diện tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại nhà";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhà";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 212);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Quanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 718);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picanhnha);
            this.Controls.Add(this.dgvqldl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quanly";
            this.Text = "Quản lý nhà";
            this.Load += new System.EventHandler(this.Quanly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqldl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanhnha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvqldl;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.PictureBox picanhnha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtgiatien;
        private System.Windows.Forms.TextBox txtdientich;
        private System.Windows.Forms.TextBox txtmanha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbsonvs;
        private System.Windows.Forms.ComboBox cmbsopn;
        private System.Windows.Forms.ComboBox cmbloainha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmanha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvloainha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdientich;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsopn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsonvs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgiatien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngaydang;
    }
}