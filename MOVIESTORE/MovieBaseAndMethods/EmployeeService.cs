using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBaseAndMethods
{
    public class EmployeeService
    {




        public void EmployesServices()

        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var user in MovieBase.Users)
            {
                Console.WriteLine("REGISTERED USERS");
                user.DisplayInfo();

            }
            var ranted = MovieBase.movies
                                    .OrderBy(x => x.Ranted)
                                     .ToList();

            foreach (var item in ranted)
            {
                if (item.Ranted == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("MOVIE WHO IS RANTED");
                    item.DisplayInfo();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("MOVIE FREE FOR RENT");
                    item.DisplayInfo();
                }
            }

            Console.ResetColor();


        }
    }
}