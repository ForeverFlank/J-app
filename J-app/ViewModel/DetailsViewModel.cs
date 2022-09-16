using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using J_app.Model;
using System.Windows.Input;

namespace J_app.ViewModel;

[QueryProperty("Period", "Period")]
public partial class DetailsViewModel : BaseViewModel
{
    public DetailsViewModel()
    {
        
    }

    public ICommand TapCommand =>
        new Command<string>(async (url) =>
        await Browser.Default.OpenAsync(url,
                                        BrowserLaunchMode.SystemPreferred));


    [ObservableProperty]
    public Period period;
}