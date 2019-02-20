using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Controllers;
using System;
using Xunit;

namespace MVCVirtualPets.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
