namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation5 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation6 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Show = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnLienHe = new System.Windows.Forms.Button();
            this.btnQuanTri = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.banHangUC1 = new FinalProject.BanHangUC();
            this.hoaDon1 = new FinalProject.HoaDon();
            this.trangChuUC1 = new FinalProject.TrangChuUC();
            this.plKho = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plQT = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Hide = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.nhanVien1 = new FinalProject.NhanVien();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.plKho.SuspendLayout();
            this.plQT.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bntMenu);
            this.panel1.Controls.Add(this.btnClose);
            this.Hide.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Show.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 31);
            this.panel1.TabIndex = 0;
            // 
            // bntMenu
            // 
            this.bntMenu.BackColor = System.Drawing.Color.Transparent;
            this.Show.SetDecoration(this.bntMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.bntMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bntMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntMenu.FlatAppearance.BorderSize = 0;
            this.bntMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMenu.Image = global::FinalProject.Properties.Resources.menu_32px;
            this.bntMenu.Location = new System.Drawing.Point(0, 0);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(45, 31);
            this.bntMenu.TabIndex = 2;
            this.bntMenu.UseVisualStyleBackColor = false;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.Show.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnClose, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FinalProject.Properties.Resources.delete_sign_24px;
            this.btnClose.Location = new System.Drawing.Point(667, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Show
            // 
            this.Show.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Show.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.Show.DefaultAnimation = animation5;
            this.Show.TimeStep = 0.01F;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnLienHe);
            this.panelMenu.Controls.Add(this.btnQuanTri);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnHoaDon);
            this.panelMenu.Controls.Add(this.btnKho);
            this.panelMenu.Controls.Add(this.btnBanHang);
            this.panelMenu.Controls.Add(this.btnTongQuan);
            this.Hide.SetDecoration(this.panelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Show.SetDecoration(this.panelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMenu.GradientTopRight = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(45, 738);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseHover += new System.EventHandler(this.panelMenu_MouseHover);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnDangXuat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnDangXuat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::FinalProject.Properties.Resources.logout_rounded_up_32px;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 646);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(45, 46);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // btnLienHe
            // 
            this.btnLienHe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnLienHe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnLienHe, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnLienHe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLienHe.FlatAppearance.BorderSize = 0;
            this.btnLienHe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLienHe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLienHe.Image = global::FinalProject.Properties.Resources.send_32px;
            this.btnLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLienHe.Location = new System.Drawing.Point(0, 692);
            this.btnLienHe.Name = "btnLienHe";
            this.btnLienHe.Size = new System.Drawing.Size(45, 46);
            this.btnLienHe.TabIndex = 6;
            this.btnLienHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLienHe.UseVisualStyleBackColor = true;
            // 
            // btnQuanTri
            // 
            this.btnQuanTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnQuanTri, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnQuanTri, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnQuanTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanTri.FlatAppearance.BorderSize = 0;
            this.btnQuanTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanTri.Image = global::FinalProject.Properties.Resources.admin_settings_male_32px;
            this.btnQuanTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanTri.Location = new System.Drawing.Point(0, 230);
            this.btnQuanTri.Name = "btnQuanTri";
            this.btnQuanTri.Size = new System.Drawing.Size(45, 46);
            this.btnQuanTri.TabIndex = 5;
            this.btnQuanTri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanTri.UseVisualStyleBackColor = true;
            this.btnQuanTri.Click += new System.EventHandler(this.btnQuanTri_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnBaoCao, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnBaoCao, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Image = global::FinalProject.Properties.Resources.report_card_32px;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 184);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(45, 46);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnHoaDon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnHoaDon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = global::FinalProject.Properties.Resources.file_32px;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 138);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(45, 46);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKho
            // 
            this.btnKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnKho, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnKho, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.Image = global::FinalProject.Properties.Resources.product_32px;
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.Location = new System.Drawing.Point(0, 92);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(45, 46);
            this.btnKho.TabIndex = 2;
            this.btnKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnBanHang, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnBanHang, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Image = global::FinalProject.Properties.Resources.shopping_cart_32px;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.Location = new System.Drawing.Point(0, 46);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(45, 46);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.btnTongQuan, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.btnTongQuan, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.Image = global::FinalProject.Properties.Resources.hospital_32px;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 0);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(45, 46);
            this.btnTongQuan.TabIndex = 0;
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // banHangUC1
            // 
            this.banHangUC1.AutoScroll = true;
            this.banHangUC1.BackColor = System.Drawing.Color.White;
            this.Show.SetDecoration(this.banHangUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.banHangUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.banHangUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banHangUC1.Location = new System.Drawing.Point(45, 31);
            this.banHangUC1.Name = "banHangUC1";
            this.banHangUC1.Size = new System.Drawing.Size(659, 738);
            this.banHangUC1.TabIndex = 2;
            // 
            // hoaDon1
            // 
            this.hoaDon1.AutoScroll = true;
            this.hoaDon1.BackColor = System.Drawing.Color.White;
            this.Show.SetDecoration(this.hoaDon1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.hoaDon1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.hoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoaDon1.Location = new System.Drawing.Point(45, 31);
            this.hoaDon1.Name = "hoaDon1";
            this.hoaDon1.Size = new System.Drawing.Size(659, 738);
            this.hoaDon1.TabIndex = 3;
            // 
            // trangChuUC1
            // 
            this.trangChuUC1.AutoScroll = true;
            this.trangChuUC1.BackColor = System.Drawing.Color.White;
            this.Show.SetDecoration(this.trangChuUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.trangChuUC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.trangChuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trangChuUC1.Location = new System.Drawing.Point(45, 31);
            this.trangChuUC1.Name = "trangChuUC1";
            this.trangChuUC1.Size = new System.Drawing.Size(659, 738);
            this.trangChuUC1.TabIndex = 4;
            // 
            // plKho
            // 
            this.plKho.BackColor = System.Drawing.Color.Aquamarine;
            this.plKho.Controls.Add(this.button2);
            this.plKho.Controls.Add(this.button1);
            this.Hide.SetDecoration(this.plKho, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Show.SetDecoration(this.plKho, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.plKho.Location = new System.Drawing.Point(190, 123);
            this.plKho.Name = "plKho";
            this.plKho.Size = new System.Drawing.Size(190, 92);
            this.plKho.TabIndex = 6;
            this.plKho.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::FinalProject.Properties.Resources.product_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kiểm kho";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::FinalProject.Properties.Resources.product_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nhập hàng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // plQT
            // 
            this.plQT.BackColor = System.Drawing.Color.Aquamarine;
            this.plQT.Controls.Add(this.button3);
            this.plQT.Controls.Add(this.button4);
            this.Hide.SetDecoration(this.plQT, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Show.SetDecoration(this.plQT, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.plQT.Location = new System.Drawing.Point(190, 261);
            this.plQT.Name = "plQT";
            this.plQT.Size = new System.Drawing.Size(190, 92);
            this.plQT.TabIndex = 7;
            this.plQT.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::FinalProject.Properties.Resources.product_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cài đặt";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.SetDecoration(this.button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::FinalProject.Properties.Resources.product_32px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nhân viên";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Hide
            // 
            this.Hide.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Hide.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.Hide.DefaultAnimation = animation6;
            this.Hide.TimeStep = 0.05F;
            // 
            // nhanVien1
            // 
            this.nhanVien1.BackColor = System.Drawing.Color.White;
            this.Show.SetDecoration(this.nhanVien1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this.nhanVien1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.nhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanVien1.Location = new System.Drawing.Point(0, 0);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(704, 769);
            this.nhanVien1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 769);
            this.Controls.Add(this.plQT);
            this.Controls.Add(this.plKho);
            this.Controls.Add(this.trangChuUC1);
            this.Controls.Add(this.hoaDon1);
            this.Controls.Add(this.banHangUC1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nhanVien1);
            this.Show.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Hide.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.plKho.ResumeLayout(false);
            this.plQT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button bntMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnLienHe;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnQuanTri;
        private Bunifu.UI.WinForms.BunifuTransition Show;
        private Bunifu.UI.WinForms.BunifuTransition Hide;
        private BanHangUC banHangUC1;
        private HoaDon hoaDon1;
        private TrangChuUC trangChuUC1;
        private System.Windows.Forms.Panel plKho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel plQT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private NhanVien nhanVien1;
    }
}

