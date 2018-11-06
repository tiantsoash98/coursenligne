﻿using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.AnswerExercice
{
    public class GetMarksOfStudentRequest: Request
    {
        public Guid AccountId { get; set; }
        public Guid StudyCode { get; set; }
        public int Level { get; set; }
    }
}