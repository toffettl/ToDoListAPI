using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;
public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    private readonly IUnitOfWork _unitOfWork;
    public TaskService(ITaskRepository taskRepository, IUnitOfWork unitOfWork)
    {
        _taskRepository = taskRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<TodoTask> AddTaskAsync(AddTaskDTO task)
    {
        var createdTask = new TodoTask
        {
            TasksId = Guid.NewGuid(),
            Content = task.Content,
            DateLimiting = task.DateLimiting,
            Description = task.Description,
            TaskPriority = task.TaskPriority,
            TaskStatus = task.TaskStatus,
            UserId = task.UserId
        };

        var todoTask = await _taskRepository.AddTaskAsync(createdTask);
        if(todoTask == null)
        {
            return null;
        }

        _unitOfWork.SaveChangesAsync();

        return todoTask;
    }

    public Task<TodoTask> DeleteTaskAsync(Guid taskId)
    {
        var todoTask = _taskRepository.DeleteTaskAsync(taskId);
        if (todoTask == null)
        {
            return null;
        }

        _unitOfWork.SaveChangesAsync();

        return todoTask;
    }

    public Task<TodoTask> GetTaskByIdAsync(Guid taskId)
    {
        var todoTask = _taskRepository.GetTaskByIdAsync(taskId);
        if (todoTask == null)
        {
            return null;
        }

        _unitOfWork.SaveChangesAsync();

        return todoTask;
    }

    public Task<IEnumerable<TodoTask>> GetTasksByUserIdAsync(Guid userId)
    {
        var todoTasks = _taskRepository.GetTasksByUserIdAsync(userId);
        if (todoTasks == null)
        {
            return null;
        }

        _unitOfWork.SaveChangesAsync();

        return todoTasks;
    }

    public Task<TodoTask> UpdateTaskAsync(TodoTask task)
    {
        var todoTask = _taskRepository.UpdateTaskAsync(task);
        if (todoTask == null)
        {
            return null;
        }

        _unitOfWork.SaveChangesAsync();

        return todoTask;
    }
}
