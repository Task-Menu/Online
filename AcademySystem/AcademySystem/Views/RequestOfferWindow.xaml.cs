using AcademySystem.Data;
using AcademySystem.Models;
using System.Windows;
using System.Windows.Controls;

namespace AcademySystem.Views
{
    /// <summary>
    /// Interaction logic for RequestOfferWindow.xaml
    /// </summary>
    public partial class RequestOfferWindow : Window
    {
        private readonly RequestOfferService requestOfferService;
        public RequestOfferWindow()
        {
            InitializeComponent();

            requestOfferService = new RequestOfferService();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            var firstName = FirstNameInput.Text;
            var lastName = LastNameInput.Text;
            var message = MessageInput.Text;

            var newMessage = new RequestOffer(firstName, lastName, message);

            bool isSuccess;
            isSuccess = requestOfferService.CreateMessage(newMessage);
            if(isSuccess)
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
