using Assignment1.DataStructures.BinaryTree;
using Assignment1.Models;
using Assignment1.Utils;

namespace TestProject.DataStructuresTest.BinaryTreeTest
{
    public class BinaryTreeTests
    {
        BinaryTree binaryTree;

        [SetUp]
        public void SetUp()
        {
            Student[] studentArray = TestData.CreateTestStudentArrayForBinaryTree();
            binaryTree = new BinaryTree();

            foreach (Student student in studentArray)
            {
                binaryTree.Add(student.StudentId);
            }
        }

        // Using this method to capture console output and perform the tests
        // https://stackoverflow.com/a/2139303

        [Test]
        public void PreOrderTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                binaryTree.TraversePreOrder(binaryTree.Root);

                string expected = "444444 222222 111111 333333 666666 555555 777777 ";

                Assert.That(expected == sw.ToString());
            }
        }

        [Test]
        public void InOrderTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                binaryTree.TraverseInOrder(binaryTree.Root);

                string expected = "111111 222222 333333 444444 555555 666666 777777 ";

                Assert.That(expected == sw.ToString());
            }
        }

        [Test]
        public void PostOrderTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                binaryTree.TraversePostOrder(binaryTree.Root);

                string expected = "111111 333333 222222 555555 777777 666666 444444 ";

                Assert.That(expected == sw.ToString());
            }
        }
    }
}
