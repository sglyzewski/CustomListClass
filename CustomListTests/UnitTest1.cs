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



    }


}
