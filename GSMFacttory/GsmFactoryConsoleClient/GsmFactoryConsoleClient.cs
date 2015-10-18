namespace GsmFactoryConsoleClient
{
    using System;
    using GsmFactory.Data;
    using GsmFactory.Models;

    internal class GsmFactoryConsoleClient
    {
        private static void Main()
        {
            var db = new GsmFactoryContext();

            var Os = new Os();

            db.OperatingSystems.Add(Os);
            db.SaveChanges();
        }

    }
}