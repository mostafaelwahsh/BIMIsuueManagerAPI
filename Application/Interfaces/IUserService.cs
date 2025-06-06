﻿namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllAsync();
        Task<UserDto> GetByIdAsync(string id);
        Task<UserDto> RegisterAsync(RegisterUserDto dto);     
        Task<bool> UpdateAsync(string id, UpdateUserDto dto); 
        Task<bool> DeleteAsync(string id);
        Task<IEnumerable<UserOverviewDto>> GetUserOverviewAsync();
        Task<int> GetCompanyIdAsync(string userId);
        Task<LoginResponseDto> LoginAsync(LoginRequestDto dto);
        Task<UserDto> CreateUserWithProjectsAsync(string adminUserId, CreateUserWithProjectsDto dto);

    }
}
