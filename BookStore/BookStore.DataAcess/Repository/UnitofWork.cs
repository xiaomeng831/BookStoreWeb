﻿using BookStore.DataAcess.Data;
using BookStore.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAcess.Repository
{
    public  class UnitofWork : IUnitofWork
    {
        private ApplicationDbContext _db;
        public UnitofWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
