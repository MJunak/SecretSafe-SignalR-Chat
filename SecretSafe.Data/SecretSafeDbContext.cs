﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Models;
using SecretSafe.Models;

namespace Data
{

    public class SecretSafeDbContext : IdentityDbContext<SecretSafeUser>, IDbContext
    {
        public SecretSafeDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<LoginHistory> LoginHistory { get; set; }

        public virtual IDbSet<ChatRoom> ChatRooms { get; set; }

        public virtual IDbSet<SecurityLevel> SecurityLevels { get; set; }

        public static SecretSafeDbContext Create()
        {
            return new SecretSafeDbContext();
        }

         

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>()
                .ToTable("Users");

            modelBuilder.Entity<IdentityRole>()
                .ToTable("Roles");

            modelBuilder.Entity<IdentityUserRole>()
                .ToTable("UserRoles");

            modelBuilder.Entity<IdentityUserClaim>()
               .ToTable("UserClaims");

            modelBuilder.Entity<IdentityUserLogin>()
                .ToTable("UserLogins");
        }
        
    }
}
