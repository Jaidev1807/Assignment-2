using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /* Problem J1: Telemarketer or not?
        
           Problem Description
        
           Here at the Concerned Citizens of Commerce(CCC), we have noted that telemarketers like to use
            seven-digit phone numbers where the last four digits have three properties.Looking just at the last
            four digits, these properties are:

                • the first of these four digits is an 8 or 9;
                • the last digit is an 8 or 9;
                • the second and third digits are the same.

            For example, if the last four digits of the telephone number are 8229, 8338, or 9008, these are
            telemarketer numbers.
            Write a program to decide if a telephone number is a telemarketer number or not, based on the
            last four digits. If the number is not a telemarketer number, we should answer the phone, and
            otherwise, we should ignore it.*/

        /// </summary>
        /// <param name="w">Digit 1</param>
        /// <param name="x">Dight 2</param>
        /// <param name="y">Digit 3</param>
        /// <param name="z">Digit 4</param>
        /// <returns> 
        ///    it returen string weathe to answere or ignore 
        /// </returns>
        /// <example>
        ///     GET : localhostxxx/api/telemarketer/9/0/0/8  :- Ignore
        ///     GET : localhostxxx/api/telemarketer/7/1/2/3  :- Answer 
        ///     GET : localhostxxx/api/telemarketer/8/10/1/2 :- Invalid input. Please enter a valid four-digit number.
        /// </example>
        /// <api>
        ///     GET : loacalhostxxx/api/telemarketer/{w}/{x}/{y}/{z}
        /// </api>

        [HttpGet]
        [Route("api/telemarketer/{w}/{x}/{y}/{z}")]
        public string Telemarketer(int w , int x, int y , int z)
        {

            bool validLength = (w < 0 || w > 9) ||
                               (x < 0 || x > 9) ||
                               (y < 0 || y > 9) ||
                               (z < 0 || z > 9);
            if (validLength == true)
            {
                return "Invalid input. Please enter a valid four-digit number.";
            }

            bool isValid = (w == 8 || w == 9) &&
                           (z == 8 || z == 9) &&
                           (x == y);

           if(isValid == true)
            {
                return ("Ignore");
            }
            else
            {
                return ("Answere");
            }
        }
    }
}
