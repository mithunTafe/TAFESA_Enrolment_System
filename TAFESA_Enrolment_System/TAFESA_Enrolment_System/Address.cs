using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    class Address
    {
        // default constants
        const int DEF_STNO = -1;
        const string DEF_STNAME = "No street name provided";
        const string DEF_SUBURB = "No suburb provided";
        const int DEF_PC = -1; 
        const string DEF_STATE = "No state provided";

        /// <summary>
        /// Property assessor method for stNo
        /// </summary>
        public int AddressStNo { get; set; }

        /// <summary>
        /// Property assessor method for stName
        /// </summary>
        public string AddressStName { get; set; }

        /// <summary>
        /// Property assessor method for suburb
        /// </summary>
        public string AddressSuburb { get; set; }

        /// <summary>
        /// Property assessor method for postcode
        /// </summary>
        public int AddressPostcode { get; set; }

        /// <summary>
        /// Property assessor method for state
        /// </summary>
        public string AddressState { get; set; }

        /// <summary>
        /// all-arg constructor
        /// </summary>
        /// <param name="stNo"></param>
        /// <param name="stName"></param>
        /// <param name="suburb"></param>
        /// <param name="pc"></param>
        /// <param name="state"></param>
        public Address(int stNo, string stName, string suburb, int pc, string state)
        {
            AddressStNo = stNo;
            AddressStName = stName;
            AddressSuburb = suburb;
            AddressPostcode = pc;
            AddressState = state;
        }

        /// <summary>
        /// no-arg constructor
        /// </summary>
        public Address() : this(DEF_STNO, DEF_STNAME, DEF_SUBURB, DEF_PC, DEF_STATE) 
        {
        }

        /// <summary>
        /// toString() method
        /// </summary>
        /// <returns>
        /// String displaying the street number, street name, suburb, state, and postcode of the Address object
        /// </returns>
        public override string ToString()
        {
            return "Address: No." + AddressStNo + " " + AddressStName + " street, " + AddressSuburb + ", " + AddressState + " " + AddressPostcode;
        }
    }
}
