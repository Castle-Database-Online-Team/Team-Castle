namespace GsmFactoryConsoleClient
{
    using System;
    using GsmFactory.Data;
    using GsmFactory.Models;
    using GsmFactory.ReportCreators;
    using MongoDB.Driver;
    using GsmFactory.Data.Contracts;
    using ZipperExcell;

    internal class GsmFactoryConsoleClient
    {
        private static GsmFactoryModule gsmFactoryModule;
        private static ILogger logger;

        private static void Main()
        {
            //InitializeComponent();

            //SeedDataFromMongoDB();

            //var db = new GsmFactoryContext();

            //var Os = new Os { Id = 5, Name = "Symbian" };
            //var Os2 = new Os { Id = 6, Name = "Windows Phone" };

            //var creator = new JsonReportCreator();
            //Console.WriteLine(creator.CreateReport<Os>(Os));
            //Console.WriteLine(creator.SaveReport(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));

            //var creator = new XmlReportCreator();
            //Console.WriteLine(creator.CreateReport(Os));
            //Console.WriteLine(creator.SaveReport(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
            //Person person = new Person { Email = "onche.bonche@abv.bg", PersonName = "Big Boss", Phone = "+359887653678" };
            //Person person2 = new Person { Email = "onche.adasdnche@abv.bg", PersonName = "Humble Employee", Phone = "+359sdfsfasf78" };

            //var creator = new PdfReportCreator();
            //Console.WriteLine(creator.CreateReportEntry(person));
            //Console.WriteLine(creator.CreateReportEntry(person2));
            //Console.WriteLine(creator.SaveReport(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\"));

            var result = Extractor.ExtractPersonFromFile(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\GSM.zip", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Excel");
            foreach (Person person in result)
            {
                Console.WriteLine(person.Email);
                Console.WriteLine(person.PersonId);
                Console.WriteLine(person.PersonName);
                Console.WriteLine(person.Phone);
            }
        }

        private static void SeedDataFromMongoDB()
        {
            gsmFactoryModule.ReadFromMongoDb();
        }

        private static void InitializeComponent()
        {
            logger = new ConsoleLogger();
            gsmFactoryModule = new GsmFactoryModule(logger);
        }


    }
}