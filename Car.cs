using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    internal class Car
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public string Renter { get; set; }

        public string update;



        public static SqlConnection connection = new SqlConnection(@"Data Source=STARBREAKER\SQLEXPRESS;Initial Catalog=RentACar;Integrated Security=True");

       public static int Save(Car car)
        {
            SqlCommand cmd = new SqlCommand("insert into Car (Marka, Model, ModelYili, Renk, Plaka, Ucret) values(@brand,@model,@year,@color,@plate,@ucret)", connection);
            cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value= car.Brand;
            cmd.Parameters.Add("@model", SqlDbType.VarChar).Value= car.Model;
            cmd.Parameters.Add("@year", SqlDbType.VarChar).Value= car.Year;
            cmd.Parameters.Add("@plate", SqlDbType.VarChar).Value= car.Plate;
            cmd.Parameters.Add("@color", SqlDbType.VarChar).Value = car.Color;
            cmd.Parameters.Add("@ucret", SqlDbType.Int).Value = car.Price;
            

            connection.Open();

            int result = cmd.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public static int Update(Car car)
        {
            SqlCommand cmd = new SqlCommand("update Car set Marka=@brand, Model=@model, ModelYili=@year, Renk=@color, Plaka=@plate, Ucret=@ucret where Model = @selected", connection);
            cmd.Parameters.Add("@brand", SqlDbType.VarChar).Value = car.Brand;
            cmd.Parameters.Add("@model", SqlDbType.VarChar).Value = car.Model;
            cmd.Parameters.Add("@year", SqlDbType.VarChar).Value = car.Year;
            cmd.Parameters.Add("@plate", SqlDbType.VarChar).Value = car.Plate;
            cmd.Parameters.Add("@color", SqlDbType.VarChar).Value = car.Color;
            cmd.Parameters.Add("@ucret", SqlDbType.Int).Value = car.Price;

            cmd.Parameters.Add("@selected", SqlDbType.VarChar).Value = car.update;


            connection.Open();

            int result = cmd.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public static List<Car> GetCars()
        {
            SqlCommand cmd = new SqlCommand("Select * from Car", connection);

            connection.Open();

            SqlDataReader reader= cmd.ExecuteReader();

            List<Car> list = new List<Car>();

            while (reader.Read())
            {
                Car car = new Car();
               
                car.Brand = reader.GetString(1);
                car.Model = reader.GetString(2);
                car.Year = reader.GetString(3);
                car.Color = reader.GetString(4);
                car.Plate= reader.GetString(5);
                if (reader[6] is DBNull)
                {

                }
                else
                {
                    car.Renter = reader.GetString(6);
                }
                    
                car.Price = reader.GetInt32(7);

                list.Add(car);
            }

            connection.Close();
            return list;
        }

        /*public static List<Car> Get()
        {
            SqlCommand cmd = new SqlCommand("Select * from Car where Kiralayan is NULL", connection);

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Car> list = new List<Car>();

            while (reader.Read())
            {
                Car car = new Car();
                car.Brand = reader.GetString(1);
                car.Model = reader.GetString(2);
                car.Year = reader.GetString(3);
                car.Color = reader.GetString(4);
                car.Plate = reader.GetString(5);
                if (reader[6] is DBNull)
                {

                }
                else
                {
                    car.Renter = reader.GetString(6);
                }

                car.Price = reader.GetInt32(7);

                list.Add(car);
            }

            connection.Close();
            return list;
        }*/

        /*public static int Update()
        {
            Car.GetCars();

        }*/

        
    }
}
