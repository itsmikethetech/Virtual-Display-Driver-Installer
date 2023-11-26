using Microsoft.UI.Xaml.Controls;

using VDD_Config.ViewModels;

namespace VDD_Config.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class GitHubPage : Page
{
    public GitHubViewModel ViewModel
    {
        get;
    }

    public GitHubPage()
    {
        ViewModel = App.GetService<GitHubViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
