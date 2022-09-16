using CommunityToolkit.Mvvm.ComponentModel;

namespace J_app.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
}