using Sixgram.Stories.Database.Models;
using Sixgram.Stories.Database.Repository.Base;

namespace Sixgram.Stories.Database.Repository.Story
{
    public class StoryRepository : BaseRepository<StoryModel>, IStoryRepository
    {
        public StoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}