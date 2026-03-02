using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace TAFESA_Enrolment_System
{
    class Student : Person
    {
        // default constants
        const string DEF_ID = "No ID provided";
        const string DEF_PROG = "No prog provided";
        const string DEF_DATE_REG = "No date provided"; // Date registered

        /// <summary>
        /// property assessor method for id
        /// </summary>
        public string StudentID { get; set; }

        /// <summary>
        /// property assessor method for program
        /// </summary>
        public string StudentProg { get; set; }

        /// <summary>
        /// property assessor method for dateRegistered
        /// </summary>
        public string StudentDateReg { get; set; }

        /// <summary>
        /// property assessor method for Enrolment object
        /// </summary>
        public Enrolment StudentEnrolment { get; set; }

        /// <summary>
        /// all-arg constructor to include Enrolment object and inherit from Person class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phNo"></param>
        /// <param name="address"></param>
        /// <param name="id"></param>
        /// <param name="prog"></param>
        /// <param name="dateReg"></param>
        /// <param name="enrolObj"></param>
        public Student(string name, string email, string phNo, Address address, string id, string prog, string dateReg, Enrolment enrolObj) : base(name, email, phNo, address)
        {
            StudentID = id;
            StudentProg = prog;
            StudentDateReg = dateReg;
            StudentEnrolment = enrolObj;
        }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Student() : this(DEF_NAME, DEF_EMAIL, DEF_PHNO, new Address(), DEF_ID, DEF_PROG, DEF_DATE_REG, new Enrolment())
        {
        }

        /// <summary>
        /// partial-arg constructor to include only StudentID
        /// </summary>
        /// <param name="id"></param>
        public Student(string id) : this(DEF_NAME, DEF_EMAIL, DEF_PHNO, new Address(), id, DEF_PROG, DEF_DATE_REG, new Enrolment())
        {

        }

        /// <summary>
        /// toString() method to include the toString() method of Person class
        /// </summary>
        /// <returns>
        /// String displaying the id, program, and date registered of the Student object after displaying the return value of toString() method of Person class
        /// </returns>
        public override string ToString()
        {
            return base.ToString() + "\nStudent ID: " + StudentID + " - Program: " + StudentProg + " - Date Registered: " + StudentDateReg + StudentEnrolment;
        }

        /// <summary>
        /// Override default Equals() method to check for equality of Student ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// True, if Student ID of the calling object matches that of the object passed in. If not, False.
        /// </returns>
        public override bool Equals(object obj)
        {
            // Check for null objects
            if(obj == null)
                return false; 

            // Check if obj has the same reference/memory address as this
            if (ReferenceEquals(obj, this))
                return true;

            // Check if obj is not of Student type 
            if(obj.GetType() != this.GetType())
                return false;

            // If object is not null, not same, and of Student type
            Student obj1 = (Student)obj; // Typecasting generic object obj into Student type object obj1

            // Check for equality of Student ID
            return obj1.StudentID == this.StudentID;
        }

        /// <summary>
        /// Equals() method taking two objects as parameters and checks the equality of their Student ID
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns>
        /// True, if Student ID of both objects matches. If not, False.
        /// </returns>
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
                return true;

            if (obj1 == null || obj2 == null)
                return false;
            else
                return obj1.Equals(obj2); // calls the overriden Equals() method
        }

        /// <summary>
        /// Overload == to check equality of StudentIDs of the two Student objects passed in
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>
        /// True, if Student ID of both objects matches. If not, False.
        /// </returns>
        public static bool operator ==(Student s1, Student s2)
        {
            return object.Equals(s1,s2);  
        }

        /// <summary>
        /// Overload != to check inequality of StudentIDs of the two Student objects passed in
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>
        /// True, if Student ID of both objects does not match. If it matches then, False.
        /// </returns>
        public static bool operator !=(Student s1, Student s2)
        {
            return !object.Equals(s1,s2);
        }


        /// <summary>
        /// Override .NET frameworks Object.GetHashCode() method to enable optimised sorting and searching of Student objects.
        /// Uses bitwise XOR (^) to combine default hascode with the generated one based of Student ID.
        /// </summary>
        /// <returns>
        /// The combined hash code of base and the one generated of Student ID.
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.StudentID.GetHashCode();
        }

    }
}
