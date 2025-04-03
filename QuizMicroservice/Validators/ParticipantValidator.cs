using QuizService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    public class ParticipantValidator
    {
        public void Validate(Participant participant)
        {
            if (string.IsNullOrWhiteSpace(participant.Username))
                throw new ArgumentException("Username cannot be empty.", nameof(participant.Username));
        }
    }
}
