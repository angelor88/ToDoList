using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;


namespace ToDoList.Tests
{

    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Item.DeleteAll();
        }
        public ItemTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
        }

        [TestMethod]
        public void GetAll_DbStartsEmpty_0()
        {
          //Arrange
          //Act
          int result = Item.GetAll().Count;

          //Assert
          Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfDescriptionAreTheSame_Item()
        {
            //Arrage, Act
            Item firstItem = new Item("Angelo R", 0);
            Item sencondItem = new Item("Angelo R", 0);

            //Assert
            Assert.AreEqual(firstItem, sencondItem);
        }
    }
}
