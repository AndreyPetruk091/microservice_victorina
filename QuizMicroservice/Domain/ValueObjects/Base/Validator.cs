using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.ValueObjects.Base
{
    public abstract class Validator<T>
    {
        public abstract void Validate(T entity);
    }
}
