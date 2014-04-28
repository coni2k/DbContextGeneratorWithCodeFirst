using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DbContextGeneratorWithCodeFirst
{
    public partial class QAContext : DbContext
    {
        static QAContext()
        {
            Database.SetInitializer<QAContext>(new CreateDatabaseIfNotExists<QAContext>());
        }

        public QAContext()
            : base("Name=QAContext")
        {
        }

        public QAContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
