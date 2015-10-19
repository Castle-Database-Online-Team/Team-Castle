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

            this.AddCities();
            this.AddPersons();
            this.AddVendors();
            // this.AddProdusers();
            this.AddProductTypes();
            this.AddProducts();
            this.SaveChanges();
        }

        public void AddVendors()
        {
            if (this.gsmFactoryData.Vendors.All().Any())
            {
                return;
            }

            foreach (var vendors in this.mongoDb.Vendor.FindAll())
            {
                this.gsmFactoryData.Vendors.Add(new Vendor()
                {
                    Id = vendors.VendorId,
                    Name = vendors.VendorName,
                    Person = vendors.Person,
                    CityId = vendors.CityId

                });
            }
        }

        public void AddPersons()
        {
            if (this.gsmFactoryData.Persons.All().Any())
            {
                return;
            }

            foreach (var person in this.mongoDb.Persons.FindAll())
            {
                this.gsmFactoryData.Persons.Add(new Person()
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

        //public void AddProdusers()
        //{
        //    if (this.gsmFactoryData.Producers.All().Any())
        //    {
        //        return;
        //    }

        //    foreach (var produser in this.mongoDb.Produser.FindAll())
        //    {
        //        this.gsmFactoryData.Producers.Add(new Produser()
        //        {
        //            //ProduserId = produser.ProduserId,
        //            ProduserName = produser.ProduserName
        //        });
        //    }
        //}

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