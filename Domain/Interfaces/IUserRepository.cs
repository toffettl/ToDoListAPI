using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;
public interface IUserRepository
{
    public Task<User> AddAsync(User user);
    public Task<User> UpdateAsync(User user);
    public Task<User> DeleteAsync(Guid id);
    public Task<User> GetByIdAsync(Guid id);
}