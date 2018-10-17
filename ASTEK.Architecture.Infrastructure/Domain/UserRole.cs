using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Infrastructure.Domain
{
    public static class UserRoleUtilities
    {
        public static string RoleToString(UserRole role)
        {
            switch (role)
            {
                case UserRole.Admin:
                    return "ADMIN";
                case UserRole.Student:
                    return "STUDENT";
                case UserRole.Teacher:
                    return "TEACHER";
                default:
                    return role.ToString().ToUpper();
            }
        }
    }

    public enum UserRole
    {
        Admin,
        Student,
        Teacher
    }
}
