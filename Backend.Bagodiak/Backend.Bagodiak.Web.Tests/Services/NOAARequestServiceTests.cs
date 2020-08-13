using Backend.Bagodiak.Services;
using System;
using Xunit;

namespace Backend.Bagodiak.Web.Tests.Services
{
    public class NOAARequestServiceTests
    {
        [Fact]
        public static void ThrowsOnNullCtorArgs()
        {
            Assert.Throws<ArgumentNullException>(() => new NOAARequestService(null));
        }
    }
}
