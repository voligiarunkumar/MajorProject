using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LMS.Web.Models
{
    public class ToDoListStatusPriorityViewModel
    {
       

        public List<ToDoList> ToDoLists { get; set; }    
        public SelectList Statuses { get; set; } 
        public string ToDoListStatus { get; set; }
        public SelectList Priorities { get; set; }
        public string ToDoListPriority { get; set; }
        public string SearchString { get; set; }
    }
}
