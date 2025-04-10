using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMicroservice.Domain.Domain.Entities.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; private set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
