using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Web.Http;
using System.Web.Http.Description;
using WebGrease.Css.Ast;

namespace Assignment_2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /* Problem J2: Old Fishin’ Hole
           Problem Description
                Fishing habitat and fish species are a resource that must be carefully managed to ensure that they
                will be there for the future.Accordingly, fishing limits have been established for a particular river
                based on the population of each species. Specifically, points are associated with the fish caught
                and the total points you catch must be less than or equal to the points allowed for that river.
                As an example, suppose each brown trout counts as 2 points, each northern pike counts as 5 points
                and each yellow pickerel counts as 2 points, and the total points allowed must be less than or
                equal to 12. One acceptable catch could consist of 3 brown trout and 1 northern pike, but, other
                combinations would also be allowed.
                Your job is to write a program to input the points allocated for a river, and find how many different
                ways an angler who catches at least one fish can stay within his/her limit.
                Input Description
                You will be given 4 integers, one per line, representing trout points, pike points, pickerel points,
                and total points allowed in that order.
                You can assume that each integer will be greater than 0 and less than or equal to 100.
                Output Description
                For each different combination of fish caught, output the combination of brown trout, northern
                pike, and yellow pickerel in that order. The combinations may be listed in any order. The last line
                of output should display the total number of unique ways to catch fish within the established limit.

                            Sample Input
                            1
                            2
                            3
                            2

                            Sample Output
                            1 Brown Trout, 0 Northern Pike, 0 Yellow Pickerel
                            2 Brown Trout, 0 Northern Pike, 0 Yellow Pickerel
                            0 Brown Trout, 1 Northern Pike, 0 Yellow Pickerel
                            Number of ways to catch fish: 3*/

        /// </summary>
        /// <param name="x"> Brown Trout </param>
        /// <param name="y"> Northern Pike </param>
        /// <param name="z"> Yellow Pickerel </param>
        /// <param name="w"> Total must be less than </param>
        /// 
        /// <returns>
        ///     its returns the list of strong and all possible ways
        /// </returns>
        /// <example>
        ///         GET : localhost:xxxx/api/FishProblem/1/2/3/2 :- 1 Brown Trout, 0 Northern Pike, 0 Yellow Pickerel
        ///                                                         2 Brown Trout, 0 Northern Pike, 0 Yellow Pickerel
        ///                                                         0 Brown Trout, 1 Northern Pike, 0 Yellow Pickerel
        ///                                                         Number of ways to catch fish: 3
        /// </example>
        /// <api>
        ///         GET : localhost:xxxx/api/FishProblem/{x}/{y}/{z}/{w}
        /// </api>
        /// 

        [HttpGet]
        [Route("api/FishProblem/{x}/{y}/{z}/{w}")]
        public List<string> FishProblem(int x, int y, int z, int w) 
        {
            List<string> result = new List<string>();
            int total = 0;

            for (int i = 0; i * x <= w; i++) {
                for (int j = 0; i * x + j * y <= w; j++) {
                    for (int k = 0;i * x + j * y + k * z <= w ; k++) {
                        if (i == 0 && j == 0 && k == 0)
                            continue;
                        total += 1;
                        result.Add(i + " Brown Trout, " + j + " Northern Pike, " + k + " Yellow Pickerel");                                                
                    }
                }
               
            }


            result.Add("Number of ways to catch fish: "+total);
;            return result;
        }

    }
}
