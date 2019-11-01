namespace FinalProject
{
    partial class Loadding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loadding));
            this.label1 = new System.Windows.Forms.Label();
            this.ProBar = new Bunifu.UI.Winforms.BunifuProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HIỆU THUỐC";
            // 
            // ProBar
            // 
            this.ProBar.Animation = 0;
            this.ProBar.AnimationStep = 10;
            this.ProBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProBar.BackgroundImage")));
            this.ProBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.ProBar.BorderRadius = 5;
            this.ProBar.BorderThickness = 2;
            this.ProBar.Location = new System.Drawing.Point(61, 119);
            this.ProBar.MaximumValue = 100;
            this.ProBar.MinimumValue = 0;
            this.ProBar.Name = "ProBar";
            this.ProBar.ProgressBackColor = System.Drawing.Color.White;
            this.ProBar.ProgressColorLeft = System.Drawing.Color.Black;
            this.ProBar.ProgressColorRight = System.Drawing.Color.DimGray;
            this.ProBar.Size = new System.Drawing.Size(343, 19);
            this.ProBar.TabIndex = 1;
            this.ProBar.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(177, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vui lòng chờ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Load_Tick);
            // 
            // Loadding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loadding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loadding";
            this.Load += new System.EventHandler(this.Loadding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.Winforms.BunifuProgressBar ProBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}