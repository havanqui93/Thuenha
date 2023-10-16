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
    public partial class Locthem : Form
    {

        Dulieu db;
        public Locthem()
        {
            InitializeComponent();
            db = new Dulieu();
        }

        private void Locthem_Load(object sender, EventArgs e)
        {
            cmbphongngu.SelectedIndex = 0;
            cmbnsv.SelectedIndex = 0;
            List<Locdientich> ldt = db.Locdientiches.ToList();
            hienthicmbdientich(ldt);
        }

        //button xóa lọc
        private void btnxoaloc_Click(object sender, EventArgs e)
        {
            cmbnsv.SelectedIndex = 0;
            cmbphongngu.SelectedIndex = 0;
            cmbdientich.SelectedIndex = 0;
        }

        //hiển thị cmb lọc diện tích
        private void hienthicmbdientich(List<Locdientich> locdientiches)
        {
            cmbdientich.DataSource = locdientiches;
            cmbdientich.DisplayMember = "locdientich1";
            cmbdientich.ValueMember = "code";
        }
    }
}
