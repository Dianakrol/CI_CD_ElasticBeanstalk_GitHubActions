using Xunit;
using Microsoft.AspNetCore.Mvc;
using HelloCloudApi.Controllers;

public class HelloTests
{
    [Fact]
    public void TestHelloEndpoint()
    {
        var controller = new HelloController();
        var result = controller.Get() as OkObjectResult;
        Assert.NotNull(result);
        var value = result.Value as dynamic;
        Assert.Equal("Hello from the Cloud!", value.message);
    }
}