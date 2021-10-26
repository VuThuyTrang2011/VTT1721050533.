using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTT1721050533.Models
{
    public class QL : DbContext
    {
        public QL() : base("name=QL")
        { }
        public virtual DbContext<Person> Persons { get; set; }
        public virtual ISet<Student> Student { get; set; }
        public virtual ISet<Lecture> Lectures { get; set; }
        public object People { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entr(Person person)
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }

        internal object Entry(Person person1, Person person2)
        {
            throw new NotImplementedException();
        }

        internal object Entry(Person person)
        {
            throw new NotImplementedException();
        }
    }
}