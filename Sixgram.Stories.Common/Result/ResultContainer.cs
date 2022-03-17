using Sixgram.Stories.Common.Error;

namespace Sixgram.Stories.Common.Result
{
    public class ResultContainer<T>
    {
        public T Data { get; set; }
        public ErrorType? ErrorType { get; set; }
    }
}