using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {

        [Theory]
        // Arrange
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(100, false)]
        [InlineData(400, true)]
        [InlineData(888, true)]
        public void Test_LeapYear(int year, bool expected){
            // Act and Assert
            Program program = new Program();
            Assert.Equal(expected, program.IsLeapYear(year));
        }


        [Theory]
        // Arrange
        [InlineData("4", "yay")]
        [InlineData("5", "nay")]
        [InlineData("800", "yay")]
        [InlineData("999", "nay")]
        public void Test_LeapYear_UserInput(string inputYear, string expected){
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader(inputYear));

            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Contains(expected, output);
        }

    }
}
