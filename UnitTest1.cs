using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Day21_MSMODEANALYSER_ASGMNT_uc1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public MoodAnalyser obj;
        [TestMethod]
        public void TestMethod()
        {
            obj = new MoodAnalyser();
            string expected = "Happy";

            string message = "my mood is Happy";
           
            string mood= obj.analyseMood(message);
            Assert.AreEqual(expected, mood);
           
           
        }

    }
   }
