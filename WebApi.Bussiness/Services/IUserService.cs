using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;

namespace WebApi.Bussiness.Services
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
