﻿
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDBContext _db;
        public ApplicationUserRepository(ApplicationDBContext db):base(db)
        {
            _db = db;
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}

        //public void Update(ApplicationUser obj)
        //{
        //    _db.ApplicatioUsers.Update(obj);
        //}
    }


}
