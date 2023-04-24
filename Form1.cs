using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btn_listele_Click(object sender, EventArgs e)
        {

            this.Hide();
            Listele listele = new Listele();
            listele.Show();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = txt_marka.Text;
            car.Model = txt_model.Text;
            car.Year = txt_yil.Text;
            car.Plate = txt_plaka.Text;
            car.Color = cbox_renk.Text;
            car.Price = int.Parse(txt_price.Text); 
           
                int sonuc = Car.Save(car);

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!!!");
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listele listele = new Listele();
            listele.Show();
        }

        
    }

}
