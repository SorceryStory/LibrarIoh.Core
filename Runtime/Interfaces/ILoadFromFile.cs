namespace SorceressSpell.LibrarIoh.Core
{
    public interface ILoadFromFile<T>
    {
        #region Methods

        T Load(string sourceFilePath);

        #endregion Methods
    }
}
