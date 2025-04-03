using System;

namespace QuizService
{
    public class Participant
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }

        public Participant(string username)
        {
            Id = Guid.NewGuid();
            Username = username;
        }

        public void UpdateUsername(string newUsername)
        {
            if (string.IsNullOrWhiteSpace(newUsername))
                throw new ArgumentException("Username cannot be empty.", nameof(newUsername));

            Username = newUsername;
        }
    }
}