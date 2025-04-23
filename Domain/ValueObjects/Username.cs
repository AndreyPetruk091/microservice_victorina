using QuizMicroservice.Domain.Domain.ValueObjects.Base;
using QuizMicroservice.Domain.Domain.ValueObjects.Validators;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.ValueObjects
{
    public class Username : ValueObject
    {
        public string Value { get; }

        public Username(string value)
        {
            new UsernameValidator().Validate(this);
            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues() => new[] { Value };
        public static implicit operator string(Username username) => username.Value;
    }
}