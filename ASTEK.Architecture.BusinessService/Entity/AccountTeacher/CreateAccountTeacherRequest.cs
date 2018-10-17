using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.AccountTeacher
{
    public class CreateAccountTeacherRequest: Request
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid Gender { get; set; }
        public Guid Contry { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
