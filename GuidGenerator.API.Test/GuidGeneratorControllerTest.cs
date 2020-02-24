using System;
using Xunit;
using GuidGenerator.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuidGenerator.API.Test
{
    public class GuidGeneratorControllerTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public async void GenerateGuid_ReturnsQtd(int total)
        {
            // 1A
            GuidGeneratorController controler = new GuidGeneratorController();

            // 2A
            var result = await controler.Generate(total);

            // 3A
            var okResult1 = Assert.IsType<OkObjectResult>(result);
            var newTeams = Assert.IsType<List<Guid>>(okResult1.Value);

            Assert.Equal(total, newTeams.Count);
        }
    }
}
