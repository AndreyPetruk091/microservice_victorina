using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Domain.Exceptions
{
    public class QuizException : DomainException
    {
        public QuizException(string message) : base(message)
        {
        }
    }
}
