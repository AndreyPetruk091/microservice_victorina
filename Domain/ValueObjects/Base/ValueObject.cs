using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;

namespace QuizMicroservice.Domain.ValueObjects.Base
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        protected abstract IEnumerable<object> GetAtomicValues();

        // Реализация сравнения
        public override bool Equals(object obj)
        {
            if (obj is null || obj.GetType() != GetType())
                return false;

            var other = (ValueObject)obj;
            return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
        }

        public bool Equals(ValueObject other) => Equals((object)other);

        
        public override int GetHashCode()
        {
            unchecked
            {
                return GetAtomicValues()
                    .Aggregate(17, (current, obj) =>
                        current * 23 + (obj?.GetHashCode() ?? 0));
            }
        }

        // Операторы == и !=
        public static bool operator ==(ValueObject left, ValueObject right)
            => left?.Equals(right) ?? ReferenceEquals(right, null);

        public static bool operator !=(ValueObject left, ValueObject right)
            => !(left == right);
    }
}