using System;

namespace UnitTestJune5Demo
{
    public class MyLogger : IMyLogger
    {
        public void Log(string msg)
        {
            Console.Write(msg);
        }
    }
}
