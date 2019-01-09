using SportApp.Data.Models;
using System;
using Xunit;

namespace SportApp.Tests
{
    public class StadiumTests
    {
        [Fact]
        public void CanChangeStadiumName()
        {
            // Arrange
            var p = new Stadium { Name = "Test", Capacity = 10000 };
            // Act
            p.Name = "New Name";
            //Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeStadiumCapacity()
        {
            // Arrange
            var p = new Stadium { Name = "Test", Capacity = 10000 };
            // Act
            p.Capacity = 20000;
            //Assert
            Assert.Equal(20000, p.Capacity);
        }

    }
}
