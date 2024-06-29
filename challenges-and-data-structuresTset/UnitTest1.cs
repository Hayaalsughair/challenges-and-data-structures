using c_basics.Challenges.Common_Elements;

namespace challenges_and_data_structuresTset
{
    public class UnitTest1
    {
        [Fact]
        public void CommonElementsTests_ReturnCommonNumberCase11()
        {
            // Arrange
            var arr1 = new[] {  1, 2, 3, 0 };
            var arr2 = new[] { 2, 3, 4, 9 };
            var expected = new[] { 2, 3 };
            //Act
            var actual = solutionCommonElement.CommonElements(arr1, arr2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CommonElementsTests_ReturnCommonNumberCase2()
        {
            // Arrange
            var arr1 = new[] { 79, 8, 15 };
            var arr2 = new[] { 23, 79, 8 };
            var expected = new[] { 79, 8 };
            //Act
            var actual = solutionCommonElement.CommonElements(arr1, arr2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}