namespace AltyapiSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbMahalle = new System.Windows.Forms.ComboBox();
            this.cmbSokak = new System.Windows.Forms.ComboBox();
            this.cmbAptNo = new System.Windows.Forms.ComboBox();
            this.listBoxAltyapi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(164, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "İLÇE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(106, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "MAHALLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(135, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "SOKAK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "APARTMAN NO";
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(244, 32);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(172, 24);
            this.cmbIl.TabIndex = 5;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(244, 92);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(172, 24);
            this.cmbIlce.TabIndex = 6;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // cmbMahalle
            // 
            this.cmbMahalle.FormattingEnabled = true;
            this.cmbMahalle.Location = new System.Drawing.Point(244, 156);
            this.cmbMahalle.Name = "cmbMahalle";
            this.cmbMahalle.Size = new System.Drawing.Size(172, 24);
            this.cmbMahalle.TabIndex = 7;
            this.cmbMahalle.SelectedIndexChanged += new System.EventHandler(this.cmbMahalle_SelectedIndexChanged);
            // 
            // cmbSokak
            // 
            this.cmbSokak.FormattingEnabled = true;
            this.cmbSokak.Location = new System.Drawing.Point(244, 214);
            this.cmbSokak.Name = "cmbSokak";
            this.cmbSokak.Size = new System.Drawing.Size(172, 24);
            this.cmbSokak.TabIndex = 8;
            this.cmbSokak.SelectedIndexChanged += new System.EventHandler(this.cmbSokak_SelectedIndexChanged);
            // 
            // cmbAptNo
            // 
            this.cmbAptNo.FormattingEnabled = true;
            this.cmbAptNo.Location = new System.Drawing.Point(244, 269);
            this.cmbAptNo.Name = "cmbAptNo";
            this.cmbAptNo.Size = new System.Drawing.Size(172, 24);
            this.cmbAptNo.TabIndex = 9;
            this.cmbAptNo.SelectedIndexChanged += new System.EventHandler(this.cmbAptNo_SelectedIndexChanged);
            // 
            // listBoxAltyapi
            // 
            this.listBoxAltyapi.FormattingEnabled = true;
            this.listBoxAltyapi.ItemHeight = 16;
            this.listBoxAltyapi.Location = new System.Drawing.Point(111, 340);
            this.listBoxAltyapi.Name = "listBoxAltyapi";
            this.listBoxAltyapi.Size = new System.Drawing.Size(632, 164);
            this.listBoxAltyapi.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 576);
            this.Controls.Add(this.listBoxAltyapi);
            this.Controls.Add(this.cmbAptNo);
            this.Controls.Add(this.cmbSokak);
            this.Controls.Add(this.cmbMahalle);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbMahalle;
        private System.Windows.Forms.ComboBox cmbSokak;
        private System.Windows.Forms.ComboBox cmbAptNo;
        private System.Windows.Forms.ListBox listBoxAltyapi;
    }
}

