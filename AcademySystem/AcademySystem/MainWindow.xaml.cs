using AcademySystem.Models;
using AcademySystem.Views;
using System.Windows;

namespace AcademySystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Academy_Info_Click(object sender, RoutedEventArgs e)
        {
            var infoWindow = new InformationWindow();
            infoWindow.Owner = this;
            infoWindow.Show();
            
        }
        
        private void Consultation_Click(object sender, RoutedEventArgs e)
        {
            var consultationWindow = new ConsultationWindow();
            consultationWindow.Owner = this;
            consultationWindow.Show();
        }
        
        private void Request_Click(object sender, RoutedEventArgs e)
        {
            var requestWindow = new RequestOfferWindow();
            requestWindow.Owner = this;
            requestWindow.Show();
        }
        
        private void Partner_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
