using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly TestServerFixture _fixture;
        public UnitTest1()
        {
            _fixture = new TestServerFixture();
        }

        [Fact]
        public async Task GetRoot()
        {
            var response = await _fixture.Client.GetAsync("/");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("Value 1", responseString);
        }
    }
}
