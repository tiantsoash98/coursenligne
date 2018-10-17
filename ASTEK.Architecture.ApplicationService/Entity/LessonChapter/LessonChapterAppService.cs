using ASTEK.Architecture.BusinessService.Entity.LessonChapter;
using ASTEK.Architecture.BusinessService.Interface;
using ASTEK.Architecture.Infrastructure.Utility;
using System;

namespace ASTEK.Architecture.ApplicationService.Entity.LessonChapter
{
    public class LessonChapterAppService
    {
        private readonly ILessonChapterBusinessService _service;

        public LessonChapterAppService()
        {
            _service = new LessonChapterBusinessService();
        }

        public CreateLessonChapterOutputModel Create(CreateLessonChapterInputModel input)
        {
            var request = new CreateLessonChapterRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                Title = input.Title,
                Description = input.Description,
                Content = input.Content,
                Duration = new TimeSpan(input.Hours, input.Minutes, 0).Ticks
            };
 

            CreateLessonChapterResponse response = _service.Create(request);

            var output = new CreateLessonChapterOutputModel()
            {
                Response = response
            };

            return output;
        }

        public GetChapterByNumberOutputModel GetByNumber(GetChapterByNumberInputModel input)
        {
            var request = new GetChapterByNumberRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                Number = input.Number,
                LoadChildren = input.LoadChildren
            };

            return new GetChapterByNumberOutputModel()
            {
                Response = _service.GetByNumber(request)
            };
        }

        public GetChapterTitleOutputModel GetTitle(GetChapterTitleInputModel input)
        {
            var request = new GetChapterTitleRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ChapterNumber = input.ChapterNumber
            };

            return new GetChapterTitleOutputModel()
            {
                Response = _service.GetTitle(request)
            };
        }

        public CountChapterGroupByLessonOutputModel Count(CountChapterGroupByLessonInputModel input)
        {
            var request = new CountChapterGroupByLessonRequest()
            {
                LessonId = GuidUtilities.TryParse(input.LessonId)
            };

            return new CountChapterGroupByLessonOutputModel()
            {
                Response = _service.Count(request)
            };
        }

        public UpdateLessonChapterOutputModel Update(UpdateLessonChapterInputModel input)
        {
            var request = new UpdateChapterRequest
            {
                LessonId = GuidUtilities.TryParse(input.LessonId),
                ChapterNumber = input.ChapterNumber,
                Title = input.Title,
                Description = input.Description,
                Content = input.Content,
                Duration = new TimeSpan(input.Hours, input.Minutes, 0).Ticks             
            };

            UpdateChapterResponse response = _service.Update(request);

            return new UpdateLessonChapterOutputModel() { Response = response };
        }
    }
}
