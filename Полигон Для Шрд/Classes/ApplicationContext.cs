using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Полигон_Для_Шрд.Classes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<NumberOfClass> NumberOfClasses { get; set; } = null!;
        public DbSet<Tasks> Tasks { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NumberOfClass>()
                .HasOne(c => c.User)
                .WithMany(c => c.NumberOfClasses)
                .HasForeignKey(c => c.UserId);
            modelBuilder.Entity<NumberOfClass>()
                .HasData(
                new NumberOfClass { NumberOfClassId = 7 },
                new NumberOfClass { NumberOfClassId = 8 },
                new NumberOfClass { NumberOfClassId = 9 }
                );
            modelBuilder.Entity<Tasks>().HasData
                (
                new Tasks { TaskId = 1, Task = "Что такое физика", Anwer = "наука", NumberOfClassId = 7 },
                new Tasks { TaskId = 2, Task = "Что такое диффузия", Anwer = "ялвение", NumberOfClassId = 7 },
                new Tasks { TaskId = 3, Task = "Что такое магнетизм", Anwer = "явление", NumberOfClassId = 8 },
                new Tasks { TaskId = 4, Task = "Как найти количество теплоты", Anwer = "по формуле", NumberOfClassId = 8 }
                );
            modelBuilder.Entity<Tasks>()
                .HasOne(c => c.NumberOfClass)
                .WithMany(t => t.Tasks)
                .HasForeignKey(c => c.NumberOfClassId);
        }
    }
}
