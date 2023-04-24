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

namespace RentACar
{
    public partial class Update : Form
    {
        public string update;

        public Update()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = txt_marka.Text;
            car.Model = txt_model.Text;
            car.Year = txt_yil.Text;
            car.Plate = txt_plaka.Text;
            car.Color = cbox_renk.Text;
            car.Price = int.Parse(txt_price.Text);
            car.update= update;

            int sonuc = Car.Update(car);

            if (sonuc > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız!!!");
            }

            this.Hide();
            Listele listele = new Listele();
            listele.Show();
        }
    }
}
