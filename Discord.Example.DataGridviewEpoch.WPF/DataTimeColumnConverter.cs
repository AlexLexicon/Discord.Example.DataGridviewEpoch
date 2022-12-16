using System;
using System.Globalization;
using System.Windows.Data;

namespace Discord.Example.DataGridviewEpoch.WPF;
public class DataTimeColumnConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string stringValue && long.TryParse(stringValue, out long epochSeconds))
        {
            return DateTimeOffset.FromUnixTimeSeconds(epochSeconds).DateTime.ToString();
        }

        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
