using System;
using System.Collections.Generic;

namespace QuizService
{
    public class Program
    {
        static void Main(string[] args)
        {
            var quizService = new QuizService(); // Создаем экземпляр класса QuizService

            // create quiz
            var quiz = new Quiz("General Knowledge");
            quizService.CreateQuiz(quiz);

            // adding a question
            var question = new Question("What is the capital of France?", new List<string> { "Paris", "London", "Berlin" }, 0, quiz.Id);
            quizService.ManageQuestions(quiz.Id, question);

            // receiving questions
            var questions = quizService.GetQuestions(quiz.Id);
            Console.WriteLine($"Questions in quiz '{quiz.Title}':");
            foreach (var q in questions)
            {
                Console.WriteLine(q.Text);
            }

            // quiz removed
            bool removed = quizService.RemoveQuiz(quiz.Id);
            Console.WriteLine($"Quiz removed: {removed}");

            // remaining questions in quiz 
            var remainingQuestions = quizService.GetQuestions(quiz.Id);
            Console.WriteLine($"Remaining questions in quiz '{quiz.Title}': {remainingQuestions.Count}");
        }
    }
}