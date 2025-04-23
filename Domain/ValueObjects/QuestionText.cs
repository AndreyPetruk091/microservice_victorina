using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;

namespace QuizMicroservice.Domain.Domain.ValueObjects
{
    public class QuestionText : ValueObject
    {
        public string Value { get; }
        private const int MaxLength = 500;

        public QuestionText(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new QuestionTextException(ExceptionMessages.EmptyQuestionText);
            
            if (value.Length > MaxLength)
                throw new QuestionTextException(
                    ExceptionMessages.Format(ExceptionMessages.QuestionTextTooLong, MaxLength));

            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
        public static implicit operator string(QuestionText text) => text.Value;
    }
}