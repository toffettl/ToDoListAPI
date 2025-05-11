using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces;
public interface IUserService
{
    Task<UserDTO> UpdateUserAsync(UserDTO user);
    Task<UserDTO> DeleteUserAsync(Guid id);
    Task<UserDTO> GetUserByIdAsync(Guid id);
}
