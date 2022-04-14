namespace SorceressSpell.LibrarIoh
{
    public interface ILoadFromFile<T>
    {
        #region Methods

        T Load(string filePath);

        #endregion Methods
    }
}
