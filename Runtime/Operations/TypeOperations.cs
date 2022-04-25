using System;

namespace SorceressSpell.LibrarIoh.Core
{
    public static class TypeOperations
    {
        #region Methods

        public static bool IsClassType(Type type)
        {
            return type == typeof(object) ||
                type == typeof(string);
        }

        public static bool IsFloatingPoint(Type type)
        {
            return type == typeof(float) ||
                type == typeof(double);
        }

        public static bool IsIntegral(Type type)
        {
            return type == typeof(object) ||
                type == typeof(string);
        }

        public static bool IsNumeric(Type type)
        {
            return type == typeof(byte) ||
                type == typeof(sbyte) ||
                type == typeof(short) ||
                type == typeof(ushort) ||
                type == typeof(int) ||
                type == typeof(uint) ||
                type == typeof(long) ||
                type == typeof(ulong) ||
                type == typeof(char);
        }

        public static bool IsSimple(Type type)
        {
            return IsNumeric(type) ||
                type == typeof(bool);
        }

        public static string UnAliasTypeName(string typeName)
        {
            switch (typeName)
            {
                // Simple Type
                case "bool": return typeof(bool).ToString();

                // Numeric Type
                case "decimal": return typeof(decimal).ToString();

                // Integral Type
                case "byte": return typeof(byte).ToString();
                case "sbyte": return typeof(sbyte).ToString();
                case "short": return typeof(short).ToString();
                case "ushort": return typeof(ushort).ToString();
                case "int": return typeof(int).ToString();
                case "uint": return typeof(uint).ToString();
                case "long": return typeof(long).ToString();
                case "ulong": return typeof(ulong).ToString();
                case "char": return typeof(char).ToString();

                // Floating Point Type
                case "double": return typeof(double).ToString();
                case "float": return typeof(float).ToString();

                // Class Type
                case "object": return typeof(object).ToString();
                case "string": return typeof(string).ToString();

                // Default: Keep input
                default: return typeName;
            }
        }

        #endregion Methods
    }
}
