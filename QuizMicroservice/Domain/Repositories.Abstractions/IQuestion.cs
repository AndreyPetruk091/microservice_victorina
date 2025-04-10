using QuizMicroservice.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Repositories.Abstractions
{
    public interface IQuestionRepository : IRepository<Question>
    {
        Task<IEnumerable<Question>> GetQuestionsByQuizIdAsync(Guid quizId, CancellationToken cancellationToken);
        Task<Question?> GetQuestionByIdAsync(Guid questionId, CancellationToken cancellationToken);
    }
}