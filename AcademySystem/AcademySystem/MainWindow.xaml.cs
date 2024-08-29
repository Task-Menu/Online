using AcademySystem.Extensions;
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

            DatabaseInitializer.SeedDatabase();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            var studentView = new StudentWindow();
        }
    }
}
