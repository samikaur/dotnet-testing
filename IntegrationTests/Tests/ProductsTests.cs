using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IntegrationTests.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using Newtonsoft.Json;

namespace IntegrationTests.Tests
{
    public class ProductsTests
    {
        private TestServer _server;
        private HttpClient _client;

        [Fact]
        public async Task Get_ReturnsProducts()
        {
            Initialize();

            var response = await _client.GetAsync("/products");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<IEnumerable<Product>>(responseString);

            Assert.Equal(2, result.Count());
            Assert.Equal("testi", result.First().Name);
            Assert.Equal(10m, result.First().Price);
            Assert.Equal("toinen", result.Last().Name);
            Assert.Equal(4m, result.Last().Price);
        }

        private void Initialize()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
    }
}
