
using Domain.Exceptions;
using Domain.Interfaces;
using Domain.ValueObjects;
using System;
using System.Text.RegularExpressions;

namespace Domain.Validators
{
	public class UsernameValidator : IValidator<Username>
	{
		private const int MinLength = 3;
		private const int MaxLength = 50;

		public void Validate(Username username)
		{
			if (username == null)
				throw new ArgumentNullException(
					nameof(username),using QuizMicroservice.Domain.Domain.ValueObjects.Base;
using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions;
using System.Text.RegularExpressions;

namespace QuizMicroservice.Domain.Domain.ValueObjects.Validators
{
    public class UsernameValidator : IValidator<Username>
    {
        private const int MinLength = 3;
        private const int MaxLength = 50;

        public void Validate(Username username)
        {
            var value = username.Value;

            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException(ExceptionMessages.EmptyValue);

            if (value.Length < MinLength)
                throw new ValidationException($"Username must be at least {MinLength} characters");

            if (value.Length > MaxLength)
                throw new ValidationException($"Username cannot exceed {MaxLength} characters");

            if (!Regex.IsMatch(value, @"^[a-zA-Z0-9_\-\.]+$"))
                throw new ValidationException("Username contains invalid characters");
        }
    }
}
					ExceptionMessages.Format(ExceptionMessages.NullValue, nameof(Username)));

			var value = username.Value;

			if (string.IsNullOrWhiteSpace(value))
				throw new ArgumentException(
					ExceptionMessages.Format(ExceptionMessages.EmptyValue, nameof(Username)));

			if (value.Length < MinLength)
				throw new ArgumentException(
					ExceptionMessages.Format(ExceptionMessages.UsernameTooShort, MinLength));

			if (value.Length > MaxLength)
				throw new ArgumentException(
					ExceptionMessages.Format(ExceptionMessages.UsernameTooLong, MaxLength));

			if (!Regex.IsMatch(value, @"^[a-zA-Z0-9_\-\.]+$"))
				throw new ArgumentException(ExceptionMessages.UsernameInvalidChars);
		}
	}
}