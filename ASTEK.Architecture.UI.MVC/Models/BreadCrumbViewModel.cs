using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace ASTEK.Architecture.UI.MVC.Models
{
    public class BreadCrumbViewModel
    {
        public string Title { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
        public bool IsCurrent { get; set; }
    }
}