using Backend.Bagodiak.Controllers;
using Backend.Bagodiak.Services;
using Moq;
using System;
using System.Net;
using Xunit;

namespace Backend.Bagodiak.Web.Tests.Controllers
{
    public class NOAAControllerTests
    {

        [Fact]
        public static void ThrowsOnNullCtorArgs()
        {
            Assert.Throws<ArgumentNullException>(() => new NOAAController(null));
        }

        [Fact]

        public static void GetReturnsConflict()
        {
            var result = new NOAAController(new Mock<IRequestService>().Object).Get();
            Assert.Equal(HttpStatusCode.Conflict, result.StatusCode);
        }

    }
}
