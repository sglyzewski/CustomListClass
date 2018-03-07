using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void Add_InitialElementInArray_AddsElementToArray()
        {
          
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            
            customList.Add(expected);
            int result = customList[0];
            
            Assert.AreEqual(expected, result);
        }

        

        [TestMethod]
        public void Add_FourthElementInArray_AddsElementToEndOfArray()
        {
          
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(expected);
            int result = customList[4];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_ElementInArrayOfUnknownLength_AddsElementToEndOfArray()
        {
        
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;
            customList.Add(1);
            customList.Add(expected);
            int result = customList[customList.Count -1];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void Add_ElementAddedToArray_ChangesLengthOfTheArray()
        {
            CustomList<int> customList = new CustomList<int>();
            int expectedLength = 2;
            customList.Add(1);
            customList.Add(2);
            int result = customList.Count;
            Assert.AreEqual(expectedLength, result);
        }



   
        [TestMethod]

        public void Indexer_ElementInArray_ReturnsCorrectElement()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            customList.Add(1);
            customList.Add(2);
            int result = customList[1];
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Indexer_LastElementInArray_ReturnsFinalElement()
        {
            CustomList<int> customList = new CustomList<int>();
            int expected = 2;
            customList.Add(1);
            customList.Add(2);
            int result = customList[customList.Count-1];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_RequestIndexHigherThanCount_ThrowsException()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            string act = customList[1];
        }


        [TestMethod]
        public void Remove_FourthStringInList_CountDecrementsFrom4To3()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("world");
            customList.Add("hi");
            customList.Add("there");
            int expected = 3;
            customList.Remove("there");
            int result = customList.Count;
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Remove_ElementWithElementAfter_FollowingElementReplacesIndex()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("world");
            customList.Add("hi");
            string expected = "hi";
            customList.Remove("world");
            string result = customList[1];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_RemoveElementFrom2ElementList_Return1()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            customList.Remove("hi");
            int expected = 1;
            int result = customList.Count;
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Count_2ElementList_Return2()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            int expected = 2;
            int result = customList.Count;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Count_EmptyCustomList_CountIsZero()
        {
            CustomList<string> customList = new CustomList<string>();
            int expected = 0;
            int result = customList.Count;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Remove_RemovingNonExistentElement_ReturnsFalse()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            bool result = customList.Remove("world");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Remove_RepeatElement_RemovesFirstInstanceOfElement()
        {
            CustomList<string> customList = new CustomList<string>();
            customList.Add("hello");
            customList.Add("hi");
            customList.Add("hello");
            string expected = "hi";
           customList.Remove("hello");
            string result = customList[0];
           Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddTwoCustomListsWithCountOf1_Index1ContainsSecondListElement()
        {
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList1.Add(1);
            customList2.Add(2);
            CustomList<int> customList3;
            int expected = 2;
            customList3 = customList1 + customList2;
            int result = customList3[1];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddTwoCustomListsWithCountOf1_CountOfSummedListIs2()
        {
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customList1.Add(1);
            customList2.Add(2);
            CustomList<int> customList3;
            int expected = 2;
            customList3 = customList1 + customList2;
            int result = customList3.Count;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PlusOperatorOverLoad_AddThreeCustomListsWithCountOf1_CountOfSummedListIs3()
        {
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            CustomList<int> customList4;
            customList1.Add(1);
            customList2.Add(2);
            customList3.Add(3);
            int expected = 3;
            customList4 = customList1 + customList2 + customList3;
            int result = customList4.Count;
            Assert.AreEqual(expected, result);
        }
        

        [TestMethod]
        public void PlusOperatorOverLoad_AddEmptyCustomList_CountRemainsTheSame()
        {
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3;
            customList1.Add(1);
            customList3 = customList1 + customList2;
            Assert.AreEqual(customList3.Count, customList1.Count);
        }

        [TestMethod]
        public void MinusOperatorOverload_TwoStringArrays_SubtractStrings()
        {
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
            customList3 = customList1 - customList2;
            string result = customList1[customList1.Count - 1];
            Assert.AreEqual(expected, result);
        }
         
       
        [TestMethod]
  
        public void MinusOperatorOverLoad_TwoIntegerArrays_RemovesElementsWhichOccurInBoth()
        {
            CustomList<int> customList1 = new CustomList<int>() { 2, 3, 4 };
            CustomList<int> customList2 = new CustomList<int>() { 3 };
            CustomList<int> customList3;
            int expected = 4;
            customList3 = customList1 - customList2;
            int result = customList3[1];
           Assert.AreEqual(expected, result);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void MinusOperatorOverLoad_TwoIntegerListsWithSameValues_ThrowsExceptionWhenAskedForIndexOfList3()
        {
            CustomList<int> customList1 = new CustomList<int>() { 2, 3, 4 };
            CustomList<int> customList2 = new CustomList<int>() { 2, 3, 4 };
            CustomList<int> customList3;
            customList3 = customList1 - customList2;
            int result = customList3[0];
        }
        

        [TestMethod]
        public void MinusOperatorOverLoad_TwoIntegerListsWithNoSharedValues_ReturnsList1AsList3()
        {
            CustomList<int> customList1 = new CustomList<int>() { 2, 3, 4 };
            CustomList<int> customList2 = new CustomList<int>() { 5, 6, 7};
            CustomList<int> customList3;
            int expectedCount = 3;
            int expectedNumber = 4;
            customList3 = customList1 - customList2;
            int resultCount = customList3.Count;
            int resultNumber= customList3[2];
            Assert.AreEqual(expectedCount, resultCount);
            Assert.AreEqual(expectedNumber, resultNumber);
        }

        [TestMethod]
        public void ZipCustomLists_TwoIntegerLists_ZipsValuesTogetherInCorrectOrder()
        {
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            int expected = 2;
            CustomList<int> zipped;
            zipped = odd.ZipCustomLists(even);
            int result = zipped[1];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZipCustomLists_TwoIntegerLists_CountChanges()
        {
            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            int expected = 6;
            CustomList<int> zipped = new CustomList<int>();
            zipped = odd.ZipCustomLists(even);
            int result = zipped.Count;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZipCustomLists_TwoIntegerListsOfDifferentLengths_CountChanges()
        {
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
            CustomList<int> zipped = new CustomList<int>();
            zipped = odd.ZipCustomLists(even);
            int result = zipped.Count;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ZipCustomLists_List1IsEmpty_ReturnsSecondList()
        {
         
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            second.Add(2);
            second.Add(4);
            second.Add(6);
            second.Add(6);
            second.Add(6);
            int expected = 6;
            CustomList<int> zipped = new CustomList<int>();
            zipped = first.ZipCustomLists(second);
            int result = zipped[4];
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void ZipCustomLists_List2IsEmpty_ReturnsFirstList()
        {
            CustomList<int> first = new CustomList<int>();
            first.Add(2);
            first.Add(4);
            first.Add(6);
            first.Add(6);
            first.Add(6);
            CustomList<int> second = new CustomList<int>();
            int expected = 6;
            int expectedCount = 5;
            CustomList<int> zipped = new CustomList<int>();
            zipped = first.ZipCustomLists(second);
            int resultCount = zipped.Count;
            int result = zipped[4];
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expectedCount, resultCount);
        }

        [TestMethod]
        public void ToString_CustomListOfTwoStrings_ReturnsAConcatenatedStringOfElements()
        {
            CustomList<string> helloWorld = new CustomList<string>();
            helloWorld.Add("Hello ");
            helloWorld.Add("world!");
            string expected = "Hello world!";
            string result = helloWorld.ToString();
            Assert.AreEqual(expected, result);
        }

        
        [TestMethod]
        public void ToString_CustomListOfTwoDoubles_ReturnsAConcatenatedStringOfElements()
        {
            CustomList<double> doublesList = new CustomList<double>();
            doublesList.Add(2);
            doublesList.Add(4);
            string expected = "24";
            string result = doublesList.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_EmptyCustomList_ReturnsEmptyString()
        {
            CustomList<int> emptyList = new CustomList<int>();
            string expected = "";
            string result;
            result = emptyList.ToString();        
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BubbleSort_LowerNumberFirst_ReturnsHigherNumberFirst()
        {
            CustomList<int> unsortedList = new CustomList<int>() { 1, 2 };
            int expected = 2;
            int result = (unsortedList.BubbleSort(unsortedList))[0];
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BubbleSort_HigherNumberFirst_ReturnsHigherNumberFirst()
        {
            CustomList<int> unsortedList = new CustomList<int>() { 2 , 1 };
            int expected = 2;
            int result = (unsortedList.BubbleSort(unsortedList))[0];
            Assert.AreEqual(expected, result);
        }

    }


}
