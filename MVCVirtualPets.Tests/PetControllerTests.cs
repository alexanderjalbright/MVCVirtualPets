using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Controllers;
using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MVCVirtualPets.Tests
{
    public class PetControllerTests
    {
        [Fact]
        public void Index_Returns_View()
        {
            var underTest = new PetController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Index_Model_Has_Shelter()
        {
            var underTest = new PetController();

            var result = underTest.Index();

            Shelter model = (Shelter)result.Model;

            Assert.IsType<Shelter>(model);

        }
    }
}
