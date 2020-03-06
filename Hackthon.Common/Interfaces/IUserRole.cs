using Hackthon.Common.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackthon.Common.Interfaces
{
    public interface IUserRole
    {
        Guid AddTask(TaskTO Tasks);
        List<TaskTO> ListTask(Guid userId);
        bool MarkTaskComplete(Guid taskId);
        bool DeleteTask(Guid taskId);
        TaskTO GetTask(Guid taskId);
    }
}
