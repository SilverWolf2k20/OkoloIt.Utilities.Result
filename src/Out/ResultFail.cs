namespace OkoloIt.Utilities.Result.Out
{

    /// <summary>
    /// Ошибочный результат.
    /// </summary>
    public sealed class ResultFail
    {
        #region Internal Constructors

        /// <summary>
        /// Создает экземпляр ошибочного результата.
        /// </summary>
        /// <param name="message">Сообщение ошибки.</param>
        internal ResultFail(string message)
            => Message = message;

        #endregion Internal Constructors

        #region Internal Properties

        /// <summary>
        /// Сообщение ошибки.
        /// </summary>
        internal string Message { get; }

        #endregion Internal Properties
    }
}