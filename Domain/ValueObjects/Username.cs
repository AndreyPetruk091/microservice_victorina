
using QuizMicroservice.Domain.Domain.Interfaces;
using QuizMicroservice.Domain.Domain.Validators;
using QuizMicroservice.Domain.System.Collections.Generic;
using QuizMicroservice.Domain.Domain.ValueObjects;

namespace QuizMicroservice.Domain.ValueObjects

public class Username : ValueObject
{
    public string Value { get; }

    public Username(string value)
    {
        Value = value;
        new UsernameValidator().Validate(this); // Автоматическая валидация
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    // Необязательно: для удобства вывода
    public override string ToString() => Value;

    // Необязательно: implicit оператор для строки
    public static implicit operator string(Username username) => username.Value;
}