using System.Reflection;
using TestTetacom.Attribute;
using TestTetacom.Locale;

namespace TestTetacom.Model
{
    static class WellStatusExtensions
    {
        public static String ToStringView(this WellStatus wellStatus)
        {
            Type type = wellStatus.GetType();
            FieldInfo? fi = type.GetField(wellStatus.ToString());

            if (fi == null)
            {
                return string.Empty;
            }

            EnumLocaleAttribute? attr = fi.GetCustomAttribute<EnumLocaleAttribute>();

            if (attr == null)
            {
                return string.Empty;
            }

            return RuLocale.Locale[attr.Text];
        }
    }
}
