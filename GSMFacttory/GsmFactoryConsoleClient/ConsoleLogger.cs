namespace GsmFactoryConsoleClient
{
    using System;
    using GsmFactory.Data.Contracts;

    public class ConsoleLogger : ILogger
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine("+ {0}{1}", message, Environment.NewLine);
        }
    }
}
