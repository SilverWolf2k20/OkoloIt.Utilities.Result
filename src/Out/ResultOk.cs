namespace OkoloIt.Utilities.Result.Out
{

    /// <summary>
    /// Положительный результ.
    /// </summary>
    /// <typeparam name="T">Тип хранящегося значения.</typeparam>
    public sealed class ResultOk<T>
    {
        #region Internal Constructors

        /// <summary>
        /// Создает экземпляр положительного результата.
        /// </summary>
        /// <param name="value">Значение.</param>
        internal ResultOk(T value)
            => Value = value;

        #endregion Internal Constructors

        #region Internal Properties

        /// <summary>
        /// Значение.
        /// </summary>
        internal T Value { get; }

        #endregion Internal Properties
    }
}