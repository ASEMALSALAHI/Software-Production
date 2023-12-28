
namespace Yazılımyapımı
{
    partial class sifremiunuttumFrm
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
            this.yazılımyapımıDataSet1 = new Yazılımyapımı.yazılımyapımıDataSet();
            this.cikisBttn = new System.Windows.Forms.Button();
            this.uyeolBttn = new System.Windows.Forms.Button();
            this.cevapTxtbox = new System.Windows.Forms.TextBox();
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.cevapLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.sifreLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // yazılımyapımıDataSet1
            // 
            this.yazılımyapımıDataSet1.DataSetName = "yazılımyapımıDataSet";
            this.yazılımyapımıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cikisBttn
            // 
            this.cikisBttn.Location = new System.Drawing.Point(213, 266);
            this.cikisBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikisBttn.Name = "cikisBttn";
            this.cikisBttn.Size = new System.Drawing.Size(300, 50);
            this.cikisBttn.TabIndex = 19;
            this.cikisBttn.Text = "ÇIKIŞ";
            this.cikisBttn.UseVisualStyleBackColor = true;
            this.cikisBttn.Click += new System.EventHandler(this.cikisBttn_Click);
            // 
            // uyeolBttn
            // 
            this.uyeolBttn.Location = new System.Drawing.Point(213, 208);
            this.uyeolBttn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyeolBttn.Name = "uyeolBttn";
            this.uyeolBttn.Size = new System.Drawing.Size(300, 50);
            this.uyeolBttn.TabIndex = 18;
            this.uyeolBttn.Text = "ŞİFRE SIFIRLA";
            this.uyeolBttn.UseVisualStyleBackColor = true;
            this.uyeolBttn.Click += new System.EventHandler(this.uyeolBttn_Click);
            // 
            // cevapTxtbox
            // 
            this.cevapTxtbox.Location = new System.Drawing.Point(213, 116);
            this.cevapTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cevapTxtbox.Name = "cevapTxtbox";
            this.cevapTxtbox.Size = new System.Drawing.Size(315, 24);
            this.cevapTxtbox.TabIndex = 16;
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Location = new System.Drawing.Point(213, 71);
            this.emailTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(315, 24);
            this.emailTxtbox.TabIndex = 14;
            // 
            // cevapLbl
            // 
            this.cevapLbl.AutoSize = true;
            this.cevapLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapLbl.Location = new System.Drawing.Point(113, 108);
            this.cevapLbl.Name = "cevapLbl";
            this.cevapLbl.Size = new System.Drawing.Size(101, 31);
            this.cevapLbl.TabIndex = 13;
            this.cevapLbl.Text = "Cevap:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.Location = new System.Drawing.Point(124, 64);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(89, 31);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.Location = new System.Drawing.Point(213, 161);
            this.sifreTxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(315, 24);
            this.sifreTxtbox.TabIndex = 21;
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLbl.Location = new System.Drawing.Point(76, 154);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(139, 31);
            this.sifreLbl.TabIndex = 20;
            this.sifreLbl.Text = "Yeni Şifre:";
            // 
            // sifremiunuttumFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.sifreTxtbox);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.cikisBttn);
            this.Controls.Add(this.uyeolBttn);
            this.Controls.Add(this.cevapTxtbox);
            this.Controls.Add(this.emailTxtbox);
            this.Controls.Add(this.cevapLbl);
            this.Controls.Add(this.emailLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "sifremiunuttumFrm";
            this.Text = "şifremi unuttum";
            this.Load += new System.EventHandler(this.sifremiunuttumFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazılımyapımıDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private yazılımyapımıDataSet yazılımyapımıDataSet1;
        private System.Windows.Forms.Button cikisBttn;
        private System.Windows.Forms.Button uyeolBttn;
        private System.Windows.Forms.TextBox cevapTxtbox;
        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.Label cevapLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.Label sifreLbl;
    }
}