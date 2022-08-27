using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositores
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);

        void Update(TodoItem todo);
    }
}
