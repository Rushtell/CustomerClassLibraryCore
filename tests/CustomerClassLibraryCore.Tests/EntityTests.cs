using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerClassLibraryCore.Tests
{
    public class EntityTests
    {
        [Fact]
        public void ShouldBeCreateCustomerAddressAndNote()
        {
            Address address = new Address()
            {
                AddressId = 2,
                AddressType = "Shipping",
                CustomerId = 2,
                AddressLine = "st. Pushkina",
                SecondAddressLine = "house Kolotushkina",
                AddressTypeEnum = AddressType.Shipping,
                City = "Vakandaa",
                PostalCode = "244343",
                State = "Texas",
                Country = "United States"
            };

            Note note = new Note()
            {
                CustomerId = 2,
                NoteId = 2,
                Text = "asdf"
            };

            Customer customer = new Customer()
            {
                CustomerId = 2,
                FirstName = "Vasd",
                LastName = "Masd",
                Address = new List<Address>() { address },
                Note = new List<Note>() { note },
                PhoneNumber = "+56785663",
                Email = "123@ewok.com",
                Money = 322
            };

            Assert.Equal("Vasd", customer.FirstName);
        }
    }
}
