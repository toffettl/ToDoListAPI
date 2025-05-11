using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;

namespace Application.Services;
public class UserService : IUserService
{
    public readonly IUserRepository _userRepository;
    public readonly IUnitOfWork _unitOfWork;

    public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<UserDTO> DeleteUserAsync(Guid id)
    {
        var deletedUser = await _userRepository.DeleteAsync(id);
        if (deletedUser == null)
        {
            return null;
        }

        await _unitOfWork.SaveChangesAsync();
        return new UserDTO
        {
            UserId = deletedUser.UserId,
            Email = deletedUser.Email
        };
    }

    public async Task<UserDTO> GetUserByIdAsync(Guid id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        if (user == null)
        {
            return null;
        }

        return new UserDTO
        {
            UserId = user.UserId,
            Email = user.Email
        };
    }

    public async Task<UserDTO> UpdateUserAsync(UserDTO userDto)
    {
        var user = await _userRepository.GetByIdAsync(userDto.UserId);
        if (user == null)
        {
            return null;
        }

        user.Email = userDto.Email;

        var updatedUser = await _userRepository.UpdateAsync(user);

        await _unitOfWork.SaveChangesAsync();

        return new UserDTO
        {
            UserId = updatedUser.UserId,
            Email = updatedUser.Email
        };
    }
}
