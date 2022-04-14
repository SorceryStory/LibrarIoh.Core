namespace SorceressSpell.LibrarIoh.Core
{
    public interface ICopyFrom<T>
    {
        #region Methods

        void CopyFrom(T original);

        #endregion Methods
    }
}
