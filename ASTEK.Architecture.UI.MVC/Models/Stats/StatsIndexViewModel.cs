using ASTEK.Architecture.Domain.Entity.AnswerExercice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTEK.Architecture.UI.MVC.Models.Stats
{
    public class StatsIndexViewModel: BaseViewModel
    {
        public Domain.Entity.Account.Account Account { get; set; }
        public string StudyCode { get; set; }
        public int? Level { get; set; }
        public List<AnswerExercice> Marks { get; set; }
        public AnswerExercice Lowest { get; set; }
        public AnswerExercice Highest { get; set; }
        public decimal Average { get; set; }
        public decimal? PreviousAverage { get; set; }
    }
}