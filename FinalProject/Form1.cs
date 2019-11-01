using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMenu_Click(object sender, EventArgs e)
        {
            t5 = new Thread(An);
            t6 = new Thread(An);
            if (panelMenu.Width==45)
            {
                btnTongQuan.Text = "Tổng quan";
                btnQuanTri.Text = "Quản trị";
                btnLienHe.Text = "Liên hệ - Góp ý";
                btnKho.Text = "Quản lý kho";
                btnHoaDon.Text = "Quản lý hóa đơn";
                btnDangXuat.Text = "Đăng xuất";
                btnBaoCao.Text = "Báo cáo";
                btnBanHang.Text = "Bán hàng";
                panelMenu.Visible = false;
                panelMenu.Width = 190;
                Show.ShowSync(panelMenu);
                bntMenu.Image = Properties.Resources.back_32px;
                
            }
            else
            {
                t5.Start(plKho);
                t6.Start(plQT);
                btnTongQuan.Text = "";
                btnQuanTri.Text = "";
                btnLienHe.Text = "";
                btnKho.Text = "";
                btnHoaDon.Text = "";
                btnDangXuat.Text = "";
                btnBaoCao.Text = "";
                btnBanHang.Text = "";
                panelMenu.Visible = false;
                panelMenu.Width = 45;
                Hide.ShowSync(panelMenu);
                bntMenu.Image = Properties.Resources.menu_32px;
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTongQuan.MouseHover += panelMenu_MouseHover;
            btnQuanTri.MouseHover += panelMenu_MouseHover;
            btnLienHe.MouseHover += panelMenu_MouseHover;
            btnKho.MouseHover += panelMenu_MouseHover;
            btnHoaDon.MouseHover += panelMenu_MouseHover;
            btnDangXuat.MouseHover += panelMenu_MouseHover;
            btnBanHang.MouseHover += panelMenu_MouseHover;
            btnBaoCao.MouseHover += panelMenu_MouseHover;
            trangChuUC1.BringToFront();
        }

        private void panelMenu_MouseHover(object sender, EventArgs e)
        {
            if (panelMenu.Width == 45)
            {
                btnTongQuan.Text = "Tổng quan";
                btnQuanTri.Text = "Quản trị";
                btnLienHe.Text = "Liên hệ - Góp ý";
                btnKho.Text = "Quản lý kho";
                btnHoaDon.Text = "Quản lý hóa đơn";
                btnDangXuat.Text = "Đăng xuất";
                btnBaoCao.Text = "Báo cáo";
                btnBanHang.Text = "Bán hàng";
                panelMenu.Visible = false;
                panelMenu.Width = 190;
                Show.ShowSync(panelMenu);
                bntMenu.Image = Properties.Resources.back_32px;
                
            }
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            trangChuUC1.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            banHangUC1.BringToFront();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hoaDon1.BringToFront();
        }


        Thread t1, t2, t3, t4, t5, t6;

        private void button4_Click(object sender, EventArgs e)
        {
            nhanVien1.BringToFront();
        }


        private void btnKho_Click(object sender, EventArgs e)
        {
            t1 = new Thread(Hien);
            t2 = new Thread(An);
            if (plKho.Visible)
            {   
                Hide.HideSync(plKho);
            }
            else
            {
                plKho.BringToFront();
                t1.Start(plKho);
                t2.Start(plQT);
            }
            
        }

        
        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            t3 = new Thread(Hien);
            t4 = new Thread(An);
            if (plQT.Visible)
            {
                Hide.HideSync(plQT);              
            }
            else
            {
                plQT.BringToFront();
                t3.Start(plQT);
                t4.Start(plKho);  
            }          
        }
        private void An(Object a)
        {
            Panel b = (Panel)a;
            Hide.HideSync(b);
        }
        private void Hien(Object a)
        {
            Panel b = (Panel)a;
            Show.ShowSync(b);
        }
    }
}
