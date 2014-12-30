using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.BizTalk.TestTools.Mapper;
using Microsoft.BizTalk.TestTools.Schema;
using System.IO;

namespace FFMapTest_UnitTests
{
    [TestClass]
    public class TestFFMap
    {
        #region Private Fields

        private string inputFile;
        private string outputFile = "FFOutput.txt";

        #endregion

        #region Initialisation

        [TestInitialize]
        public void TestSetup()
        {
            inputFile = string.Empty;
        }

        #endregion

        
        [DeploymentItem(@"SampleCustomerFF.txt")]
        [DeploymentItem(@"SourceCustomer.xml")]
        [DeploymentItem(@"Microsoft.BizTalk.TOM.dll")]
        [TestMethod]
        public void MapOutputAsExpected()
        {
            GivenATestDataInputFile("SourceCustomer.xml");
            GivenAMapCalled(new FFMapTest.SourceCustomer_2_TargetCustomerFF());
            ThenResultAsExpected();
        }

        #region Private Helper Methods

        private void GivenATestDataInputFile(string TestData)
        {
            inputFile = TestData;
        }

        private void GivenAMapCalled(TestableMapBase target)
        {
            InputInstanceType inputType = InputInstanceType.Xml;
            OutputInstanceType outputType = OutputInstanceType.Native;

            target.TestMap(inputFile, inputType, outputFile, outputType);
            Assert.IsTrue(File.Exists(outputFile), "Failed to generate output file..");
        }

        private void ThenResultAsExpected()
        {
            File.Exists(outputFile);
        }

        #endregion
    }
}
