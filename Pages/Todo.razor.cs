using System;
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;
using MyFrontendApp.Models;

namespace MyFrontendApp.Pages
{
    public partial class Todo
    {
        private List <TodoItem> todos = new();

        private string newTodo;
        
        private void AddToDo() {
            if(!string.IsNullOrWhiteSpace(newTodo)){
                todos.Add(new TodoItem{ Title=newTodo });
                newTodo = string.Empty;
            }
        }
    }
}