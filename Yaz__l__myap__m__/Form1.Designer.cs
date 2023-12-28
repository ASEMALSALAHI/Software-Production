
namespace Yazılımyapımı
{
    partial class girisekrani
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
            this.SuspendLayout();
            // 
            // girisyap_Bttn
            // 
            this.girisyap_Bttn.Location = new System.Drawing.Point(141, 168);
            this.girisyap_Bttn.Name = "girisyap_Bttn";
            this.girisyap_Bttn.Size = new System.Drawing.Size(186, 37);
            this.girisyap_Bttn.TabIndex = 0;
            this.girisyap_Bttn.Text = "Giriş Yap";
            this.girisyap_Bttn.UseVisualStyleBackColor = true;
           // this.girisyap_Bttn.Click += new System.EventHandler(this.girisyap_Bttn_Click);
            // 
            // email_Txtbox
            // 
            this.email_Txtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.email_Txtbox.Location = new System.Drawing.Point(141, 85);
            this.email_Txtbox.Name = "email_Txtbox";
            this.email_Txtbox.Size = new System.Drawing.Size(180, 20);
            this.email_Txtbox.TabIndex = 1;
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.sifreTxtbox.Location = new System.Drawing.Point(141, 142);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(180, 20);
            this.sifreTxtbox.TabIndex = 2;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailLbl.Location = new System.Drawing.Point(75, 80);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(62, 24);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email:";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sifreLbl.Location = new System.Drawing.Point(75, 138);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(52, 24);
            this.sifreLbl.TabIndex = 4;
            this.sifreLbl.Text = "Şifre:";
            // 
            // sifremiunuttumBttn
            // 
            this.sifremiunuttumBttn.Location = new System.Drawing.Point(141, 211);
            this.sifremiunuttumBttn.Name = "sifremiunuttumBttn";
            this.sifremiunuttumBttn.Size = new System.Drawing.Size(186, 37);
            this.sifremiunuttumBttn.TabIndex = 5;
            this.sifremiunuttumBttn.Text = "Şifremi Unuttum";
            this.sifremiunuttumBttn.UseVisualStyleBackColor = true;
            // 
            // uyeolBttn
            // 
            this.uyeolBttn.Location = new System.Drawing.Point(141, 254);
            this.uyeolBttn.Name = "uyeolBttn";
            this.uyeolBttn.Size = new System.Drawing.Size(186, 37);
            this.uyeolBttn.TabIndex = 6;
            this.uyeolBttn.Text = "Üye Ol";
            this.uyeolBttn.UseVisualStyleBackColor = true;
            // 
            // girisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyeolBttn);
            this.Controls.Add(this.sifremiunuttumBttn);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.email_Txtbox);
            this.Controls.Add(this.girisyap_Bttn);
            this.Name = "girisekrani";
            this.Text = "Test Okula Hoşgeldiniz";
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
    }
}

