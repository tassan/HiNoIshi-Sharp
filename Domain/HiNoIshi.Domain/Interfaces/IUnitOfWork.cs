using System;
using System.Threading.Tasks;

namespace HiNoIshi.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}