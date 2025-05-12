using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces;
public interface IAuthService
{
    Task<AuthResponseDTO> RegisterAsync(LoginRegisterDTO dto);
    Task<AuthResponseDTO> LoginAsync(LoginRegisterDTO dto);
    Task<AuthResponseDTO> RefreshTokenAsync(string refreshToken);
    Task RevokeRefreshTokenAsync(Guid userId);
}
