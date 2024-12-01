using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PizzaShopApi.Controllers;

namespace PizzaShopApi.Tests
{
    public class WeatherForecastControllerTest
    {
        private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;
        private readonly WeatherForecastController _forecastController;

        public WeatherForecastControllerTest()
        {
            _mockLogger = new Mock<ILogger<WeatherForecastController>>();
            _forecastController = new WeatherForecastController(_mockLogger.Object);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllWeatherConditions()
        {
            // Arrange

            // Act
            var result = _forecastController.Get();

            // Assert
            Assert.True(result.Count() > 1);
        }
    }
}