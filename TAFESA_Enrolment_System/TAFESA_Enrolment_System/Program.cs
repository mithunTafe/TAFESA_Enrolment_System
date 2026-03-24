using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAFESA_Enrolment_System.Model;


namespace TAFESA_Enrolment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ----------------------
             * Testing Address Class
             * ----------------------
            */

            Console.WriteLine("\n-----Testing Address class and objects-----");

            // Test no-arg constructor
            Address a1 = new Address();
            Console.WriteLine(a1);

            // Test property assessor methods (setters)
            a1.AddressStNo = 1;
            a1.AddressStName = "One";
            a1.AddressSuburb = "First";
            a1.AddressPostcode = 1111;
            a1.AddressState = "SA";

            // Test property assessor methods (getters)
            Console.WriteLine("Street No. of Address 1: " + a1.AddressStNo);
            Console.WriteLine("Street Name of Address 1: " + a1.AddressStName);
            Console.WriteLine("Suburb No. of Address 1: " + a1.AddressSuburb);
            Console.WriteLine("Post Code of Address 1: " + a1.AddressPostcode);
            Console.WriteLine("State of Address 1: " + a1.AddressState);

            // Test all-arg constructor
            Address a2 = new Address(2, "Two", "Second", 2222, "Vic");

            // Test toString()
            Console.WriteLine(a2);

            /*
             * ------------------------------------------
             * Testing Person Class with Address Objects
             * ------------------------------------------
            */

            Console.WriteLine("\n-----Testing Person class with Address objects-----");

            // Test no-arg constructor
            Person p1 = new Person();
            Console.WriteLine(p1);

            // Test property assessor methods (setters)
            p1.PersonName = "P1";
            p1.PersonEmail = "P1@tafe.edu";
            p1.PersonPhNo = "123";
            p1.PersonAddress = a1;

            // Test property assessor methods (getters)
            Console.WriteLine("Person1's Name: " + p1.PersonName);
            Console.WriteLine("Person1's Email: " + p1.PersonEmail);
            Console.WriteLine("Person1's Phone: " + p1.PersonPhNo);
            Console.WriteLine("Person1's Address: " + p1.PersonAddress);

            // Test all-arg constructor
            Person p2 = new Person("P2", "P2@tafe.edu", "456", a2);

            // Test toString()
            Console.WriteLine(p2);

            /*
             * ----------------------
             * Testing Subject Class
             * ----------------------
            */

            Console.WriteLine("\n-----Testing Subject class and objects-----");

            // Test no-arg constructor
            Subject sub1 = new Subject();
            Console.WriteLine(sub1);

            // Test property assessor methods (setters)
            sub1.SubjectCode = 1;
            sub1.SubjectName = "C# Adv";
            sub1.SubjectCost = 123.45;

            // Test property assessor methods (getters)
            Console.WriteLine("Code of Subject 1: " + sub1.SubjectCode);
            Console.WriteLine("Name of Subject 1: " + sub1.SubjectName);
            Console.WriteLine("Cost of Subject 1: $" + sub1.SubjectCost);

            // Test all-arg constructor
            Subject sub2 = new Subject(2, "Java", 543.21);

            // Test toString()
            Console.WriteLine(sub2);

            /*
             * ------------------------------------------
             * Testing Enrolment Class with Subject Objects
             * ------------------------------------------
            */

            Console.WriteLine("\n-----Testing Enrolment class with Subject objects-----");

            // Test no-arg constructor
            Enrolment e1 = new Enrolment();
            Console.WriteLine(e1);

            // Test property assessor methods (setters)
            e1.EnrolmentDate = "1 Jan 2026";
            e1.EnrolmentGrade = "A";
            e1.EnrolmentSem = "First";
            e1.EnrolmentSubject = sub1;

            // Test property assessor methods (getters)
            Console.WriteLine("Date Enrolled of Enrolment 1: " + e1.EnrolmentDate);
            Console.WriteLine("Grade of Enrolment 1: " + e1.EnrolmentGrade);
            Console.WriteLine("Semester enrolled of Enrolment 1: " + e1.EnrolmentSem);
            Console.WriteLine("Subject enrolled of Enrolment 1: " + e1.EnrolmentSubject);

            // Test all-arg constructor
            Enrolment e2 = new Enrolment("1 Jul 2025", "A", "Second", sub2);

            // Test toString()
            Console.WriteLine(e2);

            /*
             * ------------------------------------------------------------------------------
             * Testing Student Class with Enrolment Objects and inheriting from Person Class 
             * ------------------------------------------------------------------------------
            */

            Console.WriteLine("\n-----Testing Student class with Aggregation and Inheritance-----");

            // Test no-arg constructor
            Student s1 = new Student();
            Console.WriteLine(s1);

            // Test property assessor methods (setters)
            s1.StudentID = "a111";
            s1.StudentProg = "Diploma";
            s1.StudentDateReg = "1 Feb 2026";
            s1.StudentEnrolment = e1;

            // Test property assessor methods (getters)
            Console.WriteLine("\nStudent ID of Student 1: " + s1.StudentID);
            Console.WriteLine("Program of Student 1: " + s1.StudentProg);
            Console.WriteLine("Date of Registration of Student 1: " + s1.StudentDateReg);
            Console.WriteLine("Enrolment of Student 1: " + s1.StudentEnrolment);

            // Test all-arg constructor
            Student s2 = new Student(p2.PersonName, p2.PersonEmail, p2.PersonPhNo, a2, "a222", "C4", "1 Aug 2025", e2);

            // Test toString()
            Console.WriteLine("\nStudent 2:" + s2);

            // Test partial-arg constructor
            Student s3 = new Student("a222");

            Console.WriteLine("\nStudent 3:" + s3);

            // Check equality of two student objects
            Console.WriteLine("\n-----Checking equality of Student object 1 and Student object 2. Expected: NOT EQUAL-----");
            DisplayWhetherEqual(s1, s2);

            Console.WriteLine("\n-----Checking equality of Student object 2 and Student object 3. Expected: EQUAL-----");
            DisplayWhetherEqual(s2, s3);

            /*
             * -------------------------------------------------------------
             * Searching Student object using Sequential and Binary searches 
             * -------------------------------------------------------------
            */

            // Creating 10 Student objects
            const int NO_OF_STUDENTS = 10;
            Student[] studentArray = new Student[NO_OF_STUDENTS];

            // To generate random student IDs
            Random rnd = new Random();
            int intID;

            Console.WriteLine("\n-----Student Array with 10 Student objects-----\n");
            
            // Populating studentArray
            for (int i = 0; i < studentArray.Length; i++)
            {
                intID = rnd.Next(NO_OF_STUDENTS);
                studentArray[i] = new Student(intID.ToString());
                Console.WriteLine("Student object at index {0} - ID: {1}", i, studentArray[i].StudentID);
            }

            Console.WriteLine("\n-----Searching STUDENT array-----\n");

            Console.WriteLine("\n-----Linear Search - STUDENT array-----\n");
            Console.WriteLine("\nLinear Search for Student with ID '0' is found at index : " + Utility.LinearSearchArray(studentArray, new Student("0")));
            Console.WriteLine("\nLinear Search for Student with ID '6' is found at index : " + Utility.LinearSearchArray(studentArray, new Student("6")));
            Console.WriteLine("\nLinear Search for Student with ID '7' is found at index : " + Utility.LinearSearchArray(studentArray, new Student("7")));

            Console.WriteLine("\n-----Binary Search - STUDENT array-----\n");
            Console.WriteLine("\nBinary Search for Student with ID '0' is found at index: " + Utility.BinarySearchArray(studentArray, new Student("0")));
            Console.WriteLine("\nBinary Search for Student with ID '6' is found at index: " + Utility.BinarySearchArray(studentArray, new Student("6")));
            Console.WriteLine("\nBinary Search for Student with ID '7' is found at index: " + Utility.BinarySearchArray(studentArray, new Student("7")));


            Console.WriteLine("\n-----Sorting STUDENT array-----\n");
            
            Console.WriteLine("\n-----Selection Sort in ascending order - STUDENT array-----\n");
            Utility.SelectionSortAsc(studentArray);
            
            // Displaying studentArray after sorting
            Console.WriteLine("\n-----After sorting-----");
            PrintStudentArray(studentArray);
            
            Console.WriteLine("\n-----Bubble Sort in descending order - STUDENT array-----\n");
            Utility.SelectionSortDesc(studentArray);

            // Displaying studentArray after sorting
            Console.WriteLine("\n-----After sorting-----");
            PrintStudentArray(studentArray);

        }

        /// <summary>
        /// Method to display equality
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void DisplayWhetherEqual(Student a, Student b)
        {
            if (a == b)
                Console.WriteLine(string.Format("{0} \n\n EQUAL \n {1}", a, b));
            else
                Console.WriteLine(string.Format("{0} \n\n NOT EQUAL \n {1}", a, b));
        }

        /// <summary>
        /// Method to print Student array displaying StudentID of each object (element of the array) and its index
        /// </summary>
        /// <param name="myArray"> Student array to be printed </param>
        public static void PrintStudentArray(Student[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Student object at index {0} - ID: {1}", i, myArray[i].StudentID);
            }
        }
    }
}
