using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SST_C_sharp_test_project.functions;

namespace SST_C_sharp_test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Sleep Timer C# edition");
            Console.Write("Input a decimal number: ");
            string user_input = Console.ReadLine();

            double sleep_time;

            if (double.TryParse(user_input, out  sleep_time) == true)
            {
                sleep_time = Convert.ToInt32(sleep_time * 3600);
                string sleep_time_string = Convert.ToString(sleep_time);
                string cmd_command = "shutdown -s -f -t " + sleep_time_string;
                Console.WriteLine("Sleep time: " + sleep_time_string);

                functions.functions.send_command(cmd_command);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


            System.Threading.Thread.Sleep(3000);
        }
    }
}
