using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.DataAcess.Data;
using BookStore.DataAcess.Repository.IRepository;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAcess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
	{
        private  ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
               

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
