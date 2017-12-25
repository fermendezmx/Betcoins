using System;
using System.Collections.Generic;

namespace Betcoins.Repositories.Base
{
    public interface IRepository<T, TId> : IDisposable where T : class
    {
        T GetById(TId id);
        List<T> GetAll();
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
        void Save();
    }
}
