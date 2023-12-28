
namespace Yazılımyapımı
{
    partial class frmAdminEkrani
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
            this.sifreLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.email_Txtbox = new System.Windows.Forms.TextBox();
            this.girisyap_Bttn = new System.Windows.Forms.Button();
            this.CıkısBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sifreLbl.Location = new System.Drawing.Point(182, 198);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(69, 29);
            this.sifreLbl.TabIndex = 11;
            this.sifreLbl.Text = "Şifre:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailLbl.Location = new System.Drawing.Point(182, 127);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(80, 29);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.sifreTxtbox.Location = new System.Drawing.Point(259, 203);
            this.sifreTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(441, 24);
            this.sifreTxtbox.TabIndex = 9;
            // 
            // email_Txtbox
            // 
            this.email_Txtbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.email_Txtbox.Location = new System.Drawing.Point(259, 133);
            this.email_Txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_Txtbox.Name = "email_Txtbox";
            this.email_Txtbox.Size = new System.Drawing.Size(441, 24);
            this.email_Txtbox.TabIndex = 8;
            // 
            // girisyap_Bttn
            // 
            this.girisyap_Bttn.Location = new System.Drawing.Point(259, 235);
            this.girisyap_Bttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisyap_Bttn.Name = "girisyap_Bttn";
            this.girisyap_Bttn.Size = new System.Drawing.Size(442, 100);
            this.girisyap_Bttn.TabIndex = 7;
            this.girisyap_Bttn.Text = "Admin Girişi Yap";
            this.girisyap_Bttn.UseVisualStyleBackColor = true;
            this.girisyap_Bttn.Click += new System.EventHandler(this.girisyap_Bttn_Click);
            // 
            // CıkısBttn
            // 
            this.CıkısBttn.Location = new System.Drawing.Point(259, 342);
            this.CıkısBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CıkısBttn.Name = "CıkısBttn";
            this.CıkısBttn.Size = new System.Drawing.Size(442, 110);
            this.CıkısBttn.TabIndex = 12;
            this.CıkısBttn.Text = "Ana Ekrana Dön";
            this.CıkısBttn.UseVisualStyleBackColor = true;
            this.CıkısBttn.Click += new System.EventHandler(this.CıkısBttn_Click);
            // 
            // frmAdminEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.CıkısBttn);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.email_Txtbox);
            this.Controls.Add(this.girisyap_Bttn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminEkrani";
            this.Text = "Admin Ekranı";
            this.Load += new System.EventHandler(this.frmAdminEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.TextBox email_Txtbox;
        private System.Windows.Forms.Button girisyap_Bttn;
        private System.Windows.Forms.Button CıkısBttn;
    }
}