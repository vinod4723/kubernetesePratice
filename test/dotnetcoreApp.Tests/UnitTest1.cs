using System;
using Xunit;
using dotnetcoreApp.Controllers;

namespace dotnetcoreApp.Tests
{
    public class UnitTest1
    {
    WeatherForecastController wfObj=new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            var testRes=wfObj.Get(101);
            Assert.Equal("Vinod Singh",testRes);

            //A3=> Assign, Assert, Act
        }
    }
}
