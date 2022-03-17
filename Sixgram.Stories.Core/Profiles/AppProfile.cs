﻿using AutoMapper;
using Sixgram.Stories.Common.Result;
using Sixgram.Stories.Core.Dto.Story;
using Sixgram.Stories.Database.Models;

namespace Sixgram.Stories.Core.Profiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<StoryModel, ResultContainer<DeleteStoryRequestDto>>()
                .ForMember("Data", opt
                    => opt.MapFrom(p => p));
            CreateMap<StoryModel, DeleteStoryRequestDto>();

        }
    }
}