using System;
using System.Collections.Generic;

namespace QuizService
{
    public class Quiz
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public List<Question> Questions { get; private set; }

        public Quiz(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void RemoveQuestion(Guid questionId)
        {
            var question = Questions.Find(q => q.Id == questionId);
            if (question != null)
            {
                Questions.Remove(question);
            }
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}