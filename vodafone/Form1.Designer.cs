
namespace vodafone
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
            this.girisAnasayfa = new System.Windows.Forms.Button();
            this.kayıtOl = new System.Windows.Forms.Button();
            this.kullanıcAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.giris = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisAnasayfa
            // 
            this.girisAnasayfa.Location = new System.Drawing.Point(118, 189);
            this.girisAnasayfa.Name = "girisAnasayfa";
            this.girisAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.girisAnasayfa.TabIndex = 0;
            this.girisAnasayfa.Text = "Giriş";
            this.girisAnasayfa.UseVisualStyleBackColor = true;
            this.girisAnasayfa.Click += new System.EventHandler(this.girisAnasayfa_Click);
            // 
            // kayıtOl
            // 
            this.kayıtOl.Location = new System.Drawing.Point(6, 189);
            this.kayıtOl.Name = "kayıtOl";
            this.kayıtOl.Size = new System.Drawing.Size(75, 23);
            this.kayıtOl.TabIndex = 1;
            this.kayıtOl.Text = "Kayıt Ol";
            this.kayıtOl.UseVisualStyleBackColor = true;
            this.kayıtOl.Click += new System.EventHandler(this.kayıtOl_Click);
            // 
            // kullanıcAdi
            // 
            this.kullanıcAdi.AccessibleDescription = "";
            this.kullanıcAdi.AccessibleName = "";
            this.kullanıcAdi.Location = new System.Drawing.Point(6, 42);
            this.kullanıcAdi.Multiline = true;
            this.kullanıcAdi.Name = "kullanıcAdi";
            this.kullanıcAdi.Size = new System.Drawing.Size(187, 28);
            this.kullanıcAdi.TabIndex = 4;
            this.kullanıcAdi.Tag = "";
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(6, 99);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(187, 30);
            this.sifre.TabIndex = 5;
            // 
            // sifremiUnuttum
            // 
            this.sifremiUnuttum.AutoSize = true;
            this.sifremiUnuttum.Location = new System.Drawing.Point(6, 145);
            this.sifremiUnuttum.Name = "sifremiUnuttum";
            this.sifremiUnuttum.Size = new System.Drawing.Size(81, 13);
            this.sifremiUnuttum.TabIndex = 6;
            this.sifremiUnuttum.TabStop = true;
            this.sifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.Transparent;
            this.giris.Controls.Add(this.label2);
            this.giris.Controls.Add(this.label1);
            this.giris.Controls.Add(this.button1);
            this.giris.Controls.Add(this.kullanıcAdi);
            this.giris.Controls.Add(this.kayıtOl);
            this.giris.Controls.Add(this.sifremiUnuttum);
            this.giris.Controls.Add(this.sifre);
            this.giris.Controls.Add(this.girisAnasayfa);
            this.giris.Location = new System.Drawing.Point(12, 12);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(206, 269);
            this.giris.TabIndex = 7;
            this.giris.TabStop = false;
            this.giris.Text = "Giris ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yönetici Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 317);
            this.Controls.Add(this.giris);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.giris.ResumeLayout(false);
            this.giris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button girisAnasayfa;
        private System.Windows.Forms.Button kayıtOl;
        private System.Windows.Forms.TextBox kullanıcAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.LinkLabel sifremiUnuttum;
        private System.Windows.Forms.GroupBox giris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

