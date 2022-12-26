using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface IRoleService
    {
        Task<bool> CreateRole(string id);
        Task<bool> DeleteRole(string name);
        Task<bool> UpdateRole(string id ,string name);
        (object,int) GetAllRoles(int page, int size);
        Task<(string id, string name)> GetRoleById(string id);
    }
}
