using System.Windows;

namespace AcademySystem.Views
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();

            DataContext = new StudentsViewModel();
        }
    }
}
