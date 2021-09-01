
namespace TurKLoJeN_Wordlist_Maker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.login_btn = new Ambiance.Ambiance_Button_2();
            this.cikis_btn = new Ambiance.Ambiance_Button_2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.ambiance_ThemeContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ambiance_ThemeContainer1
            // 
            this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Button_11);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label2);
            this.ambiance_ThemeContainer1.Controls.Add(this.login_btn);
            this.ambiance_ThemeContainer1.Controls.Add(this.cikis_btn);
            this.ambiance_ThemeContainer1.Controls.Add(this.pictureBox1);
            this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_Label1);
            this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
            this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
            this.ambiance_ThemeContainer1.RoundCorners = true;
            this.ambiance_ThemeContainer1.Sizable = true;
            this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(531, 426);
            this.ambiance_ThemeContainer1.SmartBounds = true;
            this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ambiance_ThemeContainer1.TabIndex = 0;
            this.ambiance_ThemeContainer1.Text = "TurKLoJeN Wordlist Maker";
            this.ambiance_ThemeContainer1.Click += new System.EventHandler(this.ambiance_ThemeContainer1_Click);
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(338, 396);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(184, 21);
            this.ambiance_Label2.TabIndex = 5;
            this.ambiance_Label2.Text = "Developed By TurKLoJeN";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.login_btn.Image = null;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_btn.Location = new System.Drawing.Point(167, 325);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(207, 30);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.Color.Transparent;
            this.cikis_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.cikis_btn.Image = null;
            this.cikis_btn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cikis_btn.Location = new System.Drawing.Point(498, 0);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(33, 30);
            this.cikis_btn.TabIndex = 3;
            this.cikis_btn.Text = "X";
            this.cikis_btn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(121, 56);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(311, 32);
            this.ambiance_Label1.TabIndex = 0;
            this.ambiance_Label1.Text = "Welcome to Wordlist Maker";
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.Location = new System.Drawing.Point(167, 363);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(207, 30);
            this.ambiance_Button_11.TabIndex = 1;
            this.ambiance_Button_11.Text = "Visit My Site";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 426);
            this.Controls.Add(this.ambiance_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurKLoJeN Wordlist Maker";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ambiance_ThemeContainer1.ResumeLayout(false);
            this.ambiance_ThemeContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Button_2 cikis_btn;
        private Ambiance.Ambiance_Button_2 login_btn;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
    }
}

