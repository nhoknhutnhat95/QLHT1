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
    public partial class BanHangUC : UserControl
    {
        
        public BanHangUC()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void BanHangUC_Load(object sender, EventArgs e)
        {
            //DataTable dt= KetNoi.LayDL("select MaThuoc,TenThuoc,MaNhaCC,HanDung,DonGia,DVT from Thuoc");
            //bunifuDataGridView1.DataSource = dt;
            

            KetNoi.autocompleteTextbox(txtTimKiem, "select TenThuoc from Thuoc");
            BHUC_txtNguoiBan.Text = Login.name;
        }


        private void txtTimKiem_TextChange(object sender, EventArgs e)
        {
            if (txtTimKiem.AutoCompleteCustomSource.IndexOf(txtTimKiem.Text)>=0)
            {
                
                dt = KetNoi.LayDL("select MaThuoc,TenThuoc,MaNhaCC,HanDung,DonGia,DVT from Thuoc where TenThuoc = N'"+txtTimKiem.Text+"'");
                DataRow dr = dt.Rows[0];
                DateTime dti = Convert.ToDateTime(dr["HanDung"].ToString());
                String HanDung = String.Format("{0:M/d/yyyy}", dti);
                String[] row = new String[] { dr["MaThuoc"].ToString(), dr["TenThuoc"].ToString(), dr["MaNhaCC"].ToString(), HanDung, dr["DonGia"].ToString(), dr["DVT"].ToString() };
                for (int i = 0; i < dgvOrder.Rows.Count-1; i++)
                {
                    if (row[0]==dgvOrder.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Thuốc đã có trong đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                dgvOrder.Rows.Add(row); 
            }
        }   
        private void bunifuDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double tongTien = 0;
            if (dgvOrder.Rows.Count > 1)
            {
                if (e.ColumnIndex==6)
                {
                    try
                    {
                        dgvOrder.CurrentRow.Cells[7].Value = Convert.ToDouble(dgvOrder.CurrentRow.Cells[4].Value) * Convert.ToDouble(dgvOrder.CurrentRow.Cells[6].Value);
                        for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                        {
                            tongTien += Convert.ToDouble(dgvOrder.Rows[i].Cells[7].Value.ToString());
                        }
                        BHUC_txtTTTT.Text = tongTien.ToString();
                        BHUC_txtKPTT.Text = (tongTien * 105 / 100).ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bạn chưa nhập số lượng hoặc số lượng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==8)
            {
                if (dgvOrder.CurrentRow.Index + 1 == dgvOrder.Rows.Count)
                {
                    return;
                }
                dgvOrder.Rows.Remove(dgvOrder.CurrentRow);
            }
        }

        private void BHUC_KTT_TextChanged(object sender, EventArgs e)
        {
            if (BHUC_KTT.Text == "")
            {
                BHUC_txtTTTK.Text = "";
            }
            else
            {
                try
                {
                    BHUC_txtTTTK.Text = (Convert.ToDouble(BHUC_KTT.Text.ToString()) - Convert.ToDouble(BHUC_txtKPTT.Text.ToString())).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvOrder.Rows.Count>1)
            {
                if (dgvOrder.CurrentRow.Index+1 == dgvOrder.Rows.Count)
                {
                    rtxtDetails.Text = "";
                    return;
                }
                DataTable dt = KetNoi.LayDL("select ChiTiet from Thuoc where MaThuoc ='" + dgvOrder.CurrentRow.Cells[0].Value.ToString() + "'");
                object a = dt.Rows[0]["ChiTiet"];
                rtxtDetails.Text = Convert.ToString(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timeBan.Value.ToString("MM/dd/yyyy"));
        }
    }
}
 