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
        public void Count_RemoveElementFrom2ElementList_Return1()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            customList.Remove("hi");
            int expected = 1;

            //act
            int result = customList.Count;

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

        //public void MinusOperatorOverLoad
        [TestMethod]
        public void MinusOperatorOverload_TwoFloatArrays_SubtractsEachElement()
        {
            //arrange
            CustomList<float> customList1 = new CustomList<float>();
            CustomList<float> customList2 = new CustomList<float>();
            CustomList<float> customList3;
            customList1.Add(2);
            customList1.Add(3);
            customList2.Add(1);
            customList2.Add(2);
            
            int expected = 1;
            //act
            customList3 = customList1 - customList2;
            float result = customList1[1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinusOperatorOverload_TwoStringArrays_SubtractStrings()
        {
            //arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            CustomList<string> customList3;
            customList1.Add("Hey,");
            customList1.Add("it's");
            customList1.Add("me.");
            customList1.Add("How");
            customList1.Add("are");
            customList1.Add("you?");
            customList2.Add("How");
            customList2.Add("are");
            customList2.Add("you?");
            string expected = "me.";
            //act
            customList3 = customList1 - customList2;
            string result = customList1[customList1.Count - 1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MinusOperatorOverload_TwoIntegerArraysOfDifferentCounts_AddsZeroesToSubtract()
        {
            //arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3;
            customList1.Add(2);
            customList1.Add(3);
            customList2.Add(1);
            customList2.Add(2);
            customList2.Add(3);
            int expected = -3;
            //act
            customList3 = customList1 - customList2;
            int result = customList3[2];
            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Zip_TwoIntegerLists_ZipsValuesTogetherInCorrectOrder()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            int expected = 2;
            //act
            CustomList<int> zipped;
            zipped = odd.Zipper(even);
            int result = zipped[1];
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zip_TwoIntegerLists_CountChanges()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            int expected = 6;
            //act
            CustomList<int> zipped = new CustomList<int>();
            zipped = odd.Zipper(even);
            int result = zipped.Count;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zip_TwoIntegerListsOfDifferentLengths_CountChanges()
        {
            //arrange
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(6);
            even.Add(6);
            int expected = 8;
            //act
            CustomList<int> zipped = new CustomList<int>();
            zipped = odd.Zipper(even);
            int result = zipped.Count;
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Zip_List1IsEmpty_ReturnsSecondList()
        {
            //arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            second.Add(2);
            second.Add(4);
            second.Add(6);
            second.Add(6);
            second.Add(6);
            int expected = 6;
            //act
            CustomList<int> zipped = new CustomList<int>();
            zipped = first.Zipper(second);
            int result = zipped[4];
            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void ToString_CustomListOfTwoStrings_ReturnsAConcatenatedStringOfElements()
        {
            //arrange
            CustomList<string> helloWorld = new CustomList<string>();
            helloWorld.Add("Hello ");
            helloWorld.Add("world!");
            string expected = "Hello world!";
            //act
            string result = helloWorld.ToString();
            //assert
            Assert.AreEqual(expected, result);
        }

        
        [TestMethod]
        public void ToString_CustomListOfTwoDoubles_ReturnsAConcatenatedStringOfElements()
        {
            //arrange
            CustomList<double> doublesList = new CustomList<double>();
            doublesList.Add(2);
            doublesList.Add(4);
            string expected = "24";
            //act
            string result = doublesList.ToString();
            //assert
            Assert.AreEqual(expected, result);
        }








    }


}
