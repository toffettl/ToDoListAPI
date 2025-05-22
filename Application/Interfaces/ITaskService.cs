using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces;
public interface ITaskService
{
    Task<TodoTask> AddTaskAsync(AddTaskDTO task);
    Task<TodoTask> UpdateTaskAsync(TodoTask task);
    Task<TodoTask> DeleteTaskAsync(Guid taskId);
    Task<TodoTask> GetTaskByIdAsync(Guid taskId);
    Task<IEnumerable<TodoTask>> GetTasksByUserIdAsync(Guid userId);
}
