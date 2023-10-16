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
            cmbcapnha.SelectedIndex = 0;
            List<province> pro = db.provinces.ToList();
            hienthicmbthanhpho(pro);

            List<Gia> gi = db.Gias.ToList();
            hienthicmbgiathuemax(gi);
              
            List<Gia> gi2 = db.Gias.ToList();
            hienthicmbgiathuemin(gi2);

        }

        //listview
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //hiển thị combobox thành phố
        private void hienthicmbthanhpho (List<province> provinces)
        {
            cmbthanhpho.DataSource = provinces;
            cmbthanhpho.DisplayMember = "name";
            cmbthanhpho.ValueMember = "code";
        }

        //hiển thị combobox giá thuê max
        private void hienthicmbgiathuemax(List<Gia> gias)
        {
            cmbgiathuemin.DataSource = gias;
            cmbgiathuemin.DisplayMember = "Giá_thấp_nhất";
        }

        //hiển thị combobox giá thuê min
        private void hienthicmbgiathuemin(List<Gia> gias)
        {
            cmbgiathuemax.DataSource = gias;         
            cmbgiathuemax.DisplayMember = "Giá_cao_nhất";
        }

        //button lọc thêm
        private void btnlocthem_Click(object sender, EventArgs e)
        {
            Locthem floc = new Locthem();
            floc.ShowDialog();
        }
    }
}
