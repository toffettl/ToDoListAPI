using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TodoTask
    {
        [Key]
        public int TasksId {get; set;}
        public string? content {get; set;}
    }
}