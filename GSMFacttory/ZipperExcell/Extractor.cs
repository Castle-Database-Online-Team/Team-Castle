using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipperExcell
{
    using GsmFactory.CommonResources;
    using GsmFactory.Models;
    using Ionic.Zip;
    using LinqToExcel;

    public static class Extractor
    {
        public static ExtractionResult ExtractFromZip(string path, string outputDirectory)
        {
            Unzip(path,outputDirectory);
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            ExtractionResult result = new ExtractionResult();
            result.Products = ExtractProductFromFile(excellFilePath);
            result.Currencies = ExtractCurrencyFromFile(excellFilePath);
            result.Displays = ExtractDisplayFromFile(excellFilePath);
            result.Measures = ExtractMeasureFromFile(excellFilePath);
            result.Memories = ExtractMemoryFromFile(excellFilePath);
            result.Persons = ExtractPersonFromFile(excellFilePath);
            result.Vendors = ExtractVendorFromFile(excellFilePath);
            result.ProductTypes = ExtractProductTypeFromFile(excellFilePath);
            result.Products = ExtractProductFromFile(excellFilePath);
            return result;

        }

        public static List<Product> ExtractProductFromFile(string excellFilePath)
        {
            List<Product> result = new List<Product>();
            var sheetName = "Product";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Product currentObject = new Product();
                    currentObject.Model= entry["Model"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.ProductName = Convert.ToInt32(entry["ProductName"].ToString().Trim());
                    currentObject.ProducerId = Convert.ToInt32(entry["ProduserId"].ToString().Trim());
                    currentObject.MeasureId = Convert.ToInt32(entry["MeasureId"].ToString().Trim());
                    currentObject.DisplayId = Convert.ToInt32(entry["DisplayId"].ToString().Trim());
                    currentObject.OSId = Convert.ToInt32(entry["PlatformOsId"].ToString().Trim());
                    currentObject.MemoryId = Convert.ToInt32(entry["MemoryId"].ToString().Trim());
                    currentObject.BasePrice = Convert.ToDecimal(entry["BasePrice"].ToString().Trim());
                    currentObject.CurrencyId = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Vendor> ExtractVendorFromFile(string excellFilePath)
        {
            List<Vendor> result = new List<Vendor>();
            var sheetName = "Vendor";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Vendor currentObject = new Vendor();
                    currentObject.Name = entry["VendorName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.CityId = Convert.ToInt32(entry["City"].ToString().Trim());
                    currentObject.VendorAddress = entry["Address"];
                    currentObject.Person = Convert.ToInt32(entry["Person"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Producer> ExtractProducerFromFile(string path, string outputDirectory)
        {
            List<Producer> result = new List<Producer>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Produser";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Producer currentObject = new Producer();
                    currentObject.Name = entry["ProduserName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<ProductType> ExtractProductTypeFromFile(string excellFilePath)
        {
            List<ProductType> result = new List<ProductType>();
            var sheetName = "ProductName";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    ProductType currentObject = new ProductType();
                    currentObject.Name = entry["ProductName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Memory> ExtractMemoryFromFile(string excellFilePath)
        {
            List<Memory> result = new List<Memory>();
            var sheetName = "Memory";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Memory currentObject = new Memory();
                    currentObject.Size = entry["MemoryName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.MeasureId = Convert.ToInt32(entry["MeasureId"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Display> ExtractDisplayFromFile(string excellFilePath)
        {
            List<Display> result = new List<Display>();
            var sheetName = "Display";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Display currentObject = new Display();
                    currentObject.Size = entry["DisplayName"].ToString().Trim();
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.MeasureId = Convert.ToInt32(entry["MeasureId"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Measure> ExtractMeasureFromFile(string excellFilePath)
        {
            List<Measure> result = new List<Measure>();
            var sheetName = "MeasureName";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Measure currentObject = new Measure();
                    currentObject.Name = entry["MeasureName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Currency> ExtractCurrencyFromFile(string excellFilePath)
        {
            List<Currency> result = new List<Currency>();
            var sheetName = "Currency";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Currency currentObject = new Currency();
                    currentObject.Name = entry["CurrensyName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<City> ExtractCityFromFile(string path, string outputDirectory)
        {
            List<City> result = new List<City>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "City";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    City currentObject = new City();
                    currentObject.Name = entry["CityName"];
                    currentObject.CityId = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Person> ExtractPersonFromFile(string excellFilePath)
        {
            List<Person> result = new List<Person>();
            var sheetName = "Person";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Person liason = new Person();
                    liason.Email = entry["Email"];
                    //liason.PersonId = Convert.ToInt32(Convert.ChangeType(entry["Id"], typeof (int?)));
                    liason.PersonId = Convert.ToInt32(entry["Id"].ToString().Trim());
                    liason.PersonName = entry["PersonName"];
                    liason.Phone = entry["Phone"];
                    result.Add(liason);
                }

            }
            return result;
        }

        private static void Unzip(string path, string outputDirectory)
        {
            Helper.CreateDirectoryIfUnexistant(outputDirectory);
            using (ZipFile zip = ZipFile.Read(path))
            {
                zip.ExtractAll(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
            }
        }
    }
}
