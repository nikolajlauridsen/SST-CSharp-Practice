using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST_C_sharp_test_project.timer
{
    class functions
    {
        public static void send_command(string cmd_command)
        {
            // creates cmd process, and sends a string argument
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + cmd_command;
            process.StartInfo = startInfo;
            process.Start();
        }

        public static string convert_number(string number)
        {
            // Multiplies input with 3600 if it's a decimal number, returns null if it isn't
            double sleep_time;
            if (double.TryParse(number, out sleep_time))
            {
                sleep_time = Convert.ToInt32(sleep_time * 3600);
                string sleep_time_string = Convert.ToString(sleep_time);
                return sleep_time_string;
            }
            else return null;
        }
    }
}
