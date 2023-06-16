using System.ComponentModel.DataAnnotations;

namespace app.Services
{
    public static class EnumHelper
    {
        public static string GetEnumDisplayName<TEnum>(TEnum value)
            where TEnum : Enum
        {
            var displayAttribute = typeof(TEnum)
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            return displayAttribute?.Name ?? value.ToString();
        }
    }
}
