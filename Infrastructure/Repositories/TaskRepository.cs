using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class TaskRepository : ITaskRepository
{
    private readonly AppDbContext _context;
    public TaskRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TodoTask> AddTaskAsync(TodoTask task)
    {
        await _context.Set<TodoTask>().AddAsync(task);
        return task;
    }
    public async Task<TodoTask> DeleteTaskAsync(Guid taskId)
    {
        var task = await _context.Set<TodoTask>().FindAsync(taskId);
        if (task == null)
        {
            return null;
        }

        _context.Set<TodoTask>().Remove(task);
        return task;
    }

    public async Task<TodoTask> GetTaskByIdAsync(Guid taskId)
    {
        var task = await _context.Set<TodoTask>().FirstOrDefaultAsync(t => t.TasksId == taskId);
        return task;
    }

    public async Task<IEnumerable<TodoTask>> GetTasksByUserIdAsync(Guid userId)
    {
        var tasks = await _context.Set<TodoTask>()
                          .Where(t => t.UserId == userId)
                          .ToListAsync();
        return tasks;
    }

    public async Task<TodoTask> UpdateTaskAsync(TodoTask task)
    {
        _context.Set<TodoTask>().Update(task);

        return task;
    }
}
