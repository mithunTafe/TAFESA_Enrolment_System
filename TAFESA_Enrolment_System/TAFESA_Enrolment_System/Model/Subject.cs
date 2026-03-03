using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    class Subject
    {
        // default constants
        const int DEF_CODE = -1;
        const string DEF_NAME = "No name provided";
        const double DEF_COST = -1.0;

        /// <summary>
        /// Property assessor method for code
        /// </summary>
        public int SubjectCode { get; set; }
        
        /// <summary>
        /// Property assessor method for name
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Property assessor method for cost
        /// </summary>
        public double SubjectCost { get; set; }

        /// <summary>
        /// all-arg constructor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        public Subject(int code, string name, double cost)
        {
            SubjectCode = code;
            SubjectName = name;
            SubjectCost = cost;
        }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Subject() : this(DEF_CODE, DEF_NAME, DEF_COST)
        {
        }

        /// <summary>
        /// toString() method
        /// </summary>
        /// <returns>
        /// String displaying the code, name, and cost of the Subject object
        /// </returns>
        public override string ToString()
        {
            return "\nSubject Code: " + SubjectCode + " - Name: " + SubjectName + " - Cost: $" + SubjectCost;
        }
    }
}
