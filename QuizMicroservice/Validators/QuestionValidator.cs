using QuizService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService;

public class QuestionValidator
{
    public void Validate(Question question)
    {
        if (string.IsNullOrWhiteSpace(question.Text))
            throw new ArgumentException("Question text cannot be empty.", nameof(question.Text));

        if (question.Answers == null || question.Answers.Count == 0)
            throw new ArgumentException("Answers cannot be empty.", nameof(question.Answers));

        if (question.CorrectAnswerIndex < 0 || question.CorrectAnswerIndex >= question.Answers.Count)
            throw new ArgumentOutOfRangeException(nameof(question.CorrectAnswerIndex), "Correct answer index is out of range.");
    }
}
