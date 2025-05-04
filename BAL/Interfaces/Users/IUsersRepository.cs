using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Users;

namespace BAL.Interfaces.Users
{
    public interface IUsersRepository
    {
        int InsertEmployee(EmployeeDTO emp);
        List<EmployeeDTO> GetAllEmployees();
    }
}
