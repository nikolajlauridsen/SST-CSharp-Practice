using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST_C_sharp_test_project.timer;

namespace SST_C_sharp_test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Sleep Timer C# edition");
            Console.Write("Input a decimal number: ");
            string user_input = Console.ReadLine();

            //attempts to convert input to time in seconds, will return null if unseccessful
            string sleep_time = functions.convert_number(user_input); 
            // If sleep time isn't null
            if (!sleep_time.Equals(null))
            {
                //Send shutdown signal
                functions.send_command("shutdown -s -f -t " + sleep_time);
            }
            // Testing else if
            else if (user_input == "test")
            {
                Console.WriteLine("You've entered the test block, good job!");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


            System.Threading.Thread.Sleep(3000);
        }
    }
}
