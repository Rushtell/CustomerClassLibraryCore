using CustomerClassLibraryWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerClassLibraryWebApp.Tests
{
    public class AddressControllerTests
    {
        [Fact]
        public void ShouldBeCreateAddressController()
        {
            AddressController controller = new AddressController();

            Assert.NotNull(controller);
        }
    }
}
