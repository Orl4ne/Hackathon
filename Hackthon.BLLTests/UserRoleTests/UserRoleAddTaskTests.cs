using Hackthon.BLL.UseCases;
using Hackthon.Common.TransferObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hackthon.BLLTests.UserRoleTests
{
    [TestClass]
    public class UserRoleAddTaskTests
    {

        [TestMethod]
        public void AddTask_ReturnTaskId_WhenValidTaskIsProvided()
        {
            //ARRANGE
            var task = new TaskTO
            {
                Name = $"Test Add Task"
            };
            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());
            var result = user.AddTask(task);

            //ASSERT
            Assert.AreNotEqual(Guid.Empty, result);
        }

        [TestMethod]
        public void AddTask_ThrowException_WhenTaskIsCompleted()
        {
            //ARRANGE
            var task = new TaskTO
            {
                Name = $"Test Add Task",
                IsCompleted = true
            };
            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());

            //ASSERT
            var exMessage = Assert.ThrowsException<Exception>(() => user.AddTask(task));
            Assert.AreEqual("Task should not be created as completed", exMessage.Message);
        }

        [TestMethod]
        public void AddTask_ThrowException_WhenTaskIsArchived()
        {
            //ARRANGE
            var task = new TaskTO
            {
                Name = $"Test Add Task",
                IsArchived = true
            };
            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());

            //ASSERT
            var exMessage = Assert.ThrowsException<Exception>(() => user.AddTask(task));
            Assert.AreEqual("Task should not be created as archived", exMessage.Message);
        }

        [TestMethod]
        public void AddTask_ThrowException_WhenTaskIsNull()
        {
            //ARRANGE
            TaskTO task = null;

            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());

            //ASSERT
            var exMessage = Assert.ThrowsException<ArgumentNullException>(() => user.AddTask(task));
        }

        [TestMethod]
        public void AddTask_ThrowException_WhenTaskNameIsEmpty()
        {
            //ARRANGE
            var task = new TaskTO
            {
                Name = string.Empty
            };

            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());

            //ASSERT
            var exMessage = Assert.ThrowsException<Exception>(() => user.AddTask(task));
            Assert.AreEqual("Task should not be created when no name is provided", exMessage.Message);
        }

        [TestMethod]
        public void AddTask_ThrowException_WhenTaskIdIsNotEmpty()
        {
            //ARRANGE
            var task = new TaskTO
            {
                Id = Guid.NewGuid(),
                Name = $"Test Add Task"
            };

            //ACT
            var user = new UserRole(TestHelper.GetMockRepository());

            //ASSERT
            var exMessage = Assert.ThrowsException<Exception>(() => user.AddTask(task));
            Assert.AreEqual("Task should not be created from a existing task", exMessage.Message);
        }
    }
}
