using OkoloIt.Utilities.Result.Out;

namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Данные возврата метода.
    /// </summary>
    /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
    public class Result<T> : Result, IResult<T>
    {
        #region Internal Constructors

        /// <summary>
        /// Содает экземпляр класса.
        /// </summary>
        /// <param name="value">Возвращаемое значение.</param>
        /// <param name="success">True - если успешно выполнилось.</param>
        /// <param name="error">Текст ошибки.</param>
        internal Result(T value, bool success, string error)
            : base(success, error)
            => Value = value;

        #endregion Internal Constructors

        #region Public Properties

        /// <summary>
        /// Хранимое значение.
        /// </summary>
        public T Value { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Неявное преобразование типа <see href="ResultOk"/>
        /// в <see href="Result"/>.
        /// </summary>
        /// <param name="ok">Положительный результат.</param>
        public static implicit operator Result<T>(ResultOk<T> ok)
            => new Result<T>(ok.Value, true, string.Empty);

        /// <summary>
        /// Неявное преобразование типа <see href="ResultFail"/>
        /// в <see href="Result"/>.
        /// </summary>
        /// <param name="error">Ошибочный результат.</param>
        public static implicit operator Result<T>(ResultFail error)
            => new Result<T>(default, false, error. Message);

        #endregion Public Methods
    }
}