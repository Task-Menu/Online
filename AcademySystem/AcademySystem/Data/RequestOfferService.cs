using AcademySystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Windows;

namespace AcademySystem.Data
{
    internal class RequestOfferService
    {
        public bool CreateMessage(RequestOffer requestOffer)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=PAVILION;Initial Catalog=Academy;Integrated Security=True;Trust Server Certificate=True");

            var affectedRows = 0;
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = $"INSERT INTO REQUESTOFFER(FirstName, LastName, MessageText) " +
                    $"VALUES(@firstName, @lastName, @message)";
                cmd.Parameters.AddWithValue("@firstName", requestOffer.FirstName);
                cmd.Parameters.AddWithValue("@lastName", requestOffer.LastName);
                cmd.Parameters.AddWithValue("@message", requestOffer.MessageText);

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"There was an server error. Details: {ex.Message}", 
                    "Error", 
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return affectedRows > 0;
        }
    }
}
