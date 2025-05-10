using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarInventory
{
    public class CarRepository
    {
        private const string ConnectionString = "Server=WIN-MNTN6RSB8CO\\SQLEXPRESS01; Database=carsdatabase; Trusted_Connection=True; TrustServerCertificate=True; ";

        public List<Car> GetCars()
        {
            List<Car> carslist = new List<Car>();

            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                string CarsQuery = "SELECT * FROM cars";
                SqlCommand command = new SqlCommand(CarsQuery, sqlconnection);

                try
                {
                    sqlconnection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car()
                            {
                                Id = reader.GetInt32(0),
                                Model = reader.GetString(1),
                                Manufacture = reader.GetInt32(2),
                                Speed = reader.GetInt32(3),
                                Weight = reader.GetInt32(4)
                            };
                            carslist.Add(car);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving cars: {ex.Message}");
                }
            }
            return carslist;
        }


        public void AddCar(Car car)
        {
            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {
                string CarsQuery = "INSERT INTO cars (Model, Manufacture, Speed, Weight) VALUES (@model, @manufacture, @speed, @weight)";
                SqlCommand command = new SqlCommand(CarsQuery, sqlconnection);
                command.Parameters.AddWithValue("@model", car.Model);
                command.Parameters.AddWithValue("@manufacture", car.Manufacture);
                command.Parameters.AddWithValue("@speed", car.Speed);
                command.Parameters.AddWithValue("@weight", car.Weight);
                try
                {
                    sqlconnection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        public void DeleteCar(int CarID)
        {
            using (SqlConnection sqlconnection = new SqlConnection(ConnectionString))
            {

                if (CarID > 0)
                {
                    string CarsQuery = "DELETE FROM cars WHERE Id = @id";
                    SqlCommand command = new SqlCommand(CarsQuery, sqlconnection);
                    command.Parameters.AddWithValue("@id", CarID);

                    sqlconnection.Open();
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Selection is required");
                }
            }
        }
    }
}
