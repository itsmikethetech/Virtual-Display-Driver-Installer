using Microsoft.UI.Xaml.Controls;

using VDD_Config.ViewModels;

namespace VDD_Config.Views;

public sealed partial class ConfigurePage : Page
{
    public ConfigureViewModel ViewModel
    {
        get;
    }

    public ConfigurePage()
    {
        ViewModel = App.GetService<ConfigureViewModel>();
        InitializeComponent();
    }
}
