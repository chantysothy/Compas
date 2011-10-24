using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using System.Reflection;
using System.Diagnostics;

namespace Compas.Helpers
{
    public static class CompasLogger
    {
       public enum Level {Trace, Debug, Info, Warn, Error, Fatal};
       private static Logger logger = LogManager.GetCurrentClassLogger();

       public static void Add(string MessageText, Level LevelValue)
       {
           //Взнаємо звідки викликана подія логування

           // get call stack
           StackTrace stackTrace = new StackTrace();

           // get calling method name
           MessageText = MessageText + "    Source: " +
               stackTrace.GetFrame(1).GetMethod().DeclaringType.ToString() + "   " + 
               stackTrace.GetFrame(1).GetMethod().Name;

           switch (LevelValue) 
           { 
               case Level.Debug:
                   logger.Debug(MessageText);
                   break;
               case Level.Error:
                   logger.Error(MessageText);
                   break;
               case Level.Fatal:
                   logger.Fatal(MessageText);
                   break;
               case Level.Info:
                   logger.Info(MessageText);
                   break;
               case Level.Trace:
                   logger.Trace(MessageText);
                   break;
               case Level.Warn:
                   logger.Warn(MessageText);
                   break;              

           }
           
       }
    }

    
}
