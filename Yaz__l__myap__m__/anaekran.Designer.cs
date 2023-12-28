
namespace Yazılımyapımı
{
    partial class frmAnaekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaekran));
            this.TestokulPicturebox = new System.Windows.Forms.PictureBox();
            this.UyegirisiBttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestokulPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // TestokulPicturebox
            // 
            this.TestokulPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("TestokulPicturebox.Image")));
            this.TestokulPicturebox.Location = new System.Drawing.Point(159, 28);
            this.TestokulPicturebox.Name = "TestokulPicturebox";
            this.TestokulPicturebox.Size = new System.Drawing.Size(466, 111);
            this.TestokulPicturebox.TabIndex = 0;
            this.TestokulPicturebox.TabStop = false;
            // 
            // UyegirisiBttn
            // 
            this.UyegirisiBttn.BackColor = System.Drawing.Color.DarkOrange;
            this.UyegirisiBttn.Location = new System.Drawing.Point(159, 145);
            this.UyegirisiBttn.Name = "UyegirisiBttn";
            this.UyegirisiBttn.Size = new System.Drawing.Size(466, 102);
            this.UyegirisiBttn.TabIndex = 1;
            this.UyegirisiBttn.Text = "ÜYE GİRİŞİ İÇİN TIKLAYINIZ";
            this.UyegirisiBttn.UseVisualStyleBackColor = false;
            this.UyegirisiBttn.Click += new System.EventHandler(this.UyegirisiBttn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(159, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(466, 112);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADMİN GİRİŞİ İÇİN TIKLAYINIZ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAnaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UyegirisiBttn);
            this.Controls.Add(this.TestokulPicturebox);
            this.Name = "frmAnaekran";
            this.Text = "Test Okula Hoşgeldiniz";
            ((System.ComponentModel.ISupportInitialize)(this.TestokulPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TestokulPicturebox;
        private System.Windows.Forms.Button UyegirisiBttn;
        private System.Windows.Forms.Button button2;
    }
}