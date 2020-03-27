using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise603_Build_Api.Models;

namespace Exercise603_Build_Api
{

    
    public class FakeDb
    {
        public static List<TodoItem> _todoItems = new List<TodoItem>();

        public static void initialize()
        {
            _todoItems.Add(new TodoItem() { Description = "First todo", Id = 1, IsComplete = false, Name = "First" });
            _todoItems.Add(new TodoItem() { Description = "Second todo", Id = 2, IsComplete = false, Name = "Second" });
            _todoItems.Add(new TodoItem() { Description = "Third todo", Id = 3, IsComplete = false, Name = "Third" });
            _todoItems.Add(new TodoItem() { Description = "Fourth todo", Id = 4, IsComplete = false, Name = "Fourth" });
        }
    }
}
