using System.Windows;
using IlluminanceCalculation.Models;
using IlluminanceCalculation.ViewModels;
using IlluminanceCalculation.Views;

namespace IlluminanceCalculation;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var fluxUtilizationTable = new FluxUtilizationTable();
        
        var fluxCalculator = new FluxCalculator(fluxUtilizationTable);
        
        var viewModel = new MainViewModel(fluxCalculator);

        var view = new MainWindow
        {
            DataContext = viewModel
        };
        
        view.Show();
    }
}