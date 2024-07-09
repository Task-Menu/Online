using AcademySystem.Data;
using AcademySystem.Models;
using System;
using System.Windows;

namespace AcademySystem.Views
{
    /// <summary>
    /// Interaction logic for ConsultationWindow.xaml
    /// </summary>
    public partial class ConsultationWindow : Window
    {
        private readonly ConsultationService consultationService;

        public ConsultationWindow()
        {
            InitializeComponent();
            consultationService = new ConsultationService();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var firstName = FirstNameInput.Text;
            var lastName = LastNameInput.Text;
            var phonenumber = PhoneNumberInput.Text;
            var birthday = BirthdayInput.SelectedDate ?? DateTime.Now;

            var newMessage = new Consultations(firstName, lastName, phonenumber, birthday);

            bool isSuccess;
            isSuccess = consultationService.CreateConsultation(newMessage);
            if (isSuccess)
            {
              MessageBox.Show("Successfully saved",
                  "Success",
                  MessageBoxButton.OK,
                  MessageBoxImage.Information);
                  Close();
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
        }
    }
}
