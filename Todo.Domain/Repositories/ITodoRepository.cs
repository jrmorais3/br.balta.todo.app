using Todo.Domain.Entities;

namespace Todo.Domain.Api.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
    }
}
