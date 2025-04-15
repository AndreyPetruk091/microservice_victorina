
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
        new UsernameValidator().Validate(this); // �������������� ���������
    }

    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    // �������������: ��� �������� ������
    public override string ToString() => Value;

    // �������������: implicit �������� ��� ������
    public static implicit operator string(Username username) => username.Value;
}