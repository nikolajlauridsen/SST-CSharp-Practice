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
 
            // Shutdown
            if (functions.is_number(user_input))
            {
                // Convert input to time in seconds
                string sleep_time = functions.convert_number(user_input);
                //Send shutdown signal
                functions.send_command("shutdown -s -f -t " + sleep_time);
            }
            // Reboot menu
            else if (user_input == "reboot")
            {
                // Prompt for new input, this time time
                Console.Write("Input a decimal number: ");
                user_input = Console.ReadLine();
                // Check if input is valid
                if (functions.is_number(user_input))
                { 
                    // Convert input to time in seconds
                    string sleep_time = functions.convert_number(user_input);
                    // Send shutdown command
                    functions.send_command("shutdown -r -f -t " + sleep_time);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

            }
            // Cancel shutdown
            else if (user_input == "cancel")
            {
                Console.WriteLine("Canceling shutdown.");
                functions.send_command("shutdown -a");
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


            System.Threading.Thread.Sleep(3000);
        }
    }
}
