using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    class Person
    {
        // class-level member variables
        private string name;
        private string email;
        private string phNo;

        // default constants
        public const string DEF_NAME = "No name provided";
        public const string DEF_EMAIL = "No email provided";
        public const string DEF_PHNO = "No phone number provided";

        // Address Object - Aggregation
        private Address addObj;

        /// <summary>
        /// Property assessor method for name
        /// </summary>
        public string PersonName 
        {
            get 
            { return name; }
            set
            { name = value; }
        }

        /// <summary>
        /// Property assessor method for email
        /// </summary>
        public string PersonEmail
        {
            get
            { return email; }
            set
            { email = value; }
        }

        /// <summary>
        /// Property assessor method for phNo
        /// </summary>
        public string PersonPhNo
        {
            get
            { return phNo; }
            set
            {  phNo = value; }
        }

        /// <summary>
        /// Property assessor method for Address Object
        /// </summary>
        public Address PersonAddress { get; set; }

        /// <summary>
        /// all-arg constructor to include Address object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phNo"></param>
        /// <param name="addObj"></param>
        public Person(string name, string email, string phNo, Address addObj)
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhNo = phNo; 
            PersonAddress = addObj;
        }

        /// <summary>
        /// partial-arg constructor (previously all-arg)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phNo"></param>
        public Person(string name, string email, string phNo) : this(name, email, phNo, new Address())
        {
        }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Person() : this(DEF_NAME, DEF_EMAIL, DEF_PHNO) 
        {
        }

        /// <summary>
        /// toString() method
        /// </summary>
        /// <returns>
        /// String displaying the name, email, phone number, and Address details of the Person object
        /// </returns>
        public override string ToString()
        {
            return "\nPerson Details:\nName: " + PersonName + "\nEmail: " + PersonEmail + "\nPhone: " + PersonPhNo + "\n" + PersonAddress;
        }
    }
}
