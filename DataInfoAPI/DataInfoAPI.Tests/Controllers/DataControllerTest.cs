using System.Web.Http;
using System.Web.Http.Results;
using DataInfoAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataInfoAPI.Tests.Controllers
{
    [TestClass]
    public class DataControllerTest
    {
        [TestMethod]
        public void GetReturn()
        {
            // Arrange
            DataController controller = new DataController();

            // Act 
            IHttpActionResult actionResult = controller.GetData();
            var contentResult = actionResult as OkNegotiatedContentResult<string>;
            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("Hello World", contentResult.Content);
        }
    }
}