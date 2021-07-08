using CustomerClassLibraryWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerClassLibraryWebApp.Tests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void ShouldBeCreateCustomerController()
        {
            CustomerController controller = new CustomerController();

            Assert.NotNull(controller);
        }
    }
}
