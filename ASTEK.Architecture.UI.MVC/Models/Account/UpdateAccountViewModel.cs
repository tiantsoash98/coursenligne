using ASTEK.Architecture.ApplicationService.Entity.Country;
using ASTEK.Architecture.ApplicationService.Entity.Gender;

namespace ASTEK.Architecture.UI.MVC.Models.Account
{
    public class UpdateAccountViewModel: BaseViewModel
    {
        public GetAllCountryOutputModel CountryOutput { get; set; }
        public GetAllGenderOutputModel GenderOutput { get; set; }
        public string Status { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool HasPassword { get; set; }
    }
}