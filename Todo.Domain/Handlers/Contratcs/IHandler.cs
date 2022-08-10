using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Api.Handlers.Contratcs
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
