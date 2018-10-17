using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Dashboard
{
    public class DashboardViewModel: BaseViewModel
    {
        public int Page { get; set; }  
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}