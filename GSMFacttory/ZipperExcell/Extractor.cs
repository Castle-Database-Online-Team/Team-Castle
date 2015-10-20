﻿using System;
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
        public static List<List<object>> ExtractFromZip(string path, string outputDirectory)
        {
            Unzip(path,outputDirectory);
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var Products = ExtractProductFromFile(excellFilePath);
            return new List<List<object>>();
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
                    currentObject.ProducerId = Convert.ToInt32(entry["ProducerId"].ToString().Trim());
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

        public static List<Vendor> ExtractVendorFromFile(string path, string outputDirectory)
        {
            List<Vendor> result = new List<Vendor>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Vendor";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Vendor currentObject = new Vendor();
                    currentObject.Name = entry["ProducerName"];
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
            var sheetName = "Producer";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Producer currentObject = new Producer();
                    currentObject.Name = entry["ProducerName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<ProductType> ExtractProductTypeFromFile(string path, string outputDirectory)
        {
            List<ProductType> result = new List<ProductType>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
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

        public static List<Memory> ExtractMemoryFromFile(string path, string outputDirectory)
        {
            List<Memory> result = new List<Memory>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Memory";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Memory currentObject = new Memory();
                    currentObject.Size = entry["MemoryName"] == "No memory" ? 0 : Convert.ToInt32(entry["DisplayName"].ToString().Trim());
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.MeasureId = Convert.ToInt32(entry["MeasureId"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Display> ExtractDisplayFromFile(string path, string outputDirectory)
        {
            List<Display> result = new List<Display>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Display";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Display currentObject = new Display();
                    currentObject.Size = Convert.ToDouble(entry["DisplayName"].ToString().Trim());
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    currentObject.MeasureId = Convert.ToInt32(entry["MeasureId"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Measure> ExtractMeasureFromFile(string path, string outputDirectory)
        {
            List<Measure> result = new List<Measure>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Measure";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Measure currentObject = new Measure();
                    currentObject.Name = entry["CityName"];
                    currentObject.Id = Convert.ToInt32(entry["Id"].ToString().Trim());
                    result.Add(currentObject);
                }

            }
            return result;
        }

        public static List<Currency> ExtractCurrencyFromFile(string path, string outputDirectory)
        {
            List<Currency> result = new List<Currency>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
            var sheetName = "Currency";
            var excelFile = new ExcelQueryFactory(excellFilePath);
            var objects = from entries in excelFile.Worksheet(sheetName) select entries;
            foreach (var entry in objects)
            {
                if (entry["Id"] != string.Empty)
                {
                    Currency currentObject = new Currency();
                    currentObject.Name = entry["CityName"];
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

        public static List<Person> ExtractPersonFromFile(string path, string outputDirectory)
        {
            List<Person> result = new List<Person>();
            var excellFilePath = outputDirectory + @"\" + Helper.GetFileName(path).Replace(".zip", ".xls");
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