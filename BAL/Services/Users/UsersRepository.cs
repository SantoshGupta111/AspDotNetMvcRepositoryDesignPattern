using BAL.Interfaces.Users;
using DTO.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Users;

namespace BAL.Services.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UserDb _userdb;

        // Constructor
        public UsersRepository()
        {
            _userdb =new UserDb();
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public int InsertEmployee(EmployeeDTO emp)
        {
            return _userdb.InsertEmployee(emp);
        }
    }
}
