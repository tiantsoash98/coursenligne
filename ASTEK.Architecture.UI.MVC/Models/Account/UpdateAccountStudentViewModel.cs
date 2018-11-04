
using ASTEK.Architecture.ApplicationService.Entity.AccountStudent;
using System.Web.Mvc;

namespace ASTEK.Architecture.UI.MVC.Models.Account
{
    public class UpdateAccountStudentViewModel: UpdateAccountViewModel
    {
        public UpdateAccountStudentInputModel Input { get; set; }
        public SelectList LevelList { get; set; }
    }
}