namespace RentACar
{
    partial class Listele
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
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_terminate = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.txt_car = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListele
            // 
            this.dataGridListele.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridListele.Location = new System.Drawing.Point(12, 40);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListele.Size = new System.Drawing.Size(846, 336);
            this.dataGridListele.TabIndex = 0;
            this.dataGridListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListele_CellContentClick);
            this.dataGridListele.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListele_CellEnter);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kaydet.Location = new System.Drawing.Point(696, 459);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(162, 38);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "Yeni Kayıt";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_listele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_listele.Location = new System.Drawing.Point(12, 399);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(158, 38);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_terminate
            // 
            this.btn_terminate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_terminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_terminate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_terminate.Location = new System.Drawing.Point(238, 398);
            this.btn_terminate.Name = "btn_terminate";
            this.btn_terminate.Size = new System.Drawing.Size(139, 38);
            this.btn_terminate.TabIndex = 3;
            this.btn_terminate.Text = "Kirayı Sonlandır";
            this.btn_terminate.UseVisualStyleBackColor = false;
            this.btn_terminate.Click += new System.EventHandler(this.btn_terminate_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(460, 399);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(158, 38);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_selected.Location = new System.Drawing.Point(104, 459);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(128, 24);
            this.lbl_selected.TabIndex = 5;
            this.lbl_selected.Text = "Seçilen Araç:";
            // 
            // txt_car
            // 
            this.txt_car.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_car.Location = new System.Drawing.Point(238, 457);
            this.txt_car.Name = "txt_car";
            this.txt_car.Size = new System.Drawing.Size(139, 26);
            this.txt_car.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(700, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(158, 38);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Sil";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(175, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(683, 26);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modele Göre Filtrele:";
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(870, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_car);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_terminate);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dataGridListele);
            this.Name = "Listele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListele;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_terminate;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.TextBox txt_car;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
    }
}