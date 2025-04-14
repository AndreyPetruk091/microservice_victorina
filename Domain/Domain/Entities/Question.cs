using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.Enums;
using QuizMicroservice.Domain.Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Question : EntityBase
    {
        public string Text { get; private set; }
        public List<string> Answers { get; private set; }
        public int CorrectAnswerIndex { get; private set; }
        public Guid QuizId { get; private set; }
        public QuestionStatus Status { get; private set; }

        public Question(string text, List<string> answers, int correctAnswerIndex, Guid quizId)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new QuestionException("Question text cannot be empty.");

            if (answers == null || answers.Count == 0)
                throw new QuestionException("Answers cannot be empty.");

            if (correctAnswerIndex < 0 || correctAnswerIndex >= answers.Count)
                throw new QuestionException("Correct answer index is out of range.");

            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
            QuizId = quizId;
            Status = QuestionStatus.Active;
        }

        public void UpdateStatus(QuestionStatus status)
        {
            Status = status;
        }

        public bool IsCorrectAnswer(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }
}