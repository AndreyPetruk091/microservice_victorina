using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.Enums;
using QuizMicroservice.Domain.Domain.ValueObjects;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Question : EntityBase
    {
        public QuestionText Text { get; private set; }
        public List<Answer> Answers { get; private set; }
        public AnswerIndex CorrectAnswerIndex { get; private set; }

        public Question(QuestionText text, List<Answer> answers, AnswerIndex correctAnswerIndex)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public void UpdateStatus(QuestionStatus status) => Status = status;
    }
}