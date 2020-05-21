using System;
using ClassLibraryArr;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectArr
{
    [TestClass]
    public class UnitTestArr
    {       
        [TestMethod]
        public void Add_123_1234()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[4] { 1, 2, 3, 4 };
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.Add(4);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Remove_123_13()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[2] { 1, 3 };
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.Remove(2);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void RemoveAt_123_13()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[2] { 1, 3 };
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.RemoveAt(1);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Clear_123_000()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[0] {};
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.Clear();
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Insert_123_1223()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[4] { 1, 2, 2, 3 };
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.Insert(2,1);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Contains_123_1()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            actualList.Contains(1);
            Assert.IsTrue(actualList.Contains(1));
        }

        [TestMethod]
        public void IndexOf_123_2()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            Assert.AreEqual(1, actualList.IndexOf(2));
        }

        [TestMethod]
        public void SubList_123_12()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            int[] expected = new int[2] { 1, 2 };
            ArrayList<int> expectedList = new ArrayList<int>(expected);
            actualList.SubList(0, 1);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void ValueOf_123_1()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            Assert.AreEqual(1, actualList[0]);
        }

        [TestMethod]
        public void Length_123_3()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            Assert.AreEqual(3, actualList.Length());
        }

        [TestMethod]
        public void ShowList_123()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            Console.WriteLine(actualList.ToString());
        }

        [TestMethod]
        public void Add_GodHelpMe_GodHelpMePlease()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[4] { "god", "help", "me", "please" };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            actualList.Add("please");
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Remove_GodHelpMe_HelpMe()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[2] { "help", "me" };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            actualList.Remove("god");
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void RemoveAt_GodHelpMe_HelpMe()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[2] { "help", "me" };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            actualList.RemoveAt(0);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Clear_GodHelpMe_000()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[0] { };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            actualList.Clear();
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Insert_GodHelpMe_GodHelpHelpMe()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[4] { "god", "help", "help", "me" };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            actualList.Insert("help", 2);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Contains_GodHelpMe_Help()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            actualList.Contains("help");
            Assert.IsTrue(actualList.Contains("help"));
        }

        [TestMethod]
        public void IndexOf_GodHelpMe_Me()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            Assert.AreEqual(2, actualList.IndexOf("me"));
        }

        [TestMethod]
        public void SubList_GodHelpMe_HelpMe()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            string[] expected = new string[2] { "help", "me" };
            ArrayList<string> expectedList = new ArrayList<string>(expected);
            Assert.IsTrue(actualList.SubList(1, 2).Equals(expectedList));
        }

        [TestMethod]
        public void ValueOf_GodHelpMe_Help()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            Assert.AreEqual("help", actualList[1]);
        }

        [TestMethod]
        public void Length_GodHelpMe_3()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            Assert.AreEqual(3, actualList.Length());
        }

        [TestMethod]
        public void ShowList_GodHelpMe()
        {
            string[] actual = new string[3] { "god", "help", "me" };
            ArrayList<string> actualList = new ArrayList<string>(actual);
            Console.WriteLine(actualList.ToString());
        }

        [TestMethod]
        public void Add_12_34_56__12_34_56_78()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[4] { 1.2, 3.4, 5.6, 7.8 };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.Add(7.8);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Remove_12_34_56__12_34()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[2] { 1.2, 3.4 };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.Remove(5.6);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void RemoveAt_12_34_56__13()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[2] { 1.2, 5.6 };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.RemoveAt(1);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Clear_12_34_56__000()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[0] { };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.Clear();
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Insert_12_34_56__12_34_34_56()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[4] { 1.2, 3.4, 3.4, 5.6 };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.Insert(3.4, 2);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void Contains_12_34_56__12()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            actualList.Contains(1.2);
            Assert.IsTrue(actualList.Contains(1.2));
        }

        [TestMethod]
        public void IndexOf_12_34_56__34()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            Assert.AreEqual(1, actualList.IndexOf(3.4));
        }

        [TestMethod]
        public void SubList_12_34_56__12()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            double[] expected = new double[2] { 1.2, 3.4 };
            ArrayList<double> expectedList = new ArrayList<double>(expected);
            actualList.SubList(0, 1);
            Assert.IsTrue(actualList.Equals(expectedList));
        }

        [TestMethod]
        public void ValueOf_12_34_56__12()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            Assert.AreEqual(1.2, actualList[0]);
        }

        [TestMethod]
        public void Length_12_34_56__3()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            Assert.AreEqual(3, actualList.Length());
        }

        [TestMethod]
        public void ShowList_12_34_56()
        {
            double[] actual = new double[3] { 1.2, 3.4, 5.6 };
            ArrayList<double> actualList = new ArrayList<double>(actual);
            Console.WriteLine(actualList.ToString());
        }

        [TestMethod]
        public void TestEmptyListException()
        {
            ArrayList<int> actualList = new ArrayList<int>();
            actualList.Remove(5);
            Console.WriteLine(actualList.ToString());
        }

        [TestMethod]
        public void TestNoIndexException()
        {
            int[] actual = new int[3] { 1, 2, 3 };
            ArrayList<int> actualList = new ArrayList<int>(actual);
            actualList.SubList(0, 5);
            Console.WriteLine(actualList.ToString());
        }

         [TestMethod]
         public void TestHash()
         {
             ArrayList<int> arr = new ArrayList<int>();
             Console.WriteLine(arr.GetHashCode());
         }

        [TestMethod]
        public void TestNullString() 
        {
            ArrayList<string> arr = new ArrayList<string>();
            arr.Add(null);
            Console.WriteLine(arr.ToString());
        }
    }
}
