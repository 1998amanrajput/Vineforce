using System.Threading.Tasks;
using Vineforce.CandidateTest.Models.TokenAuth;
using Vineforce.CandidateTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace Vineforce.CandidateTest.Web.Tests.Controllers
{
    public class HomeController_Tests: CandidateTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}