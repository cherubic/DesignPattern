using NUnit.Framework;
using System;
using DesignPattern.ChainOfResponsibilityPattern;
namespace DesignPattern.Test
{
    [TestFixture()]
    public class ChainPatternTest
    {
        [Test()]
        public void ChainPatternDemo()
        {
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO,
         "This is an information.");

            loggerChain.LogMessage(AbstractLogger.DEBUG,
               "This is an debug level information.");

            loggerChain.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");
        }

        private AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }


    }
}
