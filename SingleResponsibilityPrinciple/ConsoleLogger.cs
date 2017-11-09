﻿using System;

using SingleResponsibilityPrinciple.Contracts;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string type, string message, params object[] args)
        {
            Console.WriteLine(string.Concat("WARN: ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><type>" + type + "</type><message>" + message + "</message></log> ", args);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("INFO: ", message), args);
        }
    }
}
