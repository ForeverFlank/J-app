using System.Collections.ObjectModel;
using J_app.Services;
using J_app.Model;
using J_app.View;
using CommunityToolkit.Mvvm.Input;

namespace J_app.ViewModel;

public partial class TableViewModel : BaseViewModel
{
    LoadTable loadTable;
    public ObservableCollection<Period> Table { get; } = new();
    public ObservableCollection<Period> Table2 { get; } = new();
    public Command LoadTableACommand { get; }
    public Command LoadTableBCommand { get; }
    public TableViewModel(LoadTable loadTable)
    {
        this.loadTable = loadTable;
        LoadTableACommand = new Command(async () => await GetTableAsync('A'));
        LoadTableBCommand = new Command(async () => await GetTableAsync('B'));
    }

    [RelayCommand]
    async Task GoToDetailsAsync(Period period)
    {
        if (period == null)
            return;
        await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
            new Dictionary<string, object>
            {
                {"Period", period}
            });
    }

    async Task GetTableAsync(char c)
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            var table = await loadTable.GetTable(c);
            if (c == 'A')
            {
                if (Table.Count() != 0)
                    Table.Clear();
                foreach (var item in table)
                    Table.Add(item);
            }
            if (c == 'B')
            {
                if (Table2.Count() != 0)
                    Table2.Clear();
                foreach (var item in table)
                    Table2.Add(item);
            }
            IsBusy = false;
        }
        catch (Exception e)
        {
            await Shell.Current.DisplayAlert("Error!", $"Unable to load {e.Message}", "OK");
        }
        finally
        {

        }
    }
}