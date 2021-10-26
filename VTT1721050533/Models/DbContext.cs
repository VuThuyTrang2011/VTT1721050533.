namespace VTT1721050533.Models
{
    public class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
              .Property(e => e.PersonID)
              .IsUnicode(false);
            modelBuilder.Entity<Person>()
              .Property(e => e.PersonName)
              .IsUnicode(false);
        }
    }
}