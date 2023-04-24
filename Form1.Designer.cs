namespace RentACar
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
            this.g_box_kayit = new System.Windows.Forms.GroupBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.cbox_renk = new System.Windows.Forms.ComboBox();
            this.lbl_renk = new System.Windows.Forms.Label();
            this.lbl_plaka = new System.Windows.Forms.Label();
            this.lbl_yil = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.g_box_kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_box_kayit
            // 
            this.g_box_kayit.Controls.Add(this.txt_price);
            this.g_box_kayit.Controls.Add(this.lbl_price);
            this.g_box_kayit.Controls.Add(this.btn_listele);
            this.g_box_kayit.Controls.Add(this.btn_kaydet);
            this.g_box_kayit.Controls.Add(this.txt_marka);
            this.g_box_kayit.Controls.Add(this.txt_model);
            this.g_box_kayit.Controls.Add(this.txt_yil);
            this.g_box_kayit.Controls.Add(this.txt_plaka);
            this.g_box_kayit.Controls.Add(this.cbox_renk);
            this.g_box_kayit.Controls.Add(this.lbl_renk);
            this.g_box_kayit.Controls.Add(this.lbl_plaka);
            this.g_box_kayit.Controls.Add(this.lbl_yil);
            this.g_box_kayit.Controls.Add(this.lbl_model);
            this.g_box_kayit.Controls.Add(this.lbl_marka);
            this.g_box_kayit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.g_box_kayit.Location = new System.Drawing.Point(16, 37);
            this.g_box_kayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g_box_kayit.Name = "g_box_kayit";
            this.g_box_kayit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g_box_kayit.Size = new System.Drawing.Size(349, 469);
            this.g_box_kayit.TabIndex = 0;
            this.g_box_kayit.TabStop = false;
            this.g_box_kayit.Text = "Araç Kayıt";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_price.Location = new System.Drawing.Point(140, 260);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(160, 26);
            this.txt_price.TabIndex = 19;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(35, 262);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(56, 19);
            this.lbl_price.TabIndex = 18;
            this.lbl_price.Text = "Ücret:";
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listele.Location = new System.Drawing.Point(185, 325);
            this.btn_listele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(116, 33);
            this.btn_listele.TabIndex = 16;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kaydet.Location = new System.Drawing.Point(13, 325);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(116, 33);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_marka.Location = new System.Drawing.Point(140, 49);
            this.txt_marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_marka.MaxLength = 15;
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(160, 26);
            this.txt_marka.TabIndex = 9;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model.Location = new System.Drawing.Point(140, 90);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_model.MaxLength = 15;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(160, 26);
            this.txt_model.TabIndex = 8;
            // 
            // txt_yil
            // 
            this.txt_yil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yil.Location = new System.Drawing.Point(140, 130);
            this.txt_yil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_yil.MaxLength = 15;
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(160, 26);
            this.txt_yil.TabIndex = 7;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_plaka.Location = new System.Drawing.Point(140, 171);
            this.txt_plaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_plaka.MaxLength = 15;
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(160, 26);
            this.txt_plaka.TabIndex = 6;
            // 
            // cbox_renk
            // 
            this.cbox_renk.FormattingEnabled = true;
            this.cbox_renk.Items.AddRange(new object[] {
            "Siyah",
            "Kırmızı",
            "Mavi",
            "Sarı",
            "Beyaz"});
            this.cbox_renk.Location = new System.Drawing.Point(140, 212);
            this.cbox_renk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_renk.Name = "cbox_renk";
            this.cbox_renk.Size = new System.Drawing.Size(160, 27);
            this.cbox_renk.TabIndex = 5;
            // 
            // lbl_renk
            // 
            this.lbl_renk.AutoSize = true;
            this.lbl_renk.Location = new System.Drawing.Point(39, 222);
            this.lbl_renk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_renk.Name = "lbl_renk";
            this.lbl_renk.Size = new System.Drawing.Size(54, 19);
            this.lbl_renk.TabIndex = 4;
            this.lbl_renk.Text = "Renk:";
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Location = new System.Drawing.Point(35, 181);
            this.lbl_plaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(57, 19);
            this.lbl_plaka.TabIndex = 3;
            this.lbl_plaka.Text = "Plaka:";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Location = new System.Drawing.Point(8, 140);
            this.lbl_yil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(91, 19);
            this.lbl_yil.TabIndex = 2;
            this.lbl_yil.Text = "Model Yılı:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(27, 100);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(63, 19);
            this.lbl_model.TabIndex = 1;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Location = new System.Drawing.Point(25, 53);
            this.lbl_marka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(64, 19);
            this.lbl_marka.TabIndex = 0;
            this.lbl_marka.Text = "Marka:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(364, 426);
            this.Controls.Add(this.g_box_kayit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.g_box_kayit.ResumeLayout(false);
            this.g_box_kayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox g_box_kayit;
        private System.Windows.Forms.ComboBox cbox_renk;
        private System.Windows.Forms.Label lbl_renk;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.Label lbl_yil;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_price;
    }
}

