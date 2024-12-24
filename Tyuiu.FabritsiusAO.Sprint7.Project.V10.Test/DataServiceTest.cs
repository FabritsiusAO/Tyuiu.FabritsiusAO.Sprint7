using Tyuiu.FabritsiusAO.Sprint7.Project.V10.Lib;

namespace Tyuiu.FabritsiusAO.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = "testdata.csv";
            string[] lines = new string[]
            {
            "1;2;3",
            "4;5;6",
            "7;8;9"
            };
            File.WriteAllLines(path, lines);
            var Res = ds.GetMatrix(path);

            Assert.AreEqual("1", Res[0, 0]);
            Assert.AreEqual("2", Res[0, 1]);
            Assert.AreEqual("3", Res[0, 2]);
            Assert.AreEqual("4", Res[1, 0]);
            Assert.AreEqual("5", Res[1, 1]);
            Assert.AreEqual("6", Res[1, 2]);
            Assert.AreEqual("7", Res[2, 0]);
            Assert.AreEqual("8", Res[2, 1]);
            Assert.AreEqual("9", Res[2, 2]);

            File.Delete(path);
        }
    }
}