﻿using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyWeb_2.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
