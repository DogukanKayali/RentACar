using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Customer : Form
    {

        SqlDataAdapter da;
        DataTable dt = new DataTable();
        
        public Customer()
        {
            InitializeComponent();



            //data_grid_customer.DataSource = Car.Get();
            da = new SqlDataAdapter("Select * From Car where Kiralayan is NULL", Car.connection);
            Car.connection.Open();
            da.Fill(dt);
            data_grid_customer.DataSource = dt;
            Car.connection.Close();

        }

        string selected;
        int price;
        int day;
        

        private void data_grid_customer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_car.Text = data_grid_customer.CurrentRow.Cells[1].Value.ToString();
       
            selected= txt_car.Text;
          
        }

      

        private void btn_rent_Click(object sender, EventArgs e)
        {
           

            SqlCommand cmd2 = new SqlCommand("select Ucret from Car where marka = @selected", Car.connection);
            Car.connection.Open();
            cmd2.Parameters.Add("@selected", SqlDbType.VarChar).Value = selected;
            SqlDataReader reader = cmd2.ExecuteReader();

            while (reader.Read())
            {
                price = reader.GetInt32(0);
            }
            
            day = (int)numericUpDown1.Value;
            Car.connection.Close();

            SqlCommand cmd = new SqlCommand("update Car set Kiralayan=@renter where marka = @selected", Car.connection);
            Car.connection.Open();
            cmd.Parameters.Add("@selected", SqlDbType.VarChar).Value = selected;
            cmd.Parameters.Add("@renter", SqlDbType.VarChar).Value = txt_renter.Text;
            if (txt_renter.Text== "")
            {
                MessageBox.Show("Kiralayan ismini girin");
            }
            else
            {
                
               cmd.ExecuteNonQuery();
                MessageBox.Show("Kiralama işlemi tamamlandı");
                txt_message.Text = "Araç " + day + " günlüğüne " + (price * day) + " TL Karşılığı kiralandı.";
              
                
            }

            Car.connection.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Model LIKE '" + txt_search.Text + "%'";
            data_grid_customer.DataSource = dv;
        }

        private void txt_message_TextChanged(object sender, EventArgs e)
        {
           

            


        }
    }
}
