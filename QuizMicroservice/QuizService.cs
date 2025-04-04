﻿using System;
using System.Collections.Generic;

namespace QuizService
{
    public class QuizService
    {
        private readonly List<Quiz> _quizzes;

        public QuizService()
        {
            _quizzes = new List<Quiz>();
        }

        public void CreateQuiz(Quiz quiz)
        {
            if (quiz == null)
                throw new ArgumentNullException(nameof(quiz), "Quiz cannot be null.");

            _quizzes.Add(quiz);
        }

        public void ManageQuestions(Guid quizId, Question question)
        {
            if (question == null)
                throw new ArgumentNullException(nameof(question), "Question cannot be null.");

            var existingQuiz = _quizzes.Find(q => q.Id == quizId);
            if (existingQuiz == null)
            {
                throw new ArgumentException("Quiz does not exist.", nameof(quizId));
            }

            existingQuiz.AddQuestion(question);
        }

        public List<Question> GetQuestions(Guid quizId)
        {
            var quiz = _quizzes.Find(q => q.Id == quizId);
            return quiz?.Questions ?? new List<Question>(); // Возвращаем пустой список, если викторина не найдена
        }

        public List<Quiz> GetAllQuizzes()
        {
            return _quizzes;
        }

        public bool RemoveQuiz(Guid quizId)
        {
            var quiz = _quizzes.Find(q => q.Id == quizId);
            if (quiz != null)
            {
                _quizzes.Remove(quiz);
                return true; // Успешное удаление
            }
            return false; // Викторина не найдена
        }
    }
}