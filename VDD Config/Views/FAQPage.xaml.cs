using Microsoft.UI.Xaml.Controls;

using VDD_Config.ViewModels;

namespace VDD_Config.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class FAQPage : Page
{
    public FAQViewModel ViewModel
    {
        get;
    }

    public FAQPage()
    {
        ViewModel = App.GetService<FAQViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
