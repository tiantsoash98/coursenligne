using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AccountStudent
{
    public class CreateAccountStudentRequest: Request
    {   
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid Gender { get; set; }
        public Guid Contry { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsExternalLogin { get; set; }
    }
}
