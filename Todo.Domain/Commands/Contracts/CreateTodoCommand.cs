using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Commands.Contracts
{
    public class CreateTodoCommand
    {
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
    }
}
