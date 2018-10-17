using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AccountStudent
{
    public class UpdateAccountStudentRequest: Request
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid Gender { get; set; }
        public Guid Country { get; set; }
        public string Phone { get; set; }
    }
}
