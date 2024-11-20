namespace SGComserv.Extensions;

public static class ValueExtensions
{
    public static int ToInt(this object value) 
    {
        return int.TryParse(value?.ToString(), out int result) ? result : 0;
    }
    public static decimal ToDecimal(this object value)
    {
        return decimal.TryParse(value?.ToString(), out decimal result) ? result : 0m;
    }
    public static double ToDouble(this object value)
    {
        return double.TryParse(value?.ToString(), out double result) ? result : 0;
    }

}
