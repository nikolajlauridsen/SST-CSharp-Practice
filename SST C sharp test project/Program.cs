using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (double.TryParse(user_input, out  sleep_time) == true){
                sleep_time = Convert.ToInt32(sleep_time * 3600);
                string sleep_time_string = Convert.ToString(sleep_time);
                string cmd_command = "shutdown -s -f -t " + sleep_time_string;
                Console.WriteLine("Sleep time: " + sleep_time_string);

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/c " + cmd_command;
                process.StartInfo = startInfo;
                process.Start();
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


            System.Threading.Thread.Sleep(3000);
        }
    }
}
