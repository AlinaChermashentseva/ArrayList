using ClassLibraryArr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectArr
{
    [TestClass]
    public class UnitTestArr
    {
        private static readonly int[] actual = new int[3] { 1, 2, 3 };
        readonly ArrayList<int> actualList = new ArrayList<int>(actual);

        bool Result(int[] expected)
        {
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            bool result = true;
            for (int i = 0; i < expected.Length; i++)
            {
                if (actualList.ValueOf(i) == expectedList.ValueOf(i))
                    result = true;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        
        [TestMethod]
        public void Add_123_1234()
        {
            int[] expected = new int[4] { 1, 2, 3, 4 };
            actualList.Add(4);
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void Remove_123_13()
        {
            int[] expected = new int[2] { 1, 3 };
            actualList.Remove(2);
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void RemoveAt_123_13()
        {
            int[] expected = new int[2] { 1, 3 };
            actualList.RemoveAt(1);
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void Clear_123_000()
        {
            int[] expected = new int[0] {};
            actualList.Clear();
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void Insert_123_1223()
        {
            int[] expected = new int[4] { 1, 2, 2, 3 };
            actualList.Insert(2,1);
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void Contains_123_1()
        {          
            actualList.Contains(1);
            Assert.IsTrue(actualList.Contains(1));
        }

        [TestMethod]
        public void IndexOf_123_2()
        {          
            Assert.AreEqual(1, actualList.IndexOf(2));
        }

        [TestMethod]
        public void SubList_123_12()
        {
            int[] expected = new int[2] { 1, 2 };
            actualList.SubList(0, 1);
            Assert.IsTrue(Result(expected));
        }

        [TestMethod]
        public void ValueOf_123_1()
        {
            Assert.AreEqual(1, actualList.ValueOf(0));
        }
    }
}
