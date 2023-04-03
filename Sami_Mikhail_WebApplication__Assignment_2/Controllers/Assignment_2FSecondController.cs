using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sami_Mikhail_WebApplication__Assignment_2.Controllers
{
    public class Assignment_2FSecondController : Controller
    {
        // GET: Assignment_2FSecond
        public ActionResult Index(int x, int y)
        {
            //  Input for this methos is two interger, representing the number of faces for the two dices
            //  Output if all possible combination of the two dice to get total of 10
            //  Value on first die(m= 6)  Value on second die(n= 8)
            //  2 &  8       10
            //  3 &  7       10
            //  4 &  6       10
            //  5 &  5       10
            //  6 &  4       10
            //  The to accompish that is two nexted for loops

            for (int i = 0; i <= x; i++)
            {
                for (int y = 0; i <= y; i++)
                {
                    if i + y = 10
                        {
                        Console.WriteLine("A combination of 10 with " + i +','  + y);
                    }
                }
            }

        }
    }
}