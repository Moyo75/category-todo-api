using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryTodoAPI.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        public string Name { get; set; }

       // [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
