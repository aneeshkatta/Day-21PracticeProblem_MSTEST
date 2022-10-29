using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Day21_MSMODEANALYSER_ASGMNT1;
namespace T.C_uc2_No._01
{
    [TestClass]
    public class UnitTest1
    {
        public MoodAnalyser obj;
        [TestMethod]
        public void TestMethod1()
        {
                     
                obj = new MoodAnalyser();
                string expected = "Happy";

            string message = "my mood is null";

                string mood = obj.analyseMood(message);
                Assert.AreEqual(expected, mood);


            }

        }
    }
