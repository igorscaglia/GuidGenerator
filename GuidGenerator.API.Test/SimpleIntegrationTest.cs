using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace GuidGenerator.API.Test
{
    public class SimpleIntegrationTest
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public SimpleIntegrationTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/guidgenerator/generate")]
        [InlineData("/guidgenerator/generate/1")]
        [InlineData("/guidgenerator/generate/0")]
        [InlineData("/guidgenerator/generate/24")]
        public async void GetGenerate_ReturnsSuccessAndValue(string url)
        {
            // 1A
            var client = _factory.CreateClient();

            // 2A
            var response = await client.GetAsync(url);

            // 3A
            response.EnsureSuccessStatusCode(); // Status Code 200-299

            var raw = await response.Content.ReadAsStringAsync();
            var guids = JsonConvert.DeserializeObject<List<Guid>>(raw);

            Assert.True(guids.Count > 0);
        }
    }
}