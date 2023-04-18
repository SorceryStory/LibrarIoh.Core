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
            return typeName switch
            {
                // Simple Type
                "bool" => typeof(bool).ToString(),
                // Numeric Type
                "decimal" => typeof(decimal).ToString(),
                // Integral Type
                "byte" => typeof(byte).ToString(),
                "sbyte" => typeof(sbyte).ToString(),
                "short" => typeof(short).ToString(),
                "ushort" => typeof(ushort).ToString(),
                "int" => typeof(int).ToString(),
                "uint" => typeof(uint).ToString(),
                "long" => typeof(long).ToString(),
                "ulong" => typeof(ulong).ToString(),
                "char" => typeof(char).ToString(),
                // Floating Point Type
                "double" => typeof(double).ToString(),
                "float" => typeof(float).ToString(),
                // Class Type
                "object" => typeof(object).ToString(),
                "string" => typeof(string).ToString(),
                // Default: Keep input
                _ => typeName,
            };
        }

        #endregion Methods
    }
}
