using System.Collections.Generic;

namespace SehirDefteri.API
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll();

    }
}
