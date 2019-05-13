using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XamlYoutubeLoadingSpinner
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = ViewModel;
        }

        private void ButtonLoading_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.State = LoadingSpinner.SpinnerStates.Loading;
        }

        private void ButtonHanging_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.State = LoadingSpinner.SpinnerStates.Hanging;
        }
    }
}
