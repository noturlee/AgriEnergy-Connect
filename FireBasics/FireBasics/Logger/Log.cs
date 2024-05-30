using System.Text;

namespace FireBasics.Logger
{
    public sealed class Log : ILog
    {
        //Private Constructor to Restrict Class Instantiation from outside the Log class
        private Log()
        {
        }
        //Creating Log Instance using Eager Loading
        private static readonly Log LogInstance = new Log();
        //Returning the Singleton LogInstance
        //This Method is Thread Safe as it uses Eager Loading
        public static Log GetInstance()
        {
            return LogInstance;
        }
        //This Method Log the Exception Details in a Log File
        public void LogException(string message)
        {
            //Create the Dynamic File Name
            string fileName = "failed-login";
            //Create the Path where you want to Create the Log file
            string logFilePath = string.Format(@"{0}/{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            //Build the String Object using StringBuilder for a Better Performance
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString() + " : " + message);
            //Write the StringBuilder Message into the Log File Path using StreamWriter Object
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
