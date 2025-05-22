using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;
    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]


    public async Task<IActionResult> GetTasksById(Guid takdId)
    {
        var tasks = _taskService.GetTaskByIdAsync(takdId);
        if (tasks == null)
        {
            return NotFound("Task not found!");
        }

        return Ok(tasks);
    }

    [HttpPost]
    public async Task<IActionResult> AddTask(AddTaskDTO task)
    {
        var addedTask = await _taskService.AddTaskAsync(task);
        if (addedTask == null)
        {
            return NotFound("Task cannot be null!");
        }
        return Ok(addedTask);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTask(TodoTask task)
    {
        var updatedTask = await _taskService.UpdateTaskAsync(task);
        if (updatedTask == null)
        {
            return NotFound("Task cannot be null!");
        }
        return Ok(updatedTask);
    }

    [HttpDelete("{taskId}")]
    public async Task<IActionResult> DeleteTask(Guid taskId)
    {
        var deletedTask = await _taskService.DeleteTaskAsync(taskId);
        if (deletedTask == null)
        {
            return NotFound("Task not found!");
        }
        return Ok(deletedTask);
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetTasksByUserId(Guid userId)
    {
        var tasks = await _taskService.GetTasksByUserIdAsync(userId);
        if (tasks == null)
        {
            return NotFound("Tasks not found!");
        }
        return Ok(tasks);
    }
}
