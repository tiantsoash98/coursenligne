using System.Collections.Generic;

namespace ASTEK.Architecture.UI.MVC.Models
{
    public class CultureViewModel
    {
        public string CurrentCulture { get; set; }
        public List<Domain.Entity.Culture.Culture> Cultures { get; set; }
    }
}