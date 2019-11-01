using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.Size = new Size(336, 642);
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            showLogin.Start();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            showReg.Start();
        }
        int x = 342;
        private void showReg_Tick(object sender, EventArgs e)
        {

            int go = 4;
            if (x > 0)
            {
                panelReg.Location = new Point(panelReg.Location.X - go, panelReg.Location.Y);
                x = x - go;
                if (x <= 0)
                {
                    showReg.Stop();
                    x1 = 0;
                }
            }
        }
        int x1 = 0;
        private void showLogin_Tick(object sender, EventArgs e)
        {
            int go = 4;
            if (x1 < 342)
            {
                panelReg.Location = new Point(panelReg.Location.X + go, panelReg.Location.Y);
                x1 = x1 + go;
                if (x1 >= 342)
                {
                    showLogin.Stop();
                    x = 342;
                }
            }
        }
        private void ErrorProvider(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox a ,String str)
        {
            if (String.IsNullOrEmpty(a.Text))
            {
                errorProvider1.SetError(a, str);
            }
        }
        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(txtUser, "Tên đăng nhập không được để trống");
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(txtPass, "Mật khẩu không được để trống");
        }

        private void txtUserReg_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(txtUserReg, "Tên đăng ký không được để trống");
        }

        private void txtPassReg_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(txtPassReg, "Mật khẩu không được để trống");
        }

        private void txtLevel_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider(txtLevel, "Cấp độ không được để trống");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_TextChange(object sender, EventArgs e)
        {
            if (!txtPass.Modified)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
        bool show = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (show)
            {
                txtPass.PasswordChar = (char)0;
                show = !show;
                btnShow.Image = Properties.Resources.invisible_32px;
            }
            else
            {
                txtPass.PasswordChar = '*';
                show = !show;
                btnShow.Image = Properties.Resources.visible_32px;
            }
        }

        public static String name;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Loadding a = new Loadding();
            SqlDataReader dr = KetNoi.check("select * from Login where Username='" + txtUser.Text + "' and Password='" + txtPass.Text + "'");
            if (dr.Read())
            {
                name = dr.GetString(0);
                this.Hide();
                a.Show();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Loadding a = new Loadding();
                SqlDataReader dr = KetNoi.check("select * from Login where Username='" + txtUser.Text + "' and Password='" + txtPass.Text + "'");
                if (dr.Read())
                {
                    name = dr.GetString(0);
                    this.Hide();
                    a.Show();

                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
