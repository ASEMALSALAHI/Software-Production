
namespace Yazılımyapımı
{
    partial class FrmGirisekrani
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
            this.girisyap_Bttn = new System.Windows.Forms.Button();
            this.email_Txtbox = new System.Windows.Forms.TextBox();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.sifremiunuttumBttn = new System.Windows.Forms.Button();
            this.uyeolBttn = new System.Windows.Forms.Button();
            this.CikisBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisyap_Bttn
            // 
            this.girisyap_Bttn.Location = new System.Drawing.Point(164, 207);
            this.girisyap_Bttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisyap_Bttn.Name = "girisyap_Bttn";
            this.girisyap_Bttn.Size = new System.Drawing.Size(217, 46);
            this.girisyap_Bttn.TabIndex = 0;
            this.girisyap_Bttn.Text = "Giriş Yap";
            this.girisyap_Bttn.UseVisualStyleBackColor = true;
            this.girisyap_Bttn.Click += new System.EventHandler(this.Girisyap_Bttn_Click);
            // 
            // email_Txtbox
            // 
            this.email_Txtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.email_Txtbox.Location = new System.Drawing.Point(164, 105);
            this.email_Txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_Txtbox.Name = "email_Txtbox";
            this.email_Txtbox.Size = new System.Drawing.Size(209, 24);
            this.email_Txtbox.TabIndex = 1;
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.sifreTxtbox.Location = new System.Drawing.Point(164, 175);
            this.sifreTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(209, 24);
            this.sifreTxtbox.TabIndex = 2;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailLbl.Location = new System.Drawing.Point(87, 98);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(80, 29);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email:";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sifreLbl.Location = new System.Drawing.Point(87, 170);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(69, 29);
            this.sifreLbl.TabIndex = 4;
            this.sifreLbl.Text = "Şifre:";
            // 
            // sifremiunuttumBttn
            // 
            this.sifremiunuttumBttn.Location = new System.Drawing.Point(164, 260);
            this.sifremiunuttumBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifremiunuttumBttn.Name = "sifremiunuttumBttn";
            this.sifremiunuttumBttn.Size = new System.Drawing.Size(217, 46);
            this.sifremiunuttumBttn.TabIndex = 5;
            this.sifremiunuttumBttn.Text = "Şifremi Unuttum";
            this.sifremiunuttumBttn.UseVisualStyleBackColor = true;
            this.sifremiunuttumBttn.Click += new System.EventHandler(this.sifremiunuttumBttn_Click);
            // 
            // uyeolBttn
            // 
            this.uyeolBttn.Location = new System.Drawing.Point(164, 313);
            this.uyeolBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyeolBttn.Name = "uyeolBttn";
            this.uyeolBttn.Size = new System.Drawing.Size(217, 46);
            this.uyeolBttn.TabIndex = 6;
            this.uyeolBttn.Text = "Üye Ol";
            this.uyeolBttn.UseVisualStyleBackColor = true;
            this.uyeolBttn.Click += new System.EventHandler(this.uyeolBttn_Click);
            // 
            // CikisBttn
            // 
            this.CikisBttn.Location = new System.Drawing.Point(164, 366);
            this.CikisBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CikisBttn.Name = "CikisBttn";
            this.CikisBttn.Size = new System.Drawing.Size(217, 46);
            this.CikisBttn.TabIndex = 7;
            this.CikisBttn.Text = "Ana Ekrana Dön";
            this.CikisBttn.UseVisualStyleBackColor = true;
            this.CikisBttn.Click += new System.EventHandler(this.CikisBttn_Click);
            // 
            // FrmGirisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 554);
            this.Controls.Add(this.CikisBttn);
            this.Controls.Add(this.uyeolBttn);
            this.Controls.Add(this.sifremiunuttumBttn);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.email_Txtbox);
            this.Controls.Add(this.girisyap_Bttn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGirisekrani";
            this.Text = "Test Okula Hoşgeldiniz";
            this.Load += new System.EventHandler(this.FrmGirisekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisyap_Bttn;
        private System.Windows.Forms.TextBox email_Txtbox;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Button sifremiunuttumBttn;
        private System.Windows.Forms.Button uyeolBttn;
        private System.Windows.Forms.Button CikisBttn;
    }
}

