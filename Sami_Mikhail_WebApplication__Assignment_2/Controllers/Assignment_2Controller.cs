using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;
using System.Web.UI.WebControls;

namespace Sami_Mikhail_WebApplication__Assignment_2_First.Controllers
{
    public class Assignment_2FirstController : ApiController
    {
        // GET api/Assignment_2

           
        public IEnumerable<string> Get( int p_burger, int p_drink, int p_side, int p_dessert )
        {
            // For this assignment to CRUD is required, so I'll hard code the data
            // in real time envirinomant the data should be populated from the database
            // the required output can also be accomplished by a bunch of IF or CASE statments, but it will be a long code
            // I belive the easiest way are two dimention arrays

            // Declare a two dimensional array.

            //  Here are the 3 burger choices: 
            //  1 - Cheeseburger(461 Calories)
            //  2 - Fish Burger(431 Calories)
            //  3 - Veggie Burger(420 Calories)
            //  4 - no burger
            string[,] Burgers = { { "Cheeseburger",  461},
                                  { "Fish Burger",   431},
                                  { "Veggie Burger", 420},
                                  { "no burger",     0  }};
            //  Here are the three drink choices: 
            //  1 - Soft Drink(130 Calories)b
            //  2 - Orange Juice(160 Calories)
            //  3 - Milk(118 Calories)
            //  4 - no drink
            string[,] Drinks  = { { "Soft Drink",    130},
                                  { "Orange Juicer", 160},
                                  { "Milk"         , 118},
                                  { "no drink"     , 0  }};
            //  Here are the 3 side order choices:
            //  1 - Fries(100 Calories)
            //  2 - Baked Potato(57 Calories)
            //  3 - Chef Salad(70 Calories)
            //  4 - no side order
            string[,] Sides   = { { "Fries"         , 100},
                                  { "Baked Potato"  , 57},
                                  { "Chef Salad"    , 70},
                                  { "no side order" , 0  }};
            //  Here are the three dessert choices: 
            //  1 - Apple Pie(167 Calories)
            //  2 - Sundae(266 Calories)
            //  3 - Fruit Cup(75 Calories)
            //  4 - No Dessert
            string[,] Desserts  = { { "Apple Pie"  , 167},
                                    { "Sundae"     , 266},
                                    { "Fruit Cup"  , 75},
                                    { "No Dessert" , 0  }};

            int Total_Calories;
            //  Sample input
            //  GET: http://localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert} 
            
            //  Sample input/output
            //  Output Specification
            //  Example HTTP request Example Response
            //  GET .. / api / J1 / Menu / 4 / 4 / 4 / 4  Your total calorie count is 0
            //  GET..  / api / J1 / Menu / 1 / 2 / 3 / 4  Your total calorie count is 691


            

            Total_Calories = burgers  [p_burger+1,  p_burger+1] + 
                             drinks   [p_drink+1,   p_drink+1]  + 
                             sides    [p_side+1,    p_side+1]   +
                             desserts [p_dessert+1, p_dessert+1];

            return new string[] { Total_Calories };
        }
    }
}