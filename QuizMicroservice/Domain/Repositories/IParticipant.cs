using QuizMicroservice.Domain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Repositories
{
    public interface IParticipantRepository : IRepository<Participant, Guid>
    {
        Task<Participant?> GetParticipantByUsernameAsync(string username, CancellationToken cancellationToken);
    }
}