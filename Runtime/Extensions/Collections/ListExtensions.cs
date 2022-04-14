using System.Collections.Generic;

namespace SorceressSpell.LibrarIoh
{
    public static class ListExtensions
    {
        #region Methods

        public static int Sum(this List<int> list)
        {
            int sum = 0;
            foreach (int i in list) { sum += i; }
            return sum;
        }

        public static float Sum(this List<float> list)
        {
            float sum = 0f;
            foreach (float f in list) { sum += f; }
            return sum;
        }

        #endregion Methods
    }
}
