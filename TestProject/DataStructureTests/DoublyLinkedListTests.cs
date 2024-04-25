using Assignment1.DataStructures.DoublyLinkedList;
using Assignment1.Models;
using Assignment1.Utils;

namespace TestProject.DataStructuresTest.DoublyLinkedList
{
    public class DoublyLinkedListTests
    {
        Student[] studentArray;
        DoublyLinkedList<Student> studentsLinkedList;
        Student headStudent;
        Student tailStudent;

        [SetUp] 
        public void SetUp() 
        {
            studentArray = TestData.CreateTestStudentArray();
            studentsLinkedList = new DoublyLinkedList<Student>();

            foreach (Student student in studentArray)
            {
                studentsLinkedList.Add(student);
            }

            headStudent = TestData.GetHeadStudent();
            tailStudent = TestData.GetTailStudent();
        }

        [Test]
        public void AddStudentHead()
        {
            studentsLinkedList.AddFirst(headStudent);
            Assert.That(studentsLinkedList.Head.Value.Equals(headStudent));
        }

        [Test]
        public void AddStudentTail()
        {
            studentsLinkedList.AddLast(tailStudent);
            Assert.That(studentsLinkedList.Tail.Value.Equals(tailStudent));
        }

        [Test]
        public void FindStudent()
        {
            Student findStudent = TestData.GetCarlosPietrasantaStudent();
            Assert.That(studentsLinkedList.Contains(findStudent));
        }

        [Test]
        public void RemoveHead()
        {
            studentsLinkedList.RemoveFirst();
            Assert.That(!studentsLinkedList.Contains(headStudent));
        }

        [Test]
        public void RemoveTail()
        {
            studentsLinkedList.RemoveLast();
            Assert.That(!studentsLinkedList.Contains(tailStudent));
        }
    }
}
