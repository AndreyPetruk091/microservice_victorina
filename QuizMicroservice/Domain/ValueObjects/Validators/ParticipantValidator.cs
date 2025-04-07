using QuizMicroservice.Domain.ValueObjects.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMicroservice.Domain.Domain.Entities;
using QuizMicroservice.Domain.ValueObjects.Base;

namespace QuizMicroservice.Domain.ValueObjects.Validators
{
    public class ParticipantValidator : Validator<Participant>
    {
        public override void Validate(Participant participant)
        {
            if (string.IsNullOrWhiteSpace(participant.Username))
                throw new ValidationException("Username cannot be empty.");
        }
    }
}
