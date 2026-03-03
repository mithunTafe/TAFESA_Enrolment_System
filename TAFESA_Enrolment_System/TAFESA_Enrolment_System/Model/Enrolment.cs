using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    class Enrolment
    {
        // default constants
        const string DEF_DATE = "No date provided"; // Date enrolled
        const string DEF_GRADE = "No grade provided";
        const string DEF_SEM = "No semester provided";

        // Subject Object - Aggregation
        private Subject subObj;

        /// <summary>
        /// Property assessor method for dateEnrolled
        /// </summary>
        public string EnrolmentDate { get; set; }

        /// <summary>
        /// Property assessor method for grade
        /// </summary>
        public string EnrolmentGrade { get; set; }

        /// <summary>
        /// Property assessor method for semester
        /// </summary>
        public string EnrolmentSem { get; set; }

        /// <summary>
        /// property assessor method for Subject object
        /// </summary>
        public Subject EnrolmentSubject
        {
            get { return subObj; }
            set { subObj = value; }
        }

        /// <summary>
        /// all-arg constructor to include Subject object
        /// </summary>
        /// <param name="date"></param>
        /// <param name="grade"></param>
        /// <param name="sem"></param>
        /// <param name="subObj"></param>
        public Enrolment(string date, string grade, string sem,  Subject subObj)
        {
            EnrolmentDate = date;
            EnrolmentGrade = grade;
            EnrolmentSem = sem;
            EnrolmentSubject = subObj;
        }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Enrolment() : this(DEF_DATE, DEF_GRADE, DEF_SEM, new Subject())
        {
        }

        /// <summary>
        /// toString() method
        /// </summary>
        /// <returns>
        /// String displaying the date enrolled, grade, and semester of the Enrolment object
        /// </returns>
        public override string ToString()
        {
            return "\nDate enrolled: " + EnrolmentDate + " - Grade: " + EnrolmentGrade + " - Semester enrolled: " + EnrolmentSem + EnrolmentSubject;
        }
    }
}
