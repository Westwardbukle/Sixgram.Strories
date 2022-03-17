using System;
using System.Threading.Tasks;
using Sixgram.Stories.Common.Base;

namespace Sixgram.Stories.Database.Repository.Base
{
    public interface IBaseRepository<TModel>
        where TModel : BaseModel
    {
        Task<TModel> Create(TModel data);
        Task<TModel> GetById(Guid id);
        TModel GetOne(Func<TModel, bool> predicate);
        Task<TModel> Delete(Guid id);
    }
}