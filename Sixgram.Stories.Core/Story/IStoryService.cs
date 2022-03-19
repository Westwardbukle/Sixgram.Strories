using System;
using System.Threading.Tasks;
using Sixgram.Stories.Common.Result;
using Sixgram.Stories.Core.Dto.Story;

namespace Sixgram.Stories.Core.Story
{
    public interface IStoryService
    {
        Task<ResultContainer<StoryModelDto>> GetById(Guid storyId);
        Task<ResultContainer<DeleteStoryResponseDto>> Delete(Guid storyId);
    }
}