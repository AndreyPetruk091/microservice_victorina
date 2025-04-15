using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.ValueObjects.Base
{
    public interface IValidator<T>
    {
        
        void Validate(T value);
    }
}
