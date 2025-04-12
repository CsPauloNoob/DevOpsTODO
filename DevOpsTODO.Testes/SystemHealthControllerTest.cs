using DevOpsTODO.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTODO.Testes
{
    public class SystemHealthControllerTest
    {
        [Fact]
        public void Health_DeveRetornarStatusOk()
        {
            // Arrange
            var controller = new SystemHealthController();

            // Act
            var result = controller.Health();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void Ping_DeveRetornarPong()
        {
            // Arrange
            var controller = new SystemHealthController();

            // Act
            var result = controller.Ping();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("pong", okResult.Value);
        }
    }
}
