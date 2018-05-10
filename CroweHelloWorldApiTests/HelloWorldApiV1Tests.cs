using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using CroweHelloWorldAPI;

namespace CroweHelloWorldApiTests
{
    /// <summary>
    /// HelloWorldApi Unit Tests
    /// </summary>
    [TestClass]
    public class HelloWorldApiTests
    {

        public HelloWorldApiTests()
        {
           
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
            
            /// <summary>
            /// Test that GetMessage() returns the correct string value
            /// </summary>
            /// <returns></returns>
        [TestMethod]
        public async Task V1_GetMessage_Returns_CorrectValue()
        {
            //arrange
            IHelloWorldAPI api = new HelloWorldAPIv1();

            //act
            string actual = await api.GetMessageAsync();

            //assert
            Assert.AreEqual("Hello World", actual);
        }
    }
}
