using QuizMicroservice.Domain.Domain.Entities.Base;
using QuizMicroservice.Domain.Domain.ValueObjects;
using QuizMicroservice.Domain.Domain.ValueObjects.Exceptions.ExeptionMasseges;
using System;
using System.Collections.Generic;

namespace QuizMicroservice.Domain.Domain.Entities
{
    public class Participant : EntityBase
    {
        public Username Username { get; private set; }// сделано

        public Participant(Username Username)
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