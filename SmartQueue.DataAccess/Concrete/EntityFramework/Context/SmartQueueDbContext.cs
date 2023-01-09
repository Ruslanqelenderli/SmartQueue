using Microsoft.EntityFrameworkCore;
using SmartQueue.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.DataAccess.Concrete.EntityFramework.Context
{
    public class SmartQueueDbContext:DbContext
    {
        public SmartQueueDbContext()
        {

        }
        public SmartQueueDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString: @"workstation id=SmartQueueDb.mssql.somee.com;packet size=4096;user id=SmartQueue_SQLLogin_1;pwd=oo5n1sspx2;data source=SmartQueueDb.mssql.somee.com;persist security info=False;initial catalog=SmartQueueDb;"
                );



        }
        public DbSet<User> Users { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SmartQueue.Entity.Entities.Queue>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<User>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Role>()
                .HasKey(x=>x.Id);
            modelBuilder.Entity<UserRole>()
                .HasKey(x => x.Id);





            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Admin",Surname="Admin",PhoneNumber="0559122536",Email="admin@gmail.com",HashedPassword= "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=", State = true, CreatedDate = DateTime.Now }
                ); ;
            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin", State = true, CreatedDate = DateTime.Now },
                new Role() { Id = 2, Name = "User", State = true, CreatedDate = DateTime.Now }
                ); ;
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole() { Id = 1,UserId=1,RoleId=1, State = true, CreatedDate = DateTime.Now }
                ); ;
            modelBuilder.Entity<SmartQueue.Entity.Entities.Queue>().HasData(
                new Queue() { Id = 1, Name = "Gular", Surname = "Azimli", Email = "ruslan.galandarli@gmail.com",PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 2, Name = "Ruslan", Surname = "Galandarli", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 3, Name = "Laman", Surname = "Galandarli", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 4, Name = "Nijat", Surname = "Mammadzada", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 5, Name = "Ruslan", Surname = "Salahow", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 6, Name = "Mecid", Surname = "Abdullayev", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 7, Name = "Ata", Surname = "Babayev", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 8, Name = "Nijat", Surname = "Aliyev", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 9, Name = "Ali", Surname = "Nehmatov", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 10, Name = "Samad", Surname = "Samadov", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 11, Name = "Ehtiram", Surname = "Salayev", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now},
                new Queue() { Id = 12, Name = "Kerim", Surname = "Mammadzada", Email = "ruslan.galandarli@gmail.com", PhoneNumber="0559122536", State = true, CreatedDate = DateTime.Now}

                );



        }
    }
}
