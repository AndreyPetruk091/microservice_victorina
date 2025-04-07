using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Quiz : EntityBase
    {
        public string Title { get; private set; }
        public List<Question> Questions { get; private set; }

        public Quiz(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new QuizException("Quiz title cannot be empty.");

            Title = title;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            if (question == null)
                throw new QuizException("Question cannot be null.");

            Questions.Add(question);
        }

        public void RemoveQuestion(Guid questionId)
        {
            var question = Questions.Find(q => q.Id == questionId);
            if (question != null)
            {
                Questions.Remove(question);
            }
            else
            {
                throw new QuizException("Question not found.");
            }
        }

        public void UpdateTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new QuizException("Quiz title cannot be empty.");

            Title = title;
        }
    }
}