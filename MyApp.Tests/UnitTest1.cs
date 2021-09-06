using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestLeapYear_is_divisble_by_four()
        {
            // Arrange
            var year = 4;

            // Act
            Program program = new Program();
            var test = program.IsLeapYear(year);

            // Assert
            Assert.True(test);
        }

        [Fact]
        public void TestLeapYear_is_not_divisble_by_four()
        {
            // Arrange
            var year = 5;

            // Act
            Program program = new Program();
            var test = program.IsLeapYear(year);

            // Assert
            Assert.False(test);
        }

        [Fact]
        public void TestLeapYear_is_not_divisible_by_hundred()
        {
            // Arrange
            var year = 100;

            // Act
            Program program = new Program();
            var test = program.IsLeapYear(year);

            // Assert
            Assert.False(test);
        }

        [Fact]
        public void TestLeapYear_is_divisible_by_four_hundred()
        {
            // Arrange
            var year = 400;

            // Act
            Program program = new Program();
            var test = program.IsLeapYear(year);

            // Assert
            Assert.True(test);
        }

        [Fact]
        public void TestLeapYear_is_divisible_by_eight_hundred_eighty_eight()
        {
            // Arrange
            var year = 888;

            // Act
            Program program = new Program();
            var test = program.IsLeapYear(year);

            // Assert
            Assert.True(test);
        }
    }
}
