using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.ValueObjects;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Participant : EntityBase
    {
        public Username Username { get; private set; }

        public Participant(Username username)
        {
            Username = username ?? throw new UsernameException("Username cannot be null.");
        }

        public void UpdateUsername(Username newUsername)
        {
            Username = newUsername ?? throw new UsernameException("Username cannot be null.");
        }
    }
}