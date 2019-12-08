using System.Collections.Generic;

namespace CategoryTodoAPI.Models
{
    public class Category
    {
        public Category()
        {
            //TodoItems = new HashSet<TodoItem>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        //public IEnumerable<TodoItem> TodoItems { get; set; }
    }
}
