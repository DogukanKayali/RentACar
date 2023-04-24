namespace RentACar
{
    partial class Customer
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
            this.components = new System.ComponentModel.Container();
            this.data_grid_customer = new System.Windows.Forms.DataGridView();
            this.rentACarDataSet = new RentACar.RentACarDataSet();
            this.rentACarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_rent = new System.Windows.Forms.Label();
            this.lbl_car = new System.Windows.Forms.Label();
            this.txt_car = new System.Windows.Forms.TextBox();
            this.btn_rent = new System.Windows.Forms.Button();
            this.txt_renter = new System.Windows.Forms.TextBox();
            this.lbl_renter = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_customer
            // 
            this.data_grid_customer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.data_grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_customer.Location = new System.Drawing.Point(16, 50);
            this.data_grid_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_grid_customer.Name = "data_grid_customer";
            this.data_grid_customer.Size = new System.Drawing.Size(1141, 369);
            this.data_grid_customer.TabIndex = 0;
            this.data_grid_customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_customer_CellEnter);
            // 
            // rentACarDataSet
            // 
            this.rentACarDataSet.DataSetName = "RentACarDataSet";
            this.rentACarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentACarDataSetBindingSource
            // 
            this.rentACarDataSetBindingSource.DataSource = this.rentACarDataSet;
            this.rentACarDataSetBindingSource.Position = 0;
            // 
            // lbl_rent
            // 
            this.lbl_rent.AutoSize = true;
            this.lbl_rent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rent.Location = new System.Drawing.Point(17, 16);
            this.lbl_rent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rent.Name = "lbl_rent";
            this.lbl_rent.Size = new System.Drawing.Size(268, 24);
            this.lbl_rent.TabIndex = 1;
            this.lbl_rent.Text = "Mevcut Kiralanabilir Araçlar";
            // 
            // lbl_car
            // 
            this.lbl_car.AutoSize = true;
            this.lbl_car.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_car.Location = new System.Drawing.Point(17, 437);
            this.lbl_car.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_car.Name = "lbl_car";
            this.lbl_car.Size = new System.Drawing.Size(128, 24);
            this.lbl_car.TabIndex = 2;
            this.lbl_car.Text = "Seçilen Araç:";
            // 
            // txt_car
            // 
            this.txt_car.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_car.Location = new System.Drawing.Point(196, 438);
            this.txt_car.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_car.Name = "txt_car";
            this.txt_car.Size = new System.Drawing.Size(217, 26);
            this.txt_car.TabIndex = 3;
            // 
            // btn_rent
            // 
            this.btn_rent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_rent.Location = new System.Drawing.Point(587, 486);
            this.btn_rent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(228, 53);
            this.btn_rent.TabIndex = 4;
            this.btn_rent.Text = "Seçili Aracı Kirala";
            this.btn_rent.UseVisualStyleBackColor = false;
            this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
            // 
            // txt_renter
            // 
            this.txt_renter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_renter.Location = new System.Drawing.Point(588, 439);
            this.txt_renter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_renter.Name = "txt_renter";
            this.txt_renter.Size = new System.Drawing.Size(227, 26);
            this.txt_renter.TabIndex = 5;
            // 
            // lbl_renter
            // 
            this.lbl_renter.AutoSize = true;
            this.lbl_renter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_renter.Location = new System.Drawing.Point(437, 438);
            this.lbl_renter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_renter.Name = "lbl_renter";
            this.lbl_renter.Size = new System.Drawing.Size(106, 24);
            this.lbl_renter.TabIndex = 6;
            this.lbl_renter.Text = "Kiralayan:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(194, 486);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(219, 52);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Giriş Ekranı";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(685, 12);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(471, 31);
            this.txt_search.TabIndex = 8;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(411, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modele Göre Filtrele:";
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_message.Location = new System.Drawing.Point(16, 574);
            this.txt_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ReadOnly = true;
            this.txt_message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_message.Size = new System.Drawing.Size(1140, 46);
            this.txt_message.TabIndex = 10;
            this.txt_message.TextChanged += new System.EventHandler(this.txt_message_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(972, 434);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 26);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(861, 438);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gün:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1188, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_renter);
            this.Controls.Add(this.txt_renter);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.txt_car);
            this.Controls.Add(this.lbl_car);
            this.Controls.Add(this.lbl_rent);
            this.Controls.Add(this.data_grid_customer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_customer;
        private System.Windows.Forms.BindingSource rentACarDataSetBindingSource;
        private RentACarDataSet rentACarDataSet;
        private System.Windows.Forms.Label lbl_rent;
        private System.Windows.Forms.Label lbl_car;
        private System.Windows.Forms.TextBox txt_car;
        private System.Windows.Forms.Button btn_rent;
        private System.Windows.Forms.TextBox txt_renter;
        private System.Windows.Forms.Label lbl_renter;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}