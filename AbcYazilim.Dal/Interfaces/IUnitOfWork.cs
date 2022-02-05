using System;

namespace AbcYazilim.Dal.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable
       where T : class
    {
        IRepository<T> GetRepository { get; }
        bool Save();
    }
}
