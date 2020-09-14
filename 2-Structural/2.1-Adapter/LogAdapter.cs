﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._2_Structural._2._1_Adapter
{
    public class LogAdapter : ILogger
    {
        private readonly ILogNetMaster _logNetMaster;

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}