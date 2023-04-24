namespace RentACar
{
    partial class Update
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
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
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox.Controls.Add(this.btn_update);
            this.groupBox.Controls.Add(this.txt_price);
            this.groupBox.Controls.Add(this.lbl_price);
            this.groupBox.Controls.Add(this.txt_marka);
            this.groupBox.Controls.Add(this.txt_model);
            this.groupBox.Controls.Add(this.txt_yil);
            this.groupBox.Controls.Add(this.txt_plaka);
            this.groupBox.Controls.Add(this.cbox_renk);
            this.groupBox.Controls.Add(this.lbl_renk);
            this.groupBox.Controls.Add(this.lbl_plaka);
            this.groupBox.Controls.Add(this.lbl_yil);
            this.groupBox.Controls.Add(this.lbl_model);
            this.groupBox.Controls.Add(this.lbl_marka);
            this.groupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox.Location = new System.Drawing.Point(-4, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(374, 431);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Araç Güncelleme";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(145, 310);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(165, 46);
            this.btn_update.TabIndex = 32;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(149, 246);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(160, 26);
            this.txt_price.TabIndex = 31;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(44, 249);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 19);
            this.lbl_price.TabIndex = 30;
            this.lbl_price.Text = "Ücret:";
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(149, 36);
            this.txt_marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_marka.MaxLength = 15;
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(160, 26);
            this.txt_marka.TabIndex = 29;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(149, 76);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_model.MaxLength = 15;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(160, 26);
            this.txt_model.TabIndex = 28;
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(149, 117);
            this.txt_yil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_yil.MaxLength = 15;
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(160, 26);
            this.txt_yil.TabIndex = 27;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Location = new System.Drawing.Point(149, 158);
            this.txt_plaka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_plaka.MaxLength = 15;
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(160, 26);
            this.txt_plaka.TabIndex = 26;
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
            this.cbox_renk.Location = new System.Drawing.Point(149, 198);
            this.cbox_renk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_renk.Name = "cbox_renk";
            this.cbox_renk.Size = new System.Drawing.Size(160, 27);
            this.cbox_renk.TabIndex = 25;
            // 
            // lbl_renk
            // 
            this.lbl_renk.AutoSize = true;
            this.lbl_renk.Location = new System.Drawing.Point(48, 208);
            this.lbl_renk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_renk.Name = "lbl_renk";
            this.lbl_renk.Size = new System.Drawing.Size(51, 19);
            this.lbl_renk.TabIndex = 24;
            this.lbl_renk.Text = "Renk:";
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.Location = new System.Drawing.Point(44, 167);
            this.lbl_plaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(52, 19);
            this.lbl_plaka.TabIndex = 23;
            this.lbl_plaka.Text = "Plaka:";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Location = new System.Drawing.Point(17, 127);
            this.lbl_yil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(83, 19);
            this.lbl_yil.TabIndex = 22;
            this.lbl_yil.Text = "Model Yılı:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(36, 86);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(58, 19);
            this.lbl_model.TabIndex = 21;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Location = new System.Drawing.Point(35, 39);
            this.lbl_marka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(61, 19);
            this.lbl_marka.TabIndex = 20;
            this.lbl_marka.Text = "Marka:";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 402);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.ComboBox cbox_renk;
        private System.Windows.Forms.Label lbl_renk;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.Label lbl_yil;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Button btn_update;
    }
}