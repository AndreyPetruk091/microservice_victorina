
namespace QuizMicroservice.Domain.ValueObjects.Exceptions
{
    public static class ExceptionMessages
    {
        // ����� ���������
        public const string NullValue = "{0} �� ����� ���� null";
        public const string EmptyValue = "{0} �� ����� ���� ������";

        // ��������� ��� Username
        public const string UsernameTooShort = "Username ������ ��������� ������� {0} ��������";
        public const string UsernameTooLong = "Username ������ ��������� �������� {0} ��������";
        public const string UsernameInvalidChars = "Username ����� ��������� ������ �����, �����, '-', '_' � '.'";

        // ����� ��� �������������� ���������
        public static string Format(string template, params object[] args)
            => string.Format(template, args);
    }
}