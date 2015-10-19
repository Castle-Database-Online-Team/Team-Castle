namespace GsmFactoryConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using GsmFactory.Data;
    using GsmFactory.JsonReport;
    using GsmFactory.Models;

    internal class GsmFactoryConsoleClient
    {
        private static void Main()
        {
            var db = new GsmFactoryContext();

            var Os = new Os {Id = 5, Name = "Symbian"};

            //var creator = new JsonReportCreator();
            //Console.WriteLine(creator.CreateReport<Os>(Os));
            //Console.WriteLine(creator.SaveReport(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

            var creator = new XmlReportCreator();
            Console.WriteLine(creator.CreateReport(Os));
            Console.WriteLine(creator.SaveReport(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
        }
    }
}