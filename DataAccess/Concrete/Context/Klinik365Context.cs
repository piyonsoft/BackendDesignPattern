using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Context
{
    public class Klinik365Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=xxxx;user id=xxxxxx;password=xxxx;initial catalog=xxxxx;Persist Security Info=true");
        }

        public DbSet<PatientData> PatientDatas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
