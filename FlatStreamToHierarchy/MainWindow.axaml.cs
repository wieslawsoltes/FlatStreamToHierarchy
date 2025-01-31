using Avalonia.Controls;
using FlatStreamToHierarchy.ViewModels;

namespace FlatStreamToHierarchy
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel = new MainWindowViewModel();


        public MainWindow()
        {
            InitializeComponent();

            DataContext = _viewModel;
        }
    }
}
