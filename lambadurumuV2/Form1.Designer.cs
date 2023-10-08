namespace lambadurumuV2
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
            this.chcTF = new System.Windows.Forms.CheckBox();
            this.lblLamba = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblTF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chcTF
            // 
            this.chcTF.AutoSize = true;
            this.chcTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcTF.Location = new System.Drawing.Point(17, 31);
            this.chcTF.Name = "chcTF";
            this.chcTF.Size = new System.Drawing.Size(15, 14);
            this.chcTF.TabIndex = 0;
            this.chcTF.UseVisualStyleBackColor = true;
            this.chcTF.CheckedChanged += new System.EventHandler(this.chcTF_CheckedChanged);
            // 
            // lblLamba
            // 
            this.lblLamba.AutoSize = true;
            this.lblLamba.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLamba.Location = new System.Drawing.Point(50, 25);
            this.lblLamba.Name = "lblLamba";
            this.lblLamba.Size = new System.Drawing.Size(93, 22);
            this.lblLamba.TabIndex = 1;
            this.lblLamba.Text = "Lamba aç";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(13, 66);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(163, 22);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Lambanın durumu :";
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTF.Location = new System.Drawing.Point(183, 74);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(0, 22);
            this.lblTF.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(252, 127);
            this.Controls.Add(this.lblTF);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblLamba);
            this.Controls.Add(this.chcTF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcTF;
        private System.Windows.Forms.Label lblLamba;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblTF;
    }
}

