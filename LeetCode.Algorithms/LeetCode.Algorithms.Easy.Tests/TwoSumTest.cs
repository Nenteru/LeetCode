namespace LeetCode.Algorithms.Easy.Tests
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void Array_2and7and11and15_Target_9_0and1returned()
        {
            // arrange
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            int[] expected = [0, 1];

            // act
            int[] actual = TwoSum.twoSum(nums, target);

            //assert
            for(int i = 0; i < actual.Length; ++i)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Array_3and2and4_Target_6_1and2returned()
        {
            // arrange
            int[] nums = [3, 2, 4];
            int target = 6;
            int[] expected = [1, 2];

            // act
            int[] actual = TwoSum.twoSum(nums, target);

            //assert
            for (int i = 0; i < actual.Length; ++i)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void Array_3and3_Target_6_0and1returned()
        {
            // arrange
            int[] nums = [3, 3];
            int target = 6;
            int[] expected = [0, 1];

            // act
            int[] actual = TwoSum.twoSum(nums, target);

            //assert
            for (int i = 0; i < actual.Length; ++i)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}