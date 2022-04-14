using System;

namespace SorceressSpell.LibrarIoh
{
    public static class DateTimeExtensions
    {
        #region Methods

        public static string GetFileDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("yyMMdd_HHmmss");
        }

        public static string GetHumanDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yy HH:mm:ss");
        }

        #endregion Methods
    }
}
