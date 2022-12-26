using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface IAuthorizationEndpointService
    {
        Task AssignRoleEndpointAsync(string[] roles, string code, string menu, Type type);
        Task<List<string>> GetRolesToEndpointAsync(string code,string menu);
    }
}
