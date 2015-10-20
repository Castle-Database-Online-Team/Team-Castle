namespace GsmFactory.Data
{
    using System;
    using System.Linq;
    using GsmFactory.Data.Contracts;
    using GsmFactory.Models;
    using GsmFactory.MongoDb.Contracts;

    public class MongoDbSeeder
    {
        private readonly IMongDbContext mongoDb;
        private readonly IGsmFactoryData gsmFactoryData;

        public MongoDbSeeder(IGsmFactoryData gsmFactoryData, IMongDbContext mongoDb)
        {
            this.gsmFactoryData = gsmFactoryData;
            this.mongoDb = mongoDb;
        }

        public void Seed()
        {
            this.AddOs();
            this.AddDisplay();
            this.AddCurrency();
            this.AddCities();
            this.AddPersons();
            this.AddVendors();
            this.AddProdusers();
            this.AddProduserExpense();
            this.AddProductTypes();
            this.AddMeasure();
            this.AddMemory();
            this.AddProducts();
            this.SaveChanges();
        }

        private void AddProduserExpense()
        {
            if (this.gsmFactoryData.ProduserExpense.All().Any())
            {
                return;
            }

            foreach (var produserExpense in this.mongoDb.ProduserExpense.FindAll())
            {
                this.gsmFactoryData.ProduserExpense.Add(new ProduserExpense()
                {
                    ExpenseId = produserExpense.ProduserId,
                    Expense = produserExpense.Expense,
                    ReportDate = produserExpense.ReportDate

                });
            }
        }

        private void AddOs()
        {
            if (this.gsmFactoryData.Os.All().Any())
            {
                return;
            }

            foreach (var operationSystem in this.mongoDb.PlatformOs.FindAll())
            {
                this.gsmFactoryData.Os.Add(new Os()
                {
                    Id = operationSystem.PaltrformOsId,
                    Name = operationSystem.PlatrformOsName

                });
            }
        }

        private void AddMemory()
        {
            if (this.gsmFactoryData.Memory.All().Any())
            {
                return;
            }

            foreach (var memory in this.mongoDb.Memory.FindAll())
            {
                this.gsmFactoryData.Memory.Add(new Memory()
                {
                    Id = memory.MemoryId,
                    Size = memory.MemorySize.ToString(),
                    MeasureId = memory.MemoryId

                });
            }
        }

        private void AddMeasure()
        {
            if (this.gsmFactoryData.Measure.All().Any())
            {
                return;
            }

            foreach (var measure in this.mongoDb.Measure.FindAll())
            {
                this.gsmFactoryData.Measure.Add(new Measure()
                {
                    Id = measure.MeasureId,
                    Name = measure.MeasureName

                });
            }
        }

        private void AddDisplay()
        {
            if (this.gsmFactoryData.Display.All().Any())
            {
                return;
            }

            foreach (var display in this.mongoDb.Display.FindAll())
            {
                this.gsmFactoryData.Display.Add(new Display()
                {
                    Id = display.DisplayId,
                    Size = display.DisplaySize.ToString(),
                    MeasureId = display.MeasureId

                });
            }
        }

        private void AddCurrency()
        {
            if (this.gsmFactoryData.Currency.All().Any())
            {
                return;
            }

            foreach (var currency in this.mongoDb.Currensy.FindAll())
            {
                this.gsmFactoryData.Currency.Add(new Currency()
                {
                    Id = currency.CurrensyId,
                    Name = currency.CurrensyName

                });
            }
        }

        public void AddVendors()
        {
            if (this.gsmFactoryData.Vendor.All().Any())
            {
                return;
            }

            foreach (var vendors in this.mongoDb.Vendor.FindAll())
            {
                this.gsmFactoryData.Vendor.Add(new Vendor()
                {
                    Id = vendors.VendorId,
                    Name = vendors.VendorName,
                    PersonId = vendors.Person,
                    CityId = vendors.CityId

                });
            }
        }

        public void AddPersons()
        {
            if (this.gsmFactoryData.Person.All().Any())
            {
                return;
            }

            foreach (var person in this.mongoDb.Persons.FindAll())
            {
                this.gsmFactoryData.Person.Add(new Person()
                {
                    PersonId = person.PersonId,
                    PersonName = person.PersonName,
                    Phone = person.Phone,
                    Email = person.Email
                });
            }
        }

        public void AddCities()
        {
            if (this.gsmFactoryData.Cities.All().Any())
            {
                return;
            }

            foreach (var city in this.mongoDb.Cities.FindAll())
            {
                this.gsmFactoryData.Cities.Add(new City()
                {
                    CityId = city.CityId,
                    Name = city.CityName
                });
            }
        }

        public void AddProdusers()
        {
            if (this.gsmFactoryData.Producers.All().Any())
            {
                return;
            }

            foreach (var produser in this.mongoDb.Produser.FindAll())
            {
                this.gsmFactoryData.Producers.Add(new Producer()
                {
                    Id = produser.ProduserId,
                    Name = produser.ProduserName
                });
            }
        }

        public void AddProductTypes()
        {
            if (this.gsmFactoryData.ProductTypes.All().Any())
            {
                return;
            }

            foreach (var productName in this.mongoDb.ProductName.FindAll())
            {
                this.gsmFactoryData.ProductTypes.Add(new ProductType()
                {
                    Id = productName.ProductNameId,
                    Name = productName.ProductName
                });
            }
        }

        public void AddProducts()
        {
            if (this.gsmFactoryData.Products.All().Any())
            {
                return;
            }

            foreach (var product in this.mongoDb.Products.FindAll())
            {
                this.gsmFactoryData.Products.Add(new Product()
                {
                    Id = product.ProductId,
                    Model = product.Model,
                    ProductTypeId = product.ProductName,
                    ProducerId = product.ProduserId,
                    MeasureId = product.MeasureId,
                    DisplayId = product.DisplayId,
                    OSId = product.PlatformOsId,
                    MemoryId = product.MemoryId,
                    BasePrice = (decimal)product.BasePrice,
                    CurrencyId = product.CurrencyId

                });
            }
        }

        public void SaveChanges()
        {
            this.gsmFactoryData.SaveChanges();
        }
    }
}