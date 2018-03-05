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






    }


}
