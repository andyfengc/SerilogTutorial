using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace SerilogTutorial
{
    public class BasicLogger
    {
        public static void Run()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.ColoredConsole()
                .WriteTo.RollingFile(@"D:\Log-{Date}.txt")
                .CreateLogger();
            var appointment =
                new { Id = 1, Subject = "Meeting of database migration", Timestamp = new DateTime(2015, 3, 12) };
            logger.Information("An appointment is booked successfully: {@appountment}", appointment);
            logger.Error("Failed to book an appointment: {@appountment}", appointment);
        }
    }
}
