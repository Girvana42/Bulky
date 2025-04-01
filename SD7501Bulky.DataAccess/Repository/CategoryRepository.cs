using SD7501BulkyWeb.Models;
using SD7501Bulky.DataAccess.Data;
using SD7501Bulky.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void ICategoryRepository.Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
