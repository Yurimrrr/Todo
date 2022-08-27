using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositores;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
        Notifiable,
        IHandler<CreateTodoCommand>

    {
        private readonly ITodoRepository _repository;
        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateTodoCommand command)
        {
            // Criar todo -- fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Alguma coisa errada", command.Notifications);

            //Gera
            var todo = new TodoItem(command.Title, command.Date, command.User);

            //Salva
            _repository.Create(todo);

            return new GenericCommandResult(true, "Tarefa salva", todo);
        }
    }
}
