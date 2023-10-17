using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuenha.DATATHUENHA;

namespace Thuenha
{
    public partial class Quanly : Form
    {
        Dulieu db;
        public Quanly()
        {
            InitializeComponent();
            db = new Dulieu();
        }

        //form tổng
        private void Quanly_Load(object sender, EventArgs e)
        {
            cmbsopn.SelectedIndex = 0;
            cmbsonvs.SelectedIndex = 0;

            List<Thongtinnha> ttn = db.Thongtinnhas.ToList();
            hienthiDS(ttn);

            List<phanloainha> pln = db.phanloainhas.ToList();
            hienthicmbloainha(pln);
        }

        //hiển thị dữ liệu dgv
        private void hienthiDS(List<Thongtinnha> ttn)
        {
            dgvqldl.Rows.Clear();
            foreach (Thongtinnha item in ttn)
            {
                int index = dgvqldl.Rows.Add();
                dgvqldl.Rows[index].Cells[0].Value = item.manha;
                dgvqldl.Rows[index].Cells[1].Value = item.maloainha;
                dgvqldl.Rows[index].Cells[2].Value = item.dientich;
                dgvqldl.Rows[index].Cells[3].Value = item.sophongngu;
                dgvqldl.Rows[index].Cells[4].Value = item.sonvs;
                dgvqldl.Rows[index].Cells[5].Value = item.diachi;
                dgvqldl.Rows[index].Cells[6].Value = item.giatien;
                dgvqldl.Rows[index].Cells[7].Value = item.ngaydang;
            }      
        }

        //hiển thị cmb loại nhà
        private void hienthicmbloainha(List<phanloainha> plns)
        {
            cmbloainha.DataSource = plns;
            cmbloainha.DisplayMember = "loainha";
            cmbloainha.ValueMember = "maloainha";
        }

        //lấy dữ liệu từ dgv hiển thị lên textbox và combobox
        private void dgvqldl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvqldl.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmanha.Text = row.Cells[0].Value.ToString();
                cmbloainha.Text = row.Cells[1].Value.ToString();
                txtdientich.Text = row.Cells[2].Value.ToString();
                cmbsopn.Text = row.Cells[3].Value.ToString();
                cmbsonvs.Text = row.Cells[4].Value.ToString();
                txtdiachi.Text = row.Cells[5].Value.ToString();
                txtgiatien.Text = row.Cells[6].Value.ToString();
                //dateTimePicker1.Text = row.Cells[7].Value.ToString();

                //Không cho phép sửa trường STT
                //txtmanha.Enabled = false;
            }       
        }

        //kiểm tra mã nhà khi nhập vào
        private bool CheckData()
        {
            if (string.IsNullOrEmpty(txtmanha.Text) || string.IsNullOrEmpty(txtdientich.Text) || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtgiatien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            if (txtmanha.TextLength < 0 && txtmanha.TextLength > 10)
            {
                MessageBox.Show("Mã nhà phải lớn hơn 0 và dưới 10 ký tự !");
                return false;
            }
            if (txtdientich.Text == null)
            {
                MessageBox.Show("Vui lòng nhập diện tích nhà !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //đặt con trỏ vào textbox diện tích
                txtdientich.Focus();
                return false;
            }
            if (txtdiachi.Text == null)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //đặt con trỏ vào textbox địa chỉ
                txtdiachi.Focus();
                return false;
            }
            if (txtgiatien.Text == null)
            {
                MessageBox.Show("Vui lòng nhập giá tiền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //đặt con trỏ vào textbox giá tiền
                txtgiatien.Focus();
                return false;
            }
            return true;
        }

        //button thêm dữ liệu
        private void btnthem_Click(object sender, EventArgs e)
        {

            if(!CheckData())
            {
                return;
            }
            Thongtinnha thongtinnha = new Thongtinnha();
            thongtinnha.manha = txtmanha.Text;
            thongtinnha.maloainha = cmbloainha.ValueMember = "loainha";
            thongtinnha.dientich = txtdientich.Text;
            thongtinnha.sophongngu = Convert.ToInt32(cmbsopn.Text);
            thongtinnha.sonvs = Convert.ToInt32(cmbsonvs.Text);
            thongtinnha.diachi = txtdiachi.Text;
            thongtinnha.giatien = txtgiatien.Text;
            //thongtinnha.ngaydang = dateTimePicker1.Text;

            db.Thongtinnhas.Add(thongtinnha);
            db.SaveChanges();

            MessageBox.Show("Thêm dữ liệu thành công !");
            List<Thongtinnha> stu = db.Thongtinnhas.ToList();
            dgvqldl.Rows.Clear();
            dgvqldl.Refresh();
            hienthiDS(stu);
        }


        //button xóa dữ liêu
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            var st = db.Thongtinnhas.FirstOrDefault(x => x.manha == txtmanha.Text);

            if (st == null)
            {
                MessageBox.Show("Không tìm thấy mã nhà cần xóa!");
            }
            else
            {
                db.Thongtinnhas.Remove(st);
                db.SaveChanges();
                MessageBox.Show("Đã xóa dữ liệu thành công !");
                List<Thongtinnha> stu = db.Thongtinnhas.ToList();
                dgvqldl.Rows.Clear();
                dgvqldl.Refresh();
                hienthiDS(stu);
            }
        }

       
    }
}
