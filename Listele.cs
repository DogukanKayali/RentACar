using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace RentACar
{

    public partial class Listele : Form
    {
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public string terminate;
        public Listele()
        {
            InitializeComponent();
            da = new SqlDataAdapter("Select * From Car", Car.connection);
            Car.connection.Open();
            da.Fill(dt);
            dataGridListele.DataSource = dt;
            Car.connection.Close();
        }

        private void dataGridListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridListele.DataSource = Car.GetCars();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
           
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridListele.DataSource = Car.GetCars();
        }

        private void btn_terminate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Car set Kiralayan='' where model = @selected", Car.connection);
            Car.connection.Open();
            cmd.Parameters.Add("@selected", SqlDbType.VarChar).Value = terminate;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Kiralama işlemi sonlandırıldı");

            Car.connection.Close();


        }



        private void dataGridListele_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_car.Text = dataGridListele.CurrentRow.Cells[1].Value.ToString();
            terminate = txt_car.Text;
            
           
            

            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update= new Update();
            update.update = terminate;
            update.Show();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Car where marka = @selected", Car.connection);
            Car.connection.Open();
            cmd.Parameters.Add("@selected", SqlDbType.VarChar).Value = terminate;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Araç Listeden Silindi");
            Car.connection.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Model LIKE '" + txt_search.Text + "%'";
            dataGridListele.DataSource = dv;
        }
    }
}
