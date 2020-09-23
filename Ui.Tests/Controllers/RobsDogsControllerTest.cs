using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ui.Controllers;
using Ui.Data;
using Ui.Entities;
using Ui.Models;
using Ui.Services;

namespace Ui.Tests.Controllers
{
	[TestClass]
	public class RobsDogsControllerTest
	{
		[TestMethod]
		public void When_Index_Called_GetAllDogOwners_ShouldBeCalledOnce()
		{

			// Arrange
			Mock<DogOwnerService> dogOwnerService = new Mock<DogOwnerService>();
			dogOwnerService.Setup(a => a.GetAllDogOwners()).Returns(new List<DogOwner>()) ;
			RobsDogsController controller = new RobsDogsController(dogOwnerService.Object);

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			dogOwnerService.Verify(a => a.GetAllDogOwners(), Times.Once);

		}

	}
}