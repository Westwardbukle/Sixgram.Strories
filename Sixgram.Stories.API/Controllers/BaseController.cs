using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sixgram.Stories.Common.Error;
using Sixgram.Stories.Common.Result;

namespace Sixgram.Stories.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected async Task<ActionResult> ReturnResult<T, TM>(Task<T> task) where T : ResultContainer<TM>
        {
            var result = await task;

            if (result.ErrorType.HasValue)
            {
                return result.ErrorType switch
                {
                    ErrorType.NotFound => NotFound(),
                    ErrorType.BadRequest => BadRequest(),
                    ErrorType.Unauthorized => Unauthorized(),
                    ErrorType.UnsupportedMediaType => StatusCode(415),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            if (result.Data == null)
                return NoContent();

            return Ok(result.Data);
        }
    }
}