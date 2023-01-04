namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Итерфейс объекта возврата.
    /// </summary>
    public interface IResult
    {
        #region Public Properties

        /// <summary>
        /// Ошибка.
        /// </summary>
        bool Error { get; }

        /// <summary>
        /// Сообщение.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Успех.
        /// </summary>
        bool Success { get; }

        #endregion Public Properties
    }
}