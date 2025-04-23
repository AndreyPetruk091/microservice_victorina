using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;

namespace QuizMicroservice.Domain.Domain.ValueObjects
{
    public class AnswerIndex : ValueObject
    {
        public int Value { get; }

        public AnswerIndex(int value, int totalAnswers)
        {
            if (value < 0 || value >= totalAnswers)
                throw new AnswerIndexException(
                    ExceptionMessages.Format(ExceptionMessages.InvalidAnswerIndex, totalAnswers-1));

            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
    }
}