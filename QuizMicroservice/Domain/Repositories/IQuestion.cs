using QuizMicroservice.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Repositories
{
    public interface IQuestionRepository : IRepository<Question, Guid>
    {
        Task<IEnumerable<Question>> GetQuestionsByQuizIdAsync(Guid quizId, CancellationToken cancellationToken);
        Task<Question?> GetQuestionByIdAsync(Guid questionId, CancellationToken cancellationToken);
    }
}
