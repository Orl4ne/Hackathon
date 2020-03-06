using System;

namespace Hackthon.Common.TransferObjects
{
    public class TaskTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsArchived { get; set; }
    }
}