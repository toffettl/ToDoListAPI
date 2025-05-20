using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;
public interface ITaskRepository
{
    Task<TodoTask> GetTaskByIdAsync(Guid taskId);
    Task<IEnumerable<TodoTask>> GetTasksByUserIdAsync(Guid userId);
    Task<TodoTask> AddTaskAsync(TodoTask task);
    Task<TodoTask> UpdateTaskAsync(TodoTask task);
    Task<TodoTask> DeleteTaskAsync(Guid taskId);
}
