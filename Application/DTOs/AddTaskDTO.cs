using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Constants;
using Domain.Entities;

namespace Application.DTOs;
public class AddTaskDTO
{
    public string? Content { get; set; }
    public string? Description { get; set; }
    public Status TaskStatus { get; set; }
    public Priority TaskPriority { get; set; }
    public DateTime DateLimiting { get; set; }
    public Guid UserId { get; set; }
}
