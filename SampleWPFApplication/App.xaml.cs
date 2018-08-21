using System.Windows;

namespace SampleWPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View.MainPage window = new View.MainPage();
            ViewModel.UserViewModel VM = new ViewModel.UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
