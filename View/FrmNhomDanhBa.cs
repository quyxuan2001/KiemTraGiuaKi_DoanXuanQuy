using Kiemtragiuaki_DoanXuanQuy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemtraGiuaKi_DoanXuanQuy
{
    public partial class FrmNhomDanhBa : Form
    {
        public FrmNhomDanhBa()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var rs = new NhomDanhBa
            {
                TenNhom = txtTenNhom.Text
            };
            var kq = NhomDanhBaServices.ThemNhomDanhBa(rs);
            if (kq == true) DialogResult = DialogResult.OK;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhomDanhBa_Load(object sender, EventArgs e)
        {

        }
    }
}
