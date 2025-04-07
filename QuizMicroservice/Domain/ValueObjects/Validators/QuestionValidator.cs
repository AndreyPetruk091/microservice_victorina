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
    public class QuestionValidator : Validator<Question>
    {
        public override void Validate(Question question)
        {
            if (string.IsNullOrWhiteSpace(question.Text))
                throw new ValidationException("Question text cannot be empty.");

            if (question.Answers == null || question.Answers.Count == 0)
                throw new ValidationException("Answers cannot be empty.");

            if (question.CorrectAnswerIndex < 0 || question.CorrectAnswerIndex >= question.Answers.Count)
                throw new ValidationException( "Correct answer index is out of range.");
        }
    }
}
