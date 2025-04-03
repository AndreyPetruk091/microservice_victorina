using System;
using System.Collections.Generic;

namespace QuizService
{
    public class Question
    {
        public Guid Id { get; private set; }
        public string Text { get; private set; }
        public List<string> Answers { get; private set; }
        public int CorrectAnswerIndex { get; private set; }
        public Guid QuizId { get; private set; }
        public string Status { get; private set; }

        public Question(string text, List<string> answers, int correctAnswerIndex, Guid quizId)
        {
            Id = Guid.NewGuid();
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
            QuizId = quizId;
            Status = "Active";
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }

        public bool IsCorrectAnswer(int answerIndex)
        {
            return answerIndex == CorrectAnswerIndex;
        }
    }
}