﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sixgram.Stories.Common.Result;
using Sixgram.Stories.Core.Dto.Story;
using Sixgram.Stories.Core.Story;

namespace Sixgram.Stories.API.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class StoryController : BaseController
    {
        private readonly IStoryService _storyService;

        public StoryController
        (
            IStoryService storyService
        )
        {
            _storyService = storyService;
        }

        /// <summary>
        /// Deletes story by id
        /// </summary>
        /// <param name="id"></param>
        /// <response code="200">Returns file id</response>
        /// <response code="404">File not found</response>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DeleteStoryResponseDto>> Delete(Guid id)
            => await ReturnResult<ResultContainer<DeleteStoryResponseDto>, DeleteStoryResponseDto>(
                _storyService.Delete(id));
    }
}