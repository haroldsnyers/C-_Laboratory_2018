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

            // TODO: Add your test code here
            // Assert.AreEqual(true, Dyck.IsDyckString("((()))"));
            // Assert.AreEqual(true, Dyck.IsDyckString("[(())]"));
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
