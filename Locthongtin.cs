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
