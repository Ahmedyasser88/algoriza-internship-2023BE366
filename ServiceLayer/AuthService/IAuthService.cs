using DomainLayer.DTO;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeseetaApi.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterDTO model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
