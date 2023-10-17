using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuenha.DATATHUENHA;

namespace Thuenha
{
    public partial class frmlocthongtin : Form
    {
        Dulieu db;
        public frmlocthongtin()
        {
            InitializeComponent();
            db = new Dulieu();
        }

        //button close
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //form tổng
        private void frmlocthongtin_Load(object sender, EventArgs e)
        {
            List<province> pro = db.provinces.ToList();
            hienthicmbthanhpho(pro);

            List<Gia> gi = db.Gias.ToList();
            hienthicmbgiathue(gi);

            List<phanloainha> pln = db.phanloainhas.ToList();
            hienthicmbloainha(pln);

            List<Thongtinnha> ttn = db.Thongtinnhas.ToList();
            hienthiDS(ttn);

        }

        //hiển thị dữ liệu dgv
        private void hienthiDS(List<Thongtinnha> ttn)
        {
            dgvdata.Rows.Clear();
            foreach (Thongtinnha item in ttn)
            {
                int index = dgvdata.Rows.Add();
                dgvdata.Rows[index].Cells[0].Value = item.manha;
                dgvdata.Rows[index].Cells[1].Value = item.maloainha;
                dgvdata.Rows[index].Cells[2].Value = item.dientich;
                dgvdata.Rows[index].Cells[3].Value = item.sophongngu;
                dgvdata.Rows[index].Cells[4].Value = item.sonvs;
                dgvdata.Rows[index].Cells[5].Value = item.diachi;
                dgvdata.Rows[index].Cells[6].Value = item.giatien;
                dgvdata.Rows[index].Cells[7].Value = item.ngaydang;
            }      
        }


        //hiển thị combobox thành phố
        private void hienthicmbthanhpho (List<province> provinces)
        {
            cmbthanhpho.DataSource = provinces;
            cmbthanhpho.DisplayMember = "name";
            cmbthanhpho.ValueMember = "code";
        }

        //hiển thị combobox giá thuê 
        private void hienthicmbgiathue(List<Gia> gias)
        {
            cmbgiathue.DataSource = gias;
            cmbgiathue.DisplayMember = "Gia1";
            cmbgiathue.ValueMember = "code";
        }

        //hiển thị cmb loại nhà
        private void hienthicmbloainha(List<phanloainha> plns)
        {
            cmbloainha.DataSource = plns;
            cmbloainha.DisplayMember = "loainha";
            cmbloainha.ValueMember = "maloainha";
        }

        //button lọc thêm
        private void btnlocthem_Click(object sender, EventArgs e)
        {
            Locthem floc = new Locthem();
            floc.ShowDialog();
        }
    }
}
