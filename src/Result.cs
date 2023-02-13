namespace OkoloIt.Utilities.Result
{
    /// <summary>
    /// Данные возврата метода.
    /// </summary>
    public class Result : IResult
    {
        #region Protected Constructors

        /// <summary>
        /// Создает экземпляр класса.
        /// </summary>
        /// <param name="success">Состояние результата.</param>
        /// <param name="message">Сообщение результата.</param>
        protected Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        #endregion Protected Constructors

        #region Public Properties

        /// <summary>
        /// Ошибка.
        /// </summary>
        public bool Error => !Success;

        /// <summary>
        /// Сообщение.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Успех.
        /// </summary>
        public bool Success { get; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Возврощает объект класса при ошибке.
        /// </summary>
        /// <returns>Объект класса.</returns>
        public static Result Fail()
            => new Result(false, string.Empty);

        /// <summary>
        /// Возврощает объект класса при ошибке.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <returns>Объект класса.</returns>
        public static Result<T> Fail<T>()
            => new Result<T>(default, false, string.Empty);

        /// <summary>
        /// Возврощает объект класса при ошибке с сообщением.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <returns>Объект класса.</returns>
        public static Result Fail(string message)
            => new Result(false, message);

        /// <summary>
        /// Возврощает объект класса при ошибке с сообщением.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="message">Сообщение.</param>
        /// <returns>Объект класса.</returns>
        public static Result<T> Fail<T>(string message)
            => new Result<T>(default, false, message);

        /// <summary>
        /// Возврощает объект класса при ошибке с сообщением.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="value">Возвращаемное значение.</param>
        /// <returns>Объект класса.</returns>
        public static Result<T> Fail<T>(T value)
            => new Result<T>(value, false, string.Empty);

        /// <summary>
        /// Возврощает объект класса при ошибке с сообщением.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="value">Возвращаемное значение.</param>
        /// <param name="message">Сообщение.</param>
        /// <returns></returns>
        public static Result<T> Fail<T>(T value, string message)
            => new Result<T>(value, false, message);

        /// <summary>
        /// Возврощает объект класса при успехе.
        /// </summary>
        /// <returns>Объект класса.</returns>
        public static Result Ok()
            => new Result(true, string.Empty);

        /// <summary>
        /// Возврощает объект класса при успехе.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <returns>Объект класса.</returns>
        public static Result Ok(string message)
            => new Result(true, message);

        /// <summary>
        /// Возврощает объект класса при успехе.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="value">Возвращаемное значение.</param>
        /// <returns>Объект класса.</returns>
        public static Result<T> Ok<T>(T value)
            => new Result<T>(value, true, string.Empty);

        /// <summary>
        /// Возврощает объект класса при успехе.
        /// </summary>
        /// <typeparam name="T">Тип возвращаемого значения.</typeparam>
        /// <param name="message">Сообщение.</param>
        /// <param name="value">Возвращаемное значение.</param>
        /// <returns>Объект класса.</returns>
        public static Result<T> Ok<T>(T value, string message)
            => new Result<T>(value, true, message);

        #endregion Public Methods
    }
}