using System;
using System.Threading.Tasks;
using AutoMapper;
using Sixgram.Stories.Common.Error;
using Sixgram.Stories.Common.Result;
using Sixgram.Stories.Core.Dto.Story;
using Sixgram.Stories.Core.Story;
using Sixgram.Stories.Database.Repository.Story;

namespace Sixgram.Stories.Core.Services
{
    public class StoryService : IStoryService
    {
        private readonly IStoryRepository _storyRepository;
        private readonly IMapper _mapper;

        public StoryService
        (
            IStoryRepository storyRepository,
            IMapper mapper
        )
        {
            _storyRepository = storyRepository;
            _mapper = mapper;
        }

        public async Task<ResultContainer<DeleteStoryResponseDto>> Delete(Guid storyId)
        {
            var result = new ResultContainer<DeleteStoryResponseDto>();

            var story = await _storyRepository.GetById(storyId);

            if (story == null)
            {
                result.ErrorType = ErrorType.NotFound;
                return result;
            }

            result = _mapper.Map<ResultContainer<DeleteStoryResponseDto>>(await _storyRepository.Delete(story));

            return result;
        }
    }
}