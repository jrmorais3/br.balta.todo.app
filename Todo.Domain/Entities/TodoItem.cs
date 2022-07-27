﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(Guid id, string title, bool done, DateTime date, string user) : base(id)
        {
            Title = title;
            Done = false;
            Date = date;
            User = user;
        }

        public void MarkAsDone()
        {
            Done = true;
        }

        public void MarkAsUndone()
        {
            Done = true;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
    }
}
