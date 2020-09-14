﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2_Structural._2._1_Adapter
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}