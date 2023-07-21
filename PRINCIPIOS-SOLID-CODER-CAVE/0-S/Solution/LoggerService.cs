using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRINCIPIOS_SOLID_CODER_CAVE._0_S.Solution
{
    public interface ILoggerService
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
    public class LoggerService : ILoggerService
    {
        public void Info(string info)
        {
            // here we need write the code for initializtion
            // that is Creating the Log file with necessary details
        }

        public void Debug(string info)
        {
            // here we need to write the Code for Debug information into the ErrorLog text file
        }

        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the Error text file
        }
    }
}
