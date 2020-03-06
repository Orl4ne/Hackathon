using Hackthon.Common.Interfaces;
using Hackthon.Common.TransferObjects;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackthon.BLLTests
{
    public static class MocksHelper
    {
        public static IRepository<TaskTO> GetMockRepository()
        {
            var mock = new Mock<IRepository<TaskTO>>();
            mock.Setup(x=>x.Add(It.IsAny<TaskTO>()))
                .Returns(Guid.NewGuid());
            return mock.Object;
        }
    }
}
