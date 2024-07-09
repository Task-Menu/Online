using Microsoft.Data.SqlClient;
using System.Windows;
using System;
using AcademySystem.Models;

namespace AcademySystem.Data
{
    class ConsultationService
    {
        public bool CreateConsultation(Consultations consultaion)
        {

            SqlConnection sqlconnection = new SqlConnection("Data Source=PAVILION;Initial Catalog=Academy;Integrated Security=True;Trust Server Certificate=True");
            var affectedRows = 0;
            try
            {
                sqlconnection.Open();
                SqlCommand cmd = sqlconnection.CreateCommand();
                cmd.CommandText = $"INSERT INTO CONSULTATION(FirstName, LastName, PhoneNumber, Birthday) " +
                    $"VALUES(@firstname, @lastname, @phonenumber, @birthday)";

                cmd.Parameters.AddWithValue("@firstName", consultaion.FirstName);
                cmd.Parameters.AddWithValue("@lastName", consultaion.LastName);
                cmd.Parameters.AddWithValue("@phonenumber", consultaion.PhoneNumber);
                cmd.Parameters.AddWithValue("@birthday", consultaion.Birthday.ToString("MM/dd/yyyy"));

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an server error. Details: {ex.Message}",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                sqlconnection.Close();
            }
            return affectedRows > 0;
        }
    }
}
