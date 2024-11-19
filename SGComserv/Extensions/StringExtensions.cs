using System.Text.RegularExpressions;

namespace SGComserv.Extensions;

public static class StringExtensions {
    public static string RemoveFormat(this string value) => Regex.Replace(value, @"\D", string.Empty);
}
