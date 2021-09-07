using System;
using System.IO;
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


        [Fact]
        public void TestLeapYear_user_input_is_leapyear()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader("4"));

            // Act
            Program.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Contains("yay", output);
        }
        
        [Fact]
        public void TestLeapYear_user_input_is_leapyear2()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader("800"));

            // Act
            Program.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Contains("yay", output);
        }

        [Fact]
        public void TestLeapYear_user_input_is_not_leapyear()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader("5"));

            // Act
            Program.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Contains("nay", output);
        }

        [Fact]
        public void TestLeapYear_user_input_is_not_leapyear2()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader("999"));

            // Act
            Program.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Contains("nay", output);
        }

    }
}
