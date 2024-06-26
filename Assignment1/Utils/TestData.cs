﻿using Assignment1.Models;
using System;
using System.Collections.Generic;
using static Assignment1.Models.Enrollment;

namespace Assignment1.Utils
{
    public static class TestData
    {
        public static Student GetCarlosPietrasantaStudent()
        {
            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Test Subject ABC123", 99.99M);

            // Create enrollments for student 
            List<Enrollment> student1Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-15), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3)
            };

            // Create an Address for student 
            Address student1Address = new Address("123", "Test St.", "Testingham", "5000", StateEnum.SA);

            // Create an Address for student 
            Student student = new Student("Carlos Pietrasanta",
                                   "Carlos.PIETRASANTA@student.tafesa.edu.au",
                                   "04444 444 444",
                                   student1Address,
                                   123456,
                                   "Test Program",
                                   DateTime.Now.AddYears(-1),
                                   student1Enrollments);

            return student;
        }

        public static Student GetHeadStudent()
        {
            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Head Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Head Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Head Subject ABC123", 99.99M);

            // Create enrollments for student 
            List<Enrollment> studentEnrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-15), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3)
            };

            // Create an Address for student 
            Address studentAddress = new Address("999", "Head St.", "Headingham", "5000", StateEnum.SA);

            // Create an Address for student 
            Student student = new Student("Head Test Student",
                                   "Head.Node@linkedlist.edu.au",
                                   "04555 555 555",
                                   studentAddress,
                                   321321,
                                   "Head Program",
                                   DateTime.Now.AddYears(-1),
                                   studentEnrollments);

            return student;
        }

        public static Student GetTailStudent()
        {
            // Create some test subjects
            Subject testSubject4 = new Subject("XYZ789", "Tail Subject XYZ789", 95.50M);
            Subject testSubject5 = new Subject("XYZ789", "Tail Subject XYZ789", 95.50M);
            Subject testSubject6 = new Subject("XYZ789", "Tail Subject XYZ789", 95.50M);

            // Create enrollments for student 
            List<Enrollment> studentEnrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-20), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-45), GradeEnum.NotProvided, SemesterEnum.First, testSubject5),
                new Enrollment(DateTime.Now.AddDays(-10), GradeEnum.NotProvided, SemesterEnum.Second, testSubject6)
            };

            // Create an Address for student 
            Address studentAddress = new Address("123", "Tail St.", "Tailville", "6000", StateEnum.NSW);

            // Create a Student instance
            Student student = new Student("Tail Test Student",
                                    "Tail.Node@linkedlist.edu.au",
                                    "04666 666 666",
                                    studentAddress,
                                    654654,
                                    "Tail Program",
                                    DateTime.Now.AddYears(-2),
                                    studentEnrollments);

            return student;
        }

        public static Student[] CreateTestStudentArray()
        {
            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject4 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject5 = new Subject("ABC123", "Test Subject ABC123", 99.99M);

            Student student1 = GetCarlosPietrasantaStudent();

            // Create enrollments for student 2
            List<Enrollment> student2Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-45), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.Second, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-20), GradeEnum.NotProvided, SemesterEnum.First, testSubject1)
            };

            // Create an Address for student 2
            Address student2Address = new Address("456", "Example Ave.", "Exampletown", "1000", StateEnum.NSW);

            // Create student 2
            Student student2 = new Student("Emily Johnson",
                                   "emily.johnson@example.com",
                                   "05555 555 555",
                                   student2Address,
                                   654321,
                                   "Another Test Program",
                                   DateTime.Now.AddYears(-2),
                                   student2Enrollments);

            // Create enrollments for student 3
            List<Enrollment> student3Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-120), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-25), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
            };

            // Create an Address for student 3
            Address student3Address = new Address("789", "Sample Rd.", "Sampleville", "3000", StateEnum.VIC);

            // Create student 3
            Student student3 = new Student("Michael Smith",
                                   "michael.smith@example.com",
                                   "06666 666 666",
                                   student3Address,
                                   123123,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student3Enrollments);

            // Create enrollments for student 4
            List<Enrollment> student4Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-20), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1)
            };

            // Create an Address for student 4
            Address student4Address = new Address("1011", "Sample Rd.", "Sampletown", "3000", StateEnum.QLD);

            // Create student 4
            Student student4 = new Student("Emma Brown",
                                   "emma.brown@example.com",
                                   "07777 777 777",
                                   student4Address,
                                   111111,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student4Enrollments);

            // Create enrollments for student 5
            List<Enrollment> student5Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-50), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-80), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-25), GradeEnum.NotProvided, SemesterEnum.First, testSubject3)
            };

            // Create an Address for student 5
            Address student5Address = new Address("1213", "Sample Blvd.", "Samplecity", "4000", StateEnum.SA);

            // Create student 5
            Student student5 = new Student("William Taylor",
                                   "william.taylor@example.com",
                                   "08888 888 888",
                                   student5Address,
                                   222222,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-2),
                                   student5Enrollments);

            // Create enrollments for student 6
            List<Enrollment> student6Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-55), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-85), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-35), GradeEnum.NotProvided, SemesterEnum.Second, testSubject5)
            };

            // Create an Address for student 6
            Address student6Address = new Address("1415", "Example Lane", "Exampletown", "5000", StateEnum.TAS);

            // Create student 6
            Student student6 = new Student("Olivia Anderson",
                                   "olivia.anderson@example.com",
                                   "09999 999 999",
                                   student6Address,
                                   333333,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-1),
                                   student6Enrollments);

            // Create enrollments for student 7
            List<Enrollment> student7Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-65), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-95), GradeEnum.NotProvided, SemesterEnum.First, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-40), GradeEnum.NotProvided, SemesterEnum.First, testSubject1)
            };

            // Create an Address for student 7
            Address student7Address = new Address("1617", "Sample Ave.", "Samplecity", "6000", StateEnum.ACT);

            // Create student 7
            Student student7 = new Student("James Wilson",
                                   "james.wilson@example.com",
                                   "01111 111 111",
                                   student7Address,
                                   444444,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student7Enrollments);

            // Create enrollments for student 8
            List<Enrollment> student8Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-70), GradeEnum.NotProvided, SemesterEnum.First, testSubject5),
                new Enrollment(DateTime.Now.AddDays(-85), GradeEnum.NotProvided, SemesterEnum.Second, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject4)
            };

            // Create an Address for student 8
            Address student8Address = new Address("1819", "Sample Rd.", "Sampletown", "7000", StateEnum.NT);

            // Create student 8
            Student student8 = new Student("Sophia Lee",
                                   "sophia.lee@example.com",
                                   "02222 222 222",
                                   student8Address,
                                   555555,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-2),
                                   student8Enrollments);

            // Create enrollments for student 9
            List<Enrollment> student9Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-75), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.First, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-35), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4)
            };

            // Create an Address for student 9
            Address student9Address = new Address("2021", "Example St.", "Examplecity", "8000", StateEnum.WA);

            // Create student 9
            Student student9 = new Student("Liam Martinez",
                                   "liam.martinez@example.com",
                                   "03333 333 333",
                                   student9Address,
                                   666666,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-1),
                                   student9Enrollments);

            // Create enrollments for student 10
            List<Enrollment> student10Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-80), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-95), GradeEnum.NotProvided, SemesterEnum.Second, testSubject5),
                new Enrollment(DateTime.Now.AddDays(-40), GradeEnum.NotProvided, SemesterEnum.First, testSubject3)
            };

            // Create an Address for student 10
            Address student10Address = new Address("2223", "Example Blvd.", "Examplecity", "9000", StateEnum.SA);

            // Create student 10
            Student student10 = new Student("Amelia Garcia",
                                   "amelia.garcia@example.com",
                                   "04444 444 444",
                                   student10Address,
                                   777777,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student10Enrollments);

            // Create enrollments for student 11
            List<Enrollment> student11Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-100), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.Second, testSubject5)
            };

            // Create an Address for student 11
            Address student11Address = new Address("789", "Sample St.", "Sampleville", "2000", StateEnum.VIC);

            // Create student 11
            Student student11 = new Student("Michael Smith",
                                   "michael.smith@example.com",
                                   "06666 666 666",
                                   student11Address,
                                   987654,
                                   "Yet Another Test Program",
                                   DateTime.Now.AddYears(-1),
                                   student11Enrollments);

            Student[] studentArray = { student1, student2, student3, student4, student5, student6, student7, student8, student9, student10, student11 };


            int n = studentArray.Length;

            var rng = new Random();

            // Shuffle/Randomise the list using some code from StackOverflow
            // Source: https://stackoverflow.com/a/110570
            while (n > 1)
            {
                int k = rng.Next(n--);
                Student temp = studentArray[n];
                studentArray[n] = studentArray[k];
                studentArray[k] = temp;
            }

            return studentArray;
        }

        public static Student[] CreateTestStudentArrayForBinaryTree()
        {
            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject4 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject5 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
                        
            // Create enrollments for student 1
            List<Enrollment> student1Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-20), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1)
            };

            // Create an Address for student 1
            Address student4Address = new Address("1011", "Sample Rd.", "Sampletown", "3000", StateEnum.QLD);

            // Create student 1

            Student student1 = new Student("Emma Brown",
                                   "emma.brown@example.com",
                                   "07777 777 777",
                                   student4Address,
                                   444444,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student1Enrollments);

            // Create enrollments for student 5
            List<Enrollment> student5Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-50), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-80), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-25), GradeEnum.NotProvided, SemesterEnum.First, testSubject3)
            };

            // Create an Address for student 5
            Address student5Address = new Address("1213", "Sample Blvd.", "Samplecity", "4000", StateEnum.SA);

            // Create student 5
            Student student2 = new Student("William Taylor",
                                   "william.taylor@example.com",
                                   "08888 888 888",
                                   student5Address,
                                   222222,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-2),
                                   student5Enrollments);

            // Create enrollments for student 6
            List<Enrollment> student6Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-55), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-85), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-35), GradeEnum.NotProvided, SemesterEnum.Second, testSubject5)
            };

            // Create an Address for student 6
            Address student6Address = new Address("1415", "Example Lane", "Exampletown", "5000", StateEnum.TAS);

            // Create student 6
            Student student3 = new Student("Olivia Anderson",
                                   "olivia.anderson@example.com",
                                   "09999 999 999",
                                   student6Address,
                                   666666,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-1),
                                   student6Enrollments);

            // Create enrollments for student 7
            List<Enrollment> student7Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-65), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-95), GradeEnum.NotProvided, SemesterEnum.First, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-40), GradeEnum.NotProvided, SemesterEnum.First, testSubject1)
            };

            // Create an Address for student 7
            Address student7Address = new Address("1617", "Sample Ave.", "Samplecity", "6000", StateEnum.ACT);

            // Create student 7
            Student student4 = new Student("James Wilson",
                                   "james.wilson@example.com",
                                   "01111 111 111",
                                   student7Address,
                                   333333,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student7Enrollments);

            // Create enrollments for student 6
            List<Enrollment> student8Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-70), GradeEnum.NotProvided, SemesterEnum.First, testSubject5),
                new Enrollment(DateTime.Now.AddDays(-85), GradeEnum.NotProvided, SemesterEnum.Second, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject4)
            };

            // Create an Address for student 6
            Address student8Address = new Address("1819", "Sample Rd.", "Sampletown", "7000", StateEnum.NT);

            // Create student 6
            Student student5 = new Student("Sophia Lee",
                                   "sophia.lee@example.com",
                                   "02222 222 222",
                                   student8Address,
                                   555555,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-2),
                                   student8Enrollments);

            // Create enrollments for student 6
            List<Enrollment> student9Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-75), GradeEnum.NotProvided, SemesterEnum.Second, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.First, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-35), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4)
            };

            // Create an Address for student 6
            Address student9Address = new Address("2021", "Example St.", "Examplecity", "8000", StateEnum.WA);

            // Create student 6
            Student student6 = new Student("Liam Martinez",
                                   "liam.martinez@example.com",
                                   "03333 333 333",
                                   student9Address,
                                   777777,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-1),
                                   student9Enrollments);

            // Create enrollments for student 7
            List<Enrollment> student10Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-80), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-95), GradeEnum.NotProvided, SemesterEnum.Second, testSubject5),
                new Enrollment(DateTime.Now.AddDays(-40), GradeEnum.NotProvided, SemesterEnum.First, testSubject3)
            };

            // Create an Address for student 7
            Address student10Address = new Address("2223", "Example Blvd.", "Examplecity", "9000", StateEnum.SA);

            // Create student 7
            Student student7 = new Student("Amelia Garcia",
                                   "amelia.garcia@example.com",
                                   "04444 444 444",
                                   student10Address,
                                   111111,
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student10Enrollments);

            
            Student[] studentArray = { student1, student2, student3, student4, student5, student6, student7 };

            return studentArray;
        }
    }
}
