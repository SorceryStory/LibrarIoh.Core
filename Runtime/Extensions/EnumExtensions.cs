using System;

namespace SorceressSpell.LibrarIoh.Core
{
    public static class EnumExtensions
    {
        #region Methods

        public static T FromBitString<T>(this Enum type, string bitString)
        {
            return (T)(object)(Convert.ToInt32(bitString, 2));
        }

        public static bool Is<T>(this Enum type, T value)
        {
            return ((int)(object)type & (int)(object)value) ==
            (int)(object)value;
        }

        public static bool IsAnyOf<T>(this Enum type, T value)
        {
            return ((int)(object)type & (int)(object)value) != 0;
        }

        public static bool IsExactly<T>(this Enum type, T value)
        {
            return (int)(object)type == (int)(object)value;
        }

        public static bool IsNot<T>(this Enum type, T value)
        {
            return ((int)(object)type & (int)(object)value) !=
            (int)(object)value;
        }

        public static bool IsNotAny<T>(this Enum type, T value)
        {
            return ((int)(object)type & (int)(object)value) == 0;
        }

        //public static T Add<T>(this Enum type, T value)
        //{
        //    return (T)(object)(((int)(object)type | (int)(object)value));
        //}
        //public static T Remove<T>(this Enum type, T value)
        //{
        //    return (T)(object)(((int)(object)type & ~(int)(object)value));
        //}
        // Combinations
        public static T Set<T>(this Enum type, T value)
        {
            return (T)(object)(((int)(object)type | (int)(object)value));
        }

        // String Operations
        public static string ToBitString(this Enum type, int totalWidth)
        {
            return Convert
                .ToString((int)(object)type, 2)
                .PadLeft(totalWidth, '0');
        }

        public static T Unset<T>(this Enum type, T value)
        {
            return (T)(object)(((int)(object)type & ~(int)(object)value));
        }

        #endregion Methods

        //public static bool Has<T>(this System.Enum type, T value)
        //{
        //    try
        //    {
        //        return (((int)(object)type & (int)(object)value) == (int)(object)value);
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public static bool Is<T>(this System.Enum type, T value)
        //{
        //    try
        //    {
        //        return (int)(object)type == (int)(object)value;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public static T Add<T>(this System.Enum type, T value)
        //{
        //    try
        //    {
        //        return (T)(object)(((int)(object)type | (int)(object)value));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException(
        //            string.Format(
        //                "Could not append value from enumerated type '{0}'.",
        //                typeof(T).Name
        //                ), ex);
        //    }
        //}

        //public static T Remove<T>(this System.Enum type, T value)
        //{
        //    try
        //    {
        //        return (T)(object)(((int)(object)type & ~(int)(object)value));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException(
        //            string.Format(
        //                "Could not remove value from enumerated type '{0}'.",
        //                typeof(T).Name
        //                ), ex);
        //    }
        //}
    }
}
