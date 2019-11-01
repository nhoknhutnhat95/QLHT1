using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        static int limit;
        static int total_record;
        static int current_page=1;
        static double total_page;
        int start;
        string tableName = "Login";
        private void NhanVien_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.BackgroundColor = this.BackColor;
            comboBox1.Text = "5";
            limit = Convert.ToInt32(comboBox1.Text.ToString().Trim());
            PhanTrang.Init(tableName, limit,ref total_record,ref total_page, bunifuDataGridView1);
            txtPage.Text = "1/" + total_page;
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PhanTrang.btnNext(ref current_page, total_page, limit, start, bunifuDataGridView1, tableName);
            txtPage.Text = current_page + "/" + total_page;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            PhanTrang.btnPrev(ref current_page, total_page, limit, start, bunifuDataGridView1, tableName);
            txtPage.Text = current_page + "/" + total_page;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            PhanTrang.btnLast(ref current_page, total_page, limit, start, bunifuDataGridView1, tableName);
            txtPage.Text = current_page + "/" + total_page;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PhanTrang.btnFirst(ref current_page, total_page, limit, start, bunifuDataGridView1, tableName);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            limit = Convert.ToInt32(comboBox1.SelectedItem.ToString().Trim());
            total_page = Math.Ceiling((double)total_record / limit);
            txtPage.Text = current_page + "/" + total_page;
            PhanTrang.toGridView(limit, start,bunifuDataGridView1, tableName);
        }
    }
}
