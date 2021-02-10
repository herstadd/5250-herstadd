using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Mine.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class ItemModelTests
    {
        [Test]
        public void ItemModel_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            //Act
            var result = new ItemModel();
            result.Description = "Description";
            result.Id = "ID";
            result.Text = "Text";
            result.Value = 1;

            //Reset

            //Assert
            Assert.AreEqual(result.Description, "Description");
            Assert.AreEqual(result.Id, "ID");
            Assert.AreEqual(result.Text, "Text");
            Assert.AreEqual(result.Value, 1);
        }

        //Template:

        // Arrange

        // Act

        // Reset

        // Assert

        [Test]
        public void ItemModel_Get_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ItemModel();

            // Reset

            // Assert
            Assert.AreEqual(0, result.Value);
        }

    }
}
