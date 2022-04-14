namespace SorceressSpell.LibrarIoh.Core
{
    public static class ArrayOperations
    {
        #region Methods

        public static bool IsArraySize(float[] array, int lenght, int rank = 1)
        {
            return array.Length == lenght && array.Rank == rank;
        }

        #endregion Methods
    }
}
