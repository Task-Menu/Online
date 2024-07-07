using System.Windows;

namespace AcademySystem.Views
{
    /// <summary>
    /// Interaction logic for InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public InformationWindow()
        {
            InitializeComponent();
        }

        private void Back_Click (object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Owner = this;
            window.Show();
        }
    }
}
