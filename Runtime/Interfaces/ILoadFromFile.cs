namespace SorceressSpell.LibrarIoh.Core
{
    public interface ILoadFromFile<T>
    {
        #region Methods

        T Load(string filePath);

        #endregion Methods
    }
}
