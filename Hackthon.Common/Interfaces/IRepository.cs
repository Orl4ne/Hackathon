using Hackthon.Common.TransferObjects;
using System;

namespace Hackthon.Common.Interfaces
{
    public interface IRepository<T>
    {
        Guid Add(TaskTO task);
    }
}