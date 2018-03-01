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
            await _client.GetAsync("/products");
        }

        private void Initialize()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
    }
}
