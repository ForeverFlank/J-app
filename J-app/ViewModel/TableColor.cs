using System.Globalization;

namespace J_app.ViewModel;

public class TableColor : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int x = (int) value;
        if (x == 1)
            return Color.FromArgb("FFDD50");
        if (x == 2)
            return Color.FromArgb("EA9BCE");
        if (x == 3)
            return Color.FromArgb("95E68A");
        if (x == 4)
            return Color.FromArgb("FFB275");
        if (x == 5)
            return Color.FromArgb("99CEF8");
        return Colors.Red;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return null;
    }
}