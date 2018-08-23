using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPILabb6
{
    /// <summary>
    /// This is the InputUtility class. This class handles user input in whatever project it is meant to be put in.
    /// Some of the methods in this class are not actually used in this assignment, but are instead meant for 
    /// future projects.
    /// </summary>
    class InputUtility
    {
        ///<summary>
        ///Checks whether the value is that of an "integer" or not.
        /// </summary>
        public static bool GetInteger(string stringToConvert, out int intOutValue)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            return goodNumber;
        }

        ///<summary>
        ///Checks whether the value is that of a "double" or not. Used for future projects.
        ///</summary>
        public static bool GetDouble(string stringToConvert, out double dblOutValue)
        {
            bool goodNumber = double.TryParse(stringToConvert, out dblOutValue);
            return goodNumber;
        }

        ///<summary>
        ///Checks whether the value is a positive "double" or not.
        ///</summary>
        public static bool GetPositiveDouble(string stringToConvert, out double dblOutValue)
        {
            bool goodNumber = double.TryParse(stringToConvert, out dblOutValue);
            if (goodNumber)
                goodNumber = ((dblOutValue >  0.0) && (dblOutValue < 1000));

            return goodNumber;
        }

        ///<summary>
        ///Checks whether a string is empty or not.
        ///</summary>
        public static bool ValidateString(string stringToCheck)
        {
            string strIn = stringToCheck.Trim();

            if (string.IsNullOrEmpty(strIn))
                return false;
            else
                return true;
        }

        ///<summary>
        ///Checks whether it is a positive "integer" or not. Not actually used in this assignment.
        ///</summary>
        public static bool GetPositiveInteger(string stringToConvert, out int intOutValue)
        {
            bool goodNumber = int.TryParse(stringToConvert, out intOutValue);
            if (goodNumber)
                goodNumber = intOutValue >= 0;

            return goodNumber;
        }
    }
}
