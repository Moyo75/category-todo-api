using System.Collections.Generic;

namespace CategoryTodoAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<TodoItem> CategoryTodosItems { get; set; }
    }
}
