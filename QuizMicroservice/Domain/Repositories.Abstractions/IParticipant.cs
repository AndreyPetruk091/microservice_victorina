using QuizMicroservice.Domain.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Repositories.Abstractions
{
    public interface IParticipantRepository : IRepository<Participant>
    {
        Task<Participant?> GetParticipantByUsernameAsync(string username, CancellationToken cancellationToken);
    }
}