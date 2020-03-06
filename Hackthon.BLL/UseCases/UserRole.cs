using Hackthon.Common.Interfaces;
using Hackthon.Common.TransferObjects;
using System;
using System.Collections.Generic;

namespace Hackthon.BLL.UseCases
{
    public class UserRole : IUserRole
    {
        private readonly IRepository<TaskTO> taskRepository;

        public UserRole(IRepository<TaskTO> taskRepository)
        {
            this.taskRepository = taskRepository ?? throw new ArgumentNullException(nameof(taskRepository));
        }

        public Guid AddTask(TaskTO task)
        {
            //Step 1: Test Entries
            if (task is null)
                throw new ArgumentNullException(nameof(task));

            if (task.Id != Guid.Empty)
                throw new Exception("Task should not be created from a existing task");
            if (task.IsArchived)
                throw new Exception("Task should not be created as archived");
            if (task.IsCompleted)
                throw new Exception("Task should not be created as completed");
            if (string.IsNullOrWhiteSpace(task.Name))
                throw new Exception("Task should not be created when no name is provided");
            //Step 2 Implement Use case
            //Step 3 return required values

            return taskRepository.Add(task);
        }

        public bool DeleteTask(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public TaskTO GetTask(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public List<TaskTO> ListTask(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool MarkTaskComplete(Guid taskId)
        {
            throw new NotImplementedException();
        }
    }
}