using System;
using System.Threading.Tasks;

namespace HiNoIshi.Infra.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}