using System;

namespace SorceressSpell.LibrarIoh
{
    public static class ConversionOperations
    {
        #region Methods

        public static T ConvertTo<T>(object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }

        public static char ToChar(int unicode)
        {
            return Convert.ToChar(unicode);
        }

        public static int ToUnicode(char character)
        {
            return Convert.ToInt32(character);
        }

        #endregion Methods
    }
}
