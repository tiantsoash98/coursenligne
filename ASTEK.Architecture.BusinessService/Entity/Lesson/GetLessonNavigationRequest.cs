﻿using ASTEK.Architecture.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.BusinessService.Entity.Lesson
{
    public class GetLessonNavigationRequest: Request
    {
        public Guid LessonId { get; set; }
    }
}
