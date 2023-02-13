namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Итерфейс объекта возврата.
    /// </summary>
    public interface IResult<T> : IResult
    {
        #region Public Properties

        /// <summary>
        /// Хранимое значение.
        /// </summary>
        T Value { get; }

        #endregion Public Properties
    }
}