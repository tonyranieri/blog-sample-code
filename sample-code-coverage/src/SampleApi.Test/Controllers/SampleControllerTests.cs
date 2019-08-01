using Moq;
using SampleApi.Controllers;
using SampleApi.Services;
using Xunit;

namespace SampleApi.Test.Controllers
{
    public class SampleControllerTests
    {
        // this test file is just to get some code coverage

        [Fact]
        public void Get_Calls_FakeService()
        {
            var fakeServiceMock = new Mock<IFakeService>();
            fakeServiceMock.Setup(x => x.AThirdAction()).Returns(4);

            var controller = new SampleController(fakeServiceMock.Object);
            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}