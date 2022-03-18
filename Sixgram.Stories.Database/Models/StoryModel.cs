using System;
using Sixgram.Stories.Common.Base;

namespace Sixgram.Stories.Database.Models
{
    public class StoryModel : BaseModel
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public Guid FileId { get; set; }
    }
}