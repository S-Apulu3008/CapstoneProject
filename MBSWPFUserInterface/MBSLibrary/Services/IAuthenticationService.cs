using MBSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSLibrary.Services
{
    public interface IAuthenticationService
    {
        bool Register(string employeeId, string firstName, string lastName, string password, string confirmPassword, string isManager);
        Employee Login(string employeeId, string password);
    }
}
