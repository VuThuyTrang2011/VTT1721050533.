using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTT1721050533.Models
{
    public class QL : DbContext
    {
        public QL() : base("name=QL")
        { 
        }
       
        public DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.PersonName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal global::System.Object Entry(Student student)
        {
        }

        internal object Entry(Person person)
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}