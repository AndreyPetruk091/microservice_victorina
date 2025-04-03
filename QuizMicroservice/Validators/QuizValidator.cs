using QuizService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    public class QuizValidator
    {
        public void Validate(Quiz quiz)
        {
            if (string.IsNullOrWhiteSpace(quiz.Title))
                throw new ArgumentException("Quiz title cannot be empty.", nameof(quiz.Title));

            if (quiz.Questions == null || quiz.Questions.Count == 0)
                throw new ArgumentException("Quiz must have at least one question.", nameof(quiz.Questions));
        }
    }
}