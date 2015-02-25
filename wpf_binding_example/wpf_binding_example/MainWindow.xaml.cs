using System.ComponentModel;
using System.Windows;
using wpf_binding_example.Properties;

namespace wpf_binding_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();

            base.OnClosing(e);
        }
    }
}
