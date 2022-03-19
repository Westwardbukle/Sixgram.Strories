using System;

namespace Sixgram.Stories.Core.Dto.Story
{
    public class StoryModelDto
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public Guid FileId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}