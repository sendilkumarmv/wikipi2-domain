using Microsoft.AspNetCore.Mvc;
using Wikipi.Domain.Controllers;

namespace Wikipi.Domain.Test
{
    [TestClass]
    public sealed class HealthCheckControllerTests
    {
        [TestMethod]
        public void VerifyHealthCheck_Get()
        {
            //Arrange
            var controller = new HealthCheckController();

            // Act
            var result  = controller.Get();

            // Assert
            Assert.IsNotNull(result);
           
        }
    }
}
