using MaterialDesignThemes.Wpf;
using MvvmCross.Platforms.Wpf.Views;
using Sample.Domain.ViewModels;
using Sample.WPF.Views.Components;
using System.Windows;

namespace Sample.WPF.Views
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : MvxWpfView
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private async void OnClick_ShowRootDialogAsync(object sender, RoutedEventArgs e)
        {
            var view = new SampleDialog
            {
                DataContext = new SampleDialogViewModel()
            };

            await DialogHost.Show(view, "RootDialog", ExtendedOpenedEventHandler, ExtendedClosingEventHandler);
        }

        private async void OnClick_ShowPageDialogAsync(object sender, RoutedEventArgs e)
        {
            var view = new SampleDialog
            {
                DataContext = new SampleDialogViewModel()
            };

            await DialogHost.Show(view, "DashboardPageDialog", ExtendedOpenedEventHandler, ExtendedClosingEventHandler);
        }

        private void ExtendedOpenedEventHandler(object sender, DialogOpenedEventArgs eventargs)
        {
        }

        private void ExtendedClosingEventHandler(object sender, DialogClosingEventArgs eventArgs)
        {
        }
    }
}
