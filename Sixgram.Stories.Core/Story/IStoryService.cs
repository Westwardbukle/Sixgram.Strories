using System;
using System.Threading.Tasks;
using Sixgram.Stories.Common.Result;
using Sixgram.Stories.Core.Dto.Story;

namespace Sixgram.Stories.Core.Story
{
    public interface IStoryService
    {
        Task<ResultContainer<DeleteStoryRequestDto>> Delete(Guid storyId);
    }
}