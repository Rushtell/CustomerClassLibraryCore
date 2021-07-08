using CustomerClassLibraryWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CustomerClassLibraryWebApp.Tests
{
    public class NoteControllerTests
    {
        [Fact]
        public void ShouldBeCreateNoteController()
        {
            NoteController controller = new NoteController();

            Assert.NotNull(controller);
        }
    }
}
