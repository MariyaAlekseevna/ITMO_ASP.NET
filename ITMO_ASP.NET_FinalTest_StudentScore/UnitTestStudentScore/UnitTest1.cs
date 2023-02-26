using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web;
using System.Web.Mvc;
using StudentScore;
using StudentScore.Models;
using StudentScore.Controllers;




namespace UnitTestStudentScore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActionExecutes_ReturnView()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void IndexStringInViewData()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.AreEqual("Добрый день", result.ViewData["Greeting"]);
        }
    }
}
