using Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelperTest
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void ToCamelCase()
        {
            StringHelper sh = new StringHelper();
            Assert.AreEqual(sh.ToCamelCase("this is a test"), "This Is A Test");
        }

        [TestMethod]
        public void TruncateWord()
        {
            StringHelper sh = new StringHelper();
            Assert.AreEqual(sh.TruncateWord("this is a test", 1), "this...");
        }

        [TestMethod]
        public void StringToInt()
        {
            StringHelper sh = new StringHelper();
            Assert.AreEqual(sh.StringToInt("8"), 8);
        }

        [TestMethod]
        public void ReadFile()
        {
            FileHelper fh = new FileHelper();

            Assert.AreEqual(fh.ReadFileAsText(@"C:\Users\allisterck\Documents\test.txt"), "test");
        }
    }
}
