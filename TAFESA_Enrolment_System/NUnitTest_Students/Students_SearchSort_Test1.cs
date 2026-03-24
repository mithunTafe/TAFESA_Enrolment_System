
using TAFESA_Enrolment_System.Model;

namespace NUnitTest_Students
{
    public class Students_SearchSort_Test1
    {
        // Creating 10 Student objects
        const int NO_OF_STUDENTS = 10;

        // Student[] studentArray = new Student[NO_OF_STUDENTS];
        Student[] studentArray = new Student[NO_OF_STUDENTS];

        [SetUp]
        public void Setup()
        {
            // Assigning random values as ID to each student object when test gets initialised
            for (int i = 0; i < NO_OF_STUDENTS; i++)
            {
                studentArray[i] = new Student((i+1).ToString());
            }
        }

        [Test]
        public void LinearSearchArray_EqualTest1()
        {
            // Assign target value to be searched
            string Target = "3";

            // Act by calling the LinearSearchArray() method
            int foundAt = Utility.LinearSearchArray(studentArray, new Student(Target));

            // Assert Equal
            Assert.AreEqual(3, foundAt);

        }
    }
}