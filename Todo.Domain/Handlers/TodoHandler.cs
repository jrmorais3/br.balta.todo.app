using Flunt.Notifications;
using Todo.Domain.Api.Handlers.Contratcs;
using Todo.Domain.Api.Repositories;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : Notifiable, IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
