using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;

namespace QuizMicroservice.Domain.Domain.ValueObjects
{
    public class QuizTitle : ValueObject
    {
        public string Value { get; }
        private const int MaxLength = 100;

        public QuizTitle(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new QuizTitleException(ExceptionMessages.EmptyQuizTitle);
            
            if (value.Length > MaxLength)
                throw new QuizTitleException(
                    ExceptionMessages.Format(ExceptionMessages.QuizTitleTooLong, MaxLength));

            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
        public static implicit operator string(QuizTitle title) => title.Value;
    }
}