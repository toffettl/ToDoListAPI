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
        public Guid TasksId { get; set; }
        public string? Content { get; set; }
        public string? Description { get; set; }
        public enum Status
        {
            NotStarted,
            InProgress,
            Completed
        }
        public Status TaskStatus { get; set; }
        public enum Priority
        {
            Low,
            Medium,
            High
        }
        public Priority TaskPriority { get; set; }
        public DateTime DateLimiting { get; set; }
    }
}