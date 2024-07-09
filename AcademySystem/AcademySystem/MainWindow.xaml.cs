using AcademySystem.Models;
using AcademySystem.Views;
using System.Windows;
using System.Windows.Input;

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

        private void Online_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            var onlineWindow = new OnlineCourses();
            onlineWindow.Owner = this;
            onlineWindow.Show();
        }

        private void Offline_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            var offlineWindow = new OfflineCourses();
            offlineWindow.Owner = this;
            offlineWindow.Show();
        }
    }
}
