﻿namespace GsmFactory.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using GsmFactory.Data.Contracts;
    using GsmFactory.Data.Repositories;
    using GsmFactory.Models;

    public class GsmFactoryData : IGsmFactoryData
    {
        private readonly DbContext context;
        private readonly IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        public GsmFactoryData()
           : this(new GsmFactoryContext())
        {
        }

        public GsmFactoryData(DbContext context)
        {
            this.context = context;
        }

        public IGenericRepository<Producer> Producers
        {
            get
            {
                return this.GetRepository<Producer>();
            }
        }

        public IGenericRepository<Person> Person
        {
            get
            {
                return this.GetRepository<Person>();
            }
        }

        public IGenericRepository<Display> Display
        {
            get
            {
                return this.GetRepository<Display>();
            }
        }

        public IGenericRepository<Measure> Measure
        {
            get
            {
                return this.GetRepository<Measure>();
            }
        }

        public IGenericRepository<Memory> Memory
        {
            get
            {
                return this.GetRepository<Memory>();
            }
        }

        public IGenericRepository<Vendor> Vendor
        {
            get
            {
                return this.GetRepository<Vendor>();
            }
        }

        public IGenericRepository<Product> Products
        {
            get
            {
                return this.GetRepository<Product>();
            }
        }

        public IGenericRepository<ProductType> ProductTypes
        {
            get
            {
                return this.GetRepository<ProductType>();
            }
        }

        public IGenericRepository<City> Cities
        {
            get
            {
                return this.GetRepository<City>();
            }
        }

        public IGenericRepository<ProduserExpense> Expenses
        {
            get
            {
                return this.GetRepository<ProduserExpense>();
            }
        }

        public IGenericRepository<SalesReport> SalesReports
        {
            get
            {
                return this.GetRepository<SalesReport>();
            }
        }

        public IGenericRepository<SalesReportEntry> SalesReportEntries
        {
            get
            {
                return this.GetRepository<SalesReportEntry>();
            }
        }

        public IGenericRepository<Store> Stores
        {
            get
            {
                return this.GetRepository<Store>();
            }
        }

        public IGenericRepository<Currency> Currency
        {
            get
            {
                return this.GetRepository<Currency>();
            }
        }

        public IGenericRepository<Os> Os
        {
            get
            {
                return this.GetRepository<Os>();
            }
        }

        public IGenericRepository<ProduserExpense> ProduserExpense
        {
            get
            {
                return this.GetRepository<ProduserExpense>();
            }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                }
            }
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);

            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var typeOfRepository = typeof(GenericRepository<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(typeOfRepository, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeOfModel];
        }
    }
}