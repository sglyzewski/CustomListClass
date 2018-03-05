using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {

        //Tests for Add Method
        [TestMethod]
        public void Add_InitialElementInArray_AddsElementToArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            //act
            customList.Add(expected);
            int result = customList[0];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_FourthElementInArray_AddsElementToEndOfArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            //act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(expected);
            int result = customList[4];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_ElementInArrayOfUnknownLength_AddsElementToEndOfArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            //act
            customList.Add(1);
            customList.Add(expected);
            int result = customList[customList.Count -1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void Add_ElementAddedToArray_ChangesLengthOfTheArray()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expectedLength = 2;
            //act
            customList.Add(1);
            customList.Add(2);
            int result = customList.Count;

            //assert
            Assert.AreEqual(expectedLength, result);
        }



        //Test Indexer
        [TestMethod]

        public void Indexer_ElementInArray_ReturnsCorrectElement()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            //act
            customList.Add(1);
            customList.Add(2);
            int result = customList[1];
            //assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Indexer_LastElementInArray_ReturnsFinalElement()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            customList.Add(1);
            customList.Add(2);
            //act

            int result = customList[customList.Count-1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Indexer_RequestIndexHigherThanCount_ThrowsException()
        {

        }


        //Remove Method Tests
        //[TestMethod]
        //public void Remove_SecondIntegerElementInList_DeletesSecondIntegerElementFromList()
        //{
        //    //arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    customList.Add(1);
        //    customList.Add(2);
        //    int expected = 0;
        //    //act
        //    customList.Remove(2);

        //    int result = customList[1];
        //    //assert
        //    result.ThrowsException("The index has no value");
        //}

        [TestMethod]
        public void Remove_FourthStringInList_CountDecrementsFrom4To3()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("world");
            customList.Add("hi");
            customList.Add("there");
            int expected = 3;

            //act
            customList.Remove("there");
            int result = customList.Count;
            //assert
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Remove_ElementWithElementAfter_FollowingElementReplacesIndex()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("world");
            customList.Add("hi");
            string expected = "hi";
            //act
            customList.Remove("world");
            string result = customList[1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_2ElementList_Return2()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            int expected = 2;

            //act
            int result = customList.Count;

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_EmptyCustomList_CountIsZero()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            int expected = 0;
            //act

            int result = customList.Count;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Remove_RemovingNonExistentElement_ReturnsFalse()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            //act
            bool result = customList.Remove("world");
            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Remove_RepeatElement_RemovesFirstInstanceOfElement()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            customList.Add("hello");
            string expected = "hi";
            //act
           customList.Remove("hello");
            string result = customList[0];
           //assert
           Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddTwoCustomListsWithCountOf1_Index1ContainsSecondListElement()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList1.Add(1);
            customList2.Add(2);
            CustomList<int> customList3;
            int expected = 2;
            //act
            customList3 = customList1 + customList2;
            int result = customList3[1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddTwoCustomListsWithCountOf1_CountOfSummedListIs2()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList1.Add(1);
            customList2.Add(2);
            CustomList<int> customList3;
            int expected = 2;
            //act
            customList3 = customList1 + customList2;
            int result = customList3.Count;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddThreeCustomListsWithCountOf1_CountOfSummedListIs3()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            CustomList<int> customList4;
            customList1.Add(1);
            customList2.Add(2);
            customList3.Add(3);
            int expected = 3;
            //act
            customList4 = customList1 + customList2 + customList3;
            int result = customList4.Count;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddEmptyCustomList_CountRemainsTheSame()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3;
            customList1.Add(1);

            //act
            customList3 = customList1 + customList2;
            //assert
            Assert.AreEqual(customList3.Count, customList1.Count);
        }


       





    }


}
