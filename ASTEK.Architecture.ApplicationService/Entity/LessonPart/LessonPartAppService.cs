using ASTEK.Architecture.BusinessService.Entity.LessonPart;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonPart
{
    public class LessonPartAppService
    {
        private readonly ILessonPartBusinessService _service;

        public LessonPartAppService()
        {
            _service = new LessonPartBusinessService();
        }

        public CreateLessonPartOutputModel Create(CreateLessonPartInputModel input)
        {
            var request = AssignAvailablePropertiesToRequest(input);

            CreateLessonPartResponse response = _service.Create(request);

            var output = new CreateLessonPartOutputModel()
            {
                Response = response
            };

            return output;
        }

        public CreateAllLessonPartOutputModel CreateAll(CreateAllLessonPartInputModel input)
        {
            List<CreateLessonPartRequest> partsRequest = new List<CreateLessonPartRequest>();

            foreach(var partInput in input.PartsInput)
            {
                partsRequest.Add(AssignAvailablePropertiesToRequest(partInput));
            }

            var request = new CreateAllLessonPartRequest()
            {
                ChapterCode = GuidUtilities.TryParse(input.ChapterCode),
                Parts = partsRequest
            };

            CreateAllLessonPartResponse response = _service.CreateAll(request);

            var output = new CreateAllLessonPartOutputModel()
            {
                Response = response
            };

            return output;
        }

        public GetPartByNumberOutputModel GetByNumber(GetPartByNumberInputModel input)
        {
            var request = new GetPartByNumberRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ChapterNumber = input.ChapterNumber,
                Number = input.Number
            };

            return new GetPartByNumberOutputModel()
            {
                Response = _service.GetByNumber(request)
            };
        }

        public CountPartGroupByChapterOutputModel Count(CountPartGroupByChapterInputModel input)
        {
            var request = new CountPartGroupByChapterRequest()
            {
                ChapterCode = GuidUtilities.TryParse(input.ChapterCode)
            };

            return new CountPartGroupByChapterOutputModel()
            {
                Response = _service.Count(request)
            };
        }

        public UpdateAllLessonPartOutputModel UpdateAll(UpdateAllLessonPartInputModel input)
        {
            List<Domain.Entity.LessonPart.LessonPart> parts = new List<Domain.Entity.LessonPart.LessonPart>();
            var chapterCode = GuidUtilities.TryParse(input.ChapterCode);

            foreach (var partInput in input.PartsInput)
            {
                parts.Add(new Domain.Entity.LessonPart.LessonPart
                {
                    LSCCODE = chapterCode,
                    LSPTITLE = partInput.Title,
                    LSPCONTENT = partInput.Content
                });
            }

            var request = new UpdateAllPartsRequest()
            {
                ChapterCode = GuidUtilities.TryParse(input.ChapterCode),
                Parts = parts
            };

            UpdateAllPartsResponse response = _service.Update(request);

            return new UpdateAllLessonPartOutputModel
            {
                Response = response
            };
        }

        private CreateLessonPartRequest AssignAvailablePropertiesToRequest(CreateLessonPartInputModel input)
        {
            var request = new CreateLessonPartRequest()
            {
                ChapterCode = input.ChapterCode,
                Content = input.Content,
                Title = input.Title
            };

            return request;
        }
    }
}
