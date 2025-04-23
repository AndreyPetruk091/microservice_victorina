using QuizMicroservice.Domain.Domain.Entities;
using QuizMicroservice.Domain.Repositories.Abstractions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Services
{
    public class QuizService
    {
        private readonly IQuizRepository _quizRepo;
        private readonly IQuestionRepository _questionRepo;

        public QuizService(IQuizRepository quizRepo, IQuestionRepository questionRepo)
        {
            _quizRepo = quizRepo;
            _questionRepo = questionRepo;
        }

        public async Task CreateQuizAsync(Quiz quiz, CancellationToken ct)
        {
            await _quizRepo.AddAsync(quiz, ct);
        }

        public async Task AddQuestionToQuizAsync(Guid quizId, Question question, CancellationToken ct)
        {
            var quiz = await _quizRepo.GetByIdAsync(quizId, ct);
            quiz.AddQuestion(question);
            await _quizRepo.UpdateAsync(quiz, ct);
        }
    }
}