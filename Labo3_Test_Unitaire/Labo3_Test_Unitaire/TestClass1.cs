using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo3_Test_Unitaire
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void TestIsDyckString()
        {

            var alphabet = new Dictionary<string, string>
            {
                { "(", ")" },
                { "[", "]" },
                { "{", "}" }
            };
            alphabet.Add("<", ">");
            alphabet.Add("*", "/");

            // test to see if program is doing what we want him doing
            // Assert.AreEqual(expected response, method of class to be tested)
            Assert.AreEqual(true, IsDickStringMain.IsDyckString("[(())]", alphabet));
            Assert.AreEqual(false, IsDickStringMain.IsDyckString("[((/*))]", alphabet));
            Assert.AreEqual(true, IsDickStringMain.IsDyckString("[(({}{}))]", alphabet));
            Assert.AreEqual(false, IsDickStringMain.IsDyckString("[((}))]", alphabet));
            Assert.AreEqual(true, IsDickStringMain.IsDyckString("[((<>))]", alphabet));
            Assert.AreEqual(true, IsDickStringMain.IsDyckString("[((*/))]", alphabet));
            Assert.AreEqual(false, IsDickStringMain.IsDyckString(")", alphabet));
        }
    }
}
