using System;
using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Production> Productions { get; set; }

    public DbSet<Genre> Genres { get; set; }

    /// <summary>
        /// This method is called automatically when generating models inside EF code-first.
        /// </summary>
        /// <param name="builder">Contains an instance of the EF model builder.</param>
        /// <remarks>
        /// This is the method where specifics about entities inside the overall database design is specified.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            // build the initial models.
            base.OnModelCreating(builder);

            // set all computed column sql statements
            //// string getUtcDate = "getutcdate()";
            string newId = "newid()";
            builder.Entity<Production>().Property(a => a.UniqueId).HasDefaultValueSql(newId);
        }
}