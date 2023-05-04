using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CQRS.ScalableApp.Pages;

public class Index_Tests : ScalableAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
