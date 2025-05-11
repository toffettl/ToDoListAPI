using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories;
public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<User> AddAsync(User user)
    {
        await _context.Set<User>().AddAsync(user);
        return user;
    }

    public async Task<User> DeleteAsync(Guid id)
    {
        var user = await _context.Set<User>().FindAsync(id);
        if (user == null)
        {
            return null;
        }

        _context.Set<User>().Remove(user);

        return user;
    }

    public async Task<User> GetByIdAsync(Guid id)
    {
        var user = await _context.Set<User>().FindAsync(id);

        return user;
    }

    public async Task<User> UpdateAsync(User user)
    {
        _context.Set<User>().Update(user);

        return user;
    }
}

