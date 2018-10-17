using ASTEK.Architecture.Infrastructure.DTO;
using System;

namespace ASTEK.Architecture.BusinessService.Entity.AccountTeacher
{
    public class UpdateAccountTeacherRequest: Request
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid Gender { get; set; }
        public Guid Country { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
    }
}
