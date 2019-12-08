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
        //public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }   
}
