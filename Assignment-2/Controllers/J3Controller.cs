using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Web.Http;
using System.Web.UI;

namespace Assignment_2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// 
        /*Problem J3: Good times
        Problem Description
            A mobile cell service provider in Ottawa broadcasts an automated time standard to its mobile users
            that reflects the local time at the user’s actual location in Canada.This ensures that text messages
            have a valid local time attached to them.
            For example, when it is 1420 in Ottawa on Tuesday February 24, 2009 (specified using military,
            24 hour format), the times across the country are shown in the table below:
            Pacific Time Mountain Time Central Time Eastern Time Atlantic Time Newfoundland Time
            Victoria, BC Edmonton, AB Winnipeg, MB Toronto, ON Halifax, NS St.John’s, NL
            Tuesday Tuesday Tuesday Tuesday Tuesday Tuesday
            2/24/2009 2/24/2009 2/24/2009 2/24/2009 2/24/2009 2/24/2009
            1120 PST 1220 MST 1320 CST 1420 EST 1520 AST 1550 Newfoundland ST
            Write a program that accepts the time in Ottawa in 24 hour format and outputs the local time in
            each of the cities listed above including Ottawa. You should assume that the input time will be
            valid (i.e., an integer between 0 and 2359 with the last two digits being between 00 and 59).
            You should note that 2359 is one minute to midnight, midnight is 0, and 13 minutes after midnight
            is 13. You do not need to print leading zeros, and input will not contain any extra leading zeros.
                   
                    Sample Input
                    1300

                    Sample Output
                    1300 in Ottawa
                    1000 in Victoria
                    1100 in Edmonton
                    1200 in Winnipeg
                    1300 in Toronto
                    1400 in Halifax
                    1430 in St.John’s */

        /// </summary>
        /// <param name="ottawaTime">Ottawa time</param>
        /// <returns>
        ///     It returns the array of string with all tiem zone
        /// </returns>
        /// <example>
        ///     GET : localhost:xxxx/api/TimeZone/1300 :- 1300 in Ottawa
        ///                                               1120 in Victoria
        ///                                               1180 in Edmonton
        ///                                               1240 in Winnipeg
        ///                                               1300 in Toronto
        ///                                               1360 in Halifax
        ///                                               1390 in StJohns
        /// </example>
        /// <api>
        ///     GET : localhost:xxxxx/api/TimeZone/{ottawaTime}
        /// </api>
         

        [HttpGet]
        [Route("api/TimeZone/{ottawaTime}")]

        public string[] TimeZone(int ottawaTime)
        {

            int pacificDiff = -180;
            int mountainDiff = -120;
            int centralDiff = -60;
            int atlanticDiff = 60;
            int newfoundlandDiff = 90;


            int victoriaTime = (ottawaTime + pacificDiff) % 2400;
            int edmontonTime = (ottawaTime + mountainDiff) % 2400;
            int winnipegTime = (ottawaTime + centralDiff) % 2400;
            int torontoTime = (ottawaTime) % 2400;
            int halifaxTime = (ottawaTime + atlanticDiff) % 2400;
            int stJohnsTime = (ottawaTime + newfoundlandDiff) % 2400;

            return new string[]
            {
                $" {ottawaTime} in Ottawa" ,
                $" {victoriaTime} in Victoria" ,
                $" {edmontonTime} in Edmonton" ,
                $" {winnipegTime} in Winnipeg" ,
                $" {torontoTime} in Toronto" ,
                $" {halifaxTime} in Halifax" ,
                $" {stJohnsTime} in StJohns" 
            };
        
        }
    }
}
