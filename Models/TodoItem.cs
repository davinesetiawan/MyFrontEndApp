using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MyFrontendApp.Models
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}