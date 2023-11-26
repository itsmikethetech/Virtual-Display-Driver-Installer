using Microsoft.UI.Xaml.Controls;

using VDD_Config.ViewModels;

namespace VDD_Config.Views;

public sealed partial class InstallPage : Page
{
    public InstallViewModel ViewModel
    {
        get;
    }

    public InstallPage()
    {
        ViewModel = App.GetService<InstallViewModel>();
        InitializeComponent();
    }
}
