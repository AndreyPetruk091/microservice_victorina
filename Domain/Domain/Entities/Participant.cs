using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.Exceptions;
using System;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Participant : EntityBase
    {
        public string Username { get; private set; }

        public Participant(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new UsernameException("Username cannot be empty.");

            Username = username;
        }

        public void UpdateUsername(string newUsername)
        {
            if (string.IsNullOrWhiteSpace(newUsername))
                throw new UsernameException("Username cannot be empty.");

            Username = newUsername;
        }
    }
}