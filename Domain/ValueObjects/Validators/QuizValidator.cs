using QuizMicroservice.Domain.ValueObjects.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMicroservice.Domain.Domain.Entities;
using QuizMicroservice.Domain.ValueObjects.Base;

namespace QuizMicroservice.Domain.ValueObjects.Validators
{
    public class QuizValidator : Validator<Quiz>
    {
        public override void Validate(Quiz quiz)
        {
            if (string.IsNullOrWhiteSpace(quiz.Title))
                throw new ValidationException("Quiz title cannot be empty.");

            if (quiz.Questions == null || quiz.Questions.Count == 0)
                throw new ValidationException("Quiz must have at least one question.");
        }
    }
}