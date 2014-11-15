using System;
using System.Globalization;

namespace Volunsteer
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale();
    }
}
