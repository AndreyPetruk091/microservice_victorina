
namespace QuizMicroservice.Domain.ValueObjects.Exceptions
{
    public static class ExceptionMessages
    {
        // Общие сообщения
        public const string NullValue = "{0} не может быть null";
        public const string EmptyValue = "{0} не может быть пустым";

        // Сообщения для Username
        public const string UsernameTooShort = "Username должен содержать минимум {0} символов";
        public const string UsernameTooLong = "Username должен содержать максимум {0} символов";
        public const string UsernameInvalidChars = "Username может содержать только буквы, цифры, '-', '_' и '.'";

        // Метод для форматирования сообщений
        public static string Format(string template, params object[] args)
            => string.Format(template, args);
    }
}