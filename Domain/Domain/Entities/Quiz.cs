using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.ValueObjects;
using QuizMicroservice.Domain.Domain.Enums;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Quiz : EntityBase
    {
        public QuizTitle Title { get; private set; }
        public List<Question> Questions { get; private set; }
        public QuizStatus Status { get; private set; }

        public Quiz(QuizTitle title)
        {
            Title = title;
            Questions = new List<Question>();
            Status = QuizStatus.Active;
        }

        public void AddQuestion(Question question) => Questions.Add(question);
        public void RemoveQuestion(Question question) => Questions.Remove(question);
    }
}