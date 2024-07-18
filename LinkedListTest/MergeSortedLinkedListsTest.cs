using c_basics.Data_Structures.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class MergeSortedLinkedListsTest
    {
        [Fact]
        public void TestMergingOneListEmpty()
        {
            // Arrange
            Linked_List tsetList1 = new Linked_List();
            Linked_List tsetList2 = new Linked_List();

            tsetList1.AddEnd(2);
            tsetList1.AddEnd(5);
            tsetList1.AddEnd(15);

            // Act
            Linked_List testMergedList = Linked_List.MergeSortedLists(tsetList1, tsetList2);
            var actual = testMergedList.PrintList(); 
            var expected = tsetList1.PrintList();

            // Assert
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TestMergingTwoListEmpty()
        {
            // Arrange
            Linked_List tsetList1 = new Linked_List();
            Linked_List tsetList2 = new Linked_List();

            // Act
            Linked_List testMergedList = Linked_List.MergeSortedLists(tsetList1, tsetList2);

            // Assert
            Assert.Null(testMergedList.Head);

        }
        [Fact]
        public void TestMergingList1AndList2()
        {
            // Arrange
            Linked_List tsetList1 = new Linked_List();
            tsetList1.AddEnd(2);
            tsetList1.AddEnd(5);
            tsetList1.AddEnd(15);

            Linked_List tsetList2 = new Linked_List();
            tsetList2.AddEnd(1);
            tsetList2.AddEnd(3);
            tsetList2.AddEnd(10);

            // Act
            Linked_List testMergedList = Linked_List.MergeSortedLists(tsetList1, tsetList2);
            var result = testMergedList.PrintList();

            //Assert
            Assert.Equal(6, result);

        }
    }
}
