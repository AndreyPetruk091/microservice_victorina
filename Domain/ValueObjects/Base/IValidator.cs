namespace QuizMicroservice.Domain.Domain.ValueObjects.Base
{
    public interface IValidator<T>
    {
        void Validate(T value);
    }
}