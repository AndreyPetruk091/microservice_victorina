using QuizMicroservice.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Repositories
{
    public interface IQuizRepository : IRepository<Quiz, Guid>
    {
        Task<IEnumerable<Quiz>> GetAllQuizzesWithQuestionsAsync(CancellationToken cancellationToken);
        Task<Quiz?> GetQuizByIdAsync(Guid quizId, CancellationToken cancellationToken);
    }
}